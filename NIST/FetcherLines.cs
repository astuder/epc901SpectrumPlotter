using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectrumPlotter.NIST
{
    public class FetcherLines
    {
        public static int MinWavelength = 300;
        public static int MaxWavelength = 1100;
        public static int MinRelIntensity = 100;
        public static int MaxLevel = 2;

        private static string RemoveNotes(string str)
        {
            int pos = 0;
            while (pos < str.Length && char.IsDigit(str[pos])) pos++;
            return str.Substring(0, pos);
        }

        private static string RomanNumeral(int num)
        {
            string[] numerals = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

            if (num <= numerals.Length)
            {
                return numerals[num - 1];
            } else
            {
                return num.ToString();
            }
        }

        public static bool RequestElement(string element)
        {
            try
            {
                string url = "https://physics.nist.gov/cgi-bin/ASD/lines1.pl?spectra=" + element + "&limits_type=0&low_w=" + MinWavelength + "&upp_w=" + MaxWavelength + "&unit=1&de=0&format=3&line_out=0&remove_js=on&en_unit=0&output=0&bibrefs=1&page_size=15&show_obs_wl=1&order_out=0&max_low_enrg=&show_av=2&max_upp_enrg=&tsb_value=0&min_str=&A_out=0&intens_out=on&max_str=&allowed_out=1&forbid_out=1&min_accur=&min_intens=" + MinRelIntensity + "&submit=Retrieve+Data";

                HttpClient client = new HttpClient();

                Task<HttpResponseMessage> ret = client.GetAsync(url);
                if (!ret.Wait(10000))
                {
                    MessageBox.Show("Failed to retrieve, server didn't respond");
                    return false;
                }
                var resp = ret.Result.Content.ReadAsStringAsync();
                if (!resp.Wait(10000))
                {
                    MessageBox.Show("Failed to retrieve, server didn't respond with content");
                    return false;
                }

                string responseBody = resp.Result;

                int data_pos = 0;
                if (responseBody.StartsWith("element"))
                {
                    data_pos = 2;
                } else if (!responseBody.StartsWith("obs_wl_air"))
                {
                    // unexpected response, probably element missing in database
                    return false;
                }

                string[] rows = responseBody.Replace("\"", "").Split('\n');
                int max_level = 1;
                int[] levels = new int[rows.Length-2];
                double[] wavelengths = new double[rows.Length-2];
                int[] intensities = new int[rows.Length-2];

                
                for (int i = 0; i < rows.Length-2; i++)
                {
                    string[] cols = rows[i+1].Split('\t');

                    levels[i] = 1;
                    if (data_pos == 2)
                    {
                        levels[i] = Int32.Parse(cols[1]);
                        if (levels[i] > max_level) max_level = levels[i];
                    }
                    wavelengths[i] = double.Parse(cols[data_pos]);
                    intensities[i] = Int32.Parse(RemoveNotes(cols[data_pos + 1]));
                }

                ElementInfo spectra = new ElementInfo(element);
                spectra.Wavelengths = wavelengths;

                int lvl_index = 0;
                for (int l = 1; l <= max_level; l++)
                {
                    double[] lvl_intensities = new double[intensities.Length];
                    bool lvl_empty = true;
                    for (int i = 0; i < intensities.Length; i++)
                    {
                        if (levels[i] == l)
                        {
                            lvl_intensities[i] = intensities[i];
                            lvl_empty = false;
                        } else
                        {
                            lvl_intensities[i] = 0;
                        }
                    }

                    if (lvl_empty == false)
                    {
                        if (max_level == 1)
                        {
                            spectra.AddElement(element);
                        } else
                        {
                            spectra.AddElement(element + " " + RomanNumeral(l));
                        }
                        spectra.Elements[lvl_index].Intensities = lvl_intensities;
                        lvl_index++;
                    }
                }

                /*
                string assignStart = responseBody.Substring(responseBody.IndexOf("var dataDopplerArray=") + 21);
                string assignContent = assignStart.Substring(0, assignStart.IndexOf("    var dataSticksArray=")).Replace("\r", "").Replace("\n", "").Trim(';');

                JArray data = JsonConvert.DeserializeObject(assignContent) as JArray;
                
                List<double> wavelengths = new List<double>();
                List<List<double>> elementIntensities = new List<List<double>>();

                JArray header = data[0] as JArray;
                int elementStart = 1;

                for (int pos = 1; pos < header.Count; pos++)
                {
                    JObject elementInfo = header[pos] as JObject;
                    string name = elementInfo["label"].ToString();

                    if (name.StartsWith("Sum"))
                    {
                        elementStart = 2;
                    }
                    else
                    {
                        spectra.AddElement(name);
                        elementIntensities.Add(new List<double>());
                    }
                }
                int elements = header.Count - elementStart;

                for (int pos = 1; pos < data.Count; pos++)
                {
                    JArray spectrumInfo = data[pos] as JArray;
                    double wavelength = ((double)spectrumInfo[0]);
                    double sum = ((double)spectrumInfo[1]);

                    wavelengths.Add(wavelength);
                    for (int posw = 0; posw < elements; posw++)
                    {
                        double intensity = 0;

                        if (spectrumInfo[elementStart + posw].Type == JTokenType.Float)
                        {
                            intensity = ((double)spectrumInfo[elementStart + posw]);
                        }
                        elementIntensities[posw].Add(intensity);
                    }
                }

                spectra.Wavelengths = wavelengths.ToArray();
                for (int pos = 0; pos < elements; pos++)
                {
                    spectra.Elements[pos].Intensities = elementIntensities[pos].ToArray();
                }
*/

                spectra.Save("Lines");

                return true;
            }
            catch (Exception ex)
            {
            }

            return false;
        }
    }
}

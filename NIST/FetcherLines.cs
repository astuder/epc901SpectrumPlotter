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
        public static int MinTransitionStrength = 1;
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
                // string url = "https://physics.nist.gov/cgi-bin/ASD/lines1.pl?spectra=" + element + "&limits_type=0&low_w=" + MinWavelength + "&upp_w=" + MaxWavelength + "&unit=1&de=0&format=3&line_out=0&remove_js=on&en_unit=0&output=0&bibrefs=1&page_size=15&show_obs_wl=1&order_out=0&max_low_enrg=&show_av=2&max_upp_enrg=&tsb_value=0&min_str=&A_out=0&intens_out=on&max_str=&allowed_out=1&forbid_out=1&min_accur=&min_intens=" + MinRelIntensity + "&submit=Retrieve+Data";
                string url = "https://physics.nist.gov/cgi-bin/ASD/lines1.pl?spectra=" + element + "&limits_type=0&low_w=" + MinWavelength + "&upp_w=" + MaxWavelength + "&unit=1&de=0&format=3&line_out=0&remove_js=on&en_unit=0&output=0&page_size=15&show_obs_wl=1&order_out=0&max_low_enrg=&show_av=2&max_upp_enrg=&tsb_value=0&min_str=" + MinTransitionStrength + "&A_out=0&intens_out=on&max_str=&allowed_out=1&forbid_out=1&min_accur=&min_intens=&J_out=on&submit=Retrieve+Data";
                
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
                // int[] intensities = new int[rows.Length-2];
                double[] intensities = new double[rows.Length-2];

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
                    // intensities[i] = Int32.Parse(RemoveNotes(cols[data_pos + 1]));
                    intensities[i] = double.Parse(cols[data_pos+2]);
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

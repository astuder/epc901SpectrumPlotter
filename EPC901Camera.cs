using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace SpectrumPlotter
{
    internal class EPC901Camera
    {
        private SerialPort Serial = null;

        private static UInt16 maxPixelValue = 2600;
        private static UInt16 minPixelValue = 300;
        private static UInt16 scaleValue = (ushort)(65535 / (maxPixelValue - minPixelValue));
        
        public bool Open(string portName)
        {
            string err_msg = "";

            Serial = new SerialPort(portName, 115200);
            Serial.NewLine = "\r\n";
            try
            {
                Serial.Open();
                // Serial.ReadTimeout = 200;
                // Serial.WriteTimeout = 200;
                SendCommand("echo off");
                while(Serial.BytesToRead > 0)
                {
                    Serial.ReadLine();  // flush any stray respones
                }
                SendCommand("reset camera");
                SendCommand("reset sensor");
            }
            catch (Exception ex)
            {
                err_msg = "Failed to connect to spectrometer on port " + portName + "\n";
                err_msg += "Exception: " + ex.Message;
                MessageBox.Show(err_msg);
                if (Serial.IsOpen)
                {
                    Serial.Close();
                    Serial = null;
                }
                return false;
            }

            return true;
        }

        public bool Close()
        {
            if (Serial != null && Serial.IsOpen)
            {
                SendCommand("echo off");
                Serial.Close();
                Serial = null;
            }

            return true;
        }

        public bool SetExposure(UInt32 exposure)
        {
            if (Serial != null && Serial.IsOpen)
            {
                SendCommand("exposure " + exposure);
                return true;
            } else
            {
                return false;
            }
        }

        public bool Capture()
        {
            if (Serial != null && Serial.IsOpen)
            {
                SendCommand("burst off");
                SendCommand("capture");
                return true;
            } else {
                return false;
            }
        }

        public UInt16[] GetPixels()
        {
            UInt16[] pixels = null;
            string data = SendCommand("transfer");
            while (data == "BUSY")
            {
                Thread.Sleep(100);
                data = SendCommand("transfer");
            }
            if (data == null || data == "")
            {
                return null;
            }

            if (data.StartsWith("ERROR"))
            {
                MessageBox.Show(data);
                return null;
            }

            string[] data_split = data.Split(',');
            pixels = new UInt16[Convert.ToUInt16(data_split[3])];
            string pixel_str = Serial.ReadLine();
            int p = 0;
            for (int i = 0; i < pixel_str.Length; i+=3)
            {
                pixels[p] = (ushort) ((Convert.ToUInt16(pixel_str.Substring(i, 3), 16) - minPixelValue) * scaleValue);
                p++;
            }

            return pixels;
        }
        public string SendCommand(string command)
        {
            string cmd_string = "@" + command + "\n";
            Serial.Write(cmd_string);
            return Serial.ReadLine();
        }

    }
}

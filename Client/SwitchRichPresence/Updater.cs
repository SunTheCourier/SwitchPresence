﻿using System.IO;
using System.Net;
using System.Text;

namespace SwitchPresence
{
    public class Updater
    {
        public const string APP_VERSION = "1.0.3";
        private const string LATEST_URL = "https://raw.githubusercontent.com/Random0666/Useless-stuff/master/SwitchRichPresence/latest.txt";

        public static void GetUpdate()
        {
            try
            {
                WebClient client = new WebClient();
                byte[] data = client.DownloadData(LATEST_URL);
                StringReader sr = new StringReader(Encoding.UTF8.GetString(data).Replace("\n", "\r\n"));

                string latestVer = sr.ReadLine();
                if (latestVer != APP_VERSION)
                {
                    UpdateForm form = new UpdateForm(latestVer, sr.ReadToEnd());
                    form.ShowDialog();
                }
            }
            //probably no correction
            catch { }
        }
    }
}

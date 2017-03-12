using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK.Events;

namespace Moon_Walk_Evade_2._0
{
    class Program
    {
        static string GetOnlineVersion()
        {
            string version = string.Empty;
            WebRequest req = WebRequest.Create("https://raw.githubusercontent.com/DanThePman/MoonWalkEvadeData/master/version.txt");
            req.Method = "GET";

            // ReSharper disable once AssignNullToNotNullAttribute
            using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    version = line;
                    break;
                }
            }
            return version;
        }

        private static string dllPath = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\EloBuddy\Addons\Libraries\MWE.dll";
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += eventArgs =>
            {
                bool JustUpdated = false;

                if (!File.Exists(dllPath))
                {
                    Download();
                    JustUpdated = true;
                }


                if (File.Exists(updateReminderPath))
                {
                    File.Delete(updateReminderPath);
                    Update();
                    JustUpdated = true;
                }

                Assembly SampleAssembly = Assembly.LoadFrom(dllPath);
                Type myType = SampleAssembly.GetType("A");

                if (!JustUpdated)
                {
                    var localVersion = (string)myType.GetMethod("a", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, null);
                    string onlineVersion = GetOnlineVersion();
                    if (localVersion != onlineVersion && !File.Exists(updateReminderPath))
                    {
                        CreateUpdateReminder();
                        return;
                    }
                }

                var main = myType.GetMethod("b", BindingFlags.NonPublic | BindingFlags.Static);
                main.Invoke(null, null);
            };
        }

        private static void Download()
        {
            Chat.Print("<b><font size='20' color='#4B0082'>[Moon Walk Evade] Downloading Core...</font></b>");
            using (WebClient w = new WebClient())
            {
                w.DownloadFile("https://github.com/DanThePman/MoonWalkEvadeData/raw/master/MWE.dll", dllPath);
            }
            Chat.Print("<b><font size='20' color='#4B0082'>[Moon Walk Evade] Download Completed!</font></b>");
        }

        static string updateReminderPath = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\EloBuddy\MLS_UPDATE_PENDING.txt";
        private static void CreateUpdateReminder()
        {
            new StreamWriter(updateReminderPath).Close();
            Chat.Print("<b><font size='20' color='#4B0082'>[Moon Walk Evade] Reload This Addon To Update! (F5)</font></b>");
        }

        private static void Update()
        {
            Chat.Print("<b><font size='20' color='#4B0082'>[Moon Walk Evade] Downloading Update...</font></b>");
            using (WebClient w = new WebClient())
            {
                w.DownloadFile("https://github.com/DanThePman/MoonWalkEvadeData/raw/master/MWE.dll", dllPath);
            }
            Chat.Print("<b><font size='20' color='#4B0082'>[Moon Walk Evade] Update Completed!</font></b>");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyfOnLibrary.Common
{
    public static class Utility
    {
        public static string LogPath = @"c:\LyfOn\Log\";

        public static string GenerateKey()
        {
            string Randomkey = string.Empty;

            Randomkey = "GHFJHKJ#%$FGH";

            return Randomkey;
        }

        public static void WriteLog(Exception ex)
        {
            DateTime dateAndTime = DateTime.Now;

            Console.WriteLine();

            LogPath = LogPath + dateAndTime.ToString("dd-MMm-yyyy") + ".txt";

            if (!File.Exists(LogPath))
            {
                using (StreamWriter sw = File.CreateText(LogPath))
                {
                    sw.WriteLine(ex.Message.ToString());
                }
            }
        }
    }
}

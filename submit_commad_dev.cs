using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;

namespace submitCommad
{
    public class submit_commad_dev
    {
        public static void pushCommad(string commad,string path)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("cd/");
            cmd.StandardInput.WriteLine($@"cd {path}");
            cmd.StandardInput.WriteLine(commad);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExitAsync();
        }
        public static string actual_path(string app_name)
        {
            string dir = "";
            string[] SplitDir = Directory.GetCurrentDirectory().Split(@"\");
            foreach (string s in SplitDir)
            {
                if (s != app_name)
                {
                    dir += @$"{s}\";
                }
                else
                {
                    dir += @$"{s}\{s}";
                    break;
                }
            }
            return dir;
        }
        public static string getDir_Ini(string app_name)
        {
            string dir = "";
            string[] SplitDir = Directory.GetCurrentDirectory().Split(@"\");
            foreach (string s in SplitDir)
            {
                if (s != app_name)
                {
                    dir += @$"{s}/";
                }
                else
                {
                    dir += @$"{s}/{s}";
                    break;
                }
            }
            return dir;
        }
    }
}

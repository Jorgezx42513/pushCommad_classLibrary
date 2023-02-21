# pushCommad_classLibrary
Class library for wpf c# to push commads
```
  namespace submitCommad
{
    internal class push_commad_pro
    {
        public static void pushCommad(string commad, string path)
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
        public static string actual_path()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
```

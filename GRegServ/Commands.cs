using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRegServ
{
    class Commands
    {
        public static List<string> errors = new List<string>();
        public static List<string> succeeded = new List<string>();
        public void RegisterDLL()
        {
            

            foreach (string file in MainWindow.SelectedFiles)
            {
                string CmdText = "/C REGSVR32 /s " + '"' + file + '"';
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = CmdText;
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                //startInfo.RedirectStandardOutput = true;
                //startInfo.RedirectStandardError = true;
                //startInfo.UseShellExecute = false;
                process.StartInfo = startInfo;
                process.Start();
                //string result = process.StandardOutput.ReadLine().ToString();
                //succeeded.Add(result);
            }
        }

        public void UnregisterDLL()
        {
            foreach (string file in MainWindow.SelectedFiles)
            {
                string CmdText = "/C REGSVR32 /u " + '"' + file + '"';
                System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
                startInfo2.FileName = "cmd.exe";
                startInfo2.Arguments = CmdText;
                startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process2.StartInfo = startInfo2;
                process2.Start();

            }
        }

    }
}

using System;
using System.Runtime.InteropServices;

namespace MonitorModeSwitcher
{
    public static class MonitorChanger
    {
        //see http://www.nirsoft.net/utils/multi_monitor_tool.html for more
        public enum MonitorActions
        {
            DisableMonitor = 0,
            EnableMonitor = 1,
            SetPrimaryMonitor = 2
        }

        public static void AlterMonitor(int id, MonitorActions action)
        {
            switch (action)
            {
                case (MonitorActions.DisableMonitor):
                    RunProcess($"/disable {id}");
                    break;

                case (MonitorActions.EnableMonitor):
                    RunProcess($"/enable {id}");
                    break;

                case (MonitorActions.SetPrimaryMonitor):
                    RunProcess($"/SetPrimary {id}");
                    break;
            }
        }

        private static void RunProcess(string command)
        {
            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "MultiMonitorTool.exe";
                startInfo.Arguments = command;
                process.StartInfo = startInfo;
                process.Start();
            }
        }
    }
}

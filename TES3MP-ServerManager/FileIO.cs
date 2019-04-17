using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TES3MP_ServerManager
{
    class FileIO
    {
        //init variables for DIRs and Files
        public static string LocalDIR = Directory.GetCurrentDirectory();
        static string CacheDIR = Path.Combine(LocalDIR, "ServerManager");
        static string AddressFile = Path.Combine(CacheDIR, "AddressBook");
        
        //Create DIRs
        public static void InitDIR()
        {
            if (!Directory.Exists(CacheDIR))
            {
                Directory.CreateDirectory(CacheDIR);
            }
        }

        //Load IPs from files
        public static void LoadIP()
        {
            if (File.Exists(AddressFile))
            {
                string [] LoadIPs = File.ReadAllLines(AddressFile);
                foreach(string i in LoadIPs)
                {
                    Main.IPs.Add(i);
                }
            }
            else
            {
                Main.IPs.Add("No IPs Stored.");
                File.Create(AddressFile).Dispose();
                File.WriteAllLines(AddressFile, Main.IPs);
            }
        }

        //Save new IP to file
        public static void SaveIP(string IP)
        {
            if(Main.IPs.Contains("No IPs Stored."))
            {
                Main.IPs.Remove("No IPs Stored.");
                File.Delete(AddressFile);
                File.Create(AddressFile).Dispose();
            }
            Main.IPs.Add(IP);
            File.WriteAllLines(AddressFile, Main.IPs);
        }

        //Remove IP from file
        public static void DeleteIP(string IP)
        {
            File.Delete(AddressFile);
            File.Create(AddressFile).Dispose();
            Main.IPs.Remove(IP);
            File.WriteAllLines(AddressFile, Main.IPs);
        }

        //Launch TES3MP with selected IP
        public static void Run(string IP)
        {
            if (File.Exists(Path.Combine(LocalDIR, "tes3mp.exe")))
            {
                Process.Start(Path.Combine(LocalDIR, "tes3mp.exe"), "--connect " + IP);
            }
        }

        //Check for tes3mp.exe
        public static bool ProcessCheck()
        {
            bool ReturnState = false;
            if(File.Exists(Path.Combine(LocalDIR, "tes3mp.exe")))
            {
                return ReturnState = true;
            }
            return ReturnState;
        }
    }
}

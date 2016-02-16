using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfo
{
    class Program
    {
        //System info
        static private string system = "System Info:"
            + "\nOS Version: " + Environment.OSVersion
            + (Environment.Is64BitOperatingSystem ? ", 64-bit" : "")
            + "\nMicrosoft .Net Framework version: " + Environment.Version
            + "\nComputer Name: " + Environment.MachineName
            + "\nSystem Directory: " + Environment.SystemDirectory;

        //Current User Info
        static private string user = "Current User Info:"
            + "\nUserName: " + Environment.UserName
            + "\nSpecial folders:"
            + "\nfolder 'My Documents' = " + Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            + "\nfolder 'Desktop' = " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            + "\nfolder 'Pictures' = " + Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            + "\nfolder 'Start' = " + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
            + "\nfolder 'Programs' = " + Environment.GetFolderPath(Environment.SpecialFolder.Programs)
            + "\nfolder 'Autostart' = " + Environment.GetFolderPath(Environment.SpecialFolder.Startup)
            + "\nfolder 'User Profile' = " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);


        static void Main(string[] args)
        {
            Console.WriteLine("SystemInfo\n----------\n");
            Console.WriteLine(system + "\n");
            Console.WriteLine(user + "\n");
            Console.WriteLine("Home directory = " + Environment.GetEnvironmentVariable("USERPROFILE"));

            //Environment variables
            string varias = "";
            System.Collections.IDictionary envVar = Environment.GetEnvironmentVariables();
            foreach (System.Collections.DictionaryEntry varia in envVar)
                varias += varia.Key + " = " + varia.Value + "\n";
            Console.WriteLine("\nEnvironment Variables: \n" + varias);

            //Logical drives
            string[] disks = Environment.GetLogicalDrives();
            string driveInfo = "\nAvailable disks: ";
            foreach (string disk in disks) driveInfo += disk + " ";
            Console.WriteLine(driveInfo + "\n");

            Console.WriteLine("Hit Enter...");
            Console.ReadLine();

        }
    }
}

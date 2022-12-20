using System;
using System.Diagnostics;

using Procesor_Intel_8086;

public class Program
{
    static void menu()
    {
        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("INTEL 8086 PROJECT - (c) Mateusz Motyczynski\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Start\n2.Help\n3.Exit\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the number (1-3):\n");

            int x;
            
            try
            {
                x = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid input...");
                Console.ReadKey();
                continue;
            }

            if (x == 1)
            {
                start();
                break;
            }
            else if (x == 2)
            {
                help();
            }
            else if (x == 3)
            {
                exit();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid input...");
                Console.ReadKey();
            }
        }
    }


    static void start()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Loading...");
        Thread.Sleep(1000);
        Console.WriteLine("Starting...");
        Thread.Sleep(1000);
    }


    static void help()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Available registers: AX, BX, CX, DX.\nAvailable flags: CF.\nThere is only 'MOV', 'ADD', 'ADC', 'SUB', 'INC', 'DEC' commands.\n");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("How to use:");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# MOV:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'MOV [register], [number]' -- register = number");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'MOV AX, 4')");
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'MOV [register1], [register2]' -- register1 = register2");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'MOV BX, AX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# XCHG:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'XCHG [register1], [register2]' -- register1 < - > register2");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'XCHG CX, BX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# ADD:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'ADD [register], [number]' -- register = register + number");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'ADD CX, 87')");
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'ADD [register1], [register2]' -- register1 = register1 + register2");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'ADD BX, DX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# ADC:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'ADC [register], [number]' -- register = register + number and CF = 1");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'ADC AX, 598')");
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'ADC [register1], [register2]' -- register1 = register1 + register2 and CF = 1");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'ADC CX, AX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# SUB:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'SUB [register], [number]' -- register = register - number");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'SUB BX, 8')");
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'SUB [register1], [register2]' -- register1 = register1 - register2");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'SUB AX, BX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# SBB:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'SBB [register], [number]' -- register = register - number - CF");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'SBB CX, 54')");
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'SBB [register1], [register2]' -- register1 = register1 - register2 - CF");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'SBB CX, AX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# INC:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'ADD [register]' -- register = register + 1");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'INC DX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# DEC:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("'DEC [register]' -- register = register - 1");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (e.g: 'DEC AX')\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# CLC:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("'CLC' -- CF = 0\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("# STC:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("* ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("'STC' -- CF = 1");

        Console.ReadKey();
    }


    static void exit()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Goodbye!");
        Console.ForegroundColor = ConsoleColor.White;
        Environment.Exit(1);
    }


    static void Main(string[] args)
    {
        menu();

        Procesor procesor = new Procesor();

        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AX: {0}\nBX: {1}\nCX: {2}\nDX: {3}\n", procesor.getAX(), procesor.getBX(), procesor.getCX(), procesor.getDX());
            Console.Write("CF: ");

            if (procesor.getCF())
                Console.WriteLine("1\n");
            else
                Console.WriteLine("0\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("['reset' - set all to zero]\n");
            Console.Write("['help' - command patterns]\n");
            Console.Write("['return' - return to the previous screen]\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the command (MOV, XCHG, ADD, ADC, SUB, SBB, INC, DEC, CLC, STC):\n");

            string a;
            a = Console.ReadLine();
            string[] result = a.Split(" ");

            // Funkcje
            if (result.Length == 3) // 3 czesciowa lista
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        a = result[i];
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                    continue;
                }

                if (result[0] == "MOV") // MOV
                {
                    if (result[1] == null || result[2] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();

                    }
                    else
                    {
                        procesor.MOV(result[1], result[2]);
                    }
                }
                else if (result[0] == "XCHG") // XCHG
                {
                    if (result[1] == null || result[2] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();

                    }
                    else
                    {
                        procesor.XCHG(result[1], result[2]);
                    }
                }
                else if (result[0] == "ADD") // ADD
                {
                    if (result[1] == null || result[2] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();
                    }
                    else
                    {
                        procesor.ADD(result[1], result[2]);
                    }
                }
                else if (result[0] == "ADC") // ADC
                {
                    if (result[1] == null || result[2] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();
                    }
                    else
                    {
                        procesor.ADC(result[1], result[2]);
                    }
                }
                else if (result[0] == "SUB") // SUB
                {
                    if (result[1] == null || result[2] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();
                    }
                    else
                    {
                        procesor.SUB(result[1], result[2]);
                    }
                }
                else if (result[0] == "SBB") // SBB
                {
                    if (result[1] == null || result[2] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();
                    }
                    else
                    {
                        procesor.SBB(result[1], result[2]);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (result.Length == 2)
            {
                try
                {
                    for (int i = 0; i < 2; i++) // 2 czesciowa lista
                    {
                        a = result[i]; // ... Ważne, że działa :)
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                    continue;
                }

                if (result[0] == "INC") // INC
                {
                    if (result[1] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();
                    }
                    else
                    {
                        procesor.INC(result[1]);
                    }
                }
                else if (result[0] == "DEC") // DEC
                {
                    if (result[1] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey();
                    }
                    else
                    {
                        procesor.DEC(result[1]);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (result.Length == 1)
            {
                if (result[0] == "CLC") // CLC
                {
                    procesor.CLC();
                }
                else if (result[0] == "STC") // STC
                {
                    procesor.STC();
                }
                else if (result[0] == "reset") // reset
                {
                    procesor.RESET();
                }
                else if (result[0] == "help") // reset
                {
                    help();
                }
                else if (result[0] == "return") // reset
                {
                    menu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid command...");
                Console.ReadKey();
            }
        }
    }
}
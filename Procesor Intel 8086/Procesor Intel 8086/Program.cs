using System;
using System.Diagnostics;

using Procesor_Intel_8086;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("INTEL 8086 PROJECT - (c) Mateusz Motyczynski\n");
            Console.WriteLine("1.Start\n2.Help\n3.Exit\n\nEnter the number (1-3):\n");

            int x = Convert.ToInt16(Console.ReadLine());

            if (x == 1)
            {
                Console.Clear();
                Console.WriteLine("Starting...");
                Thread.Sleep(1000);
                break;
            }
            else if (x == 2)
            {
                Console.Clear();
                Console.WriteLine("Available registers: AX, BX, CX, DX.\nThere is only 'MOV', 'ADD', 'SUB', 'INC', 'DEC' commands.\n\nHow to use:");
                Console.WriteLine("# MOV:\n* 'MOV [register], [number]' -- register = number\n* 'MOV [register1], [register2]' -- register1 = register2\n");
                Console.WriteLine("# ADD:\n* 'ADD [register], [number]' -- register = register + number\n* 'ADD [register1], [register2]' -- register1 = register1 + register2\n");
                Console.WriteLine("# SUB:\n* 'SUB [register], [number]' -- register = register - number\n* 'SUB [register1], [register2]' -- register1 = register1 - register2\n");
                Console.WriteLine("# INC:\n* 'ADD [register]' -- register = register + 1\n");
                Console.WriteLine("# DEC:\n* 'ADD [register]' -- register = register - 1\n");
                Console.ReadKey();
            }
            else if (x == 3)
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Err");
                Console.ReadKey();
            }

        }

        Procesor procesor = new Procesor();

        while (true)
        {
            Console.Clear();



            string a;

            Console.WriteLine("AX: {0}\nBX: {1}\nCX: {2}\nDX: {3}\n", procesor.getAX(), procesor.getBX(), procesor.getCX(), procesor.getDX());
            Console.WriteLine("['reset' - set all to zero]\nEnter the commend (MOV, ADD, SUB, INC, DEC):\n");

            a = Console.ReadLine();
            string[] result = a.Split(" ");

            // Funkcje
            if (result[0] == "MOV") // MOV
            {
                if (result[1] == null || result[2] == null)
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
                else
                {
                    procesor.MOV(result[1], result[2]);
                }
            }
            else if (result[0] == "ADD") // ADD
            {
                if (result[1] == null || result[2] == null)
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
                else
                {
                    procesor.ADD(result[1], result[2]);
                }
            }
            else if (result[0] == "SUB") // SUB
            {
                if (result[1] == null || result[2] == null)
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
                else
                {
                    procesor.SUB(result[1], result[2]);
                }
            }
            else if (result[0] == "INC") // INC
            {
                if (result[1] == null)
                {
                    Console.WriteLine("Err");
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
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
                else
                {
                    procesor.DEC(result[1]);
                }
            }
            else if (result[0] == "reset")
            {
                procesor.RESET();
            }
            else
            {
                Console.WriteLine("Err");
                Console.ReadKey();
            }
        }
    }
}
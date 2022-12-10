﻿using System;
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
            Console.WriteLine("1.Start\n2.Help\n3.Exit\n\nEnter the number (1-3): ");

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
                Console.WriteLine("Commands:\n");
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
            //else if (result[0] == "ADD") // ADD
            //{
            //    if (short.TryParse(result[2], out x))
            //    {
            //        if (result[1] == "AX,")
            //        {
            //            memory.AX += x;
            //        }
            //        else if (result[1] == "BX,")
            //        {
            //            memory.BX += x;
            //        }
            //        else if (result[1] == "CX,")
            //        {
            //            memory.CX += x;
            //        }
            //        else if (result[1] == "DX,")
            //        {
            //            memory.DX += x;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Err");
            //            Console.ReadKey();
            //        }
            //    }
            //    else if (!short.TryParse(result[2], out x)) // =-=-=-=-=-=-=-=-=-=-=-=-=
            //    {

            //        if (result[1] == "AX,") // AX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.AX += memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.AX += memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.AX += memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.AX += memory.DX;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else if (result[1] == "BX,") //BX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.BX += memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.BX += memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.BX += memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.BX += memory.DX;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else if (result[1] == "CX,") //CX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.CX += memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.CX += memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.CX += memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.CX += memory.DX;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else if (result[1] == "DX,") //DX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.DX += memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.DX += memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.DX += memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.DX += memory.DX; ;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Err");
            //            Console.ReadKey();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Err");
            //        Console.ReadKey();
            //    }
            //}
            //else if (result[0] == "SUB") // ADD
            //{
            //    if (short.TryParse(result[2], out x))
            //    {
            //        if (result[1] == "AX,")
            //        {
            //            memory.AX -= x;
            //        }
            //        else if (result[1] == "BX,")
            //        {
            //            memory.BX -= x;
            //        }
            //        else if (result[1] == "CX,")
            //        {
            //            memory.CX -= x;
            //        }
            //        else if (result[1] == "DX,")
            //        {
            //            memory.DX -= x;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Err");
            //            Console.ReadKey();
            //        }
            //    }
            //    else if (!short.TryParse(result[2], out x)) // =-=-=-=-=-=-=-=-=-=-=-=-=
            //    {

            //        if (result[1] == "AX,") // AX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.AX -= memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.AX -= memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.AX -= memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.AX -= memory.DX;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else if (result[1] == "BX,") //BX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.BX -= memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.BX -= memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.BX -= memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.BX -= memory.DX;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else if (result[1] == "CX,") //CX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.CX -= memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.CX -= memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.CX -= memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.CX -= memory.DX;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else if (result[1] == "DX,") //DX, ... ====
            //        {
            //            if (result[2] == "AX")
            //            {
            //                memory.DX -= memory.AX;
            //            }
            //            else if (result[2] == "BX")
            //            {
            //                memory.DX -= memory.BX;
            //            }
            //            else if (result[2] == "CX")
            //            {
            //                memory.DX -= memory.CX;
            //            }
            //            else if (result[2] == "DX")
            //            {
            //                memory.DX -= memory.DX; ;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Err");
            //                Console.ReadKey();
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Err");
            //            Console.ReadKey();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Err");
            //        Console.ReadKey();
            //    }
            //}
            //else if (result[0] == "INC")
            //{
            //    if (result[1] == "AX")
            //    {
            //        memory.AX++;
            //    }
            //    else if (result[1] == "BX")
            //    {
            //        memory.BX++;
            //    }
            //    else if (result[1] == "CX")
            //    {
            //        memory.CX++;
            //    }
            //    else if (result[1] == "DX")
            //    {
            //        memory.DX++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Err");
            //        Console.ReadKey();
            //    }
            //}
            //else if (result[0] == "DEC")
            //{
            //    if (result[1] == "AX")
            //    {
            //        memory.AX--;
            //    }
            //    else if (result[1] == "BX")
            //    {
            //        memory.BX--;
            //    }
            //    else if (result[1] == "CX")
            //    {
            //        memory.CX--;
            //    }
            //    else if (result[1] == "DX")
            //    {
            //        memory.DX--;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Err");
            //        Console.ReadKey();
            //    }
            //}
            //else if (result[0] == "reset")
            //{
            //    memory.resetALL();
            //}
            //else
            //{
            //    Console.WriteLine("Err");
            //    Console.ReadKey();
            //}
        }
    }
}
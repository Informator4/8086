public class Program
{
    public static void Main(string[] args)
    {
        Procesor procesor = new Procesor();
        do
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
                Console.WriteLine("There is only 'MOV', 'ADD' commands.\nExample: 'MOV AX, 43'.");
                Console.ReadKey();
            }
            else if (x == 3)
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Err");
                Thread.Sleep(1000);
            }


        } while (true);

        do
        {
            Console.Clear();

            string a;
            short x;

            Console.WriteLine("AX: {0}\nBX: {1}\nCX: {2}\nDX: {3}\n", procesor.AX, procesor.BX, procesor.CX, procesor.DX);
            Console.WriteLine("Enter the commend (MOV, ADD):");

            a = Console.ReadLine();
            string[] result = a.Split(" ");
            

            if (result[0] == "MOV") // MOV
            {
                if (short.TryParse(result[2], out x))
                {
                    if (result[1] == "AX,")
                    {
                        procesor.AX = x;
                    }
                    else if (result[1] == "BX,")
                    {
                        procesor.BX = x;
                    }
                    else if (result[1] == "CX,")
                    {
                        procesor.CX = x;
                    }
                    else if (result[1] == "DX,")
                    {
                        procesor.DX = x;
                    }
                    else
                    {
                        Console.WriteLine("Err");
                        Console.ReadKey();
                    }
                }
                else if (!short.TryParse(result[2], out x)) // =-=-=-=-=-=-=-=-=-=-=-=-=
                {

                    if (result[1] == "AX,") // AX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                        else if (result[2] == "BX")
                        {
                            short i = procesor.AX;
                            procesor.AX = procesor.BX;
                            procesor.BX = i;
                        }
                        else if (result[2] == "CX")
                        {
                            short i = procesor.AX;
                            procesor.AX = procesor.CX;
                            procesor.CX = i;
                        }
                        else if (result[2] == "DX")
                        {
                            short i = procesor.AX;
                            procesor.AX = procesor.DX;
                            procesor.DX = i;
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else if (result[1] == "BX,") //BX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            short i = procesor.BX;
                            procesor.BX = procesor.AX;
                            procesor.AX = i;
                        }
                        else if (result[2] == "BX")
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                        else if (result[2] == "CX")
                        {
                            short i = procesor.BX;
                            procesor.BX = procesor.CX;
                            procesor.CX = i;
                        }
                        else if (result[2] == "DX")
                        {
                            short i = procesor.BX;
                            procesor.BX = procesor.DX;
                            procesor.DX = i;
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else if (result[1] == "CX,") //CX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            short i = procesor.CX;
                            procesor.CX = procesor.AX;
                            procesor.AX = i;
                        }
                        else if (result[2] == "BX")
                        {
                            short i = procesor.CX;
                            procesor.CX = procesor.BX;
                            procesor.BX = i;
                        }
                        else if (result[2] == "CX")
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                        else if (result[2] == "DX")
                        {
                            short i = procesor.CX;
                            procesor.CX = procesor.DX;
                            procesor.DX = i;
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else if (result[1] == "DX,") //DX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            short i = procesor.DX;
                            procesor.DX = procesor.AX;
                            procesor.AX = i;
                        }
                        else if (result[2] == "BX")
                        {
                            short i = procesor.DX;
                            procesor.DX = procesor.BX;
                            procesor.BX = i;
                        }
                        else if (result[2] == "CX")
                        {
                            short i = procesor.DX;
                            procesor.DX = procesor.CX;
                            procesor.CX = i;
                        }
                        else if (result[2] == "DX")
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Err");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
            }
            else if(result[0] == "ADD") // ADD
            {
                if (short.TryParse(result[2], out x))
                {
                    if (result[1] == "AX,")
                    {
                        procesor.AX += x;
                    }
                    else if (result[1] == "BX,")
                    {
                        procesor.BX += x;
                    }
                    else if (result[1] == "CX,")
                    {
                        procesor.CX += x;
                    }
                    else if (result[1] == "DX,")
                    {
                        procesor.DX += x;
                    }
                    else
                    {
                        Console.WriteLine("Err");
                        Console.ReadKey();
                    }
                }
                else if (!short.TryParse(result[2], out x)) // =-=-=-=-=-=-=-=-=-=-=-=-=
                {

                    if (result[1] == "AX,") // AX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            procesor.AX += procesor.AX;
                        }
                        else if (result[2] == "BX")
                        {
                            procesor.AX += procesor.BX;
                        }
                        else if (result[2] == "CX")
                        {
                            procesor.AX += procesor.CX;
                        }
                        else if (result[2] == "DX")
                        {
                            procesor.AX += procesor.DX;
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else if (result[1] == "BX,") //BX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            procesor.BX += procesor.AX;
                        }
                        else if (result[2] == "BX")
                        {
                            procesor.BX += procesor.BX;
                        }
                        else if (result[2] == "CX")
                        {
                            procesor.BX += procesor.CX;
                        }
                        else if (result[2] == "DX")
                        {
                            procesor.BX += procesor.DX;
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else if (result[1] == "CX,") //CX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            procesor.CX += procesor.AX;
                        }
                        else if (result[2] == "BX")
                        {
                            procesor.CX += procesor.BX;
                        }
                        else if (result[2] == "CX")
                        {
                            procesor.CX += procesor.CX;
                        }
                        else if (result[2] == "DX")
                        {
                            procesor.CX += procesor.DX;
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else if (result[1] == "DX,") //DX, ... ====
                    {
                        if (result[2] == "AX")
                        {
                            procesor.DX += procesor.AX;
                        }
                        else if (result[2] == "BX")
                        {
                            procesor.DX += procesor.BX;
                        }
                        else if (result[2] == "CX")
                        {
                            procesor.DX += procesor.CX;
                        }
                        else if (result[2] == "DX")
                        {
                            procesor.DX += procesor.DX; ;
                        }
                        else
                        {
                            Console.WriteLine("Err");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Err");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Err");
                Console.ReadKey();
            }
        } while (true);
    }
}
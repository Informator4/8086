using System;

public class Program
{
    public static void Main(string[] args)
    {
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
                Console.WriteLine("Jak w Asemblerze..");
                Thread.Sleep(2000);
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


        } while (1 < 2);

        // Rejestry
        short AX = 0;
        short BX = 0;
        short CX = 0;
        short DX = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("AX: {0}\nBX: {1}\nCX: {2}\nDX: {3}\n", AX, BX, CX, DX);

            int y = Convert.ToInt16(Console.ReadLine());

        }while (1 < 2);
    }
}
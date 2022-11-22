using Procesor_Intel_8086;

class Program
{
    static void Main()
    {
        Console.WriteLine("#INTEL 8086 PROJECT# \n");
        short size = Convert.ToInt16(Console.ReadLine());

        Storage storage = new Storage(size);
        short mybyte = Convert.ToInt16(Console.ReadLine());
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesor_Intel_8086
{
    public class Procesor
    {
        Memory memory = new Memory();

        public short getAX()
        {
            return memory.getAX();
        }
        public short getBX()
        {
            return memory.getBX();
        }
        public short getCX()
        {
            return memory.getCX();
        }
        public short getDX()
        {
            return memory.getDX();
        }

        public void MOV(string index1, string index2)
        {
            if (short.TryParse(index2, out short x))
            {
                changeVariable(index1, x);
            }
            else if (!short.TryParse(index2, out x))
            {
                changeVariable(index1, index2);
            }
        }

        private void changeVariable(string index, short value)
        {
            if (index == "AX,")
            {
                memory.setAX(value);
            }
            else if (index == "BX,")
            {
                memory.setBX(value);
            }
            else if (index == "CX,")
            {
                memory.setCX(value);
            }
            else if (index == "DX,")
            {
                memory.setDX(value);
            }
            else
            {
                Console.WriteLine("Err");
                Console.ReadKey();
            }

        }

        private void changeVariable(string index1, string index2)
        {
            if (index1 == "AX,")
            {
                if (index2 == "AX")
                {
                    memory.setAX(memory.getAX());
                }
                else if (index2 == "BX")
                {
                    memory.setAX(memory.getBX());
                }
                else if (index2 == "CX")
                {
                    memory.setAX(memory.getCX());
                }
                else if (index2 == "DX")
                {
                    memory.setAX(memory.getDX());
                }
                else
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
            }
            else if (index1 == "BX,")
            {
                if (index2 == "AX")
                {
                    memory.setBX(memory.getAX());
                }
                else if (index2 == "BX")
                {
                    memory.setBX(memory.getBX());
                }
                else if (index2 == "CX")
                {
                    memory.setBX(memory.getCX());
                }
                else if (index2 == "DX")
                {
                    memory.setBX(memory.getDX());
                }
                else
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
            }
            else if (index1 == "CX,")
            {
                if (index2 == "AX")
                {
                    memory.setCX(memory.getAX());
                }
                else if (index2 == "BX")
                {
                    memory.setCX(memory.getBX());
                }
                else if (index2 == "CX")
                {
                    memory.setCX(memory.getCX());
                }
                else if (index2 == "DX")
                {
                    memory.setCX(memory.getDX());
                }
                else
                {
                    Console.WriteLine("Err");
                    Console.ReadKey();
                }
            }
            else if (index1 == "DX,")
            {
                if (index2 == "AX")
                {
                    memory.setDX(memory.getAX());
                }
                else if (index2 == "BX")
                {
                    memory.setDX(memory.getBX());
                }
                else if (index2 == "CX")
                {
                    memory.setDX(memory.getCX());
                }
                else if (index2 == "DX")
                {
                    memory.setDX(memory.getDX());
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
    }
}

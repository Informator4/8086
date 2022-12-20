using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public bool getCF()
        {
            return memory.getCF();
        }

        public void RESET()
        {
            memory.resetALL();
        } 


        public void MOV(string index1, string index2) // MOV
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


        public void XCHG(string index1, string index2) // XCHG
        {
                XchangeVariable(index1, index2);
        }


        public void ADD(string index1, string index2) // ADD
        {
            if (short.TryParse(index2, out short x))
            {
                addVariable(index1, x);
            }
            else if (!short.TryParse(index2, out x))
            {
                addVariable(index1, index2);
            }
        }


        public void ADC(string index1, string index2) // ADC
        {
            if (short.TryParse(index2, out short x))
            {
                addVariable(index1, x);
                memory.setCF(true);
            }
            else if (!short.TryParse(index2, out x))
            {
                addVariable(index1, index2);
                memory.setCF(true);
            }
        }


        public void SUB(string index1, string index2) // SUB
        {
            if (short.TryParse(index2, out short x))
            {
                subVariable(index1, x);
            }
            else if (!short.TryParse(index2, out x))
            {
                subVariable(index1, index2);
            }
        }


        public void SBB(string index1, string index2) // SBB
        {
            if (short.TryParse(index2, out short x))
            {
                if (memory.getCF())
                {
                    x++;
                    subVariable(index1, x);
                }
                else
                    subVariable(index1, x);
            }
            else if (!short.TryParse(index2, out x))
            {
                if (memory.getCF())
                    sbbVariable(index1, index2);
                else
                    subVariable(index1, index2);
            }
        }


        public void INC(string index) // INC
        {
            incVariable(index);
        }


        public void DEC(string index) // DEC
        {
            decVariable(index);
        }

        public void CLC() // CLC
        {
            memory.setCF(false);
        }


        public void STC() // STC
        {
            memory.setCF(true);
        }


        // ====== MOV ======

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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid command...");
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
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

        // ====== XCHG =====

        private void XchangeVariable(string index1, string index2)
        {
            if (index1 == "AX,")
            {
                if (index2 == "AX")
                {
                    short x = memory.getAX();
                    memory.setAX(memory.getAX());
                    memory.setAX(x);
                }
                else if (index2 == "BX")
                {
                    short x = memory.getAX();
                    memory.setAX(memory.getBX());
                    memory.setBX(x);
                }
                else if (index2 == "CX")
                {
                    short x = memory.getAX();
                    memory.setAX(memory.getCX());
                    memory.setCX(x);
                }
                else if (index2 == "DX")
                {
                    short x = memory.getAX();
                    memory.setAX(memory.getDX());
                    memory.setDX(x);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "BX,")
            {
                if (index2 == "AX")
                {
                    short x = memory.getBX();
                    memory.setBX(memory.getAX());
                    memory.setAX(x);
                }
                else if (index2 == "BX")
                {
                    short x = memory.getBX();
                    memory.setBX(memory.getBX());
                    memory.setBX(x);
                }
                else if (index2 == "CX")
                {
                    short x = memory.getBX();
                    memory.setBX(memory.getCX());
                    memory.setCX(x);
                }
                else if (index2 == "DX")
                {
                    short x = memory.getBX();
                    memory.setBX(memory.getDX());
                    memory.setDX(x);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "CX,")
            {
                if (index2 == "AX")
                {
                    short x = memory.getCX();
                    memory.setCX(memory.getAX());
                    memory.setAX(x);
                }
                else if (index2 == "BX")
                {
                    short x = memory.getCX();
                    memory.setCX(memory.getBX());
                    memory.setBX(x);
                }
                else if (index2 == "CX")
                {
                    short x = memory.getCX();
                    memory.setCX(memory.getCX());
                    memory.setCX(x);
                }
                else if (index2 == "DX")
                {
                    short x = memory.getCX();
                    memory.setCX(memory.getDX());
                    memory.setDX(x);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "DX,")
            {
                if (index2 == "AX")
                {
                    short x = memory.getDX();
                    memory.setDX(memory.getAX());
                    memory.setAX(x);
                }
                else if (index2 == "BX")
                {
                    short x = memory.getDX();
                    memory.setDX(memory.getBX());
                    memory.setBX(x);
                }
                else if (index2 == "CX")
                {
                    short x = memory.getDX();
                    memory.setDX(memory.getCX());
                    memory.setCX(x);
                }
                else if (index2 == "DX")
                {
                    short x = memory.getDX();
                    memory.setDX(memory.getDX());
                    memory.setDX(x);
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

        // ==== ADD/ADC ====

        private void addVariable(string index, short value)
        {
            if (index == "AX,")
            {
                memory.setAX((short)(value + memory.getAX()));
            }
            else if (index == "BX,")
            {
                memory.setBX((short)(value + memory.getBX()));
            }
            else if (index == "CX,")
            {
                memory.setCX((short)(value + memory.getCX()));
            }
            else if (index == "DX,")
            {
                memory.setDX((short)(value + memory.getDX()));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid command...");
                Console.ReadKey();
            }
        }

        private void addVariable(string index1, string index2)
        {
            if (index1 == "AX,")
            {
                if (index2 == "AX")
                {
                    memory.setAX((short)(memory.getAX() + memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setAX((short)(memory.getAX() + memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setAX((short)(memory.getAX() + memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setAX((short)(memory.getAX() + memory.getDX()));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "BX,")
            {
                if (index2 == "AX")
                {
                    memory.setBX((short)(memory.getBX() + memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setBX((short)(memory.getBX() + memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setBX((short)(memory.getBX() + memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setBX((short)(memory.getBX() + memory.getDX()));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "CX,")
            {
                if (index2 == "AX")
                {
                    memory.setCX((short)(memory.getCX() + memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setCX((short)(memory.getCX() + memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setCX((short)(memory.getCX() + memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setCX((short)(memory.getCX() + memory.getDX()));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "DX,")
            {
                if (index2 == "AX")
                {
                    memory.setDX((short)(memory.getDX() + memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setDX((short)(memory.getDX() + memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setDX((short)(memory.getDX() + memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setDX((short)(memory.getDX() + memory.getDX()));
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

        // ==== SUB/SBB ====

        private void subVariable(string index, short value)
        {
            if (index == "AX,")
            {
                memory.setAX((short)(memory.getAX() - value));
            }
            else if (index == "BX,")
            {
                memory.setBX((short)(memory.getBX() - value));
            }
            else if (index == "CX,")
            {
                memory.setCX((short)(memory.getCX() - value));
            }
            else if (index == "DX,")
            {
                memory.setDX((short)(memory.getDX() - value));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid command...");
                Console.ReadKey();
            }
        }

        private void subVariable(string index1, string index2)
        {
            if (index1 == "AX,")
            {
                if (index2 == "AX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getDX()));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "BX,")
            {
                if (index2 == "AX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getDX()));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "CX,")
            {
                if (index2 == "AX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getDX()));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "DX,")
            {
                if (index2 == "AX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getAX()));
                }
                else if (index2 == "BX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getBX()));
                }
                else if (index2 == "CX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getCX()));
                }
                else if (index2 == "DX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getDX()));
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

        private void sbbVariable(string index1, string index2)
        {
            if (index1 == "AX,")
            {
                if (index2 == "AX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getAX() - 1));
                }
                else if (index2 == "BX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getBX() - 1));
                }
                else if (index2 == "CX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getCX() - 1));
                }
                else if (index2 == "DX")
                {
                    memory.setAX((short)(memory.getAX() - memory.getDX() - 1));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "BX,")
            {
                if (index2 == "AX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getAX() - 1));
                }
                else if (index2 == "BX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getBX() - 1));
                }
                else if (index2 == "CX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getCX() - 1));
                }
                else if (index2 == "DX")
                {
                    memory.setBX((short)(memory.getBX() - memory.getDX() - 1));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "CX,")
            {
                if (index2 == "AX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getAX() - 1));
                }
                else if (index2 == "BX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getBX() - 1));
                }
                else if (index2 == "CX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getCX() - 1));
                }
                else if (index2 == "DX")
                {
                    memory.setCX((short)(memory.getCX() - memory.getDX() - 1));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid command...");
                    Console.ReadKey();
                }
            }
            else if (index1 == "DX,")
            {
                if (index2 == "AX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getAX() - 1));
                }
                else if (index2 == "BX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getBX() - 1));
                }
                else if (index2 == "CX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getCX() - 1));
                }
                else if (index2 == "DX")
                {
                    memory.setDX((short)(memory.getDX() - memory.getDX() - 1));
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

        // ====== INC ======

        private void incVariable(string index)
        {
            if (index == "AX")
            {
                memory.setAX((short)(memory.getAX() + 1));
            }
            else if (index == "BX")
            {
                memory.setBX((short)(memory.getBX() + 1));
            }
            else if (index == "CX")
            {
                memory.setCX((short)(memory.getCX() + 1));
            }
            else if (index == "DX")
            {
                memory.setDX((short)(memory.getDX() + 1));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid command...");
                Console.ReadKey();
            }
        }

        // ====== DEC ======

        private void decVariable(string index)
        {
            if (index == "AX")
            {
                memory.setAX((short)(memory.getAX() - 1));
            }
            else if (index == "BX")
            {
                memory.setBX((short)(memory.getBX() - 1));
            }
            else if (index == "CX")
            {
                memory.setCX((short)(memory.getCX() - 1));
            }
            else if (index == "DX")
            {
                memory.setDX((short)(memory.getDX() - 1));
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

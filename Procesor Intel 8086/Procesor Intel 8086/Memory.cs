using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesor_Intel_8086
{
    internal class Memory
    {
        // Rejestry
        private short AX = 0;
        private short BX = 0;
        private short CX = 0;
        private short DX = 0;

        public void resetALL()
        {
            AX = 0;
            BX = 0;
            CX = 0;
            DX = 0;
        }

        public short getAX()
        {
            return AX;
        }
        public short getBX()
        {
            return BX;
        }
        public short getCX()
        {
            return CX;
        }
        public short getDX()
        {
            return DX;
        }

        // =================

        public void setAX(short AX)
        {
            this.AX = AX;
        }
        public void setBX(short BX)
        {
            this.BX = BX;
        }
        public void setCX(short CX)
        {
            this.CX = CX;
        }
        public void setDX(short DX)
        {
            this.DX = DX;
        }
    }
}
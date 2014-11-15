using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBoy
{
    class CPU
    {
        /* Zilog Z80
         * RAM : 8K
         * 
         * */
        private byte[] _RAM = new byte[0x10000];
        public byte getMem(int index)
        {
            return _RAM[index];
            // TODO: implement ram mirroring, etc. etc. etc.

        }

        /* series of 8-bit registers, A-E and H / L, F for flags */
        public byte A { get; set; }
        public byte B { get; set; }

        public UInt16 BC
        {
            get
            {
                return Convert.ToUInt16(B << 8 + C);
            }
            set
            {
                B = Convert.ToByte(value >> 8);
                C = Convert.ToByte(value & 0xFF);
            }
        }

        public UInt16 DE
        {
            get
            {
                return Convert.ToUInt16(D << 8 + E);
            }
            set
            {
                D = Convert.ToByte(value >> 8);
                E = Convert.ToByte(value & 0xFF);
            }
        }

        public UInt16 HL
        {
            get
            {
                return Convert.ToUInt16(H << 8 + L);
            }
            set
            {
                H = Convert.ToByte(value >> 8);
                L = Convert.ToByte(value & 0xFF);
            }
        }
        public byte C { get; set; }
        public byte D { get; set; }
        public byte E { get; set; }
        public byte H { get; set; }
        public byte L { get; set; }
        public byte F { get; set; }

        /* 16-bit Program Counter */
        public UInt16 PC { get; set; }

        /* Stack Pointer */
        public UInt16 SP { get; set; }


        public int M { get; set; } /* Machine Cycles for tracking execution speed */
        public int T { get; set; } /* Clock cycles, for tracking execution speed. generally 4x machine cycles. */

    }
}

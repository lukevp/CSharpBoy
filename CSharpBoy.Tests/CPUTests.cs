using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpBoy.Tests
{
    [TestClass]
    public class CPUTests
    {
        [TestMethod]
        public void TestRegisters()
        {
            CPU cpu = new CPU();
            // test bounds of registers
            cpu.A = 0;
            Assert.AreEqual(cpu.A, 0);
            cpu.A = 0xFF;
            Assert.AreEqual(cpu.A, 0xFF);
            //TODO: add other registers to bounds checking
            
            // test hybrid register BC
            cpu.B = 0;
            cpu.C = 0;
            Assert.AreEqual(cpu.B, 0);
            Assert.AreEqual(cpu.C, 0);
            cpu.BC = 0xFFFF;
            Assert.AreEqual(cpu.B, 0xFF);
            Assert.AreEqual(cpu.C, 0xFF);
            Assert.AreEqual(cpu.BC, 0xFFFF);
            cpu.BC = 0xABCD;
            Assert.AreEqual(cpu.B, 0xAB);
            Assert.AreEqual(cpu.C, 0xCD);
            Assert.AreEqual(cpu.BC, 0xABCD);


            // test hybrid register DE
            cpu.D = 0;
            cpu.E = 0;
            Assert.AreEqual(cpu.D, 0);
            Assert.AreEqual(cpu.E, 0);
            cpu.DE = 0xFFFF;
            Assert.AreEqual(cpu.D, 0xFF);
            Assert.AreEqual(cpu.E, 0xFF);
            Assert.AreEqual(cpu.DE, 0xFFFF);
            cpu.DE = 0xABCD;
            Assert.AreEqual(cpu.D, 0xAB);
            Assert.AreEqual(cpu.E, 0xCD);
            Assert.AreEqual(cpu.DE, 0xABCD);


            // test hybrid register HL
            cpu.H = 0;
            cpu.L = 0;
            Assert.AreEqual(cpu.H, 0);
            Assert.AreEqual(cpu.L, 0);
            cpu.HL = 0xFFFF;
            Assert.AreEqual(cpu.H, 0xFF);
            Assert.AreEqual(cpu.L, 0xFF);
            Assert.AreEqual(cpu.HL, 0xFFFF);
            cpu.HL = 0xABCD;
            Assert.AreEqual(cpu.H, 0xAB);
            Assert.AreEqual(cpu.L, 0xCD);
            Assert.AreEqual(cpu.HL, 0xABCD);

        }



    }
}

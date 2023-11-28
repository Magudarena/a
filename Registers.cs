using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch
{
    internal class Registers
    {
        private byte AH;
        private byte AL;
        private byte BH;
        private byte BL;
        private byte CH;
        private byte CL;
        private byte DH;
        private byte DL;

        public Registers() 
        {
            this.AH = 0;
            this.AL = 0;
            this.BH = 0;
            this.BL = 0;
            this.CH = 0;
            this.CL = 0;
            this.DH = 0;
            this.DL = 0;
        }

        public byte getValue(string register) 
        {
            switch (register)
            {
                case "AL":
                    return this.AL;
                case "AH":
                    return this.AH; 
                case "BL":
                    return this.BL; 
                case "BH":
                    return this.BH; 
                case "CL":
                    return this.CL; 
                case "CH":
                    return this.CH; 
                case "DL":
                    return this.DL; 
                case "DH":
                    return this.DH; 
                default:
                    throw new InvalidOperationException($"Invalid register {register}");
            }
        }    
        public void setValue(string register, byte value) 
        {
            switch (register)
            {
                case "AL":
                    this.AL = value;
                    break;
                case "AH":
                    this.AH = value;
                    break;
                case "BL":
                    this.BL = value;
                    break;
                case "BH":
                    this.BH = value;
                    break;
                case "CL":
                    this.CL = value;
                    break;
                case "CH":
                    this.CH = value;
                    break;
                case "DL":
                    this.DL = value;
                    break;
                case "DH":
                    this.DH = value;
                    break;        
                default:
                    throw new InvalidOperationException($"Invalid register {register}");
            }
        }

        public string getValueBinary (string register) 
        {
            byte value = this.getValue(register);
            return Convert.ToString(value, 2).PadLeft(8, '0');
        }

        public void INC (string register)
        {
            byte value = this.getValue(register);
            this.setValue(register, ++value);
        }
        public void DEC (string register)
        {
            byte value = this.getValue(register);
            this.setValue(register, --value);
        }
        public void MOV(string registerFrom, string registerTo) 
        {
            byte value = this.getValue(registerFrom );
            this.setValue(registerTo, value);
        }
        public void XCHG(string registerOne, string registerTwo) 
        {
            byte valueOne = this.getValue(registerOne );
            byte valueTwo = this.getValue( registerTwo );
            this.setValue(registerOne, valueTwo);
            this.setValue(registerTwo, valueOne);
        }
        
        public void NOT(string register) 
        {
            byte value = (byte)~this.getValue(register);
            this.setValue(register, value);
        }
    }
}

namespace Arch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registers registers = new Registers();
            printRegisters(registers);
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                try
                {
                    switch (command[0].ToUpper())
                    {
                        case "SET":
                            string register = command[1];
                            byte value = Byte.Parse(command[2]);
                            registers.setValue(register, value);
                            break;
                            
                        case "INC":
                            register = command[1];
                            registers.INC(register);
                            break;
                        case "DEC":
                            register = command[1];
                            registers.DEC(register);
                            break;
                        case "MOV":
                            string registerFrom = command[1];
                            string registerTo = command[2];
                            registers.MOV(registerFrom, registerTo);
                            break;
                        case "XCHG":
                            string registerOne = command[1];
                            string registerTwo = command[2];
                            registers.XCHG(registerOne, registerTwo);
                            break;
                        case "NOT":
                            register = command[1];
                            registers.NOT(register);
                            break;
                        case "ADD":
                            registerOne = command[1];
                            registerTwo = command[2];
                            registers.ADD(registerOne, registerTwo);
                            break;
                        case "SUB":
                            registerOne = command[1];
                            registerTwo = command[2];
                            registers.SUB(registerOne, registerTwo);
                            break;
                        case "NEG":
                            register = command[1];
                            registers.NEG(register);
                            break;
                        case "AND":
                            registerOne = command[1];
                            registerTwo = command[2];
                            registers.AND(registerOne, registerTwo);
                            break;
                        case "OR":
                            registerOne = command[1];
                            registerTwo = command[2];
                            registers.OR(registerOne, registerTwo);
                            break;
                        case "XOR":
                            registerOne = command[1];
                            registerTwo = command[2];
                            registers.XOR(registerOne, registerTwo);
                            break;
                        case "MUL":
                            register = command[1];
                            registers.MUL(register);
                            break;
                        case "IMUL":
                            register = command[1];
                            registers.IMUL(register);
                            break;
                        case "DIV":
                            register = command[1];
                            registers.DIV(register);
                            break;
                        case "IDIV":
                            register = command[1];
                            registers.IDIV(register);
                            break;

                        default:
                            Console.WriteLine("Invalid command");
                            break;
                    }
                } 
                catch (Exception e)
                {
                    Console.WriteLine("Invalid command");
                    Console.WriteLine(e.ToString());
                }
                printRegisters( registers );  
            }


            
          /*  registers.setValue("AL", 20);
            registers.INC("DH");
            registers.DEC("CL");
            registers.INC("CL");
            registers.XCHG("AL", "CL");
            Console.WriteLine(registers.getValueBinary("AL")) ;
            Console.WriteLine(registers.getValueBinary("DH")) ;
            Console.WriteLine(registers.getValueBinary("CL")) ;*/









        }
        public static void printRegisters(Registers registers)
        {
            Console.WriteLine($"AL: {registers.getValueBinary("AL")}");
            Console.WriteLine($"AH: {registers.getValueBinary("AH")}");
            Console.WriteLine($"BL: {registers.getValueBinary("BL")}");
            Console.WriteLine($"BH: {registers.getValueBinary("BH")}");
            Console.WriteLine($"CL: {registers.getValueBinary("CL")}");
            Console.WriteLine($"CH: {registers.getValueBinary("CH")}");
            Console.WriteLine($"DL: {registers.getValueBinary("DL")}");
            Console.WriteLine($"DH: {registers.getValueBinary("DH")}");
        }

    }
}
namespace Arch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registers registers = new Registers();
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                switch (command[0].ToUpper())
                {
                    case "GET":
                        string register = command[1];
                        Console.WriteLine(registers.getValueBinary(register));
                        break;
                    case "GETALL":
                        Console.WriteLine($"AL: {registers.getValueBinary("AL")}");
                        Console.WriteLine($"AH: {registers.getValueBinary("AH")}");
                        Console.WriteLine($"BL: {registers.getValueBinary("BL")}");
                        Console.WriteLine($"BH: {registers.getValueBinary("BH")}");
                        Console.WriteLine($"CL: {registers.getValueBinary("CL")}");
                        Console.WriteLine($"CH: {registers.getValueBinary("CH")}");
                        Console.WriteLine($"DL: {registers.getValueBinary("DL")}");
                        Console.WriteLine($"DH: {registers.getValueBinary("DH")}");
                        break;
                    case "INC":
                        register = command[1];
                        registers.INC( register );
                        break;
                    case "DEC":
                        register = command[1];
                        registers.DEC( register );
                        break;
                    case "MOV":
                        string registerFrom = command[1];
                        string registerTo = command[2];
                        registers.MOV( registerFrom, registerTo );
                        break;
                    case "XCHG":
                        string registerOne = command[1];
                        string registerTwo = command[2];
                        registers.XCHG( registerOne, registerTwo );
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
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
    }
}
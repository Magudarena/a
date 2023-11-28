namespace Arch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registers registers = new Registers();
            registers.setValue("AL", 20);
            registers.INC("DH");
            registers.DEC("CL");
            registers.INC("CL");
            Console.WriteLine(registers.getValueBinary("AL")) ;
            Console.WriteLine(registers.getValueBinary("DH")) ;
            Console.WriteLine(registers.getValueBinary("CL")) ;









        }
    }
}
namespace Arch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registers registers = new Registers();
            registers.setValue("AL", 20);
            
            Console.WriteLine(registers.getValueBinary("AL")) ;
            Console.WriteLine(registers.getValueBinary("DH")) ;









        }
    }
}
using System;
using System.Text;
using System.Data;

namespace ConsoleCSharpBasico_TeuNome{
    class Program{

        static void Main(string[] args)
        {
            Using();
        }

        static void Using()
        {
            Console.WriteLine("Sem o Using System console, esse comando seria: System.Console.WriteLine()");
            Console.WriteLine("Ajudando na organização e legibilidade do código");
            Console.WriteLine("O Using System.Data permite que eu capture infomações como a data atual: "+
            DateTime.Now);
            Console.WriteLine("FIM DO USING\n---------------------------------------");
        }
    }
}  
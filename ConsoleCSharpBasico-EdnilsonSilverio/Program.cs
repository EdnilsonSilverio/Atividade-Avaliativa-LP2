using System;
using System.Text;
using System.Data;
using System.Threading.Tasks.Dataflow;

namespace ConsoleCSharpBasico_TeuNome{
    class Program
    {

        static void Main(string[] args)
        {
            //Using(); Comentado para enfatiza a visualização alvo do Commit
            //DeclararVariaveis();
            //UsoDeVar();
            Nullable();
        }

        static void Using()
        {
            Console.WriteLine("Sem o Using System console, esse comando seria: System.Console.WriteLine()");
            Console.WriteLine("Ajudando na organização e legibilidade do código");
            Console.WriteLine("O Using System.Data permite que eu capture infomações como a data atual: " +
            DateTime.Now);
            Console.WriteLine("FIM DO USING\n---------------------------------------");
        }

        static void DeclararVariaveis()
        {
            int idade = 21;
            float altura = 1.73f;
            double peso = 73.7;
            char letra = 'D';
            string nome = "Ednilson da Silva Silvério";
            bool aprovado = true;
            DateTime hoje = DateTime.Now;

            if (aprovado)
            {
                Console.WriteLine("Parabéns " + nome + "\nVocê foi aprovado");
                Console.WriteLine("-----------Dados do aluno aprovado---------------");
                Console.WriteLine("Idade: " + idade + "\nAltura: " + altura + "\nPeso: " +
                peso + "\nInicial: " + letra + "\nData e hora da consulta no sistema: " + hoje);

            }
            else
            {
                Console.WriteLine("Você foi reprovado!\nTente novamente!");
            }
        }

        static void UsoDeVar()
        {
            var numero = 42; // interpreta, em tempo de compilação, que a varíavel em questão é int
            var nome = "Prefessor Silas"; // interpreta, em tempo de compilação, que a varíavel em questão é string
            var flt = 4.3f; // interpreta, em tempo de compilação, que a varíavel em questão é list
            const double pi = 3.14159; //Variável constante, cujo valor não será alterado durante a compilação.
            Console.WriteLine("Soma = " + (numero + 3));
            Console.WriteLine("Olá, " + nome + "!");
            Console.WriteLine("Cálculo utilizando PI = " + (flt * pi));
        }

        static void Nullable()
        {
            //normalmente representada pelo sinal de "?" após o tipo da variável
            string? nome = null; // Uma variável string que pode ser nula
            int? idade = null; // Uma variável inteira que pode ser nula
            nome = "Ednilson";

            if (idade == null){
                Console.WriteLine($"O {nome} preferiu não informar sua idade.");
            }else{
                Console.WriteLine($"O {nome} tem {idade} anos.");
            }

        }
    }
}  
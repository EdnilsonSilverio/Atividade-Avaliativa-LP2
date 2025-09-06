using System;
using System.Text;
using System.Data;

namespace ConsoleCSharpBasico_TeuNome{
    class Program{

        static void Main(string[] args)
        {
            //Using(); Comentado para enfatiza a visualização alvo do Commit
            DeclararVariaveis();
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
    }
}  
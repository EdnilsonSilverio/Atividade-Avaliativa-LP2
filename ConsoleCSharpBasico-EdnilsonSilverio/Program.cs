using System;
using System.Text;
using System.Data;
using System.Threading.Tasks.Dataflow;

namespace ConsoleCSharpBasico_TeuNome{

    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }

}
    class Program
    {

        static void Main(string[] args)
        {
            //Using(); Comentado para enfatiza a visualização alvo do Commit
            //DeclararVariaveis();
            //UsoDeVar();
            //Nullable();
            //Conversao();
            //CriarObjetos();
            //DemonstrarOperadores();
            ConcatenacaoDeStrings();
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

            if (idade == null)
            {
                Console.WriteLine($"O {nome} preferiu não informar sua idade.");
            }
            else
            {
                Console.WriteLine($"O {nome} tem {idade} anos.");
            }
        }
        static void Conversao()
        {
            string idadeEmTexto = "12";
            int idadeConvertidaInt = int.Parse(idadeEmTexto); // Converte a idade em int
            double preco = 125.50;
            string precoEmTexto = preco.ToString(); // Converte o preço em texto
            Type tipoIdade = idadeConvertidaInt.GetType(); // Guarda o tipo da variável para validação
            Type tipopreco = precoEmTexto.GetType();

            Console.WriteLine($"Numero convertido: {idadeConvertidaInt}, em int: {idadeConvertidaInt}");
            Console.WriteLine($"O preço em texto é: {precoEmTexto}");
            Console.WriteLine($"Tipo da idade = {tipoIdade}\nTipo do preço = {tipopreco}");

        }

        static void CriarObjetos()
        {

            Animal animal1 = new Animal();// Criação de um novo objeto da classe Animal usando "new"

            // Atribuição dos atribudos do objeto para "animal1"
            animal1.Nome = "Rex";
            animal1.Especie = "Cachorro";
            animal1.Cor = "Caramelo";
            animal1.Idade = 10;

            // Atribuição dos atribudos do objeto para "animal1"
            Animal animal2 = new Animal();

            animal2.Nome = "Gaturno";
            animal2.Especie = "Gato";
            animal2.Cor = "Vermelho";
            animal2.Idade = 5;

            Console.WriteLine("Animal 1:");
            Console.WriteLine($"Nome: {animal1.Nome}");
            Console.WriteLine($"Espécie: {animal1.Especie}");
            Console.WriteLine($"Cor: {animal1.Cor}");
            Console.WriteLine($"Idade: {animal1.Idade}");
            Console.WriteLine("------------------------------------------------------");


            Console.WriteLine("Animal 2:");
            Console.WriteLine($"Nome: {animal2.Nome}");
            Console.WriteLine($"Espécie: {animal2.Especie}");
            Console.WriteLine($"Cor: {animal2.Cor}");
            Console.WriteLine($"Idade: {animal2.Idade}");
        }

        static void DemonstrarOperadores()
        {
            int x = 15;
            int y = 12;
            bool fazCalor = true;
            bool fazFrio = false;

            // Operadores Relacionais
            Console.WriteLine($"x > y: {x > y}"); // verifica se x é maior que y
            Console.WriteLine($"x < y: {x < y}"); // verifica se x é menor que y
            Console.WriteLine($"x == 15: {x == 15}"); // verificar se x é igual a 15
            Console.WriteLine($"x != y: {x != y}"); // verifica se x é diferente de y
            Console.WriteLine($"x >= 15: {x >= 15}"); // verifica se x é maior ou igual a 15
            Console.WriteLine($"y <= 5: {y <= 5}"); // verificar se y é menor ou igual a 5

            Console.WriteLine();

            // Operadores Lógicos
            Console.WriteLine($"Sol E Frio: {fazCalor && fazFrio}"); // Retorna true se sol e frio forem verdadeiros
            Console.WriteLine($"Sol OU Frio: {fazCalor || fazFrio}"); // Retornaa true se sol ou frio forem verdadeiros
            Console.WriteLine($"Não está Frio: {!fazFrio}"); // Retorna tru se frio for false e virse versa
        }
        
        static void ConcatenacaoDeStrings()
        {
        string nome = "Ednilson";
        string sobrenome = "Silvério";
        int idade = 21;
        
        string nomeCompleto = nome + " " + sobrenome; //Usando o operador de soma (+)
        string mensagemIdade = "Nome: " + nomeCompleto + "\nIdade: " + idade;
        Console.WriteLine("Mensagem com o Operador Soma");
        Console.WriteLine(mensagemIdade);
        Console.WriteLine("------------------------------------");

        string mensagemFormatada = $"Nome: {nome} {sobrenome} \nIdade: {idade}"; // Usando a interpolação de strings, forma mais utilizada
        Console.WriteLine("Mensagem com interpolação");
        Console.WriteLine(mensagemFormatada);
        Console.WriteLine("------------------------------------");
 
        string saudacao = String.Concat("Olá, ", nome, "!"); //Usando String.Concat()
        Console.WriteLine("Mensagem com String.Concat()");
        Console.WriteLine(saudacao);
        }
    }
}  
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
            //ConcatenacaoDeStrings();
            //Arrays();
            //Condicionais();
            //Comentarios();
            //Interpolação();
            //ManipulacaoDeStrings();
            StringBuilder();
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

        static void Arrays()
        {

            int[] numeros = new int[5]; // Criando um array de inteiros de 5 posições.

            // Atribuindo valores aos elementos do array de acordo com o indice de posição
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;


            // Acessando e imprimindo um elemento específico
            Console.WriteLine("Array de números:\n---------------------------------------");
            Console.WriteLine($"O primeiro número no array é: {numeros[0]}");
            Console.WriteLine($"O terceiro número no array é: {numeros[2]}");
            Console.WriteLine($"O último número no array é: {numeros[4]}");


            // Declarando e inicializando um array de strings com valores
            string[] motos = { "MT-03", "R3", "CB300", "G310GS" };

            //Acessando um elemento e o tamanho do array
            Console.WriteLine("---------------------------------------\nArray de motos:");
            Console.WriteLine($"A segunda Moto é: {motos[1]}");
            Console.WriteLine($"O array de motos tem {motos.Length} elementos.");

            // Percorrendo o array com um loop 'for'e imprimindo cada elemento
            Console.WriteLine("\nLista de motos:");
            for (int i = 0; i < motos.Length; i++)
            {
                Console.WriteLine(motos[i]);
            }
        }

        static void Condicionais()
        {
            Console.WriteLine("Exemplo com if e else");
            int idade = 17;

            // Estrutura if e else simples para verificação de maior idade.
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

            Console.WriteLine("\nExemplo com if, else if e else");
            int pontuacao = 85;

            // Estrutura if, else if e else aninhada, para verificação de pontuação
            if (pontuacao >= 90)
            {
                Console.WriteLine("Excelente! Sua nota é 'Ótima'.");
            }
            else if (pontuacao >= 80)
            {
                Console.WriteLine("Muito bom! Sua nota é 'Boa'.");
            }
            else if (pontuacao >= 70)
            {
                Console.WriteLine("Bom. Sua nota é 'Intermediária'.");
            }
            else
            {
                Console.WriteLine("Precisa melhorar. Sua nota é 'Abaixo da média'.");
            }

            Console.WriteLine("\nExemplo com switch case");
            char opcao = 'B';

            // Estrutura switch case
            switch (opcao)
            {
                case 'A':
                    Console.WriteLine("Opção selecionada: A. Iniciar novo jogo.");
                    break;
                case 'B':
                    Console.WriteLine("Opção selecionada: B. Carregar jogo salvo.");
                    break;
                case 'C':
                    Console.WriteLine("Opção selecionada: C. Configurações.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void Comentarios()
        {
            // Este é um comentário de linha única.
            // Ele é muito utilizado para informar o comportamente de uma linha específica:
            int idade = 21; // varíavel do tipo int que guarda o valor 21

            /*
            Este é um comentário de múltiplas linhas.
            Ele é usado para explicações mais longas,
            como o propósito de um bloco de código ou uma função.
            Como por exemplo:
            O condicional a seguir classifica se o usuário pode ou
            não dirigir, de acordo coma a idade:
            */
            if (idade >= 18)
            {
                Console.WriteLine("Pode dirigir.");
            }
            else
            {
                Console.WriteLine("Não pode dirigir.");
            }

            /* 
            De acordo com algumas pesquisas a parte realizadas por mim,
            identifiquei que há outros tipos de comentários bem mais específicos
            como:
            */
            /// <summary>
            /// Este é um comentário de documentação XML.
            /// Ele é usado para gerar documentação automatizada do código.
            /// O sumário descreve a finalidade de um método específico.
            /// </summary>
            // param é muito utilizado para explica a finalidade de um parâmetro:
            /// <param name="nome">O nome da pessoa a ser cumprimentada.</param>
            /// <returns>Retorna uma string de saudação.</returns>

            string Cumprimentar(string nome)
            {
                return $"Olá, {nome}!";
            }

            string saudacao = Cumprimentar("João");
            Console.WriteLine(saudacao);
        }

        static void Interpolação()
        {
            string produto = "Computador";
            double preco = 2500.50;
            int quantidade = 2;

            // concatenando variáveis em uma frase:
            Console.WriteLine($"O produto é: {produto}");

            // realizando cálculos e formatando a saída de acordo com a informação:
            double total = preco * quantidade;
            Console.WriteLine($"O valor total de {quantidade} unidades de {produto} é: R$ {total}");

            // usando a interpolação para exibir uma data formatada como estamos habituado:
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine($"\nImpressão da data:");
            Console.WriteLine($"Hoje é: {dataAtual:dd/MM/yyyy}");
        }

        static void ManipulacaoDeStrings()
        {
            string textoOriginal = "   Silvério, Ednilson!   ";

            Console.WriteLine($"Texto Original: '{textoOriginal}'");

            // Trim: remove espaços no início e no fim
            string textoSemEspacos = textoOriginal.Trim();
            Console.WriteLine($"Trim: '{textoSemEspacos}'");

            // ToUpper: converte para maiúsculas
            string textoMaiusculo = textoSemEspacos.ToUpper();
            Console.WriteLine($"ToUpper: '{textoMaiusculo}'");

            // ToLower: converte para minúsculas
            string textoMinusculo = textoSemEspacos.ToLower();
            Console.WriteLine($"ToLower: '{textoMinusculo}'");

            // Replace: substitui uma parte da string
            string textoSubstituido = textoSemEspacos.Replace("Ednilson", "Aluno");
            Console.WriteLine($"Replace: '{textoSubstituido}'");

            // Contains: verifica se a string contém um trecho
            bool contemTrecho = textoSemEspacos.Contains("Ednilson");
            Console.WriteLine($"Contains 'Ednilson': {contemTrecho}");

            // Length: retorna o número de caracteres
            int tamanho = textoSemEspacos.Length;
            Console.WriteLine($"Length: {tamanho}");

            // Acesso de acordo com a posição da letra []: acessa um caractere por posição
            char primeiroCaractere = textoSemEspacos[0];
            Console.WriteLine($"Primeiro caractere: '{primeiroCaractere}'");

            // Split: divide a string em um array de strings
            string frase = "Silas é uma bom professor";
            string[] palavras = frase.Split(' ');
            Console.WriteLine($"Primeira palavra com Split: {palavras[0]}");

            // Insert: insere uma string em uma posição específica
            string textoInserido = textoSemEspacos.Insert(19, "!");
            Console.WriteLine($"Insert: '{textoInserido}'");

            // Equals: compara se duas strings são iguais
            string outraString = "Silvério, Ednilson!";
            bool saoIguais = textoSemEspacos.Equals(outraString);
            Console.WriteLine($"Equals: {saoIguais}");

            // Copy: cria uma cópia da string
            string copia = String.Copy(textoSemEspacos);
            Console.WriteLine($"Copy: '{copia}'");
        }
        
    static void StringBuilder()
        {
            // criando uma nova instância de StringBuilder:
            StringBuilder sb = new StringBuilder();

            // adicionando texto com o método Append()
            sb.Append("Bem vindo ");
            sb.Append("ao ");
            sb.Append("mundo ");
            sb.Append("do ");
            sb.Append("C#! ");

            // adicionando uma linha com AppendLine()
            sb.AppendLine("Isso é fácil!");

            // inserindo texto em uma posição específica de acordo com o índice
            sb.Insert(12, " meu");

            // removendo um trecho com base nos parâmetros: 4 caracteres a partir da posição 9
            sb.Remove(30, 14);

            // substituindo um trecho
            sb.Replace("fácil", "simples");

            // imprimindo a string final usando ToString()
            Console.WriteLine(sb.ToString());
        }
    }
}  
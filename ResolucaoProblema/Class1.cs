namespace ResolucaoProblema;

public class MediaPesos
{
    public void CalcularMediaPesosPorIdade(int[] idades, double[] pesos)
        {
            // variaveis para somar pesos e contar pessoas por faixa etária
            double somaPeso1_10 = 0;
            int count1_10 = 0;

            double somaPeso11_20 = 0;
            int count11_20 = 0;

            double somaPeso21_30 = 0;
            int count21_30 = 0;

            double somaPesoMais30 = 0;
            int countMais30 = 0;

            // Loop para processar os 15 dados
            for (int i = 0; i < 15; i++)
            {
                int idade = idades[i];
                double peso = pesos[i];

                if (idade >= 1 && idade <= 10)
                {
                    somaPeso1_10 += peso;
                    count1_10++;
                }
                else if (idade >= 11 && idade <= 20)
                {
                    somaPeso11_20 += peso;
                    count11_20++;
                }
                else if (idade >= 21 && idade <= 30)
                {
                    somaPeso21_30 += peso;
                    count21_30++;
                }
                else if (idade > 30)
                {
                    somaPesoMais30 += peso;
                    countMais30++;
                }
            }

            // Exibindo os resultados no console
            Console.WriteLine("--- Média de Pesos por Faixa Etária ---");
            
            if (count1_10 > 0)
            {
                Console.WriteLine($"Faixa Etária (1-10 anos): {somaPeso1_10 / count1_10:F2} kg");
            }
            if (count11_20 > 0)
            {
                Console.WriteLine($"Faixa Etária (11-20 anos): {somaPeso11_20 / count11_20:F2} kg");
            }
            if (count21_30 > 0)
            {
                Console.WriteLine($"Faixa Etária (21-30 anos): {somaPeso21_30 / count21_30:F2} kg");
            }
            if (countMais30 > 0)
            {
                Console.WriteLine($"Faixa Etária (Maiores de 30 anos): {somaPesoMais30 / countMais30:F2} kg");
            }
        }
}

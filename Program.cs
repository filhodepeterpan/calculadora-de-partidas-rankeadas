using System;

class Program
{
    static void Main (string[] args)
    {
        static float calculaRank(int vitorias, int derrotas)
        {
            return vitorias - derrotas;
        }

        Console.WriteLine("Digite seu número de vitórias: ");
        int vitorias = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("\n");

        Console.WriteLine("Digite seu número de derrotas: ");
        int derrotas = int.Parse(Console.ReadLine() ?? "0");

        float rank = calculaRank(vitorias, derrotas);
        string classificacao = "";

        if (rank <= 10)
        {
            classificacao = "FERRO";
        }
        else if (rank <= 20)
        {
            classificacao = "BRONZE";
        }
        else if (rank <= 50)
        {
            classificacao = "PRATA";
        }
        else if (rank <= 80)
        {
            classificacao = "OURO";
        }
        else if (rank <= 90)
        {
            classificacao = "DIAMANTE";
        }
        else if (rank <= 100)
        {
            classificacao = "LENDÁRIO";
        }
        else if (rank > 100)
        {
            classificacao = "IMORTAL";
        }

        Console.WriteLine($@"
        O Herói tem um saldo de {rank} e está no nível {classificacao};
        ");

    }
}

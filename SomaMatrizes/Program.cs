public class SomaMatrizes
{
    public void EscreveMatriz(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");

            }
            Console.WriteLine();
        }
    }
    public int[,] SomaMatriz(int[,] matriz1, int[,] matriz2, int linhas, int colunas)
    {
        Console.ReadKey();
        int[,] soma = new int[linhas, colunas];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma[i,j] = matriz1[i,j] + matriz2[i,j];
            }
        }
        Console.WriteLine("Matrizes somadas!");
        Console.ReadKey();
        return soma;
    }
    public int[,] CriaMatriz(int[,] matriz, int linhas, int colunas)
    {
        matriz = new int[linhas, colunas];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("Número da posição {0}, {1}: ", i, j);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Matriz finalizada!");
        Console.ReadKey();
        return matriz;
    }
    public static void Main()
    {
        int linhas, colunas;
        SomaMatrizes somaMatrizes = new SomaMatrizes();

        Console.Write("Informe a quantidade de linhas das matrizes: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Informe a quantidade de colunas das matrizes: ");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz1 = null;
        int[,] matriz2 = null;
        int[,] soma = null;

        Console.Clear();
        Console.WriteLine("MATRIZ 1");
        matriz1 = somaMatrizes.CriaMatriz(matriz1, linhas, colunas);

        Console.Clear();
        Console.WriteLine("MATRIZ 2");
        matriz2 = somaMatrizes.CriaMatriz(matriz2, linhas, colunas);

        Console.Clear();
        Console.WriteLine("SOMAR MATRIZES");
        soma = somaMatrizes.SomaMatriz(matriz1, matriz2, linhas, colunas);

        Console.Clear();
        Console.WriteLine("SOMA DAS MATRIZES");
        somaMatrizes.EscreveMatriz(soma, linhas, colunas);
    }
}
namespace Exemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever todos os número pares entre 0 e 100

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
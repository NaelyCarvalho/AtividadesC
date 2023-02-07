namespace Exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construa um programa em C# que solicita ao usuário que informe três números inteiros, e retorne o maior número informado.

            int a;
            int b;
            int c;

            Console.WriteLine("Informe o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a + " é o maior número!");
            }


            else if (b > a && b > c)
            {
                Console.WriteLine(b + " é o maior número!");
            }


            else if (c > a && c > b)
            {
                Console.WriteLine(c + " é o maior número!");
            }

            else
            {
                Console.WriteLine(" Números iguais!");
            }
        }
    }
}
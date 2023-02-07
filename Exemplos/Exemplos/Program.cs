namespace Exemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar Projeto com o nome MediaEscolar, ler o nome do aluno, somar 4 notas e mostrar na tela o nome do aluno e a média,
            //e se a nota for maior que 7 aprovado, menor que 7 reprovado. Colocando no for e repetindo 4 vezes.

            string nome;
            int a;
            int b;
            int c;
            int d;
            int soma;

            for (int i = 1; i < 5; i++)
            {

                Console.WriteLine("Informe seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe a primeira nota: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a segunda nota: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a terceira nota: ");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quarta nota: ");
                d = Convert.ToInt32(Console.ReadLine());

                soma = ((a + b + c + d) / 4);

                Console.WriteLine(nome + ", sua media é: " + soma);

                if (soma < 7)
                {
                    Console.WriteLine("Reprovado!");
                }

                else if (soma > 7)
                {
                    Console.WriteLine("Aprovado!");
                }

            }
        }
    }
}
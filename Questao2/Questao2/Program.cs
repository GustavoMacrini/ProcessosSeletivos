using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 1;
            int c = a + b;
            bool fim = false;

            try
            {
                Console.Write("Informe um número inteiro: ");
                int num = int.Parse(Console.ReadLine());

                do
                {
                    if (num == a || num == b || num == c)
                    {
                        Console.WriteLine($"O valor {num} pertence a sequencia!");
                        fim = true;
                    }

                    if (c > num)
                    {
                        Console.WriteLine($"O valor {num} não pertence a sequencia!");
                        fim = true;
                    }

                    a = b;
                    b = c;
                    c = a + b;

                } while (fim != true);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }

        }
    }
}
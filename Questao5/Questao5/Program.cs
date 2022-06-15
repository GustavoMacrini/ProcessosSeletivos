using System;
using Questao5.Entities;
using Questao5.Exceptions;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe a string desejada: ");
                string myString = Console.ReadLine();

                Sentence mySentence = new Sentence(myString);

                mySentence.Inverter();
                Console.WriteLine("String invertida: " + mySentence.ToString());
            }
            catch (StringException ex)
            {
                Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
            }
        }
    }
}
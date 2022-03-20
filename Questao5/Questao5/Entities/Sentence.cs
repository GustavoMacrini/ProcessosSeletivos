using System.Text;
using Questao5.Exceptions;

namespace Questao5.Entities
{
    internal class Sentence
    {
        public string Caracteres { get; set; }

        public Sentence(string caracteres)
        {
            Caracteres = caracteres;
        }

        public void Inverter()
        {
            if(Caracteres.Length == 0)
            {
                throw new StringException("A string está vazia");
            }

            string inverte = "";

            int num = Caracteres.Length;

            for (int i = 0; i < num; i++)
            {
                inverte += Caracteres[num - i - 1];
            }

            Caracteres = inverte;
        }

        public override string ToString()
        {
            return Caracteres;
        }
    }
}

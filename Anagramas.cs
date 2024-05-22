using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAnagrama
{
    internal class Anagramas
    {
        
        public bool isAnagramas(string palavra1, string palavra2)
        {
            int qtdLetras1 = palavra1.Length;
            int qtdLetras2 = palavra2.Length;
            bool isAnagram = false;

            if (qtdLetras1 != qtdLetras2)
            {
                return false;

            }
            else
            {
                char[] lista1;
                char[] lista2;

                lista1 = palavra1.ToCharArray();
                lista2 = palavra2.ToCharArray();

                Array.Sort(lista1);
                Array.Sort(lista2);

                palavra1 = string.Join("", lista1);
                palavra2 = string.Join("", lista2);

                if (palavra1 == palavra2)
                {
                    isAnagram = true;

                }

                return isAnagram;
            }

        }
    }
}

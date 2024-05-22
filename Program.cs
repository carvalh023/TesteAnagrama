using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAnagrama
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Anagramas verificaAnagrama = new Anagramas();
            bool isAnagram = verificaAnagrama.isAnagramas("bbt", "btg");
            
            Console.WriteLine("Resultado: " + isAnagram);
        }
    }
}

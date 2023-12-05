using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerliParemetreler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sinifim s= new sinifim();
            s.selamla();
            s.selamla("hasan");
        }
    }
    class sinifim
    {
        public void selamla(string ad = "OBEZ HASAN")
        {
            Console.WriteLine("Merhaba :"+ad);
        }

        
        
    }
}

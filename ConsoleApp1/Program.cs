using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculos
    {
        private int _dividendo;
        private int _divisor;

        public static void Main(string[] args)
        {
            Calculos calc = new Calculos(22, 4);
            Console.WriteLine("El resultado es {0}", calc.Division());
            Console.ReadKey();
        }

        private Calculos() { }

        public Calculos(int param1, int param2)
        {
            _dividendo = param1;
            _divisor = param2;
        }

        public double Division()
        {
            try
            {
                return _dividendo / _divisor;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}

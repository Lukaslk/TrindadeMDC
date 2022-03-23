using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrindadeMDC
{
    public class CalcularMDC
    {
        public static List<int> MDC(int num1, int num2)
        {
            if (num1 < 0 || num2 < 0)
            {
                throw new Exception("Não é permitido numero Negativo");
            }
            int Resto;
            List<int> lista = new List<int> { };
            while (num2 != 0)
            {
                for (int i = 0; num2 != 0; i++)
                {
                    Resto = num1 % num2;
                    num1 = num2;
                    num2 = Resto;
                    lista.Add(num1);
                }
            }
            return lista;
        }
    }
}

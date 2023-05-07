using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1308723_AjsivinacEslySem9
{
    public class Sumatoria
    {
        public void Suma()
        {
            int N;
            double resultado = 0;
           
            Console.WriteLine("Porfavor ingrese un número entero positivo: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                resultado = resultado + (1 / i);
                Console.WriteLine(resultado);
            }

        }
    }

    public class Factorial
    {
        public Factorial()
        {
            int N2;
            int factorial = 1;
            Console.WriteLine("Por favor ingrese un número entero positivo para cálcular su factorial");
            N2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N2; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de " + N2 + " es " + factorial);
            Console.ReadKey();
        }
    }

    public class TablasMultiplicar
    {
        public TablasMultiplicar()
        {

        }
    }

    public class NumPerfecto
    {
        public NumPerfecto()
        {

        }
    }
}

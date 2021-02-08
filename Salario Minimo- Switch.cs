using System;

namespace Salario_Minimo__Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual: ");
            double salariom = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contato:" + "Escriba 1 si es Dependiente." + " Escriba 2 si es Independiente ");
            int tipoContrato = int.Parse(Console.ReadLine());

            double cotizacion = salariom * 0.4;
            double arl = 0;
            double smmlv = 877802;

            if (cotizacion < smmlv)
            {
                cotizacion = smmlv;
            }

            switch (tipoContrato)
            {

                case 1:
                    double pension = cotizacion * 0.04;
                    double eps = cotizacion * 0.04;
                    double salarioreal = salariom - (pension + eps);
                    double bonificacion = salariom;
                    double salarioanual = (salarioreal * 12) + bonificacion;

                    Console.WriteLine("Su salario real es" + salarioreal);
                    Console.WriteLine("Su salario anual es" + salarioanual); break;


                case 2:
                    Console.WriteLine("Número de riesgo laboral (1-5)");
                    int riesgo = int.Parse(Console.ReadLine());
                    double pensión = cotizacion * 0.16;
                    double epss = cotizacion * 0.125;
                    

                    switch (riesgo)
                    {
                        case 1: arl = 0.00522; break;

                        case 2: arl = 0.01044; break;

                        case 3: arl = 0.02436; break;

                        case 4: arl = 0.04350; break;

                        case 5: arl = 0.0696; break;
                    }

                    arl *= cotizacion;
                    double realsalario = salariom - (pensión + epss + arl);
                    double anualsalario = realsalario * 12;
                    Console.WriteLine("Su salario real es" + realsalario);
                    Console.WriteLine("Su salario anual es" + anualsalario); break;
            }
        }
    }
}

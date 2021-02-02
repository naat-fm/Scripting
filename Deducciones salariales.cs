using System;

namespace Deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual: ");

            int salariom = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contato:" + "Escriba 1 si es Dependiente." + " Escriba 2 si es Independiente ");
            int tipoContrato = int.Parse(Console.ReadLine());

            int sml = 877802;
            double basecot = salariom * 0.4; //el 40% del salario


            if (basecot < sml) basecot = sml;

            if (tipoContrato==1) 
            {
                double pension = basecot * 0.04;
                double eps = basecot* 0.04;
                double prima = salariom;
                double salarioreal = salariom - (pension + eps);
                double salarioanual = (salarioreal*12)+(prima);

                Console.WriteLine("Su salario real es: " + salarioreal + ",Su salario anual es: "+salarioanual);
                Console.WriteLine("Deducciones de EPS: " + eps + ",Pensión:"+ pension);
            }
            else
            {
                Console.WriteLine("Ingrese su número de riesgo laboral: ");
                int riesgo = int.Parse(Console.ReadLine());

                if  (riesgo ==1 )
                    {
                        double pension = basecot * 0.16;
                        double eps = basecot * 0.125;
                        double arl = basecot * 0.00522;
                        double salarioreal = salariom - (pension + eps + arl);
                        double salarioanual = (salarioreal * 12);

                        Console.WriteLine("Su salario real es: " + salarioreal + ",Su salario anual es: " + salarioanual);
                        Console.WriteLine("Deducciones de ARL: " + arl + " ,EPS: " + eps + " ,Pensión: " + pension);
                    }
                else if (riesgo == 2)
                {
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double arl = basecot * 0.01044;
                    double salarioreal = salariom - (arl + pension + eps);
                    double salarioanual = (salarioreal * 12);

                    Console.WriteLine("Su salario real es: " + salarioreal + ",Su salario anual es: " + salarioanual);
                    Console.WriteLine("Deducciones de ARL:" + arl + ",EPS: " + eps + ",Pensión:" + pension);

                }
                else if (riesgo == 3)
                {
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double arl = basecot * 0.02436;
                    double salarioreal = salariom - (arl + pension + eps);
                    double salarioanual = (salarioreal * 12);

                    Console.WriteLine("Su salario real es: " + salarioreal + ",Su salario anual es: " + salarioanual);
                    Console.WriteLine("Deducciones de ARL:" + arl + ",EPS: " + eps + ",Pensión:" + pension);
                }

                else if (riesgo == 4)
                {
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double arl = basecot * 0.04350;
                    double salarioreal = salariom - (arl + pension + eps);
                    double salarioanual = (salarioreal * 12);

                    Console.WriteLine("Su salario real es: " + salarioreal + ",Su salario anual es: " + salarioanual);
                    Console.WriteLine("Deducciones de ARL:" + arl + ",EPS: " + eps + ",Pensión:" + pension);
                }
                else if (riesgo == 5)
                {
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double arl = basecot * 0.0696;
                    double salarioreal = salariom - (arl + pension + eps);
                    double salarioanual = (salarioreal * 12) ;

                    Console.WriteLine("Su salario real es: " + salarioreal + ",Su salario anual es: " + salarioanual);
                    Console.WriteLine("Deducciones de ARL:" + arl  + ",EPS: " + eps + ",Pensión:" + pension);
                }

            }

        }
    }
}


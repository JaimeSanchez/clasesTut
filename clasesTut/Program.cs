using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesTut
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion del objeto empleado
            clsEmpleados empleado;
            //Instanciacion de la variable empleado;
            empleado = new clsEmpleados();

            empleado.edad = 25;
            empleado.Nombre = "Jaime Sánchez";
            empleado.SueldoDiario = 500m;

            decimal total;

            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado "+ empleado.Nombre);
            Console.WriteLine("es: " + total.ToString("C"));
            Console.ReadKey();

        }
    }
}

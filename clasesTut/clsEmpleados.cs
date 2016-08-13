using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesTut
{
    public class clsEmpleados
    {
        //metodo constructor o constructor
        public clsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0M;
            edad = 0;
        }

        //propiedades de la clase de tipo publico para poder accesar a ellas
        private string _Nombre;     

        //accesor de propiedad--encapsulamiento
        public string Nombre
        {
            get{ return _Nombre; }
            set{ _Nombre = value;}
        }

        public decimal SueldoDiario { get; set; }
        public int edad { get; set; }

        //metodos de la clase
        //metodo para calcular los dias de salario
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }

    }
}

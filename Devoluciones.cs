using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_base_de_datos_Vehiculos
{
    public class Devoluciones
    {
        int NIT;
        string Placa;
        string FechaA;
        string FechaD;
        int Kmrecorridos;
        int PrecioKM;
        int Total;

        public int NIT1 { get => NIT; set => NIT = value; }
        public string Placa1 { get => Placa; set => Placa = value; }
        public string FechaA1 { get => FechaA; set => FechaA = value; }
        public string FechaD1 { get => FechaD; set => FechaD = value; }
        public int Kmrecorridos1 { get => Kmrecorridos; set => Kmrecorridos = value; }
        public int Total1 { get => Total; set => Total = value; }
    }
}

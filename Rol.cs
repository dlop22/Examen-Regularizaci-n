using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenCorregido
{
    class Rol
    {
        public int Numcamion
        { get; set; }

        public string Chofer
        { get; set; }

        public string Salida
        { get; set; }

        public string Ruta
        { get; set; }

        public Rol(int camion, string chofer, string ruta,string salida)
        {
            Numcamion = camion;
            Chofer = chofer;
            Salida = salida;
            Ruta = ruta;
        }
        public override string ToString()
        {
            return "camion" + Numcamion + ", " + Ruta + ", Salida: " + Salida + ", Chofer: " + Chofer;
        }
    }
}

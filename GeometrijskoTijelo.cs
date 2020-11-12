using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinPonavljanjeZadatak7
{
    class GeometrijskoTijelo
    {
        public double Volumen;
        public double Oplosje;
        public static int BrojacTijela;
        public GeometrijskoTijelo()
            {
            BrojacTijela++;
            }
        public override string ToString()
        {
            string suma = ""+BrojacTijela;
            return suma;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseH
{

    public enum Tipo {Camión,Moto,Coche};

    class Conductor
    {
        int id;
        String vehiculo;

        public int Id { get => id; set => id = value; }
        public string Vehiculo { get => vehiculo; set => vehiculo = value; }

       

    }
}

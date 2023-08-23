using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023.Practica1
{
    public abstract class TransportePublico
    {
        public int Pasajeros { get; set; }

        public TransportePublico(int Pasajeros) 
        { 
            this.Pasajeros = Pasajeros;
        }
    }
}

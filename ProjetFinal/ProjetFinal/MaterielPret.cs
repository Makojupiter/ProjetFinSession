using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class MaterielPret
    {
        int idMateriel;

        public MaterielPret(int idMateriel)
        {
            this.idMateriel = idMateriel;
        }

        public int IdMateriel
        {
            get => idMateriel;
            set => idMateriel = value;
        }
    }
}

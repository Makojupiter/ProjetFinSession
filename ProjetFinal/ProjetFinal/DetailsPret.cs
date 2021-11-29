using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class DetailsPret  : INotifyPropertyChanged
    {

        int id, noPret;
        string noMateriel, nomMateriel, marqueMateriel, retourne, usagerRetour;

        public DetailsPret(int id, int noPret, string noMateriel, string nomMateriel, string marqueMateriel, string retourne, string usagerRetour)
        {
            this.id = id;
            this.noPret = noPret;
            this.noMateriel = noMateriel;
            this.nomMateriel = nomMateriel;
            this.marqueMateriel = marqueMateriel;
            this.retourne = retourne;
            this.usagerRetour = usagerRetour;
        }

        public DetailsPret(int noPret, string noMateriel, string nomMateriel, string marqueMateriel, string retourne, string usagerRetour)
        {
            this.noPret = noPret;
            this.noMateriel = noMateriel;
            this.nomMateriel = nomMateriel;
            this.marqueMateriel = marqueMateriel;
            this.retourne = retourne;
            this.usagerRetour = usagerRetour;
        }

        public DetailsPret( string noMateriel, string nomMateriel, string marqueMateriel, string retourne, string usagerRetour)
        {
            this.noMateriel = noMateriel;
            this.nomMateriel = nomMateriel;
            this.marqueMateriel = marqueMateriel;
            this.retourne = retourne;
            this.usagerRetour = usagerRetour;
        }

        public DetailsPret(string noMateriel, string retourne, string usagerRetour)
        {
            this.noMateriel = noMateriel;
            this.retourne = retourne;
            this.usagerRetour = usagerRetour;
        }

        public int Id 
        { 
            get => id;
            set
            {
                id = value;
                this.OnPropertyChanged();
            }
        }
        public int NoPret 
        { 
            get => noPret;
            set
            {
                noPret = value;
                this.OnPropertyChanged();
            }
        }
        public string NoMateriel 
        { 
            get => noMateriel;
            set
            {
                noMateriel = value;
                this.OnPropertyChanged();
            }
        }
        public string NomMateriel 
        { 
            get => nomMateriel;
            set
            {
                nomMateriel = value;
                this.OnPropertyChanged();
            }
        }
        public string MarqueMateriel 
        { 
            get => marqueMateriel;
            set
            {
                marqueMateriel = value;
                this.OnPropertyChanged();
            }
        }
        public string Retourne 
        { 
            get => retourne;
            set
            {
                retourne = value;
                this.OnPropertyChanged();
            }
        }
        public string UsagerRetour 
        { 
            get => usagerRetour;
            set
            {
                usagerRetour = value;
                this.OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

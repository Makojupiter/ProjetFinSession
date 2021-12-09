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

        int ID_Pret, Etats, ID_Utilisateur, id_Detail;
        string ID_Materiel;

        public DetailsPret(int iD_Pret, int etats, int iD_Utilisateur, string iD_Materiel)
        {
            ID_Pret = iD_Pret;
            Etats = etats;
            ID_Utilisateur = iD_Utilisateur;
            ID_Materiel = iD_Materiel;
        }


        public int ID_Pret1 
        { 
            get => ID_Pret;
            set
            {
                ID_Pret = value;
                this.OnPropertyChanged();
            }
        }
        public int Etats1 
        { 
            get => Etats;
            set
            {
                Etats = value;
                this.OnPropertyChanged();
            }
        }
        public int ID_Utilisateur1 
        { 
            get => ID_Utilisateur;
            set
            {
                ID_Utilisateur = value;
                this.OnPropertyChanged();
            }
        }
        public string ID_Materiel1 
        { 
            get => ID_Materiel;
            set
            {
                ID_Materiel = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

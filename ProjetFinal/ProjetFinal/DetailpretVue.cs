using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class DetailpretVue : INotifyPropertyChanged
    {

        int id_Pret, etat;

        string nomClient, dateCreer,heureCreer, dateRetour, nomUtilisateur;

        public DetailpretVue(int id_Pret, int etat, string nomClient, string dateCreer, string heureCreer, string dateRetour, string nomUtilisateur)
        {
            this.id_Pret = id_Pret;
            this.etat = etat;
            this.nomClient = nomClient;
            this.dateCreer = dateCreer;
            this.heureCreer = heureCreer;
            this.dateRetour = dateRetour;
            this.nomUtilisateur = nomUtilisateur;
        }

        public int Id_Pret { get => id_Pret; set => id_Pret = value; }
        public int Etat 
        { 
            get => etat;
            set
            {
                etat = value;
                this.OnPropertyChanged();
            }
        }
        public string NomClient 
        { 
            get => nomClient;
            set
            {
                nomClient = value;
                this.OnPropertyChanged();
            }
        }
        public string DateCreer 
        { 
            get => dateCreer;
            set
            {
                dateCreer = value;
                this.OnPropertyChanged();
            }
        }
        public string HeureCreer 
        { 
            get => heureCreer;
            set
            {
                heureCreer = value;
                this.OnPropertyChanged();
            }
        }
        public string DateRetour 
        { 
            get => dateRetour;
            set
            {
                dateRetour = value;
                this.OnPropertyChanged();
            }
        }
        public string NomUtilisateur 
        { 
            get => nomUtilisateur;
            set
            {
                nomUtilisateur = value;
                this.OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

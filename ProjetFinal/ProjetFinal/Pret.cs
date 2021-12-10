using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Pret : INotifyPropertyChanged
    {

        int id_Pret, id_Client, id_Utilisateur, etat;

        string datePret, heurePret, dateRetour;

        public Pret(int id_Client, string datePret, string heurePret, string dateRetour, int id_Utilisateur, int etat)
        {
            this.id_Client = id_Client;
            this.datePret = datePret;
            this.heurePret = heurePret;
            this.dateRetour = dateRetour;
            this.id_Utilisateur = id_Utilisateur;
            this.etat = etat;
        }

        public Pret(int id_Pret, int id_Client, string datePret, string heurePret, string dateRetour, int id_Utilisateur, int etat)
        {
            this.id_Pret = id_Pret;
            this.id_Client = id_Client;
            this.datePret = datePret;
            this.heurePret = heurePret;
            this.dateRetour = dateRetour;
            this.id_Utilisateur = id_Utilisateur;
            this.etat = etat;
        }

        public int Id_Client 
        { 
            get => id_Client;
            set
            {
                id_Client = value;
                this.OnPropertyChanged();
            }
        }

        public int Id_Pret
        {
            get => id_Pret;
            set
            {
                id_Pret = value;
                this.OnPropertyChanged();
            }
        }
        public string DatePret 
        { 
            get => datePret;
            set
            {
                datePret = value;
                this.OnPropertyChanged();
            }
        }
        public string HeurePret 
        { 
            get => heurePret;
            set
            {
                heurePret = value;
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
        public int Id_Utilisateur
        {
            get => id_Utilisateur;
            set
            {
                id_Utilisateur = value;
                this.OnPropertyChanged();
            }
        }
        public int Etat
        {
            get => etat;
            set
            {
                etat = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    }
}

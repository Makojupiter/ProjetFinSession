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

        int id, client;
        string date, heure, dateRetour, usager, etat;

        public Pret(int id, int client, string date, string heure, string dateRetour, string usager, string etat)
        {
            this.id = id;
            this.client = client;
            this.date = date;
            this.heure = heure;
            this.dateRetour = dateRetour;
            this.usager = usager;
            this.etat = etat;
        }

        public Pret(int client, string date, string heure, string dateRetour, string usager, string etat)
        {
            this.client = client;
            this.date = date;
            this.heure = heure;
            this.dateRetour = dateRetour;
            this.usager = usager;
            this.etat = etat;
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
        public int Client 
        { get => client;
            set
            {
                client = value;
                this.OnPropertyChanged();
            }
        }
        public string Date 
        { get => date;
            set
            {
                date = value;
                this.OnPropertyChanged();
            }
        }
        public string Heure 
        { 
            get => heure;
            set
            {
                heure = value;
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
        public string Usager 
        { 
            get => usager;
            set
            {
                usager = value;
                this.OnPropertyChanged();
            }
        }
        public string Etat 
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

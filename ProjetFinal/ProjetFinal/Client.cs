using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal 
{
    class Client : INotifyPropertyChanged
    {
        int id;
        string nom, email, numTel, poste, numBureau, type;

        public Client(int id, string nom, string email, string numTel, string poste, string numBureau, string type)
        {
            this.id = id;
            this.nom = nom;
            this.email = email;
            this.numTel = numTel;
            this.poste = poste;
            this.numBureau = numBureau;
            this.type = type;
        }

        public Client(string nom, string email, string numTel, string poste, string numBureau, string type)
        {
            this.nom = nom;
            this.email = email;
            this.numTel = numTel;
            this.poste = poste;
            this.numBureau = numBureau;
            this.type = type;
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
        public string Nom 
        { 
            get => nom;
            set
            {
                nom = value;
                this.OnPropertyChanged();
            }
        }
        public string Email 
        { 
            get => email;
            set
            {
                email = value;
                this.OnPropertyChanged();
            }
        }
        public string NumTel 
        { 
            get => numTel;
            set
            {
                numTel = value;
                this.OnPropertyChanged();
            }
        }
        public string Poste 
        { 
            get => poste;
            set
            {
                poste = value;
                this.OnPropertyChanged();
            }
        }
        public string NumBureau 
        { 
            get => numBureau;
            set
            {
                numBureau = value;
                this.OnPropertyChanged();
            }
        }
        public string Type 
        { 
            get => type;
            set
            {
                type = value;
                this.OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

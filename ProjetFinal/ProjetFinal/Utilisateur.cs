using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Utilisateur : INotifyPropertyChanged
    {
                string username, nom, prenom, password;

        public Utilisateur(string username, string nom, string prenom, string password)
        {
            this.username = username;
            this.nom = nom;
            this.prenom = prenom;
            this.password = password;
        }

        public string Username 
        { 
            get => username;
            set
            {
                username = value;
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
        public string Prenom 
        { 
            get => prenom;
            set
            {
                prenom = value;
                this.OnPropertyChanged();
            }
        }
        public string Password 
        { 
            get => password;
            set
            {
                password = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

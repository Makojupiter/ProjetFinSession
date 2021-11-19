using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Utilisateur : INotifyPropertyChanged
    {
                string nomUsager, nom, prenom, password;

        public utilisateur(string nomUsager, string nom, string prenom, string password)
        {
            this.nomUsager = nomUsager;
            this.nom = nom;
            this.prenom = prenom;
            this.password = password;
        }

        public string NomUsager 
        { 
            get => nomUsager;
            set
            {
                nomUsager = value;
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

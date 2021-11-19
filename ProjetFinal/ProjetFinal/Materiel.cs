using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Materiel : INotifyPropertyChanged
    {
        string identifiant, marque, model, etat, note;

        public Materiel(string identifiant, string marque, string model, string etat, string note)
        {
            this.identifiant = identifiant;
            this.marque = marque;
            this.model = model;
            this.etat = etat;
            this.note = note;
        }

        public string Identifiant 
        { 
            get => identifiant;
            set
            {
                identifiant = value;
                this.OnPropertyChanged();
            }
        }
        public string Marque 
        { 
            get => marque;
            set
            {
                marque = value;
                this.OnPropertyChanged();
            }
        }
        public string Model 
        { 
            get => model;
            set
            {
                model = value;
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
        public string Note 
        { 
            get => note;
            set
            {
                note = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

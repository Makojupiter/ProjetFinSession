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

        int idPret, nbrMateriel, nbrMaterielEnCours, nbrMaterielRetourne, etatPret;

        string nom, date, dateRetour, nomUtilisateur;

        public DetailpretVue(int idPret, string nom, string date, string dateRetour, int nbrMateriel, int nbrMaterielEnCours, int nbrMaterielRetourne, int etatPret, string nomUtilisateur)
        {
            this.idPret = idPret;
            this.nom = nom;
            this.date = date;
            this.dateRetour = dateRetour;
            this.nbrMateriel = nbrMateriel;
            this.nbrMaterielEnCours = nbrMaterielEnCours;
            this.nbrMaterielRetourne = nbrMaterielRetourne;
            this.etatPret = etatPret;
            this.nomUtilisateur = nomUtilisateur;
        }

        public int IdPret
        {
            get => idPret;
            set
            {
                idPret = value;
                this.OnPropertyChanged();
            }
        }
        public int NbrMateriel 
        { 
            get => nbrMateriel;
            set
            {
                nbrMateriel = value;
                this.OnPropertyChanged();
            }
        }
        public int NbrMaterielEnCours 
        { 
            get => nbrMaterielEnCours;
            set
            {
                nbrMaterielEnCours = value;
                this.OnPropertyChanged();
            }
        }
        public int NbrMaterielRetourne
        {
            get => nbrMaterielRetourne;
            set
            {
                nbrMaterielRetourne = value;
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
        public string Date
        {
            get => date;
            set
            {
                date = value;
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
        public int EtatPret
        {
            get => etatPret;
            set
            {
                etatPret = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

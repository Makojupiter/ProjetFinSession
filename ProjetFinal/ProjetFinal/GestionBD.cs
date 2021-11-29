﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class GestionBD
    {
        MySqlConnection con;
        ObservableCollection<Pret> listePret;
        ObservableCollection<Client> listeClient;
        ObservableCollection<Materiel> listeMateriel;
        static GestionBD gestionBD = null;

        public GestionBD()
        {
            this.con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2021_420326ri_equipe_12;Uid=2029918;Pwd=Frtw6630+;");
            listePret = new ObservableCollection<Pret>();
            listeClient = new ObservableCollection<Client>();
            listeMateriel = new ObservableCollection<Materiel>();
        }

        public static GestionBD getInstance()
        {
            if (gestionBD == null)
                gestionBD = new GestionBD();

            return gestionBD;
        }
        public ObservableCollection<Pret> getPret()
        {
            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM pret";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {

                    listePret.Add(new Pret(r.GetInt32(0), r.GetInt32(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6)));
                }
                r.Close();
                con.Close();

                return listePret;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return listePret;
            }
        }
        public ObservableCollection<Pret> getListPret()
        {
            return listePret;
        }

        public ObservableCollection<Client> getClient()
        {
            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM client";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {

                    listeClient.Add(new Client(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6)));
                }
                r.Close();
                con.Close();

                return listeClient;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return listeClient;
            }
        }
        public ObservableCollection<Client> getListClient()
        {
            return listeClient;
        }

        public ObservableCollection<Materiel> getMateriel()
        {
            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM materiel";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {

                    listeMateriel.Add(new Materiel(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4)));
                }
                r.Close();
                con.Close();

                return listeMateriel;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return listeMateriel;
            }
        }
        public ObservableCollection<Materiel> getListMateriel()
        {
            return listeMateriel;
        }

        public int AjouterPret(Pret c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "INSERT INTO pret VALUES(null, @client, @date, @heure, @dateRetour, @usager, @etat)";

            commande.Parameters.AddWithValue("@client", c.Client);
            commande.Parameters.AddWithValue("@date", c.Date);
            commande.Parameters.AddWithValue("@heure", c.Heure);
            commande.Parameters.AddWithValue("@dateRetour", c.DateRetour);
            commande.Parameters.AddWithValue("@usager", c.Usager);
            commande.Parameters.AddWithValue("@etat", c.Etat);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            //Pour obtenir le dernier ID inseré pour permettre à la liste de s'actualiser
            commande.CommandText = "SELECT MAX(id) FROM pret";
            MySqlDataReader r = commande.ExecuteReader();
            r.Read();
            int id = r.GetInt32(0);
            c.Id = id;

            con.Close();

            listePret.Add(c);

            return retour;
        }

        public int AjouterClient(Client c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "INSERT INTO client VALUES(null, @nom, @email, @numTel, @poste, @numBureau, @type)";

            commande.Parameters.AddWithValue("@nom", c.Nom);
            commande.Parameters.AddWithValue("@email", c.Email);
            commande.Parameters.AddWithValue("@numTel", c.NumTel);
            commande.Parameters.AddWithValue("@poste", c.Poste);
            commande.Parameters.AddWithValue("@numBureau", c.NumBureau);
            commande.Parameters.AddWithValue("@type", c.Type);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            //Pour obtenir le dernier ID inseré pour permettre à la liste de s'actualiser
            commande.CommandText = "SELECT MAX(id) FROM client";
            MySqlDataReader r = commande.ExecuteReader();
            r.Read();
            int id = r.GetInt32(0);
            c.Id = id;

            con.Close();

            listeClient.Add(c);

            return retour;
        }

        public int AjouterMateriel(Materiel c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "INSERT INTO materiel VALUES(@identifiant, @marque, @model, @etat, @note)";

            commande.Parameters.AddWithValue("@identifiant", c.Identifiant);
            commande.Parameters.AddWithValue("@marque", c.Marque);
            commande.Parameters.AddWithValue("@model", c.Model);
            commande.Parameters.AddWithValue("@etat", c.Etat);
            commande.Parameters.AddWithValue("@note", c.Note);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            con.Close();

            listeMateriel.Add(c);

            return retour;
        }

        public void supprimerPret(Pret c)
        {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "DELETE FROM pret WHERE id = " + c.Id;

            con.Open();
            commande.ExecuteNonQuery();
            con.Close();

            listePret.Remove(c);
        }

        public void supprimerClient(Client c)
        {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "DELETE FROM client WHERE id = " + c.Id;

            con.Open();
            commande.ExecuteNonQuery();
            con.Close();

            listeClient.Remove(c);
        }

        public void supprimerMateriel(Materiel c)
        {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "DELETE FROM materiel WHERE id = " + c.Identifiant;

            con.Open();
            commande.ExecuteNonQuery();
            con.Close();

            listeMateriel.Remove(c);
        }
        public int modifierPret(Pret c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "UPDATE pret SET client = @client, date = @date, heure = @heure, dateRetour = @dateRetour, usager = @usager, etat = @etat where id = @id";

            commande.Parameters.AddWithValue("@client", c.Client);
            commande.Parameters.AddWithValue("@date", c.Date);
            commande.Parameters.AddWithValue("@heure", c.Heure);
            commande.Parameters.AddWithValue("@dateRetour", c.DateRetour);
            commande.Parameters.AddWithValue("@usager", c.Usager);
            commande.Parameters.AddWithValue("@etat", c.Etat);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            con.Close();

            return retour;
        }

        public int modifierClient(Client c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "UPDATE client SET nom = @nom, email = @email, numTel = @numTel, poste = @poste, numBureau = @numBureau, type = @type where id = @id";

            commande.Parameters.AddWithValue("@nom", c.Nom);
            commande.Parameters.AddWithValue("@email", c.Email);
            commande.Parameters.AddWithValue("@numTel", c.NumTel);
            commande.Parameters.AddWithValue("@poste", c.Poste);
            commande.Parameters.AddWithValue("@numBureau", c.NumBureau);
            commande.Parameters.AddWithValue("@type", c.Type);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            con.Close();

            return retour;
        }
        public int modifierMateriel(Materiel c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "UPDATE materiel SET identifiant = @identifiant, marque = @marque, model = @model, etat = @etat, note = @note where identifiant = @identifiant";

            commande.Parameters.AddWithValue("@identifiant", c.Identifiant);
            commande.Parameters.AddWithValue("@marque", c.Marque);
            commande.Parameters.AddWithValue("@model", c.Model);
            commande.Parameters.AddWithValue("@etat", c.Etat);
            commande.Parameters.AddWithValue("@note", c.Note);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            con.Close();

            return retour;
        }
    }
}

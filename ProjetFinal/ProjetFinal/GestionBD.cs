using MySql.Data.MySqlClient;
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
        ObservableCollection<Utilisateur> listeUtilisateur;
        static GestionBD gestionBD = null;

        internal ObservableCollection<Pret> ListePret { get => listePret; set => listePret = value; }
        internal ObservableCollection<Client> ListeClient { get => listeClient; set => listeClient = value; }
        internal ObservableCollection<Materiel> ListeMateriel { get => listeMateriel; set => listeMateriel = value; }
        internal ObservableCollection<Utilisateur> ListeUtilisateur { get => listeUtilisateur; set => listeUtilisateur = value; }

        public GestionBD()
        {
            this.con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2021_420326ri_equipe_12;Uid=2029918;Pwd=Frtw6630+;");
            listePret = new ObservableCollection<Pret>();
            listeClient = new ObservableCollection<Client>();
            listeMateriel = new ObservableCollection<Materiel>();
            listeUtilisateur = new ObservableCollection<Utilisateur>();

            getPret();
            getMateriel();
            getClient();
            getUtilisateur();
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

        public List<Client> RechercherClient(String client)
        {

            List<Client> resultats = new List<Client>();

            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM client WHERE numTel like '%" + client + "%'";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    resultats.Add(new Client(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6)));

                }
                r.Close();
                con.Close();

                return resultats;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return resultats;
            }
        }

        public Client RechercherClient2(String client)
        {

             Client c = new Client("","","","","","");

            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM client WHERE numTel = " + client ;

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    c = new Client(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6));

                }
                r.Close();
                con.Close();

                return c;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return c;
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

        public List<Materiel> RechercherMateriel(String materiel)
        {

            List<Materiel> resultats = new List<Materiel>();

            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM materiel WHERE marque like '%" + materiel + "%'";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    resultats.Add(new Materiel(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4)));

                }
                r.Close();
                con.Close();

                return resultats;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return resultats;
            }
        }

        public Materiel RechercherMateriel2(String materiel)
        {

            Materiel m = new Materiel("BAD", "BAD", "BAD", "BAD", "BAD");

            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM materiel WHERE idMateriel = " + materiel;

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    m = new Materiel(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4));

                }
                r.Close();
                con.Close();

                return m;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return m;
            }
        }

        public ObservableCollection<Materiel> getListMateriel()
        {
            return listeMateriel;
        }

        public ObservableCollection<Utilisateur> getUtilisateur()
        {
            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * FROM utilisateur";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {

                    listeUtilisateur.Add(new Utilisateur(r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4)));
                }
                r.Close();
                con.Close();

                return listeUtilisateur;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return listeUtilisateur;
            }
        }
        public ObservableCollection<Utilisateur> getListUtilisateur()
        {
            return listeUtilisateur;
        }

        public int AjouterPret(Pret c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "INSERT INTO pret VALUES(null, @client, @date, @heure, @dateRetour, @utilisateur, @etat)";

            commande.Parameters.AddWithValue("@client", c.Client);
            commande.Parameters.AddWithValue("@date", c.Date);
            commande.Parameters.AddWithValue("@heure", c.Heure);
            commande.Parameters.AddWithValue("@dateRetour", c.DateRetour);
            commande.Parameters.AddWithValue("@utilisateur", c.Utilisateur);
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

            MySqlCommand commande = new MySqlCommand("p_ajout_client");
            commande.Connection = con;
            commande.CommandType = System.Data.CommandType.StoredProcedure;

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

        public int AjouterUtilisateur(Utilisateur c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand("p_ajout_utilisateur");
            commande.Connection = con;
            commande.CommandType = System.Data.CommandType.StoredProcedure;

            commande.Parameters.AddWithValue("@username", c.Username);
            commande.Parameters.AddWithValue("@prenom", c.Prenom);
            commande.Parameters.AddWithValue("@nom", c.Nom);
            commande.Parameters.AddWithValue("@password", c.Password);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            con.Close();

            listeUtilisateur.Add(c);

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
            commande.CommandText = "DELETE FROM client WHERE idClient = " + c.Id;

            con.Open();
            commande.ExecuteNonQuery();
            con.Close();

            listeClient.Remove(c);
        }
        public void supprimerMateriel(Materiel c)
        {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "DELETE FROM materiel WHERE idMateriel = " + c.Identifiant;

            con.Open();
            commande.ExecuteNonQuery();
            con.Close();

            listeMateriel.Remove(c);
        }
        public void supprimerUtilisateur(Utilisateur c)
        {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "DELETE FROM utilisateur WHERE username = @username";

            commande.Parameters.AddWithValue("@username", c.Username);

            con.Open();
            commande.Prepare();
            commande.ExecuteNonQuery();
            con.Close();

            listeUtilisateur.Remove(c);
        }
        public int modifierPret(Pret c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "UPDATE pret SET idClient = @client, date = @date, heure = @heure, dateRetour = @dateRetour, idUtilisateur = @utilisateur, etat = @etat where idPret = @idPret";

            commande.Parameters.AddWithValue("@idPret", c.Id);
            commande.Parameters.AddWithValue("@client", c.Client);
            commande.Parameters.AddWithValue("@date", c.Date);
            commande.Parameters.AddWithValue("@heure", c.Heure);
            commande.Parameters.AddWithValue("@dateRetour", c.DateRetour);
            commande.Parameters.AddWithValue("@usager", c.Utilisateur);
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
            commande.CommandText = "UPDATE client SET nom = @nom, email = @email, numTel = @numTel, poste = @poste, numBureau = @numBureau, type = @type where idClient = @id";

            commande.Parameters.AddWithValue("@id", c.Id);
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
            commande.CommandText = "UPDATE materiel SET marque = @marque, model = @model, etat = @etat, note = @note where idMateriel = @idMateriel";

            commande.Parameters.AddWithValue("@idMateriel", c.Identifiant);
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
        public int modifierUtilisateur(Utilisateur c)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "UPDATE utilisateur SET prenom = @prenom, nom = @nom, password = @password where username = @username";

            commande.Parameters.AddWithValue("@username", c.Username);
            commande.Parameters.AddWithValue("@prenom", c.Prenom);
            commande.Parameters.AddWithValue("@nom", c.Nom);
            commande.Parameters.AddWithValue("@password", c.Password);

            con.Open();
            commande.Prepare();
            retour = commande.ExecuteNonQuery();

            con.Close();

            return retour;
        }
    }
}

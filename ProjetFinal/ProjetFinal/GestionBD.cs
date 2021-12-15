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
        ObservableCollection<DetailpretVue> listePretVue;
        ObservableCollection<Client> listeClient;
        ObservableCollection<Materiel> listeMateriel;
        ObservableCollection<Utilisateur> listeUtilisateur;

        static GestionBD gestionBD = null;

        string usernameLogged;
        int logged;
        int idUser;

        public GestionBD()
        {
            //this.con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2021_420326ri_equipe_12;Uid=2029918;Pwd=Frtw6630+;");
            this.con = new MySqlConnection("Server=localhost;Database=projetfinsession;Uid=root;Pwd=root;");
            listePret = new ObservableCollection<Pret>();
            listePretVue = new ObservableCollection<DetailpretVue>();
            listeClient = new ObservableCollection<Client>();
            listeMateriel = new ObservableCollection<Materiel>();
            listeUtilisateur = new ObservableCollection<Utilisateur>();

            getPretVue();
            getMateriel();
            getClient();
            getUtilisateur();
            getListPretVue();
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
                    listePret.Add(new Pret(r.GetInt32(0), r.GetInt32(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetInt32(5), r.GetInt32(6)));
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

        public ObservableCollection<DetailpretVue> getPretVue()
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                //commande.CommandText = "SELECT * FROM v_pret";
                commande.CommandText = "SELECT * FROM detailspretvue";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    listePretVue.Add(new DetailpretVue(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetInt32(4), r.GetInt32(5), r.GetInt32(6), r.GetInt32(7), r.GetString(8)));
                }
                r.Close();
                con.Close();

                return listePretVue;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return listePretVue;
            }
        }
        public ObservableCollection<Pret> getListPret()
        {
            return listePret;
        }

        public ObservableCollection<DetailpretVue> getListPretVue()
        {
            return listePretVue;
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

        public ObservableCollection<Materiel> getListMateriel()
        {
            return listeMateriel;
        }

        public ObservableCollection<Materiel> getMaterielPret()
        {

            try
            {
                MySqlCommand commande = new MySqlCommand("p_materiel_pret");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    listeMaterielPret.Add(new DetailpretVue(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetInt32(4), r.GetInt32(5), r.GetInt32(6), r.GetInt32(7), r.GetString(8)));
                }
                r.Close();
                con.Close();

                return listeMaterielPret;
            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return listeMaterielPret;
            }

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

        public int AjouterPret(Pret p, ObservableCollection<Materiel> m)
        {
            int retour = 0;

            MySqlCommand commande = new MySqlCommand("p_ajout_pret");           //   PAAAAAAAAAAAAAAATTTTT
            commande.Connection = con;                                          //      
            commande.CommandType = System.Data.CommandType.StoredProcedure;     //      |
                                                                                //      |
            commande.Parameters.AddWithValue("idClient", p.Id_Client);          //      |
            commande.Parameters.AddWithValue("date", p.DatePret);               //     \|/
            commande.Parameters.AddWithValue("heure", p.HeurePret);             //      V
            commande.Parameters.AddWithValue("dateRetour", p.DateRetour); //CALCULER EN BEFORE INSERT DANS LA BD
            commande.Parameters.AddWithValue("idUtilisateur", idUser);  
            commande.Parameters.AddWithValue("etatPret", 1);

            con.Open();
            commande.Prepare();
            
            MySqlDataReader r = commande.ExecuteReader();
            r.Read();
            int id = r.GetInt32(0);

            r.Close();

            foreach(Materiel item in m)
            {
                MySqlCommand commande2 = new MySqlCommand("p_ajout_detailspret");
                commande2.Connection = con;
                commande2.CommandType = System.Data.CommandType.StoredProcedure;

                commande2.Parameters.AddWithValue("idPret", id);
                commande2.Parameters.AddWithValue("idMateriel", item.Identifiant);
                commande2.Parameters.AddWithValue("etatLocation", 1);
                commande2.Parameters.AddWithValue("idUtilisateur", idUser);

                commande2.ExecuteNonQuery();
            }

            con.Close();

            listePret.Add(p);

            return retour;
        }

        public int getId()
        {
            return idUser;
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
            commande.CommandText = "DELETE FROM pret WHERE id = " + c.Id_Pret;

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

            commande.Parameters.AddWithValue("@idPret", c.Id_Pret);
            commande.Parameters.AddWithValue("@client", c.Id_Client);
            commande.Parameters.AddWithValue("@date", c.DatePret);
            commande.Parameters.AddWithValue("@heure", c.HeurePret);
            commande.Parameters.AddWithValue("@dateRetour", c.DateRetour);
            commande.Parameters.AddWithValue("@usager", c.Id_Utilisateur);
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

        public int login(string username, string password)
        {
            int check = 0;
            string nom = "";
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select * from utilisateur WHERE username = @username AND password = @password";
            commande.Parameters.AddWithValue("@username", username);
            commande.Parameters.AddWithValue("@password", password);
            con.Open();
            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();
            while (r.Read())
            {
                check = 1;
                nom = r.GetString(3);
                idUser = r.GetInt32(0);
            }
            r.Close();
            con.Close();
            if (check == 1)
            {
                logged = 1;
                usernameLogged = nom;
                return check;
            }
            else
            {
                logged = 0;
                usernameLogged = "";
                return check;
            }

        }

        public int logout() 
        {
            logged = 0;
            usernameLogged = "";
            idUser = 0;
            return logged;
        }

        public string getUsername()
        {
            return usernameLogged;
        }
    }
}

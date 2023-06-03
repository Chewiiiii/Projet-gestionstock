using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_ORM
{
    class Famille
    {
        public List<Produit> produits { get; set; }
        public string codeFamille { get; set; }
        public string nomFamille { get; set; }
        public String alleeStockage { get; set; }

        public Famille() { }

        public Famille(string code, string nom, string allee)
        {
            this.codeFamille = code;
            this.nomFamille = nom;
            this.alleeStockage = allee;
            this.produits = new List<Produit>();
        }

        public void createFamille()
        {
            MySqlConnection conn = bdconnexion.ConnectionBD();
            conn.Open();
            string sql = "INSERT INTO famille Values(@code, @nom, @allee)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@code", this.codeFamille);
            cmd.Parameters.AddWithValue("@nom", this.nomFamille);
            cmd.Parameters.AddWithValue("@allee", this.alleeStockage);
            cmd.ExecuteNonQuery();
        }


        public void findOneFamille(string code)
        {
            MySqlConnection conn = bdconnexion.ConnectionBD();
            conn.Open();
            string sql = "SELECT * FROM famille WHERE codeFamille= @code";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //lecture de l'enregistrement : reader.Read();
            //on récupère l'enregistrement : reader.GetString("maColonne");


            cmd.Parameters.AddWithValue("@code", this.codeFamille);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.codeFamille = reader.GetString("codeFamille");
            this.nomFamille = reader.GetString("nomFamille");
            this.alleeStockage = reader.GetString("alleStockage");
        }


        public List<Famille> findAllFamille() 
        {

            List<Famille> familles = new List<Famille>();
            MySqlConnection conn = bdconnexion.ConnectionBD();
            conn.Open();
            string sql = "SELECT * FROM famille";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Famille uneFamille = new Famille(reader.GetString("codeFamille"), reader.GetString("nomFamille"), reader.GetString("alleStockage"));
                familles.Add(uneFamille);
            }
            return familles;
        
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            ...
        }


    }


}

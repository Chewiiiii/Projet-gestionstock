using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_ORM
{
    class Produit
    {
        public string refProduit { get; set; }
        public string designationProduit { get; set; }
        public float prixProduit { get; set; }
        public Famille laFamille;

        public Produit() { }

        public Produit(string refp, string design, float prix, Famille famille)
        {
            this.refProduit = refp;
            this.prixProduit = prix;
            this.designationProduit = design;
            this.laFamille = famille;

        }

        public void createProduit()
        {
            MySqlConnection conn = bdconnexion.ConnectionBD();
            conn.Open();
            string sql = "INSERT INTO famille Values(@refp, @prix, @design, @famille)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@refp", this.refProduit);
            cmd.Parameters.AddWithValue("@prix", this.prixProduit);
            cmd.Parameters.AddWithValue("@design", this.designationProduit);
            cmd.Parameters.AddWithValue("@famille", this.laFamille);
            cmd.ExecuteNonQuery();
        }


        public List<Produit> findAllProduit()
        {
            List<Produit> produits = new List<Produit>();
            MySqlConnection conn = bdconnexion.ConnectionBD();
            conn.Open();
            string sql = "SELECT * FROM produit";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Famille find = new Famille();
                find.findOneFamille(reader.GetString("codeFamille"));
                Produit unProduit = new Produit(reader.GetString("refProduit"), reader.GetString("designationProduit"), reader.GetFloat("prixProduit"), find);
                produits.Add(unProduit);
            }
            return produits;
        }


        public void findOneProduit(string refp)
        {
            MySqlConnection conn = bdconnexion.ConnectionBD();
            conn.Open();
            string sql = "SELECT * FROM produit WHERE refProduit= @refp";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@refp", this.refProduit);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            
            Famille find = new Famille();
            find.findOneFamille(reader.GetString("codeFamille"));

            this.refProduit = reader.GetString("refProduit");
            this.designationProduit = reader.GetString("designationProduit");
            this.prixProduit = reader.GetFloat("prixProduit");
            this.laFamille = find;
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            ...
        }

        
    }



}

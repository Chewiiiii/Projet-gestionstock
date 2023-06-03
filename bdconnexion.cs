using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_ORM
{
    class bdconnexion
    {
        public static MySqlConnection ConnectionBD()
        {
            // Création de la chaîne de connexion
            string connString = "SERVER=localhost; DATABASE=orm; UID=root; PASSWORD=root";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibProject
{
    internal class ProjectDataBase
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource:localhost;port:3306;username=root;password=;database=gestionlib";
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.Open();
            } catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibProject
{
    internal class User
    {
        private string nom { get; set; }
        private string prenom { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        public User(string nom, string prenom, string username, string password)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.username = username;
            this.password = password;
        }
    }
}

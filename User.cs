using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpn
{
    internal class User
    {
        private int id;
        private string email, password;

        public int Id { get { return id; } set { id = value; } }

        public string Email { get { return email; } set { email = value; } }

        public string Password { get { return password; } set { password = value; } }

        public User() { }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}

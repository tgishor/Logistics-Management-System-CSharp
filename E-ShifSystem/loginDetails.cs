using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ShifSystem
{
    internal class loginDetails
    {
        private string id;

        private string username;
        private string name { get; set; }

        public loginDetails(string _id, string _name, string _username)
        {
            this.id = _id;
            this.name = _name;
            this.username = _username;
        }

        public string getUsername
        {
            get
            {
                return username;
            }

        }

        public string getID
        {
            get
            {
                return id;
            }
        }

        public string getName
        {
            get
            {
                return name;
            }
        }

    }
}

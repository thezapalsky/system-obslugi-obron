using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    public abstract class User
    {
        string _name;
        string _surname;
        string _email_external;
        string _id;
        string _email_university;
        string _password;

        //do uzupelnienia w zakladce "twoje dane" z makiety
        DateTime birthdate;
        string pesel;
        string phone_number;
        //tba jakies inty by sie przydaly, gettery i settery


        public User(string name, string surname, string email_external, string id, string email_university, string password)
        {
            _name = name;
            _surname = surname;
            _email_external = email_external;
            _id = id;
            _email_university = email_university;
            _password = password;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Email_external { get => _email_external; set => _email_external = value; }
        public string Id { get => _id; set => _id = value; }
        public string Email_university { get => _email_university; set => _email_university = value; }
        public string Password {  set => _password = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    public class Professor : User, IObserver
    {
        //professor otrzymuje powiadomienie, gdy student poprosi o zatwierdzenie tematu pracy dyplomowej

        public Professor(string name, string surname, string email_external, string id, string email_university, string password) : base(name, surname, email_external, id, email_university, password)
        {
        }

        public void Update(ThesisProposal thesisProposal)
        {
            string topic = thesisProposal.Topic;

            Console.WriteLine("(!) Powiadomienie dla {0} {1}, {2}: ", this.Name,this.Surname,this.Email_university);
            Console.WriteLine("Przypisano ci nową pracę o temacie: {0} \n",topic);
        }
    }
}

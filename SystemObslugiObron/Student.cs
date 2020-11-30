using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    public class Student : User
    {
        public Student(string name, string surname, string email_external, string id, string email_university, string password) : base(name, surname, email_external, id, email_university, password)
        {
        }

        public ThesisProposal MakeThesisProposal(ThesisProposal.Depertment department, Professor professor, string topic)
        {
            Console.WriteLine("-- {0} wysłał propzycje do {1} o temacie '{2}'--\n",this.Email_university,professor.Email_university,topic);
            ThesisProposal t = new ThesisProposal(department, professor, topic, this);
            return t;
        }
    }
}

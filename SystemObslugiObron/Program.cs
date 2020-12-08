using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
            //Professor p1 = new Professor("Ambroży","Kleks","akleks@gmail.com","123456","akleks@agh.edu.pl","hash123");

            //ThesisProposal p = s1.MakeThesisProposal(0, p1, "Analiza transportu publicznego w okresie świątecznym bla bla...");


            //s1.SetBirthDate(1, 12, 1989);
            //Console.WriteLine(s1.Birthdate);

            User p1 = Registration.Register("Adam", "Małysz", "amalysz@agh.edu.pl", true);

            Console.WriteLine("hello " + p1.Email_university + "!" );
            Console.WriteLine("you are " + p1.GetType());
            //Console.WriteLine("department:  " + p.Department + " topic: " + p.Topic);
            Console.ReadKey();
        }
    }
}

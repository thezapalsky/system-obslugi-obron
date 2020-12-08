using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    //ta klasa jest malo profesionala ale byla robiona na szybkosci pod testy
    public static class Registration
    {
        public static User Register(string name, string surname, string email, bool isProfessor)
        {
            string pass = "losowogenerowanehasloktorepowinnobychashem";
            string id_number = "123456"; //numer indeksu polaczony z kontem w domenie @agh.edu.pl (np. pobierany z bazy)
            string external_mail = "amalysz@gmail.com"; //nwm w sumie czemu tego nie ma w makiecie w rejestracji 

            if (isProfessor)
            {
                string domain = email.Split('@').Last();

                if(domain == "student.agh.edu.pl")
                {
                    //Console.WriteLine("nice try");
                    return new Student(name, surname, external_mail, id_number, email, pass);
                }
                else
                {
                    return new Professor(name, surname, external_mail, id_number, email, pass);
                }

            }
            else
            {
                return new Student(name, surname, external_mail, id_number, email, pass);
            }
        }
    }
}

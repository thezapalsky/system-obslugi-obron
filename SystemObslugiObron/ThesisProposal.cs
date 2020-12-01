using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    public class ThesisProposal : Subject
    {
        //depertment powinno byc inna klasa, ale dla uproszczenia przedstawimy ja w taki sposob
        public enum Depertment
        {
         Informatyki_Stosowanej,
         Zarzadzania_Przedsiebiorstwem,
         Ekonomii_Finansow_i_zarzadzania_srodowiskiem,
         Matematyki
        }

        Depertment _department;
        Professor _promoter;
        string _topic;
        Student _student;

        public Depertment Department { get => _department; set => _department = value; }
        public Professor Promotor { get => _promoter; set => _promoter = value; }
        public string Topic { get => _topic; set => _topic = value; }

        public ThesisProposal(Depertment department, Professor promoter, string topic, Student student)
        {
            _department = department;
            _promoter = promoter;
            _topic = topic;
            _student = student;

            if (topic == null) { throw new ArgumentNullException("null"); }
            else if (topic.Trim() == "") { throw new ArgumentException("empty string"); }

            //nie wiem do konca czy do jest dobre wykorzystanie tego wzorca
            this.Attach(promoter);
            Notify();
        }

        protected override void Notify()
        {
            foreach (IObserver observer in this._observerList)
            {
                observer.Update(this);
                //observer.Update(this._director, this._title, this._status);
            }
        }
    }
}

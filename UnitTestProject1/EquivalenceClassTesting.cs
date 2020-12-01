using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemObslugiObron;

namespace UnitTestProject1
{
    [TestClass]
    public class EquivalenceClassTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
            Professor p1 = new Professor("Ambroży", "Kleks", "akleks@gmail.com", "123456", "akleks@agh.edu.pl", "hash123");

            ThesisProposal p = s1.MakeThesisProposal(0, p1, "Analiza transportu publicznego w okresie świątecznym bla bla...");

        }

        [TestMethod]
        [DataRow("Analiza transportu publicznego w okresie świątecznym bla bla...")]
        [DataRow(" ")]
        [DataRow(42)] //int ma nie przechodzic i tak jest
        public void TestTopic(string topic)
        {
            {
                Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
                Professor p1 = new Professor("Ambroży", "Kleks", "akleks@gmail.com", "123456", "akleks@agh.edu.pl", "hash123");

                ThesisProposal p = s1.MakeThesisProposal(0, p1, topic);

            }


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTopicNullException()
        {
            {
                Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
                Professor p1 = new Professor("Ambroży", "Kleks", "akleks@gmail.com", "123456", "akleks@agh.edu.pl", "hash123");


                ThesisProposal p = s1.MakeThesisProposal(0, p1, null);

            }


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTopicEmptyStringException()
        {
            {
                Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
                Professor p1 = new Professor("Ambroży", "Kleks", "akleks@gmail.com", "123456", "akleks@agh.edu.pl", "hash123");


                ThesisProposal p = s1.MakeThesisProposal(0, p1, "");

            }


        }

        /*[TestMethod]
        [DataRow(null,1)]
        [DataRow(1,1)]
        [DataRow(-1,1)]
        [DataRow(5,1)]
        public void TestDepartment(ThesisProposal.Depertment d, ThesisProposal.Depertment actual)
        {
            //dziedzina depertment [0-4]

            Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
            Professor p1 = new Professor("Ambroży", "Kleks", "akleks@gmail.com", "123456", "akleks@agh.edu.pl", "hash123");

            //ThesisProposal actual = s1.MakeThesisProposal(0, p1, "Analiza...");
            ThesisProposal p = s1.MakeThesisProposal(d, p1, "Analiza...");

            //Assert.AreEqual(p.Department, actual);
            Assert.IsNotNull(p.Department);

        }*/
    }
}

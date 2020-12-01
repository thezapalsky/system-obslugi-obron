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


    }
}

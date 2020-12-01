using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemObslugiObron;

namespace UnitTestProject1
{
    [TestClass]
    public class BoundaryConditionsTesting
    {
        //nie wiem czy testy brzegowe na sie zrobic na stringach (A-Z ?) wiec przetestujemy na innym fragmencie
        [DataRow(1,1,1990)]
        [DataRow(31, 1, 1990)]
        [DataRow(1, 12, 1990)]
        [DataRow(1, 1, 1)]
        [TestMethod]
        public void TestBirthDate(int d, int m, int y)
        {
            Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
            s1.SetBirthDate(d, m, y);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-1, 1, 1990)]
        [DataRow(0, 1, 1990)]
        [DataRow(32, 1, 1990)]
        [DataRow(30, 2, 1990)]
        [DataRow(1, 13, 1990)]
        [DataRow(1, 1, -1)]
        [DataRow(1, 1, 0)]
        public void TestBirthDateException(int d, int m, int y)
        {
            Student s1 = new Student("Adam", "Małysz", "amalysz@gmail.com", "654321", "amalysz@student.agh.edu.pl", "hash123");
            s1.SetBirthDate(d, m, y);
        }
    }
}

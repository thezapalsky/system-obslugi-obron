using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SystemObslugiObron;

namespace UnitTestProject1
{
    [TestClass]
    public class MockTesting
    {
        // 67 linia w ThesisProposal.IsTopicCorrect() - odkomentować
        [TestMethod]
        public void WasTopicTestedOnce()
        {
            var mock = new Mock<IValidator>();
            var TestClass = new ThesisProposal(mock.Object);

            bool actual = TestClass.IsTopicCorrect("Analiza wielowymiarowa.");
            mock.Verify(x => x.IsTopicCorrect("Analiza wielowymiarowa."), Times.Once);

        }

        [TestMethod]
        public void IsTopicCorrect()
        {
            var mock = new Mock<IValidator>();
            mock.Setup(x => x.IsTopicCorrect("Analiza wielowymiarowa")).Returns(true);

            var TestClass = new ThesisProposal(mock.Object);

            bool actual = TestClass.IsTopicCorrect("Analiza wielowymiarowa");

            var expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ForbiddenWordInTopic()
        {
            var mock = new Mock<IValidator>();

            var TestClass = new ThesisProposal(mock.Object);

            bool actual = TestClass.IsTopicCorrect("Analiza matematyka wielowymiarowa");

            var expected = false;

            Assert.AreEqual(expected, actual);

        }


    }
}

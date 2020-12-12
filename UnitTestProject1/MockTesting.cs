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



    }
}

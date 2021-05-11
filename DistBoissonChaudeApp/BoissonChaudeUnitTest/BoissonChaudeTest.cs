using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistBoissonChaude;

namespace BoissonChaudeUnitTest
{
    [TestClass]
    public class BoissonChaudeTest
    {
        [TestMethod]
        public void Prix_Expresso_Test()
        {
            BoissonChaude boissonChaude = new BoissonChaude();
            Assert.AreEqual("1,56", boissonChaude.prix(eBoissonChaude.Expresso));
        }

        [TestMethod]
        public void Prix_Allonge_Test()
        {
            BoissonChaude boissonChaude = new BoissonChaude();
            Assert.AreEqual("1,82", boissonChaude.prix(eBoissonChaude.Allonge));
        }

        [TestMethod]
        public void Prix_Capucino_Test()
        {
            BoissonChaude boissonChaude = new BoissonChaude();
            Assert.AreEqual("3,51", boissonChaude.prix(eBoissonChaude.Capucino));
        }

        [TestMethod]
        public void Prix_Chocolat_Test()
        {
            BoissonChaude boissonChaude = new BoissonChaude();
            Assert.AreEqual("5,33", boissonChaude.prix(eBoissonChaude.Chocolat));
        }

        [TestMethod]
        public void Prix_The_Test()
        {
            BoissonChaude boissonChaude = new BoissonChaude();
            Assert.AreEqual("1,82", boissonChaude.prix(eBoissonChaude.The));
        }
    }
}

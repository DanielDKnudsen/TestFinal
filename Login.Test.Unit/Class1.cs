using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LogikLayer;
using NUnit.Framework;
using  DTO;

namespace Login.Test.Unit
{
    [TestFixture]
    public class LoginUnitTest
    {
        private Logind li;
        private Logind li2;
        private DTO.LogindDTO test;
        private DTO.LogindDTO test2;


        [SetUp]
        public void SetUp()
        {
            li = new Logind();
            test = new LogindDTO();
            test.Brugernavn = "123";
            test.Kodeord = "123";
            test.IsSundhed = true;

            li2 = new Logind();
            test2 = new LogindDTO();
            test2.Brugernavn = "456";
            test2.Kodeord = "456";
            test2.IsSundhed = false;

        }
        [Test]
        public void logintrue()
        {
            Assert.That(test.Brugernavn, Is.EqualTo("123"));
            Assert.That(test.Kodeord,Is.EqualTo("123"));
            Assert.That(test.IsSundhed,Is.EqualTo(true));
            Assert.That(li.CheckValues(test),Is.EqualTo(1));
        }
        [Test]
        public void logintruemed()
        {
            Assert.That(test2.Brugernavn, Is.EqualTo("456"));
            Assert.That(test2.Kodeord, Is.EqualTo("456"));
            Assert.That(test2.IsSundhed, Is.EqualTo(false));
            Assert.That(li2.CheckValues(test2),Is.EqualTo(2));
        }
    }
}

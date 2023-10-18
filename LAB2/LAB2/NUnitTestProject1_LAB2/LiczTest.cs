using System;
using System.Collections.Generic;
using System.Text;
using Biblioteka_LAB2;
using NUnit.Framework;

namespace NUnitTestProject1_LAB2
{
    class LiczTest
    {
        private Licz licz;
        [SetUp]
        public void Setup()
        {
            licz = new Licz();
        }

        [Test]
        public void ShouldCreateObject()
        {
            Assert.NotNull(licz);
        }

        [Test]
        public void Dodaj_Test()
        {
            licz.Dodaj(5);
            Assert.AreEqual(5, licz.Value);
        }
    }
}

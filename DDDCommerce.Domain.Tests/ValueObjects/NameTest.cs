using System;
using DDDEvents.Domain.Events.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDEvents.Domain.Tests.ValueObjects
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void DeveRetornarErroQuandoFirstNameVazioOuNulo()
        {
            var name = new Name("", "asd");
            Assert.IsTrue(name.Valid);
        }
    }
}

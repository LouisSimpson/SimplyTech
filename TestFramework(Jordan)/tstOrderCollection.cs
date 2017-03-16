using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramework_Jordan_
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }
    }
}

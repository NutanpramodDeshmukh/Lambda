using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = $"Name:Nutan,Email:nutanm@gmail.com,PhoneNumber:91 7028944456,Password:Passwpord";
            Program p = new Program();
            var res = p.patterncheck("Nutan", "nutanm@gmail.com", "91 7028944456", "Passwpord");
            Assert.AreEqual(expected, res);
        }
    }
}

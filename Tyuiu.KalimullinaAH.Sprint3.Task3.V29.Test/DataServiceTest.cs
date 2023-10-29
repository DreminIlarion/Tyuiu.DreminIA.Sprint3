using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIA.Sprint3.Task3.V29.Lib;
namespace Tyuiu.DreminIA.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInStringthod()
        {
            DataService ds = new DataService();
            string value = "chgr vhhtg hhht";
            char chr = 'h';
            string res = ds.DeleteCharInString(value, chr);
            string wait = "cgr vtg t";
            Assert.AreEqual(wait, res);
        }
    }
}

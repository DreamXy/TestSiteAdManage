using System;
using System.Linq;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impl.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var txc = new Entities())
            {
                var query = txc.SalaryAccounts.Select(n => n).ToList();
                var ss = query;//1
                foreach (var item in query)  
                {     
                    Console.WriteLine(item.account_name);
                }
            }
        }
    }
}

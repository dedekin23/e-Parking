using Microsoft.VisualStudio.TestTools.UnitTesting;
using TubesKPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL.Tests
{
    [TestClass()]
    public class PaymentTests
    {
        [TestMethod()]
        public void PaymentTest()
        {
            var test = new UserTableDriven();
        }

        internal class getPayment
        {
            private object althoof;

            public getPayment(object althoof)
            {
                this.althoof = althoof;
            }
        }
    }
}
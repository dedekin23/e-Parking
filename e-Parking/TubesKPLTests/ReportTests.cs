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
    public class ReportTests
    {
        [TestMethod()]
        public void ReportTest()
        {
            var test = new UserTableDriven();
        }

        internal class getReport
        {
            private object michael;

            public getReport(object michael)
            {
                this.michael = michael;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDAL;
using NUnit.Framework;

namespace CustomerDAL.Tests
{
    [TestFixture]
    public class LoggerTest
    {
        ValidateUsers v = null;
        public LoggerTest()
        {
            v = new ValidateUsers();
        }

        [TestCase(1,"Hello@123456",ExpectedResult = true)]
        [TestCase(2, "Hello@123123", ExpectedResult = false)]
        public bool ValidateUsers(int id, string password)
        {
            return v.ValidateUser(id, password);
        }

        [TestCase(1, ExpectedResult = true)]
        [TestCase("a", ExpectedResult = false)]
        public bool InsertLogID(int logid)
        {
            CustLogInfo c = new CustLogInfo();
            c.LogID = logid;
            return v.Insert(c);
        }
    }
}

using System;
using AboutNet;
using AboutNetClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AboutNetUnitTest
{
    [TestClass]
    public class UserTests
    {
        private readonly Client _client = new Client("");

        [TestMethod]
        public void GetResult()
        {
            var result = _client
                .GetResult("https://api.about.me/api/v2/json/user/register/pc");
            Console.WriteLine(result);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetData()
        {
            var result = _client
                .AsyncGetData<User.View>("https://api.about.me/api/v2/json/user/view/thomas.barthelemy")
                .Result;

            Assert.IsInstanceOfType(result, typeof(User.View));
            Assert.IsTrue(result.Status > 0);
        }
    }
}
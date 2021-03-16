using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectTestExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {
        People people = new People("Change", "123654", "Changeling_dx@mail.ru", 79992647826);

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("Change", people.Login);

        }
        [TestMethod]
        public void GetEmailTest()
        {
            Assert.AreEqual("Changeling_dx@mail.ru", people.Email);

        }

        [TestMethod]
        public void GetPhoneTest()
        {
            Assert.AreEqual(79992647826, people.Phone);

        }
        [TestMethod]
        public void GetPassTest()
        {
            Assert.AreEqual("123654", people.Pass);

        }
    }
}

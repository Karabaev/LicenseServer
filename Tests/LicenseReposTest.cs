using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Repository;
using Model.Entity.Base;
namespace Tests
{
    [TestClass]
    public class LicenseReposTest
    {
        private LicenseRepository repos;
        public LicenseReposTest()
        {
            repos = new LicenseRepository();
        }
        [TestMethod]
        public void Add()
        {
            Assert.IsTrue(repos.Add(new License { LicenseCode = "1234", LicenseTypeID = 1, TerminationTime = null }));
        }
    }
}

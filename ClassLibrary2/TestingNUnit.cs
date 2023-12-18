using NUnit.Framework;
using DataAccessLayer;
using NUnit.Framework.Legacy;
using System;
using System.Security.Policy;

namespace BlogLibrary
{
    [TestFixture]
    public class TestingUsingNUnit
    {

        [Test]
        public void checkEmployeeExistWithNunit()
        {
            var obj = new EmpInfoRepository();
            var res = obj.GetEmpInfo("aadhya@gmail.com");
            Assert.That(res, Is.Not.Null);
        }
        [Test]
        public void checkEmployeeCreateWithNunit()
        {
            EmpInfo emp = new EmpInfo
            {
                Name = "ABC",
                EmailId = "As@gmail.com",
                PassCode = 234231,
                DateOfJoining = DateTime.Now,
            };
            var obj = new BlogDbContext();
            EmpInfo res = obj.EmpInfo.Add(emp);
            obj.SaveChanges();
            ClassicAssert.AreEqual(emp.Name, res.Name);
            ClassicAssert.AreEqual(emp.EmailId, res.EmailId);
        }
    }
}
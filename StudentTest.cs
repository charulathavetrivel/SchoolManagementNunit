using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementNunit
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void StudentIdShouldBeSet()
        {
            var student = new Student { Id = 1, Name = "Sailu" };
            Assert.That(student.Id, Is.EqualTo(1));
        }
    }
}

using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementNunit
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void TeacherIdShouldBeSet()
        {
            var teacher = new Teacher { Id = 1, Name = "Charu" };
            Assert.That(teacher.Id, Is.EqualTo(1));
        }
    }
}

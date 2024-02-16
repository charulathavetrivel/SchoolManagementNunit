using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementNunit
{
    [TestFixture]
    public class SubjectTest
    {
        [Test]
        public void SubjectIdShouldBeSet()
        {
            var subject = new Subject { Id = 1, Name = "Math" };
            Assert.That(subject.Id, Is.EqualTo(1));
        }
    }
}

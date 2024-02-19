using PracticePro1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPro1Test
{
    [TestFixture]
    public class TeachTest
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherId = 104;
            teacher.Name = "Mrs. Lakshmi";

            // Act & Assert
            Assert.AreEqual(104, teacher.TeacherId);
            Assert.AreEqual("Mrs. Lakshmi", teacher.Name);
        }
    }
}
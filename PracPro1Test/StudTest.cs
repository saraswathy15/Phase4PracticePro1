using PracticePro1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPro1Test
{
    [TestFixture]
    public class StudTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.SName = "Varshithaa";

            // Act
            string studentName = student.SName;

            // Assert
            Assert.AreEqual("Varshithaa", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "10 Nehru Street";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("10 Nehru Street", studentAddress);
        }
    }
}


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tandem.Model;

namespace Tandem.Tests
{
    /// <summary>
    /// Tests the FirstName
    /// </summary>
    [TestClass]
    public class StudentUnitTest1
    {
        [TestMethod]
        public void setFirstName()
        {
            Student student = new Student();
            student.studentFirstName = "Erika";
            Assert.AreEqual("Erika",student.studentFirstName);
        }

        /// <summary>
        /// Tests LastName
        /// </summary>
        [TestMethod]
        public void setLastName()
        {
            Student student = new Student();
            student.studentLastName = "Secillano";
            Assert.AreEqual("Secillano", student.studentLastName);
        }

        /// <summary>
        /// Tests Email
        /// </summary>
        [TestMethod]
        public void setEmail()
        {
            Student student = new Student();
            student.studentEmail = "Erika@email.com";
            Assert.AreEqual("Erika@email.com", student.studentEmail);
        }

        /// <summary>
        /// Tests Mother tongue
        /// </summary>
        [TestMethod]
        public void setMotherTongue()
        {
            Student student = new Student();
            student.studentMotherTongue = "English";
            Assert.AreEqual("English", student.studentMotherTongue);
        }

        /// <summary>
        /// Tests Language Wanted
        /// </summary>
        [TestMethod]
        public void setLanguageWanted()
        {
            Student student = new Student();
            student.studentLanguageWanted = "German";
            Assert.AreEqual("German", student.studentLanguageWanted);
        }

        /// <summary>
        /// Tests All 
        /// </summary>
        [TestMethod]
        public void AllImplementations()
        {
            Student student = new Student();
            student.studentFirstName = "Erika";
            student.studentLastName = "Secillano";
            student.studentEmail = "Erika@email.com";
            student.studentMotherTongue = "English";
            student.studentLanguageWanted = "German";
            Assert.AreEqual("Erika", student.studentFirstName);
            Assert.AreEqual("Secillano", student.studentLastName);
            Assert.AreEqual("Erika@email.com", student.studentEmail);
            Assert.AreEqual("English", student.studentMotherTongue);
            Assert.AreEqual("German", student.studentLanguageWanted);
        }
    }
}

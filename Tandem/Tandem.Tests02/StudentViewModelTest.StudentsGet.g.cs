using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using Tandem.Model;
using Tandem.ViewModel;
// <copyright file="StudentViewModelTest.StudentsGet.g.cs">Copyright ©  2017</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Tandem.ViewModel.Tests
{
    public partial class StudentViewModelTest
    {

        [TestMethod]
        public void StudentsGet925()
        {
            StudentViewModel studentViewModel;
            ObservableCollection<Student> observableCollection;
            studentViewModel = new StudentViewModel();
            observableCollection = this.StudentsGet(studentViewModel);
            Assert.IsNotNull((object)observableCollection);
            Assert.IsNotNull((object)studentViewModel);
            Assert.IsNotNull(studentViewModel.Student);
            Assert.AreEqual<string>((string)null, studentViewModel.Student.studentFirstName);
            Assert.AreEqual<string>((string)null, studentViewModel.Student.studentLastName);
            Assert.AreEqual<string>((string)null, studentViewModel.Student.studentEmail);
            Assert.AreEqual<string>
                ((string)null, studentViewModel.Student.studentMotherTongue);
            Assert.AreEqual<string>
                ((string)null, studentViewModel.Student.studentLanguageWanted);
            Assert.IsNotNull(studentViewModel.Students);
            Assert.IsTrue(object.ReferenceEquals
                              (studentViewModel.Students, (object)observableCollection));
        }

[TestMethod]
[PexGeneratedBy(typeof(StudentViewModelTest))]
public void StudentsGet92501()
{
    StudentViewModel studentViewModel;
    ObservableCollection<Student> observableCollection;
    studentViewModel = new StudentViewModel();
    observableCollection = this.StudentsGet(studentViewModel);
    Assert.IsNotNull((object)observableCollection);
    Assert.IsNotNull((object)studentViewModel);
    Assert.IsNotNull(studentViewModel.Student);
    Assert.AreEqual<string>((string)null, studentViewModel.Student.studentFirstName);
    Assert.AreEqual<string>((string)null, studentViewModel.Student.studentLastName);
    Assert.AreEqual<string>((string)null, studentViewModel.Student.studentEmail);
    Assert.AreEqual<string>
        ((string)null, studentViewModel.Student.studentMotherTongue);
    Assert.AreEqual<string>
        ((string)null, studentViewModel.Student.studentLanguageWanted);
    Assert.IsNotNull(studentViewModel.Students);
    Assert.IsTrue(object.ReferenceEquals
                      (studentViewModel.Students, (object)observableCollection));
}
    }
}

using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tandem.Model;
using Tandem.ViewModel;
// <copyright file="StudentViewModelTest.StudentSet.g.cs">Copyright ©  2017</copyright>
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
        public void StudentSet275()
        {
            StudentViewModel studentViewModel;
            studentViewModel = new StudentViewModel();
            this.StudentSet(studentViewModel, (Student)null);
            Assert.IsNotNull((object)studentViewModel);
            Assert.IsNull(studentViewModel.Student);
            Assert.IsNotNull(studentViewModel.Students);
        }

[TestMethod]
[PexGeneratedBy(typeof(StudentViewModelTest))]
public void StudentSet27501()
{
    StudentViewModel studentViewModel;
    studentViewModel = new StudentViewModel();
    this.StudentSet(studentViewModel, (Student)null);
    Assert.IsNotNull((object)studentViewModel);
    Assert.IsNull(studentViewModel.Student);
    Assert.IsNotNull(studentViewModel.Students);
}
    }
}

using System.Collections.ObjectModel;
using Tandem.Model;
using System.Windows.Input;
// <copyright file="StudentViewModelTest.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tandem.ViewModel;

namespace Tandem.ViewModel.Tests
{
    [TestClass]
    [PexClass(typeof(StudentViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StudentViewModelTest
    {

        [PexMethod]
        public ICommand SubmitButtonGet([PexAssumeUnderTest]StudentViewModel target)
        {
            ICommand result = target.SubmitButton;
            return result;
            // TODO: add assertions to method StudentViewModelTest.SubmitButtonGet(StudentViewModel)
        }

        [PexMethod]
        public StudentViewModel Constructor()
        {
            StudentViewModel target = new StudentViewModel();
            return target;
            // TODO: add assertions to method StudentViewModelTest.Constructor()
        }

        [PexMethod]
        public Student StudentGet([PexAssumeUnderTest]StudentViewModel target)
        {
            Student result = target.Student;
            return result;
            // TODO: add assertions to method StudentViewModelTest.StudentGet(StudentViewModel)
        }

        [PexMethod]
        public void StudentSet([PexAssumeUnderTest]StudentViewModel target, Student value)
        {
            target.Student = value;
            // TODO: add assertions to method StudentViewModelTest.StudentSet(StudentViewModel, Student)
        }

        [PexMethod]
        public ObservableCollection<Student> StudentsGet([PexAssumeUnderTest]StudentViewModel target)
        {
            ObservableCollection<Student> result = target.Students;
            return result;
            // TODO: add assertions to method StudentViewModelTest.StudentsGet(StudentViewModel)
        }

        [PexMethod]
        public void StudentsSet([PexAssumeUnderTest]StudentViewModel target, ObservableCollection<Student> value)
        {
            target.Students = value;
            // TODO: add assertions to method StudentViewModelTest.StudentsSet(StudentViewModel, ObservableCollection`1<Student>)
        }
    }
}

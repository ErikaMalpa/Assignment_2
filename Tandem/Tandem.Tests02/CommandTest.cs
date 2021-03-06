// <copyright file="CommandTest.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tandem;

namespace Tandem.Tests
{
    [TestClass]
    [PexClass(typeof(Command))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CommandTest
    {

        [PexMethod]
        public Command Constructor(
            Action<object> executeMethod,
            Func<object, bool> canExecuteMethod,
            bool button
        )
        {
            Command target = new Command(executeMethod, canExecuteMethod, button);
            return target;
            // TODO: add assertions to method CommandTest.Constructor(Action`1<Object>, Func`2<Object,Boolean>, Boolean)
        }

        [PexMethod]
        public bool CanExecute([PexAssumeUnderTest]Command target, object parameter)
        {
            bool result = target.CanExecute(parameter);
            return result;
            // TODO: add assertions to method CommandTest.CanExecute(Command, Object)
        }
    }
}

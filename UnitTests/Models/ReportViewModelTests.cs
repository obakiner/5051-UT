using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new LogViewModel();

            // Assert 
            Assert.IsNotNull(result);
        }

        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            // Act
            var result = myTest.NumberOfUsers;

            // Assert 
            Assert.IsNotNull(result);
        }

        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            int number = 55;
            
            // Act
            myTest.NumberOfUsers = number;
            //var result = myTest.LogList;

            // Assert 
            Assert.AreEqual(55, myTest.NumberOfUsers);
        }

    }
}



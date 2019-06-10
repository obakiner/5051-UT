using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new LogViewModel();

            // Assert 
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            // Act
            var result = myTest.NumberOfUsers;

            // Assert 
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            int number = 55;
            
            // Act
            myTest.NumberOfUsers = number;

            // Assert 
            Assert.AreEqual(55, myTest.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            // Act
            var result = myTest.LogViewModel;

            // Assert 
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            var model = new LogViewModel();
            var newLogModel = new List<LogModel>();
            newLogModel.Add(new LogModel{ ID = "something" });
            model.LogList = newLogModel;

            // Act
            myTest.LogViewModel = model;
            var result = myTest.LogViewModel; 

            // Assert 
            Assert.AreEqual("something", result.LogList[0].ID);
        }

    }
}



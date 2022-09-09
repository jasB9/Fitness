using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness.BL.Model;

namespace Fitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Arrage
            string userName = Guid.NewGuid().ToString();

            DateTime birthDay = DateTime.Now.AddYears(-18);

            double weight = 75;
            double height = 175;
            string gender = "man";
            UserController controller = new UserController(userName);
            
            // Act
            controller.SetNewUserData(gender, birthDay, weight, height);
            UserController controller2 = new UserController(userName);

            //Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(birthDay, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);

        }

        [TestMethod()]
        public void SaveTest()
        {
            // Arrange
            string userName = Guid.NewGuid().ToString();

            // Act
            UserController controller = new UserController(userName);

            //Assert

            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}
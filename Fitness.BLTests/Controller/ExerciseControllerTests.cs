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
    public class ExerciseControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            string userName = Guid.NewGuid().ToString();
            string activityName = Guid.NewGuid().ToString();
            Random rnd1 = new Random();
            var userController1 = new UserController(userName);
            var exerciseController = new ExerciseController(userController1.CurrentUser);
            var activity = new Activity(activityName, rnd1.Next(10, 50));

            // Act
            exerciseController.Add(activity, DateTime.Now, DateTime.Now.AddHours(1));

            // Assert
            Assert.AreEqual(activity.Name, exerciseController.Activities.First().Name);
        }
    }
}
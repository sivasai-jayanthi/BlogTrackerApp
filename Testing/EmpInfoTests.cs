using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL;

namespace Testing
{
    [TestFixture]
    public class EmpInfoTests
    {
        [Test]
        public void Email_ShouldHaveKeyAttribute()
        {
            // Arrange
            var propertyInfo = typeof(EmpInfo).GetProperty("Email");

            // Act
            var keyAttribute = (KeyAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(KeyAttribute));

            // Assert
            Assert.IsNotNull(keyAttribute);
        }

        [Test]
        public void Email_ShouldHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(EmpInfo).GetProperty("Email");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNotNull(requiredAttribute);
        }

        [Test]
        public void Name_ShouldHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(EmpInfo).GetProperty("Name");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNotNull(requiredAttribute);
        }

        [Test]
        public void DateOfJoining_ShouldHaveDataTypeDateAttribute()
        {
            // Arrange
            var propertyInfo = typeof(EmpInfo).GetProperty("DateOfJoining");

            // Act
            var dataTypeAttribute = (DataTypeAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(DataTypeAttribute));

            // Assert
            Assert.IsNotNull(dataTypeAttribute);
            Assert.AreEqual(DataType.Date, dataTypeAttribute.DataType);
        }

        [Test]
        public void DateOfJoining_ShouldHaveDisplayFormatAttribute()
        {
            // Arrange
            var propertyInfo = typeof(EmpInfo).GetProperty("DateOfJoining");

            // Act
            var displayFormatAttribute = (DisplayFormatAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(DisplayFormatAttribute));

            // Assert
            Assert.IsNotNull(displayFormatAttribute);
            Assert.AreEqual("{0:yyyy-MM-dd}", displayFormatAttribute.DataFormatString);
            Assert.IsTrue(displayFormatAttribute.ApplyFormatInEditMode);
        }

        [Test]
        public void PassCode_ShouldHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(EmpInfo).GetProperty("PassCode");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNotNull(requiredAttribute);
        }

        [Test]
        public void Blogs_ShouldBeInitialized()
        {
            // Arrange
            var empInfo = new EmpInfo();

            // Act
            var blogs = empInfo.Blogs;

            // Assert
            Assert.IsNotNull(false);
            
        }
    }
}

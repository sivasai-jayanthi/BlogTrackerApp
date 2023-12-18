using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NUnit.Framework;
using DAL;

namespace Testing
{
    [TestFixture]
    public class BlogInfoTests
    {
        [Test]
        public void BlogId_ShouldHaveKeyAttribute()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("BlogId");

            // Act
            var keyAttribute = (KeyAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(KeyAttribute));

            // Assert
            Assert.IsNotNull(keyAttribute);
        }

        [Test]
        public void Title_ShouldHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("Title");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNotNull(requiredAttribute);
        }

        [Test]
        public void Subject_ShouldHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("Subject");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNotNull(requiredAttribute);
        }

        [Test]
        public void DateOfCreation_ShouldNotHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("DateOfCreation");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNull(requiredAttribute);
        }

        [Test]
        public void BlogUrl_ShouldHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("BlogUrl");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNotNull(requiredAttribute);
        }

        [Test]
        public void Email_ShouldHaveRequiredAttribute()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("Email");

            // Act
            var requiredAttribute = (RequiredAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequiredAttribute));

            // Assert
            Assert.IsNotNull(requiredAttribute);
        }

        [Test]
        public void Email_ShouldHaveEmailAddressAttribute()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("Email");

            // Act
            var emailAddressAttribute = (EmailAddressAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(EmailAddressAttribute));

            // Assert
            Assert.IsNotNull(emailAddressAttribute);
        }

        [Test]
        public void Email_ShouldHaveForeignKeyAttributeWithCorrectReferenceType()
        {
            // Arrange
            var propertyInfo = typeof(BlogInfo).GetProperty("Email");

            // Act
            var foreignKeyAttribute = (ForeignKeyAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(ForeignKeyAttribute));

            // Assert
            Assert.IsNotNull(foreignKeyAttribute);
            Assert.AreEqual("EmpInfo", foreignKeyAttribute.Name);
        }
    }
}

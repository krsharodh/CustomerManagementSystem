using System;
using Xunit;
using DeveloperPracticalTest;

namespace DeveloperPracticalTest.Tests
{
    public class CustomerModelTests
    {
        [Fact]
        public void CustomerModel_ShouldAddNewCustomer()
        {
            // Arrange
            CustomerModel customerExpected = new CustomerModel();

            // Act
            CustomerModel customerActual = new CustomerModel();

            // Assert
            Assert.Equal(customerExpected.CustomerId, customerActual.CustomerId);
        }

        [Fact]
        public void CustomerModel_ShouldGetAAutoGenID()
        {
            // Arrange
            string username = "james007";

            // Act
            CustomerModel customerActual = new CustomerModel(username, "james", "bond", "0123456789", new DateTime(1996,01,01));

            // Assert
            Assert.Equal(username, customerActual.Username);
        }

        [Fact]
        public void CustomerModel_ShouldEditCustomerData()
        {
            // Arrange
            CustomerModel customerActual = new CustomerModel("james007", "james", "bond", "0123456789", new DateTime(1996, 01, 01));

            // Act
            customerActual.editCustomer("james008", "james", "bond", "0123456789", new DateTime(1996, 01, 01));

            // Assert
            Assert.Equal("james008", customerActual.Username);
        }
    }
}

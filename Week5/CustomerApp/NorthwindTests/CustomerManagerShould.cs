using Moq;
using NorthwindBusiness;
using NorthwindData;
using NorthwindData.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace NorthwindTests
{

    public class CustomerManagerShould
    {
        private CustomerManager _sut;
        #region Mock
        [Ignore("Test will fail")]
        public void BeAbleToBeConstructed()
        {
            _sut = new CustomerManager(null);
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }

        [Test]
        public void BeAbleToBeConstructed_Moq()
        {
            //Arrange
            //This is a mock instance of type ICustomerService, we then retrieve the object associated with the mock
            // And that mock object is passed to the customer manager constructor
            var mockCustomerService = new Mock<ICustomerService>();
            var objectMock = mockCustomerService.Object;

            //Act
            _sut = new CustomerManager(objectMock);
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
            //IsInstanceOf tests where the instance is of class CustomerManager its
            //derivatives
            //IsTypeOf test for the exact type.
        }
        #endregion
        #region Stubs
        //A stub is a sunny piece of code - gets test to run, but we dont care what happens to it
        //

        [Category("Happy Path")]
        [Test]
        public void ReturnTrue_WhenUpdateIsCalled_WithVallidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer()
            {
                CustomerId = "ROCKY"
            };
            mockCustomerService.Setup(cs => cs.GetCustomerById("ROCKY")).Returns(originalCustomer);
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("ROCKY", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            Assert.That(result);
        }

        [Category("Sad Path")]
        [Test]
        public void ReturnFalse_WhenUpdateIsCalled_WithVallidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById("ROCKY")).Returns((Customer)null);
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("ROCKY", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            Assert.That(result, Is.False);
        }


        [Category("Happy Path")]
        [Test]
        public void ReturnTrue_WhenDeleteIsCalled_WithVallidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer()
            {
                CustomerId = "ROCKY"
            };
            mockCustomerService.Setup(cs => cs.GetCustomerById("ROCKY")).Returns(new Customer() { CustomerId = "ROCKY" });
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete("ROCKY");
            Assert.That(result);
        }


        [Category("Sad Path")]
        [Test]
        public void ReturnFalse_WhenDeleteIsCalled_WithVallidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById("ROCKY")).Returns((Customer)null);
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete("ROCKY");
            Assert.That(result, Is.False);
        }
        #endregion

        #region Stubs - exceptions throwing

        [Category("Sad Path")]
        [Test]
        public void ReturnFalse_WhenUpdateIsCalled_AndDataBaseExceptionIsThrow()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById("ROCKY")).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DbUpdateConcurrencyException>();

            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("ROCKY", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            Assert.That(result, Is.False);
        }

        #endregion

        #region Spies

        //Behaviour based testing uses spies 
        [Test]
        public void CallsSaveCustomerChanges_WhenUpdateIsCalledWithValidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById("ROCKY")).Returns(new Customer());

            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("ROCKY", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Once);
            mockCustomerService.Verify(cs => cs.GetCustomerById("ROCKY"), Times.Exactly(1));
            mockCustomerService.Verify(cs => cs.GetCustomersList(), Times.Never);

        }

        #endregion

        #region Loose and strick behaviour

        [Test]
        public void LetsSeeWhatHappensWhenWeCallUpdate_IfAllInvocationsArentSetup()
        {
            var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Loose);
            mockCustomerService.Setup(cs => cs.GetCustomerById("ROCKY")).Returns(new Customer());

            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("ROCKY", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());          


        }
        #endregion
    }
}

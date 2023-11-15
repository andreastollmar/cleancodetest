using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVerifier.Test
{
    public class SwedishPersonalNumberTests
    {
        [Theory]
        [MemberData(nameof(TestData.PersonalNumberData), MemberType = typeof(TestData))]
        public void CanVerifyPersonalNumber(string personalNumber)
        {
            // Arrange
            
            
            // Act
            

            // Assert
            Assert.True(SwedishPersonalNumber.VerifyPersonalNumber(personalNumber));
        }
        [Theory]
        [MemberData(nameof(TestData.PersonalNumberLongShortData), MemberType = typeof(TestData))]
        public void ReturnsFalseWhenLongOrShortPersonalNumber(string personalNumber)
        {
            // Arrange

            // Act

            // Assert
            Assert.False(SwedishPersonalNumber.VerifyPersonalNumber(personalNumber));

        }
        [Theory]
        [MemberData(nameof(TestData.PersonalNumberFalseData), MemberType = typeof(TestData))]
        public void ReturnsFalseWhenInvalidPersonalNumber(string personalNumber)
        {


            Assert.False(SwedishPersonalNumber.VerifyPersonalNumber(personalNumber));
        }


    }
}

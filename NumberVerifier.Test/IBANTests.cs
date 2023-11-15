using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVerifier.Test
{
    public class IBANTests
    {

        [Fact]
        public void CanVerify10DigitISBN()
        {
            // Arrange
            string isbn = "0-306-40615-2";
            var expected = true;
            // Act
            var verified = ISBN.VerifyISBNNumber(isbn);



            // Assert
            Assert.True(verified);

        }
        [Theory]
        [InlineData("9781472295941")]
        [InlineData("978-0-306-40615-7")]
        [InlineData("9789188801104")]
        [InlineData("97-891896-0702-6")]
        public void CanVerify13DigitISBN(string isbn)
        {
            // Arrange            
            var expected = true;
            // Act
            var verified = ISBN.VerifyISBNNumber(isbn);



            // Assert
            Assert.True(verified);
        }


    }
}

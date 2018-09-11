using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.Tests
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly primeservice.PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new primeservice.PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            //ACT
            var result = _primeService.IsPrime(1);

            //ASSERT
            Assert.IsFalse(result, "1 should not be prime");
        }
    }

}

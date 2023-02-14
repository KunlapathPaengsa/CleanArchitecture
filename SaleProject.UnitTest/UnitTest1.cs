using SaleProject.Domain.Extensions;
using System.Net.Mime;
using System.Text;
using Xunit;

namespace SaleProject.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task Add_GetCitiesApi_Async()
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonSerializer.Serialize(cities_Test), Encoding.UTF8, MediaTypeNames.Application.Json);
                var response = await client.PostAsync("http://localhost:1234/api/test", content);
            }
        }

        [Fact]
        public void TestIsPrime()
        {
            var primeService = new Calculator();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void TestAddTwoNumbers()
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.AddTwoNumbers(5, 6);
            //Assert
            Assert.Equal(11, result);
        }
    }
}
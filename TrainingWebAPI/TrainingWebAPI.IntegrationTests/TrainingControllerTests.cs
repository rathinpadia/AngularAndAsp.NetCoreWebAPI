using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TrainingWebAPI.IntegrationTests
{
    public class TrainingControllerTests : IClassFixture<IntegrationTest<Startup>>
    {
        private HttpClient Client;
        public TrainingControllerTests(IntegrationTest<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task Test_GetAll_Trainings_ReturnOK_Async()
        {
            // Arrange
            var request = "/api/Training";

            // Act
            var response = await Client.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Test_Post_Training_ReturnOK_Async()
        {
            // Arrange
            var request = new
            {
                Url = "/api/Training",
                Body = new
                {
                    TrainingId = "",
                    TrainingName = "Test Training",
                    StartDate = "12/12/2018",
                    EndDate = "12/13/2019"
                }
            };

            // Act
            var response = await Client.PostAsync(request.Url, ContentHelper.GetStringContent(request.Body));
            var value = await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();

        }
    }
}

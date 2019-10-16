using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;
using System.Collections.Generic;
using Template.Api;

namespace Template.Tests.Api
{
    public class ValuesControllerTests : ApiBaseTest
    {
        [Test]
        public async Task ValuesController_GetSpecificValue_Returns200()
        {
            // Act
            var response = await _httpClient.GetAsync("/values/5").ConfigureAwait(false);

            // Assert
            Assert.True(response.IsSuccessStatusCode);
        }

        [Test]
        public async Task ValuesController_GetSpecificValue_ReturnsString()
        {
            // Act
            var response = await _httpClient.GetAsync("/values/5").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Assert
            Assert.NotNull(content);
        }

        [Test]
        public async Task ValuesController_GetValues_Returns200()
        {
            // Act
            var response = await _httpClient.GetAsync("/values").ConfigureAwait(false);

            // Assert
            Assert.True(response.IsSuccessStatusCode);
        }

        [Test]
        public async Task ValuesController_GetValues_ReturnsListOfStrings()
        {
            // Act
            var response = await _httpClient.GetAsync("/values").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var result = JsonConvert.DeserializeObject<IEnumerable<string>>(content);

            // Assert
            Assert.NotNull(result);
            Assert.IsNotEmpty(result);
        }
    }
}
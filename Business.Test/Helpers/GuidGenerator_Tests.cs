using Business.Helpers;
using Xunit;

namespace Business.Test.Helpers
{
    public class GuidGenerator_Tests
    {
        [Fact]
        public void GenerateUniqueId_ShouldReturnValidGuid()
        {
            // Act
            var result = GuidGenerator.GenerateUniqueId();

            // Asert
            Assert.NotNull(result);
            Assert.True(Guid.TryParse(result, out _));
        }
    }
}

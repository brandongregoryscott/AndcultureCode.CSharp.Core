using System;
using AndcultureCode.CSharp.Core.Constants;
using AndcultureCode.CSharp.Core.Tests.Unit;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace AndcultureCode.CSharp.Core.Tests.Constants
{
    public class CacheOptionsTest : CoreUnitTest
    {
        #region Setup

        public CacheOptionsTest(ITestOutputHelper output) : base(output)
        {
        }

        #endregion Setup

        #region Minutes

        [Fact]
        public void Minutes_When_Minutes_Set_Returns_Configured_Options()
        {
            // Arrange
            var minutes = Random.Int(min: 1);
            var expected = TimeSpan.FromMinutes(minutes);

            // Act
            var result = CacheOptions.Minutes(minutes);

            // Assert
            result.SlidingExpiration.Value.Minutes.ShouldBe(expected.Minutes);
        }

        #endregion Minutes
    }
}

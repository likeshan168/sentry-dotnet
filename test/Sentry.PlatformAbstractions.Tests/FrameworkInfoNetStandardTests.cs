#if !NETFX
using Xunit;

namespace Sentry.PlatformAbstractions.Tests
{
    public class FrameworkInfoNetStandardTests
    {
        [Fact]
        public void GetLatest_Returns_Null()
        {
            var latest = FrameworkInfo.GetLatest(4);
            Assert.Null(latest);
        }

        [Fact]
        public void GetInstallations_Returns_Empty()
        {
            var allInstallations = FrameworkInfo.GetInstallations();
            Assert.Empty(allInstallations);
        }
    }
}
#endif

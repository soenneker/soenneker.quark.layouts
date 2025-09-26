using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Layouts.Tests;

[Collection("Collection")]
public sealed class LayoutTests : FixturedUnitTest
{
    public LayoutTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

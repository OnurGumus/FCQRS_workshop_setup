using Xunit;

namespace Server.Tests;

// A single placeholder so `dotnet test` exercises your test toolchain end-to-end
// before the workshop. We add the real domain tests (decide/fold, the quota window,
// the projection) during the session.
public class SetupSmoke
{
    [Fact]
    public void Toolchain_is_ready() => Assert.True(true);
}

namespace Kukshaus.ProjectName.Tests.StandardProjectNameTests;

public class StandardProjectNameTest : IDisposable
{
    private StandardProjectName _systemUnderTest;

    public StandardProjectNameTest()
    {
        _systemUnderTest = new();
    }

    [Fact] 
    public void AfterInitialisationInstanceIsNotNull()
    {
        // Arrange
        
        // Act
        
        // Assert
        using var _ = new AssertionScope();
        
        _systemUnderTest.Should().NotBeNull();
    }

    ~StandardProjectNameTest()
    {
        ReleaseUnmanagedResources();
    }

    private void ReleaseUnmanagedResources()
    {
        // TODO release managed resources here
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }
}
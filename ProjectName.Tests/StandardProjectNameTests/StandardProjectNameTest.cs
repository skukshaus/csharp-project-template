namespace Kukshaus.ProjectName.Tests.StandardProjectNameTests;

public class StandardProjectNameTest
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
}
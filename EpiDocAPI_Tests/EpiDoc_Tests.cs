using EpiDocAPI.DataClasses;
using FluentAssertions;

namespace EpiDocAPI_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RootIsNotNull()
        {
            // Arrange
            var epidoc = EpiDoc.FromFile("Resources/EpiDoc/ISic000001.xml");

            // Act
            var root = epidoc.Root;

            // Assert
            root.Should().NotBeNull();
        }


        [Test]
        public void GetISicId_Test()
        {
            // Arrange
            var epidoc = EpiDoc.FromFile("Resources/EpiDoc/ISic000001.xml");

            // Act
            var id = epidoc.ISicIdFromXPath;

            // Assert
            id.Should().Be("ISic000001");
        }

        [Test]
        public void GetISicIdFromLinq_Test()
        {
            // Arrange
            var epidoc = EpiDoc.FromFile("Resources/EpiDoc/ISic000001.xml");

            // Act
            var id = epidoc.ISicIdFromLinq;

            // Assert
            id.Should().Be("ISic000001");
        }
    }
}
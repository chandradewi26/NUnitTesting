
namespace LogAnalyzer.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [SetUp]
        //To set up data that is needed
        public void Setup()
        {
        }


        [TestCase("filewithgoodextension.SLF")]
        [TestCase("filewithgoodextension.slf")]
        public void IsValidFileName_BadExtension_ReturnsFalse2(string file)
        {
            //1.Arrange objects, creating and setting them up as necessary.
            LogAnalyzer analyzer = new LogAnalyzer();

            //2.Act on an object.
            bool result = analyzer.IsValidLogFileName(file);

            //3.Assert that something is as expected.
            Assert.True(result);
        }


        /*
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse1()
        {
            //1.Arrange objects, creating and setting them up as necessary.
            LogAnalyzer analyzer = new LogAnalyzer();

            //2.Act on an object.
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            //3.Assert that something is as expected.
            Assert.False(result);
        }

        [TestCase]
        public void
        IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer
                  .IsValidLogFileName("filewithgoodextension.slf");

            Assert.True(result);
        }

        [TestCase]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result =
                analyzer
                .IsValidLogFileName("filewithgoodextension.SLF");

            Assert.True(result);
        }
        */
    }
}
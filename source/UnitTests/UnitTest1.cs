using GartnerDevelopmentTest.Input_Readers;
using NUnit.Framework;
using System;
using System.IO;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void successful_Import_Yaml_Capterra()
        {
            var file = File.ReadAllText("Raw Files/capterra.yaml");

            Assert.NotNull(file);

            var fileReader = new CapterraFileReader();
            var data = ((IFileReader)fileReader).Read($"{baseDirectory}Raw Files/capterra.yaml"); //??? Why do I have to cast this?

            Assert.NotNull(data);

            Assert.AreEqual(data.Count, 3);
            Assert.AreEqual(data[0].Name, "GitGHub");
            Assert.AreEqual(data[0].Twitter, "github");

            Assert.AreEqual(data[1].Tags.Length, 3);

        }

        [Test]
        public void successful_Import_JSON_SoftwareAdvice()
        {
            var file = File.ReadAllText("Raw Files/softwareadvice.json");

            Assert.NotNull(file);

            var fileReader = new CapterraFileReader();
            var data = ((IFileReader)fileReader).Read($"{baseDirectory}Raw Files/softwareadvice.json");

            Assert.NotNull(data);
            Assert.AreEqual(data.Count, 2);
            Assert.AreEqual(data[0].Name, "Freshdesk");
            Assert.AreEqual(data[0].Twitter, "@freshdesk");

        }
    }
}
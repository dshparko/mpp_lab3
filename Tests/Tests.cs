using AssemblyBrowserLib;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly AssemblyBrowser _browser = new AssemblyBrowser();
        private const string TestDirectory = "C:\\Users\\Lenovo\\OneDrive - bsuir.by\\Рабочий стол\\Lab3_AssemblyBrowser\\Tests\\TestFiles\\";

        [Test]
        public void DllBrowserIsNotEmpty()
        {
            int expected = 0;
            int actual = _browser.GetAssemblyInfo(TestDirectory+"AssemblyBrowserLib.dll").Count;
            Assert.AreNotEqual(expected,actual);
        }
        
        [Test]
        public void CorrectClassCount()
        {
            int expected = 3;
            int actual = _browser.GetAssemblyInfo(TestDirectory+"TestClass.exe")[0].Members.Count;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ClassHasCorrectMembersCount()
        {
            int expected = 2;
            Container container = (Container)_browser.GetAssemblyInfo(TestDirectory+"TestClass.exe")[0].Members[0];
            int actual = container.Members.Count;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void NameSpaceIsCorrect()
        {
            var assemblyInfo = _browser.GetAssemblyInfo(TestDirectory+"TestClass.exe");
            ;
            Assert.IsTrue(assemblyInfo[0].Signature.Equals("TestClass") );
        }
        
        [Test]
        public void ClassIsCorrect()
        {
            var assemblyInfo = _browser.GetAssemblyInfo(TestDirectory+"TestClass.exe");
            ;
            Assert.IsTrue(assemblyInfo[0].Class.Equals("public  class  A") );
        }
     
        
        [Test]
        public void MethodNotNull()
        {
            var assemblyInfo = _browser.GetAssemblyInfo(TestDirectory+"TestClass.exe");
            ;
            Assert.NotNull(assemblyInfo[1].Members);
        }
    }
}
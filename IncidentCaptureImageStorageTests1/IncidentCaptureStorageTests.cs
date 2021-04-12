using Microsoft.VisualStudio.TestTools.UnitTesting;
using IncidentCaptureImageStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentCaptureImageStorage.Tests
{
    [TestClass()]
    public class IncidentCaptureStorageTests
    {
        /*[TestMethod()]
        public void btnFileSelection_ClickTest()
        {
            string expectedFilePath = @"C:\Users\Stephen\Desktop\Duracell 8G\Impractical Jokers Season 3\Impractical jokers S03E26.mp4";
            string actual = btnFileSelection_ClickTest().txt1;
            var capturePath = new IncidentCaptureStorage();

            Assert.Fail(expectedFilePath, actual);
        }*/

        [TestMethod()]
        public void returnedResultsTest()
        {
            string expectedFilePath = @"C:\Users\Stephen\Desktop\Duracell 8G\Impractical Jokers Season 3\Impractical jokers S03E26.mp4";
            string actual = IncidentCaptureStorage.returnedResults();
            
            Assert.Fail(expectedFilePath, actual);

            Console.WriteLine(expectedFilePath + actual);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IncidentCaptureImageStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV.Util;
using Emgu.CV;
using Emgu.CV.Structure;


namespace IncidentCaptureImageStorage.Tests
{
    [TestClass()]
    public class IncidentCaptureStorageTests : IncidentCaptureStorage
    {
        
        [TestMethod()]
        public void IncidentCaptureStorageTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FileCaptureTest()
        {
            string expectedFilePath = @"C:\Users\Stephen\Desktop\Duracell 8G\Impractical Jokers Season 3\Impractical jokers S03E26.mp4";

            string actual = IncidentCaptureStorage.VideoProcessing(sender, e);
            Assert.Equals(expectedFilePath, actual);
        }
    }
}
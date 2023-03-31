using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeQns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQns.Tests
{
    [TestClass()]
    public class OopsPhotoBookTests
    {
        [TestMethod()]
        public void OopsPhotoBookTest()
        {
            OopsPhotoBook book = new OopsPhotoBook();
            if (book.noOfPages == 16)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void OopsPhotoBookTest1()
        {
            OopsPhotoBook book1 = new OopsPhotoBook(32);
            if (book1.noOfPages == 32)
            {
                Assert.IsTrue(true);
            }
            else { Assert.Fail(); }
        }

        [TestMethod()]
        public void getNumberPagesTest()
        {
            OopsPhotoBook book2 = new OopsPhotoBook(99);
            if(book2.getNumberPages() == 99)
            {
                Assert.IsTrue(true);
            }
            else { Assert.Fail(); }
        }
        [TestMethod]
        public void addPhotoBookTest(){
            AddPhotoBook ad = new AddPhotoBook();
            if(ad.noOfPages==64){
                Assert.IsTrue(true);
            }
            else{Assert.Fail();}
        }
    }
}
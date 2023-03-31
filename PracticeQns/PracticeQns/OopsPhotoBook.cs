namespace PracticeQns
{
    public class OopsPhotoBook
    {
        public int noOfPages;
        public OopsPhotoBook()
        {
            noOfPages = 16;
        }
        public OopsPhotoBook(int pages)
        {
            noOfPages = pages;
        }
        public int getNumberPages()
        {
            return noOfPages;
        }
    }
    public class AddPhotoBook : OopsPhotoBook{
        public AddPhotoBook(){
            noOfPages=64;
        }
    }
    public class PhotoBookTest{
        public PhotoBookTest(){
            var test = new OopsPhotoBook();
            Console.WriteLine($"Default photobook pages : {test.getNumberPages()}");
            var test2 = new OopsPhotoBook(32);
            Console.WriteLine($"Number of pages : {test2.getNumberPages()}");
            var test3 = new AddPhotoBook();
            Console.WriteLine($"Large Photo book : {test3.noOfPages}");
        }
    }
}
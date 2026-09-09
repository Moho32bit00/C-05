namespace C05_C_
{
    #region class Book 
    public class Book
    {
        private string password = "secret";

        internal int copiesInStock = 5;

        public string Title;


        public string Genre { get; set; }

    };
    #endregion 

    #region enum Genre 
    public enum Genre
    {
        Fiction, NonFiction, Science
    }
    #endregion 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 
            //Book b1 = new Book();
            //Console.WriteLine(b1.password); 
            ////it is not going to print , cuz this is a private field so it can not be used outside the class .
            #endregion

            #region Q2 
            //Book b1 = new Book();
            //Console.WriteLine(b1.copiesInStock);
            //// it is going to compile , cuz the access modifier is "internal" that means that u can use the field inside the 
            ////project doesn't matter inside the class or in the main .
            #endregion

            #region q3 
            //Book b1 = new Book();
            //b1.Title = "Text";
            //Console.WriteLine(b1.Title);
            #endregion

            #region q4 
            //Book b1 = new Book();
            //b1.Genre = Genre.Science.ToString();
            //Console.WriteLine(b1.Genre);
            #endregion

            #region q5 
            //int value = Convert.ToInt32(Genre.Fiction);
            //Console.WriteLine(value);
            #endregion 
        }
    }
}

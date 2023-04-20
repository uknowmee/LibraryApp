namespace LibraryApp.ServiceBooksView
{
    public partial class UsableBook
    {
        public override string ToString()
        {
            return "[Title: " + Title + "], [Author: " + Author + "], [Pages: "+ Pages + "], [Price: " + Price.ToString("n2") + "]";
        }
    }
}
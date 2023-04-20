namespace LibraryApp.ServiceLogin
{
    public partial class Card
    {
        public override string ToString()
        {
            return "[ID: " + CardId + ", Owner Name: " + OwnerName + ", Owner Surname: " + OwnerSurname + "]";
        }
    }
}
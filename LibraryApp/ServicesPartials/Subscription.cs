namespace LibraryApp.ServiceSubscriptions
{
    public partial class Subscription
    {
        public override string ToString()
        {
            return IsNew ? $@"Any new book of: {Genre}" : $@"Any returned book of: {Genre}";
        }
    }
}
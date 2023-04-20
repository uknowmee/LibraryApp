using DataBase.Db.DbUsers.Context;
using DataBase.Db.DbUsers.Models;

namespace Register
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceRegister : IServiceRegister
    {
        public bool Check(string userName, string password1, string password2)
        {
            using (var db = new CtxUsers())
            {
                if (password1 != password2 || password1 == "") return false;

                return !db.DoesUserExist(userName);
            }
        }

        public User Apply(string userName, string password1, string password2)
        {
            using (var db = new CtxUsers())
            {
                return Check(userName, password1, password2) ? db.AddNewUser(userName, password1) : null;
            }
        }
    }
}

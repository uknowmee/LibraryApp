using System.ServiceModel;
using DataBase.Db.DbUsers.Models;

namespace Register
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceRegister
    {
        [OperationContract]
        bool Check(string userName, string password1, string password2);

        [OperationContract]
        User Apply(string userName, string password1, string password2);
    }
}

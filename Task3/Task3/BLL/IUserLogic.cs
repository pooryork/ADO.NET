using System;
using System.Collections.Generic;
using System.Text;
using Task3.Entities;

namespace Task3.BLL
{
    interface IUserLogic
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetNeedUsers(int index);
        void AddUser(User user);
        void RemoveUser(int index);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Task3.DAL;
using Task3.Entities;

namespace Task3.BLL
{
    class UserLogic: IUserLogic
    {
        private IUserDao userDao;
        public UserLogic()
        {
            userDao = new UserDao();
        }
        public void AddUser(User user)
        {
            userDao.AddUser(user);
        }
        public IEnumerable<User> GetUsers()
        {
            return userDao.GetUsers();
        }
        public IEnumerable<User> GetNeedUsers(int index)
        {
            return userDao.GetNeedUsers(index);
        }
        public void RemoveUser(int index)
        {
            userDao.RemoveUser(index);
        }
    }
}

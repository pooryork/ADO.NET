using System;
using System.Collections.Generic;
using System.Text;
using Task3.DAL;
using Task3.Entities;

namespace Task3.BLL
{
    class AwardLogic: IAwardLogic
    {
        private IAwardDao awardDao;
        public AwardLogic()
        {
            awardDao = new AwardDao();
        }
        public IEnumerable<Award> GetAwardsByUser(int index)
        {
            return awardDao.GetAwards(index);
        }
        public IEnumerable<Award> GetNeedAwards(int indexUser, string Title)
        {
            return awardDao.GetNeedAwards(indexUser, Title);
        }
        public void AddAward(int indexUser, string Title)
        {
            awardDao.AddAward(indexUser, Title);
        }
        public void RemoveAward(int indexUser, string Title)
        {
            awardDao.RemoveAward(indexUser, Title);
        }
    }
}

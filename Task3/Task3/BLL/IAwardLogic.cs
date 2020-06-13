using System;
using System.Collections.Generic;
using System.Text;
using Task3.Entities;

namespace Task3.BLL
{
    interface IAwardLogic
    {
        IEnumerable<Award> GetAwardsByUser(int index);
        IEnumerable<Award> GetNeedAwards(int indexUser, string Title);
        void AddAward(int indexUser, string Title);
        void RemoveAward(int indexUser, string Title);
    }
}

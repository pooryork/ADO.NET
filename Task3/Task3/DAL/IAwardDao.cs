using System;
using System.Collections.Generic;
using System.Text;
using Task3.Entities;

namespace Task3.DAL
{
    interface IAwardDao
    {
        IEnumerable<Award> GetAwards(int index);
        IEnumerable<Award> GetNeedAwards(int indexUser, string Title);
        void AddAward(int index, string Title);
        void RemoveAward(int indexUser, string Title);
    }
}

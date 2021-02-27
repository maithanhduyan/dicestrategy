using Dice.Sample.Bot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.Sample.Bot.Repository
{
    public interface IAccountRepository
    {
        Account FindById(long Id);

        int Update(Account account);

        int Create(Account account);

        int Delete(long id);
    }
}

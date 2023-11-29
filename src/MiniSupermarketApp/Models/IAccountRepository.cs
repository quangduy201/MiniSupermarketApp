using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    public interface IAccountRepository
    {
        void Add(Account account);
        void Edit(Account account);
        void Delete(int id);
        IEnumerable<Account> GetAll();
        IEnumerable<Account> GetByValue();
    }
}

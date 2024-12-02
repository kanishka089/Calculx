using CalculXBase.Repositories.Interfaces;
using GeneralLedgerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLedgerService.Repositories.Interfaces
{
    public interface ILedgerRepository: IGenericRepository<Ledger>
    {
        Task<Ledger> GetAuthorization(Ledger auth);
    }
}

using CalculX.Base.Repositories;
using GeneralLedgerService.Entities;
using GeneralLedgerService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLedgerService.Repositories
{
    public class LedgerRepository :GenericRepository<Ledger>, ILedgerRepository
    {
        public LedgerRepository(DbContext context) : base(context)
        {

        }

        public Task<Ledger> GetAuthorization(Ledger auth)
        {
            throw new NotImplementedException();
        }
    }
}

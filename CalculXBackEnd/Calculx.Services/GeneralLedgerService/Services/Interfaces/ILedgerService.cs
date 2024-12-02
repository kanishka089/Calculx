using GeneralLedgerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLedgerService.Services.Interfaces
{
    public interface ILedgerService
    {
        void CheckAuthorization(Ledger auth);
    }
}

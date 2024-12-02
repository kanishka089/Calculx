using GeneralLedgerService.Entities;
using GeneralLedgerService.Repositories.Interfaces;
using GeneralLedgerService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLedgerService.Services
{
    public class LedgerService : ILedgerService
    {
        private readonly ILedgerRepository _repository;

        public LedgerService(ILedgerRepository repository)
        {
            _repository = repository;
        }

        public void CheckAuthorization(Ledger ledger)
        {
            _repository.GetAuthorization(ledger);
        }
    }
}

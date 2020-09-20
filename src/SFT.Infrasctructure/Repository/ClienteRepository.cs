using SFT.ApplicationCore.Entity;
using SFT.ApplicationCore.Interfaces.Repository;
using SFT.Infrasctructure.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SFT.Infrasctructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(FinanceiroContext dbcontext) : base(dbcontext)
        {
                
        }

        IEnumerable IClienteRepository.ObterPorLimite(decimal limite)
        {
            return Buscar(x => x.Limite.Equals(limite));
        }
    }
}

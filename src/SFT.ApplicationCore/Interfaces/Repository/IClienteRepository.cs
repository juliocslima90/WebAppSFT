using SFT.ApplicationCore.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SFT.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable ObterPorLimite(decimal limite);
    }
}

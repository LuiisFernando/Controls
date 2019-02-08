using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Control.Infra.Data.Repositories
{
    public class MovimentacaoManualListarRepository : RepositoryBase<MovimentacaoManualListar>, IMovimentacaoManualListarRepository
    {
        ControlContext _context;
        public MovimentacaoManualListarRepository(ControlContext context) : base(context)
        {
            this._context = context;
        }

        public List<MovimentacaoManualListar> Listar()
        {
            return _context.Database
               .SqlQuery<MovimentacaoManualListar>("ListarMovimentacao")
               .ToList();
        }
    }
}

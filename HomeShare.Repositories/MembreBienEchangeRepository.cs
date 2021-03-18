using GestionDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeShare.Entities;

namespace HomeShare.Repositories
{
    public class MembreBienEchangeRepository : BaseRepository<MembreBienEchangeEntity>, IConcreteRepository<MembreBienEchangeEntity>
    {
        public MembreBienEchangeRepository(string connectionString) : base(connectionString)
        {
        }

        public List<MembreBienEchangeEntity> Get()
        {
            string requete = "SELECT * FROM MembreBienEchange";

            return base.Get(requete);
        }

        public MembreBienEchangeEntity GetOne(int PK)
        {
            string requete = "SELECT * FROM MembreBienEchange WHERE IdMembreBienEchange = @id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(MembreBienEchangeEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(MembreBienEchangeEntity toUpdate)
        {
            throw new NotImplementedException();
        }
            public bool Delete(MembreBienEchangeEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}

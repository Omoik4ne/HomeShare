using GestionDB.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class BienEchangeRepository : BaseRepository<BienEchangeEntity>, IConcreteRepository<BienEchangeEntity>
    {
        public BienEchangeRepository(string connectionString) : base(connectionString)
        {
        }

        public List<BienEchangeEntity> Get()
        {
            string requete = "SELECT * FROM BienEchange";

            throw new NotImplementedException();
        }

        public BienEchangeEntity GetOne(int PK)
        {
            string requete = "SELECT * FROM BienEchange WHERE IdBienEchange = @id";

            throw new NotImplementedException();
        }

        public bool Insert(BienEchangeEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(BienEchangeEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(BienEchangeEntity toDelete)
        {
            throw new NotImplementedException();
        }

    }
}

using GestionDB.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class MembreRepository : BaseRepository<MembreEntity>, IConcreteRepository<MembreEntity>
    {
        public MembreRepository(string connectionString) : base(connectionString)
        {
        }

        public List<MembreEntity> Get()
        {
            string requete = "SELECT * FROM Membre";

            return base.Get(requete);
        }

        public MembreEntity GetOne(int PK)
        {
            string requete = "SELECT * FROM Membre WHERE IdMembre = @id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(MembreEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(MembreEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(MembreEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}

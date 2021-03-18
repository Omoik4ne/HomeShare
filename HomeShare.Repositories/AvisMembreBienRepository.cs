using GestionDB.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class AvisMembreBienRepository : BaseRepository<AvisMembreBienEntity>, IConcreteRepository<AvisMembreBienEntity>
    {
        public AvisMembreBienRepository(string connectionString) : base(connectionString)
        {
        }

        public List<AvisMembreBienEntity> Get()
        {
            string requete = "SELECT * FROM AvisMembreBien";

            return base.Get(requete);
        }

        public AvisMembreBienEntity GetOne(int PK)
        {
            string requete = "SELECT * FROM AvisMembreBien WHERE IdAvisMembreBien = @id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(AvisMembreBienEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(AvisMembreBienEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(AvisMembreBienEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}

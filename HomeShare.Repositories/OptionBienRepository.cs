using GestionDB.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class OptionBienRepository : BaseRepository<OptionsBienEntity>, IConcreteRepository<OptionsBienEntity>
    {
        public OptionBienRepository(string connectionString) : base(connectionString)
        {
        }

        public List<OptionsBienEntity> Get()
        {
            string requete = "SELECT * FROM OptionsBien";

            return base.Get(requete);
        }

        public OptionsBienEntity GetOne(int PK)

        {
            string requete = "SELECT * FROM OptionsBien WHERE IdOptionsBien = @id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(OptionsBienEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(OptionsBienEntity toUpdate)
        {
            throw new NotImplementedException();

        }
        public bool Delete(OptionsBienEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}

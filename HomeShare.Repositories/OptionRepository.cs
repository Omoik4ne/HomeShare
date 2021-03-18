using GestionDB.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class OptionRepository : BaseRepository<OptionsEntity>, IConcreteRepository<OptionsEntity>
    {
        public OptionRepository(string connectionString) : base(connectionString)
        {
        }

        public List<OptionsEntity> Get()
        {
            string requete = "SELECT * FROM Option";

            throw new NotImplementedException();
        }

        public OptionsEntity GetOne(int PK)
        {
            string requete = "SELECT * FROM Option WHERE IdOptions = @id";

            throw new NotImplementedException();
        }

        public bool Insert(OptionsEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(OptionsEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(OptionsEntity toDelete)
        {
            throw new NotImplementedException();

        }
    }
}

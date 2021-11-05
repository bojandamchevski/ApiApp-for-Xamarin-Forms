using DataAccess.Interfaces;
using RealEstate.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Implementations
{
    public class MockEstateRepository : IRepository<Estate>
    {
        public void Delete(int id)
        {
            Estate estate = StaticDb.Estates.FirstOrDefault(x => x.Id == id);
            StaticDb.Estates.Remove(estate);
        }

        public List<Estate> GetAll()
        {
            return StaticDb.Estates;
        }

        public Estate GetById(int id)
        {
            return StaticDb.Estates.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Estate entity)
        {
            entity.Id = StaticDb.Estates.Last().Id + 1;
            StaticDb.Estates.Add(entity);
        }

        public void Update(Estate entity)
        {
            Estate estateDb = StaticDb.Estates.FirstOrDefault(x => x.Id == entity.Id);
            int entityndex = StaticDb.Estates.IndexOf(estateDb);
            StaticDb.Estates[entityndex] = estateDb;
        }
    }
}

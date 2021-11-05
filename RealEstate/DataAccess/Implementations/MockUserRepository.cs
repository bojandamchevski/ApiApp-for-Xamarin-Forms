using DataAccess.Interfaces;
using Domain.Models;
using RealEstate.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Implementations
{
    public class MockUserRepository : IUserRepository
    {
        public void Delete(int id)
        {
            User user = StaticDb.Users.FirstOrDefault(x => x.Id == id);
            StaticDb.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return StaticDb.Users;
        }

        public User GetById(int id)
        {
            return StaticDb.Users.FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByUsername(string username)
        {
            return StaticDb.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public void Insert(User entity)
        {
            entity.Id = StaticDb.Users.Last().Id + 1;
            StaticDb.Users.Add(entity);
        }

        public User LoginUser(string username, string password)
        {
            return StaticDb.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower()
            && x.Password == password);
        }

        public void Update(User entity)
        {
            User userDb = StaticDb.Users.FirstOrDefault(x => x.Id == entity.Id);
            int entityndex = StaticDb.Users.IndexOf(userDb);
            StaticDb.Users[entityndex] = userDb;
        }
    }
}

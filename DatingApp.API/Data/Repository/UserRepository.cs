using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data.Entities;

namespace DatingApp.API.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context){
            _context = context;
        }

        public DataContext Context { get; }

        public void CreateUser(User user)
        {
            _context.AppUsers.Add(user);
        }

        public void DeleteUser(User user)
        {
            _context.AppUsers.Remove(user);
        }

        public User GetUserById(int id)
        {
            return _context.AppUsers.FirstOrDefault(p => p.Id == id);
        }

        public User GetUserByUsername(string username)
        {
            return _context.AppUsers.FirstOrDefault(u => u.Username == username);
        }

        public List<User> GetUsers()
        {
            return _context.AppUsers.ToList();
        }

        public bool IsSaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public void UpdateUser(User user)
        {
            _context.AppUsers.Update(user);
        }
    }
}
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using DatingApp.API.Data.Entities;
using DatingApp.API.DTOs;

namespace DatingApp.API.Data.Seed
{
    public static class Seed
    {
        public static void SeedUsers(DataContext context){
            if (context.AppUsers.Any()) return;

            var usersText = System.IO.File.ReadAllText("Data/Seed/users.json");
            var users = JsonSerializer.Deserialize<List<User>>(usersText);

            foreach(var user in users){
                using var hmac = new HMACSHA512();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("P@$$w0rd1"));
                user.PasswordSalt = hmac.Key;
                user.CreatedAt = DateTime.Now;
                context.AppUsers.Add(user);

            }
            context.SaveChanges();
        }
    }
}
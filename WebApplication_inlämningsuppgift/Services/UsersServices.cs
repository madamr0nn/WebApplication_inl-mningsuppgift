using Microsoft.EntityFrameworkCore;
using WebApplication_inlämningsuppgift.Data;
using WebApplication_inlämningsuppgift.Models;

namespace WebApplication_inlämningsuppgift.Services
{   
    public interface IUserServices 
    {
        Task createasync(User _users);
        Task<bool> DeleteUser(int id);
        IEnumerable<User> getuserasync();
      
    }

    public class UsersServices : IUserServices
    {
        private readonly SqlContext context;
        private object _SqlContext;

        public UsersServices()
        {
        }

        public UsersServices(SqlContext _context)
        {
            context = _context;
        }

        public Task createasync(User _users)
        {
            context.Users.AddAsync(_users);
            context.SaveChanges ();
            return Task.CompletedTask;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }    
        public  IEnumerable<User> getuserasync()
        {
            var users  = new List<User>();
            foreach (var customer in context.Users.ToList())
                users.Add(customer);
               
            return users;
        }

       

       
    }
}

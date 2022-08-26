using Microsoft.EntityFrameworkCore;
using WebApplication_inlämningsuppgift.Data;
using WebApplication_inlämningsuppgift.Models;

namespace WebApplication_inlämningsuppgift.Services
{   
    public interface IUserServices 
    {
        Task CreateUserAsync(User _users);
        Task<bool> DeleteUserAsync(int id);
        IEnumerable<User> GetUsersAsync();
      
    }

    public class UsersServices : IUserServices
    {
        private readonly SqlContext context;

        public UsersServices(SqlContext _context)
        {
            context = _context;
        }
        public async Task CreateUserAsync(User _users)
        {
            await context.Users.AddAsync(_users);
            await context.SaveChangesAsync ();
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = context.Users.FirstOrDefault(i=>i. Id==id);
            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }    
        public  IEnumerable<User> GetUsersAsync()
        {
               
            return context.Users;
        }

       

       
    }
}

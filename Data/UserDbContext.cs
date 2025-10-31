using JwtAuthLearn.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthLearn.Data
{
    public class UserDbContex(DbContextOptions<UserDbContex> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}

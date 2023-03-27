using BaiThucHanh2002.Models;
using Microsoft.EntityFrameworkCore;
namespace BaiThucHanh2002.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students {get; set;}
    }
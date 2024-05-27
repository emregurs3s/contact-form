using Microsoft.EntityFrameworkCore;
using CommunicationForm.Models;

namespace CommunicationForm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contact> Contact { get; set; }
    }
}

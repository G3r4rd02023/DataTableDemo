using Microsoft.EntityFrameworkCore;

namespace DataTableDemo.Models
{
    public class ContactoContext : DbContext
    {
        public ContactoContext(DbContextOptions<ContactoContext> options) : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
 
namespace lost_in_the_woods.Models
{
    public class lost_in_the_woodsContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public lost_in_the_woodsContext(DbContextOptions<lost_in_the_woodsContext> options) : base(options) { }
        public DbSet<Place> Trail { get; set; }
    }
}
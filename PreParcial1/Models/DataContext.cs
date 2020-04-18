namespace PreParcial1.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PreParcial1.Models.Friend> Friends { get; set; }
    }
}
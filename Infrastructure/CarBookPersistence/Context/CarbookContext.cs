using CarbookDomian.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBookPersistence.Context
{
    public class CarbookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=CarBook;Trusted_Connection=True;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PickUp ilişki tanımı
            modelBuilder.Entity<Location>()
                .HasMany(l => l.PickUpReservation)
                .WithOne(r => r.PickUpLocation)
                .HasForeignKey(r => r.PickUpLocationID)
                .OnDelete(DeleteBehavior.Restrict);

            // DropOff ilişki tanımı
            modelBuilder.Entity<Location>()
                .HasMany(l => l.DropOffReservation)
                .WithOne(r => r.DropOffLocation)
                .HasForeignKey(r => r.DropOffLocationID)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}

using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Floors> Floories { get; set; }
        public virtual DbSet<Foods> Foods { get; set; }
        public virtual DbSet<FoodsDetail> FoodsDetails { get; set; }
        public virtual DbSet<Hotels> Hotelies { get; set; }
        public virtual DbSet<HotelsGallery> HotelsGalleries { get; set; }
        public virtual  DbSet<HotelsVizyonMisyon> HotelsVizyonMisyons { get; set; }
        public virtual  DbSet<IdentityCardType> IdentityCardTypes { get; set; }
        public virtual DbSet<KingSuitRooms> KingSuitRooms { get; set; }
        public virtual DbSet<KingSuitRoomPhoto> KingSuitRoomPhotos { get; set; }
        public virtual DbSet<Personels> Personels { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }

        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Rooms> Roomies { get; set; }
        public virtual DbSet<SuperAdmins> SuperAdmins { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<UserRol> UserRols { get; set; }
        public virtual DbSet<Users> Users { get; set; }
       





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasOptional(s => s.superAdmins).WithRequired(ad => ad.Users); 
            modelBuilder.Entity<Users>()
            .HasOptional(s => s.Admins).WithRequired(ad => ad.Users);
            modelBuilder.Entity<Users>()
            .HasOptional(s => s.Personels).WithRequired(ad => ad.Users); 
            modelBuilder.Entity<Users>()
            .HasOptional(s => s.Customer).WithRequired(ad => ad.Users);  
            
            modelBuilder.Entity<Rooms>()
            .HasOptional(s => s.KingSuitRooms).WithRequired(ad => ad.Rooms);
            modelBuilder.Entity<Product>()
     .HasOptional(s => s.ProductDetail).WithRequired(ad => ad.Product);

            modelBuilder.Entity<Foods>()
.HasOptional(s => s.FoodsDetail).WithRequired(ad => ad.Foods);


        }

    }
}

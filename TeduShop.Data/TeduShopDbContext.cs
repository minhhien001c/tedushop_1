using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TeduShop.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TeduShop.Data
{
    public class TeduShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public TeduShopDbContext()
          : base("TeduShopConnection")
        {
            //khi load bang cha tu dong ko include bang con
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategorys { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }

        //xem mau khi tao project co authen Models/IdentityModels
        //tao moi chinh no
        public static TeduShopDbContext Create()
        {
            return new TeduShopDbContext();
        }
        //chay khi khoi tao entityframework
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //Sau khi lam phan auth, generate ra DB bi loi nen them vao
            // EntityType 'IdentityUserRole' has no key defined. Define the key for this EntityType
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }

       

    }
}

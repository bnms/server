using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace server.Models {
    public sealed class BnmsContext : DbContext {
        public static void Initialize(IServiceProvider service) {
            using (var scope = service.CreateScope()) {
                var db = scope.ServiceProvider.GetService<BnmsContext>();
                db.Database.EnsureCreated();
                db.Roles.AddRange(new Role() {Name = "Administrator"}, new Role() {Name = "Manager"}, new Role() {Name = "Contractor"});
                db.SaveChanges();
            }
        }

        public BnmsContext(DbContextOptions<BnmsContext> options) : base(options) {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocMVCApp.Entities;
using PocMVCApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocMVCApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public class ApplicationUser : IdentityUser 
        {
            [StringLength(100)]
            public string? FirstName { get; set; }
            [StringLength(100)]
            public string? LastName { get; set; }
            [StringLength(250)]
            public string? Address1 { get; set; }
            [StringLength(250)]
            public string? Address2 { get; set; }
            [StringLength(50)]
            public string? ZipCode { get; set; }
            [ForeignKey("UserId")]
            public virtual ICollection<UserCategory>? UserCategory { get; set; }
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category>? Category { get; set; }
        public DbSet<CategoryItem>? CategoryItem { get; set; }
        public DbSet<MediaType>? MediaType { get; set; }
        public DbSet<UserCategory>? UserCategory { get; set; }
        public DbSet<Content>? Content { get; set; }
    }
}
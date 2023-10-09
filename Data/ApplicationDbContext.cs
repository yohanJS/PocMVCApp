using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocMVCApp.Entities;
using PocMVCApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocMVCApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserPrimaryInfo>? userPrimaryInfo { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserPrimaryInfo>? UserPrimaryInfo { get; set; }
    }
}
using MvcAppPOC.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAppPOC.Entities
{
    public class UserPrimaryInfo
    {
        public int Id { get; set; }
        //Id tied to IdentityUser table
        public string? UserId { get; set; }
        public string? JobTitle { get; set; }
        public int Age { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? ZipCode { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }
    }
}

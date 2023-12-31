﻿using PocMVCApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace PocMVCApp.Entities
{
    public class UserPrimaryInfo
    {
        public int Id { get; set; }
        //Id tied to IdentityUser table
        public string? UserId { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }

        public string? JobTitle { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? ZipCode { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? PrimaryPhone { get; set; }
        public string? Salary { get; set;  }

        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }        
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class User : IdentityUser
    {
        public User()
        {
            IsDelete = false;
            CreatedAt = DateTime.Now;
            CreatedBy = "";
        }
        [Required]
        public string fullName { get; set; }     
        public bool IsDelete { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public List<Client> Clients { get; set; }
    }
}
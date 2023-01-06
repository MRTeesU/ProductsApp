using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class User
    {
        public User()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }
    }
}

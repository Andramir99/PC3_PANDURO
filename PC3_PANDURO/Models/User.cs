using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC3_PANDURO.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
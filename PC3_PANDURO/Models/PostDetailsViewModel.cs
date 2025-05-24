using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC3_PANDURO.Models
{
    public class PostDetailsViewModel
    {
        public Post Post { get; set; } = new Post();
        public User User { get; set; } = new User();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnmv3.Models
{
    public class ContentModels 
    {
        public string Content { get; set; }
        public int ContentId { get; set; }
        public string Author { get; set; }
        public int VoteCount { get; set; }
        public int FavCount { get; set; }
        public DateTime DateAdded { get; set; }
        
    }
}
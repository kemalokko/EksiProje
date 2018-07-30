using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnmv3.Models
{
    public class ThreadModels
    {
        public string Thread { get; set; }
        public int ThreadId { get; set; }
        public string AuthorName { get; set; }
        public DateTime DateAdded { get; set; }
        public List<ContentModels> Content { get; set; }
    }
}
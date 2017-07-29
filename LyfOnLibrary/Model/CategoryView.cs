using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyfOnLibrary.Model
{
        public partial class CategoryView
        {
            public int Id { get; set; }
            public string PublisherName { get; set; }
            public string PublisherType { get; set; }
            public string ContentType { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime DeadLineDate { get; set; }
            public string Status { get; set; }
        }
    }

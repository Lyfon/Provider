using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyfOnLibrary.Model
{
    public class Criteria
    {
        public class SubmissionCriteria
        {
            public long? ProviderId { get; set; }

            public long? StatusId { get; set; }

            public long? SubmissionId { get; set; }

            public string Title { get; set; }
        }

        public class PublisherCriteria
        {
            public long? CategoryId { get; set; }

            public string Name { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyfOnLibrary.Model
{
   public partial class SubmissionView
    {
        public int Id { get; set; }

        public string Submission { get; set; }

        public string Category { get; set; }

        public string Publisher { get; set; }

        public string CreatedDate { get; set; }

        public string SubmittedDate { get; set; }

        public string InprogressDate { get; set; }

        public string AcceptedDate { get; set; }

        public string DeclinedDate { get; set; }

        public string WithdrawDate { get; set; }

        public string Status { get; set; }
    }
}

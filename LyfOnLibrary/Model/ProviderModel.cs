using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyfOnLibrary.Model
{
   public class ProviderModel
    {
            public partial class ContentView
            {
                public int Id { get; set; }
                public string FileName { get; set; }
                public string Category { get; set; }
                public string Publisher { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime RejectedDate { get; set; }
                public string Status { get; set; }
            }

            public partial class DiscoverView
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

            public partial class DiscoverDetailView
            {
                public int Id { get; set; }
                public string PublisherName { get; set; }
                public string ContentType { get; set; }
                public string Description { get; set; }
                public string Category { get; set; }
                public DateTime CreatedDate { get; set; }
                public string Status { get; set; }
            }

            public partial class SavedDraftView
            {
                public int Id { get; set; }
                public string FileName { get; set; }
                public string Category { get; set; }
                public string PublisherName { get; set; }
                public string Description { get; set; }
                public DateTime SavedDate { get; set; }
                public string Status { get; set; }
                public bool ChkStatus { get; set; }
            }

            public partial class AcceptedView
            {
                public int Id { get; set; }
                public string FileName { get; set; }
                public string Category { get; set; }
                public string Publisher { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime AcceptedDate { get; set; }
                public string Status { get; set; }
                public bool ChkStatus { get; set; }
            }

            public partial class InprogressView
            {
                public int Id { get; set; }
                public string FileName { get; set; }
                public string Category { get; set; }
                public string Publisher { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime InprogressDate { get; set; }
                public string Status { get; set; }
                public bool ChkStatus { get; set; }
            }

            public partial class SavedView
            {
                public int Id { get; set; }
                public string FileName { get; set; }
                public string Category { get; set; }
                public string Publisher { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime SavedDate { get; set; }
                public string Status { get; set; }
                public bool ChkStatus { get; set; }
            }

            public partial class FollowingView
            {
                public int Id { get; set; }
                public string Description { get; set; }
                public string Category { get; set; }
                public string Publisher { get; set; }
                public DateTime CreatedDate { get; set; }
                public string Status { get; set; }
                public bool ChkStatus { get; set; }
            }

            public partial class WithdrawnView
            {
                public int Id { get; set; }
                public string FileName { get; set; }
                public string Category { get; set; }
                public string Publisher { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime WithdrawnDate { get; set; }
                public string Status { get; set; }
                public bool ChkStatus { get; set; }
            }

            public partial class DeclineView
            {
                public int Id { get; set; }
                public string FileName { get; set; }
                public string Category { get; set; }
                public string Publisher { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime DeclineDate { get; set; }
                public string Status { get; set; }
                public bool ChkStatus { get; set; }
            }
        }
    }


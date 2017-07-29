using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyfOnLibrary.Model
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public int? Age { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public string PersonalInfo { get; set; }
    }
}

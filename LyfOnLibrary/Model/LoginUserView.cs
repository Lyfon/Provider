using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyfOnLibrary.Model
{
    public partial class LoginView
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Key { get; set; }
        public DateTime LoginDate { get; set; }
        public string Status { get; set; }
    }
}

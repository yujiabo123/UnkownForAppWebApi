using System;
using System.Collections.Generic;

namespace com.unkown.app.coredal.Models
{
    public partial class AccountInfo
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string MachineId { get; set; }
        public string Email { get; set; }
        public string Qq { get; set; }
        public string WeChat { get; set; }
        public string WeiBo { get; set; }
    }
}

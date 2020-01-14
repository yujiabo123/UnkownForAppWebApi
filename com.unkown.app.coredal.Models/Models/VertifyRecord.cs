using System;
using System.Collections.Generic;

namespace com.unkown.app.coredal.Models
{
    public partial class VertifyRecord
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string VertifyCode { get; set; }
        public long InvalidTime { get; set; }
        public long SendTime { get; set; }
        public short Nullity { get; set; }
    }
}

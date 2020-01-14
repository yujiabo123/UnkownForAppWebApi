using System;
using System.Collections.Generic;

namespace com.unkown.app.coredal.Models
{
    public partial class ItemContent
    {
        public int Id { get; set; }
        public string ItPicUrl { get; set; }
        public string ItName { get; set; }
        public long ItPrice { get; set; }
        public string ItDescription { get; set; }
        public int ItAreaId { get; set; }
        public int ItLevel { get; set; }
        public int Cid { get; set; }
        public DateTime InsertTime { get; set; }
        public short Nullity { get; set; }
        public DateTime LastModifiedsTime { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapShop.Models
{
    public class TbPages
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MetaKeyWord { get; set; } = null!;
        public string MetaDescriptiuon { get; set; } = null!;
        public string ImageName { get; set; } = null!;
        public int CurrentState { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}

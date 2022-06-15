using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_DangHoangXuanThai.Models
{
    public Course Course { get; set; }
        [Key]
        [Column(Order = 1)]
        public int CourseId { get; set }
        public ApplicationUser Attendee { get; set; }
}
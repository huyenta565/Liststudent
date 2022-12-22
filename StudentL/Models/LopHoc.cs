﻿using System.ComponentModel.DataAnnotations;

namespace StudentL.Models
{
    public class LopHoc
    {
        public Guid Id { get; set; }
       
        public string Name { get; set; }
        
        public List<Student> HocSinh { get; set; }
    }
}

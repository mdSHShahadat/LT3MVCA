﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ROM.Models
{
    public class MemberVM
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class CartCookies : BaseEntity
    {
        public float total { get; set; }
        public float totalprice { get; set; }
        public DateTime PickUpTime { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string  UserId{ get; set; }
        public User User { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string CityName { get; set; }
        public int ZipCode { get; set; }
    }

}
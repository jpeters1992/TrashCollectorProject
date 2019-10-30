﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string StreetAddress { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public int ZipCode { get; set; }
        public double OutstandingBalance { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
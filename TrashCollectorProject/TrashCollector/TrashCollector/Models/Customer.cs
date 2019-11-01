using System;
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

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Display(Name = "Weekly Pickup Day")]
        public int WeeklyPickUpDay { get; set; }

        [Display(Name = "$ Charge")]
        public double PickupCharge { get; set; }

        [Display(Name = "Balance")]
        public double? Balance { get; set; }
        public double? MonthlyCharge { get; set; }

        [Display(Name = "Pick Up Confirmed")]
        public bool? PickupConfirmed { get; set; }

        [Display(Name = "Service Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ServiceStartDate { get; set; }

        [Display(Name = "Service End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ServiceEndDate { get; set; }

        [Display(Name = "Extra Pickup")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ExtraPickUpDate { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
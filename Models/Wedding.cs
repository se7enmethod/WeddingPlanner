using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{

    public class IsFuture : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Type cast 'value' into a DateTime:
            DateTime InputDate = Convert.ToDateTime(value);

            if (InputDate.AddMinutes(1) > DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Wedding Date must be in the future.");
            }
        }
    }

    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required]
        [Display(Name = "Wedder One")]
        public string WedderOne { get; set; }

        [Required]
        [Display(Name = "Wedder Two")]
        public string WedderTwo { get; set; }

        [Required]
        [IsFuture]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Wedding Address")]
        public string Address { get; set; }

        // One-To-Many (One-side) nav property goes here <<

        // One-To-Many (Many-side) nav property goes here <<

        public int UserId { get; set; }
        public User Creator { get; set; }

        public List<Association> Guests { get; set; }
        // Many-To-Many nav property goes here <<

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}


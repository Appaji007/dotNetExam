using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Name can not be empty")]
        public String ProductName { get; set; }
        [DataType(DataType.Currency)]
        public int Rate { get; set; }

        [Required(ErrorMessage = "give some description")]
        [MaxLength(200)]
        [DataType(DataType.Text)]
        public String Description { get; set; }

        [Required(ErrorMessage = "Slect Category")]
        public String CategoryName { get; set; }

        public static implicit operator Product(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
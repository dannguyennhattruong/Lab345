using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab345.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public string Descriptions { get; set; }
        public string Photo { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int CheeseId { get; set; }
        private DateTime _createdOn = DateTime.MinValue;
        [Display(Name = "Created On")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateOn
        {
            get { return (_createdOn == DateTime.MinValue) ? DateTime.Now : _createdOn; }
            set { _createdOn = value; }
        }
        public CheeseType Type { get; set; }
        private static int nextId = 1;
        public Cheese() { CheeseId = nextId; nextId++; }
        public override int GetHashCode() { return CheeseId; }
    }
}

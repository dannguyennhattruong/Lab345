using Lab345.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab345.ViewModels
{
    public class CheeseViewModel
    {
        [Required(ErrorMessage = "Name not null")] [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Name { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        [Required] [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Descriptions { get; set; }
        public string Photo { get; set; }
        [Required] [Range(0, 20)] public int Quantity { get; set; }
        [Required] [Range(0, 999.99)] public double Price { get; set; }
        public int CheeseId { get; set; }

        public IEnumerable<Cheese> listCheese { get; set; }

        

        private DateTime _createdOn = DateTime.MinValue;
        [Display(Name = "Created On")] [DataType(DataType.DateTime)] [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateOn
        {
            get
            {
                return (_createdOn == DateTime.MinValue) ? DateTime.Now : _createdOn;
            }
            set
            {
                _createdOn = value;
            }
        }
        public CheeseType Type { get; set; }
        public List<SelectListItem> CheeseTypes { get; set; }
        public CheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();
            CheeseTypes.Add(new SelectListItem { Value = ((int)CheeseType.Hard).ToString(), Text = CheeseType.Hard.ToString() });
            CheeseTypes.Add(new SelectListItem { Value = ((int)CheeseType.Soft).ToString(), Text = CheeseType.Soft.ToString() });
            CheeseTypes.Add(new SelectListItem { Value = ((int)CheeseType.Fake).ToString(), Text = CheeseType.Fake.ToString() });
        }
    }
    public class PaginatedCheeseList<T> : List<T>
    {
        public int PageIndex { get; set; }

        public int TotalPages { get; set; }
        public PaginatedCheeseList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex; TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }
        public bool HasPreviousPage
        {
            get {
                return (PageIndex > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
        public static PaginatedCheeseList<T> Create(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedCheeseList<T>(items, count, pageIndex, pageSize);
        }
    }
}

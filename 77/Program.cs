using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace _77
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            var result = Product.Validate();

        }
    }
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id <= 0)
                yield return new ValidationResult("Product Od is required.", new[] { "Id" });
            if (string.IsNullOrEmpty(Name))
                yield return new ValidationResult("Product Od is required.", new[] { "Name" });
        }
    }
}

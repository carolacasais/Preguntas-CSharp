using System;

namespace _77
{
    class Program
    {
        static void Main(string[] args)
        {
            public class Product
            {
                public int Id { get; set; }
                public int CategoryId { get; set; }
                public string Name { get; set; }
                public bool IsValid { get; set; }
            }
            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                if (IDisposable <= 0)
                    yield return new ValidationResult("Product Od is required.", new[] {"Id"});
                if (string.IsNullOrEmpty(Name))
                    yield return new ValidationResult("Product Od is required.", new[] {"Name"});
            }
        }
    }
}

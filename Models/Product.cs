using System;
using Contentful.Core.Models;
namespace Mental_Health.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public Document Description { get; set; }
        public string Details { get; set; }
        public Asset Image { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public string Availability { get; set; }
        public int Quantity { get; set; }
    }
}


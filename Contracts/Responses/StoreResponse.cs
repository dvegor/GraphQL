﻿
using Seminar3.Models;

namespace Seminar3.Contracts.Responses
{
    public class StoreResponse
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}

﻿
using Seminar3.Models;

namespace Seminar3.Contracts.Requests
{
    public class StoreUpdateRequest
    {
        public int Id { get; set; }
        public int Count { get; set; } = 0;


        public Store StoreGetEntity()
        {

            return new Store()
            {
                Id = Id,
                Count = Count
            };
        }
    }
}


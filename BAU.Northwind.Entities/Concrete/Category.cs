﻿using BAU.Core.Entities;

namespace BAU.Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
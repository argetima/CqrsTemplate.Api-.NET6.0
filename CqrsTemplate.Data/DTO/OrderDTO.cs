﻿namespace CqrsTemplate.Data.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quatity { get; set; }
    }
}

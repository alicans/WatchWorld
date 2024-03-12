﻿namespace ApplicationCore.Entities
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public string? PictureUri { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }


        public Product Product { get; set; } = null!;
    }
}

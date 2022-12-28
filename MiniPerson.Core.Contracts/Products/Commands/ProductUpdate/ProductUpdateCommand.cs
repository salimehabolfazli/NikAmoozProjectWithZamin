﻿using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Products.Commands.ProductUpdate
{
    public class ProductUpdateCommand : ICommand<long>
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

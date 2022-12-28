using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId
{
    public class ProductQr
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

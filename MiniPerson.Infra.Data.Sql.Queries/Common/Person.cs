using System;
using System.Collections.Generic;

namespace WebLog.Infra.Data.Sql.Queries.Common
{
    public partial class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? CreatedByUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? ModifiedByUserId { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public Guid BusinessId { get; set; }
        public List<PersonPhoneNumber> PhoneNumbers { get; set; }
        public List<PersonProduct> Products { get; set; }
    }
    public class PersonPhoneNumber
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string? CreatedByUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? ModifiedByUserId { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string PhoneNumber { get; set; }

    }
    public class PersonProduct
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public long ProductId { get; set; }


    }
}

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniPerson.Core.Domain.Persons.ValueObjects;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace NewCms.Infra.Data.Sql.Commands.Common
{
    public class PhoneNumberConversion: ValueConverter<PhoneNumber, string>
    {
        public PhoneNumberConversion() : base(c => c.Value, c=>PhoneNumber.FromString(c))
        {

        }
    }
}

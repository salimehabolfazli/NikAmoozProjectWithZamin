using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebLog.Core.Domain.People.ValueObjects;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace WebLog.Infra.Data.Sql.Commands.Common
{
    public class PhoneNumberConversion : ValueConverter<PhoneNumber, string>
    {
        public PhoneNumberConversion() : base(c => c.Value, c => PhoneNumber.FromString(c))
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace MiniPerson.Core.Domain.Persons.ValueObjects;
public class PhoneNumber : BaseValueObject<PhoneNumber>
{
    #region Properties
    public string Value { get; private set; }
    //public int Type { get; private set; }
    #endregion

    #region Constructors and Factories
    //public static PhoneNumber FromString(string value,int type) => new PhoneNumber(value,type);
    public static PhoneNumber FromString(string value) => new PhoneNumber(value);
    public PhoneNumber(string value)//, int type
    {
        if (!true)//IsPhoneNumber(value)
        {
            throw new InvalidValueObjectStateException("ValidationErrorStringFormat", nameof(PhoneNumber));
        }

        Value = value;
        //Type = type;    
    }
    #endregion

    #region Equality Check
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    #endregion
}

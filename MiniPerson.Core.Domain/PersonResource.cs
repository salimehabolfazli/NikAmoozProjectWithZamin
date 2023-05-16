namespace WebLog.Core.Domain
{
    public class PersonResource
    {
        public const string IdRequiredError = nameof(IdRequiredError);

        #region Person 
        public const string PersonFirstnameRequiredError = nameof(PersonFirstnameRequiredError);
        public const string PersonLastnameRequiredError = nameof(PersonLastnameRequiredError);
        public const string PersonFirstnameStringLengthError = nameof(PersonFirstnameStringLengthError);
        public const string PersonLastnameStringLengthError = nameof(PersonLastnameStringLengthError);

        #endregion

        #region PhoneNumber
        public const string PhoneNumberNotExistError = nameof(PhoneNumberNotExistError);
        public const string PersonPhoneNumberExistError = nameof(PersonPhoneNumberExistError);
        public const string PersonPhoneNumberStringLengthError = nameof(PersonPhoneNumberStringLengthError);
        #endregion

        #region Product
        public const string PersonProductExistError = nameof(PersonProductExistError);
        public const string PersonProductRequiredError = nameof(PersonProductRequiredError);
        public const string ProductTitleRequiredError = nameof(ProductTitleRequiredError);
        public const string ProductDescriptionRequiredError = nameof(ProductDescriptionRequiredError);
        public const string ProductTitleStringLengthError = nameof(ProductTitleStringLengthError);

        #endregion

    }
}

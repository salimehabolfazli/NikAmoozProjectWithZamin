namespace MiniPerson.EndPoints.UI.DTOs.Persons
{
    public class CreatePersonCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumberList { get; set; }
    }
}

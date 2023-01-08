namespace MiniPerson.EndPoints.UI.DTOs.People
{
    public class CreatePersonCommand
    {
        public Guid PersonBusinessId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumberList { get; set; }
        public CreatePersonCommand() { 
            PhoneNumberList = new List<string>();   
        }    
    }
}

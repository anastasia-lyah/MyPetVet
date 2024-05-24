namespace MyPetVet
{
    internal interface IClient
    {
        string Address { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
    }
}
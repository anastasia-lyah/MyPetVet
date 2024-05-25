namespace MyPetVet
{
    internal interface IClient
    {
        string Address { get; set; }
        string FullName { get; set; }
        string Phone { get; set; }
    }
}
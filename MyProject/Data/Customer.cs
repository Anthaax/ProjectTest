namespace MyProject.Data
{
    public class Customer : BaseData
    {
        public Customer(int id, string firstName, string lastName)
            :base(id)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
    }
}
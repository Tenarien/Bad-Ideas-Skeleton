using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime AccountCreated { get; set; }
        public bool AccountVerification { get; set; }
    }
}
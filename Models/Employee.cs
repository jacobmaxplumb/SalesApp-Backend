using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SalesApp.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public DateTime HiredDate { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Note> Notes { get; set; }

        public Employee()
        {
            Customers = new Collection<Customer>();
            Notes = new Collection<Note>();
        }
    }
}
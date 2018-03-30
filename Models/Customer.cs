using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SalesApp.API.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Pin { get; set; }
        public ICollection<Note> Notes { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Customer()
        {
            Notes = new Collection<Note>();
        }
    }
}
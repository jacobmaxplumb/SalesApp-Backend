using System;

namespace SalesApp.API.Models
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NoteTaken { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
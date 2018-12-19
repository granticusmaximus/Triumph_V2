using System;
namespace Triumph.Web.Entities
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Attributes { get; set; }
        public string Priority { get; set; }
        public Client AssignedClientID { get; set; }
        public Employee AssignedEmpID { get; set; }
    }
}

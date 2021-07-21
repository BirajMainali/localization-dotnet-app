using System.ComponentModel;

namespace Localization.Models
{
    public class Employee
    {
        public long Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Age")]
        public string Age { get; set; }
        [DisplayName("Salary")]
        public string Salary { get; set; }
    }
}
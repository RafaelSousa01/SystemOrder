
using System.Runtime.CompilerServices;

namespace SystemOrder.Entities
{
    public class CLient
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public CLient() { }

        public CLient (string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name}, ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}

using System;

namespace OPD.Application.Dtos.Custumers
{
    public class CustumerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsActive { get; set; }
    }
}

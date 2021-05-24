using System;

namespace OPD.Domain.Entities.Custumers
{
    public class Custumer : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsActive { get; set; }
    }
}

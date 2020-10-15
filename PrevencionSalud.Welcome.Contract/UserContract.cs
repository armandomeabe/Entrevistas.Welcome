using System;
using System.ComponentModel.DataAnnotations;

namespace PrevencionSalud.Welcome.Contract
{
    public class UserContract
    {
        [Required]
        public Guid ID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string DocumentNumber { get; set; }
        
        public string City { get; set; }
        public string State { get; set; }
    }
}

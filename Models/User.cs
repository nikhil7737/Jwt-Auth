using System;

namespace Auth.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
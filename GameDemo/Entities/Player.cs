using System;

namespace GameDemo.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Character
    {
        public Character(string name)
        {
            Name = name;
        }

        private Character()
        {
        }

        [Key]
        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
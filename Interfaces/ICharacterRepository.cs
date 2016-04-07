using System.Collections.Generic;
using MyWebApp.Models;

namespace MyWebApp.Interfaces
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> ListAll();
        void Add(Character character);
    }
}
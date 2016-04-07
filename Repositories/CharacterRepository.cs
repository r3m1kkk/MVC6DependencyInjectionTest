using System.Collections.Generic;
using System.Linq;
using MyWebApp.Interfaces;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CharacterRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Character> ListAll()
        {
            return _dbContext.Characters.AsEnumerable();
        }

        public void Add(Character character)
        {
            _dbContext.Characters.Add(character);
            _dbContext.SaveChanges();
        }
    }
}
﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDSA2018.Lecture06.Models
{
    public interface ICharacterRepository
    {
        Task<int> CreateAsync(CharacterCreateUpdateDTO character);

        Task<CharacterDTO> FindAsync(int characterId);

        IQueryable<CharacterDTO> Read();

        Task<bool> UpdateAsync(CharacterCreateUpdateDTO character);

        Task<bool> DeleteAsync(int characterId);
    }
}

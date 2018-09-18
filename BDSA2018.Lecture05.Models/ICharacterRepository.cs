﻿using BDSA2018.Lecture05.Models;
using System;
using System.Collections.Generic;

namespace BDSA2018.Lecture05.Models
{
    public interface ICharacterRepository : IDisposable
    {
        int Create(CharacterCreateUpdateDTO character);

        CharacterDTO Find(int characterId);

        ICollection<CharacterDTO> Read();

        void Update(CharacterCreateUpdateDTO character);

        bool Delete(int characterId);
    }
}

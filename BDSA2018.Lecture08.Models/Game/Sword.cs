﻿namespace BDSA2018.Lecture08.Models.Game
{
    public class Sword : IWeapon
    {
        public string Name => nameof(Sword);

        public int Damage => 32;

        public int Range => 0;
    }
}

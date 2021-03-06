﻿using BDSA2018.Lecture10.Shared;
using System.Linq;
using System.Threading.Tasks;

namespace BDSA2018.Lecture10.Services
{
    public interface IActorRepository
    {
        Task<ActorDetailedDTO> CreateAsync(ActorCreateUpdateDTO actor);

        Task<ActorDetailedDTO> FindAsync(int actorId);

        IQueryable<ActorDTO> Read();

        Task<bool> UpdateAsync(ActorCreateUpdateDTO actor);

        Task<bool> DeleteAsync(int actorId);
    }
}

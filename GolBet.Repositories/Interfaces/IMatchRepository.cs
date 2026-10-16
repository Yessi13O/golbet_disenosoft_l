// GolBet.Repositories/Interfaces/IMatchRepository.cs
using GolBet.Entities;
using GolBet.Entities.Enums;

namespace GolBet.Repositories.Interfaces;

public interface IMatchRepository : IGenericRepository<Match>
{
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null, string? search = null);//Change"1
    Task<Match?> GetByIdWithDetailsAsync(int id);
}


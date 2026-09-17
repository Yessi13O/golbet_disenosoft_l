// GolBet.Services/Mapping/MappingProfile.cs
using AutoMapper;
using GolBet.Entities;
using GolBet.Services.DTOs;

namespace GolBet.Services.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Match, MatchDto>();

        // GolBet.Services/Mapping/MappingProfile.cs  (agregar dentro del constructor)
        CreateMap<Match, MatchDetailDto>()
            .ForMember(dto => dto.TotalBets, //Destino
                       options => options.MapFrom(match => match.Bets.Count));//Origen

    }
}

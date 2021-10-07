using AutoMapper;
using CoinOnion.Entities;
using CoinOnion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion
{
    public class CryptocurrencyMappingProfile : Profile
    {
        public CryptocurrencyMappingProfile()
        {
            CreateMap<Cryptocurrency, CryptocurrencyDto>()
                .ForMember(m => m.ContractAddress, c => c.MapFrom(s => s.Info.ContractAddress))
                .ForMember(m => m.WebSite, c => c.MapFrom(s => s.Info.WebSite));

            CreateMap<Comment, CommentDto>();
        }
            
    }
}

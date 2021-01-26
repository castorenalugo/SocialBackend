using System;
using AutoMapper;
using Backend.Domain.DTOs;
using Backend.Domain.Entities;

namespace Backend.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();
        }
    }
}

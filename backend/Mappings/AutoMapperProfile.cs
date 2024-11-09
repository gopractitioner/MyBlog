// Mappings/AutoMapperProfile.cs
using AutoMapper;
using backend.Models;


public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Post, PostDto>()
            .ForMember(dst => dst.AuthorName, opt => opt.MapFrom(src => src.Author.Username))
            .ForMember(dst => dst.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

        CreateMap<CreatePostDto, Post>();
        CreateMap<UpdatePostDto, Post>();
    }
}
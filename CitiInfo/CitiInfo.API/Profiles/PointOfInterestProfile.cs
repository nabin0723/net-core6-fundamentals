﻿using AutoMapper;

namespace CitiInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestCreationDto, Entities.PointOfInterest>();
            CreateMap<Models.PointOfInterestUpdateDto, Entities.PointOfInterest>();
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestUpdateDto>();
            
        }
    }
}

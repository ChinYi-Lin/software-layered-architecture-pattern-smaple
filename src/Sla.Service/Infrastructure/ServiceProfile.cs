﻿using AutoMapper;
using Sla.Repository.Dtos;
using Sla.Repository.Enities;

namespace Sla.Service.Infrastructure
{
    /// <summary>
    /// Class ServiceProfile.
    /// Implements the <see cref="AutoMapper.Profile" />
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ServiceProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProfile"/> class.
        /// </summary>
        public ServiceProfile()
        {
            this.CreateMap<QueryFooDto, QueryFoo>();
            this.CreateMap<Foo, FooDto>();
        }
    }
}
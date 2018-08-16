using AutoMapper;
using ProjectExercise.Core;
using ProjectExercise.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectExercise.Web.Helper.Infrastructure
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<BaseEntity, BaseEntityViewModel>().ReverseMap();
                cfg.CreateMap<Contact, ContactViewModel>().ReverseMap();
                cfg.CreateMap<ProjectUser, ProjectUserViewModel>().ReverseMap();
            });

            Mapper.AssertConfigurationIsValid();
        }
    }
}

// <summary>
// <copyright file="AutoMapperProfile.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessEntity.Services.Mapping
{
    using AutoMapper;
    using Axity.DataAccessEntity.Dtos.User;
    using Axity.DataAccessEntity.Entities.Model;
    using Axity.DataAccessEntity.Entities.Model.Rols;
    using Axity.DataAccessEntity.Entities.Model.User;
    using System.Linq;

    /// <summary>
    /// Class Automapper.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMapperProfile"/> class.
        /// </summary>
        public AutoMapperProfile()
        {
            this.CreateMap<UserRolModel, RolUserDto>();
            this.CreateMap<RolModel, RolDto>();

            this.CreateMap<UserModel, UserDto>()
                .ForMember(e => e.Status, opt => opt.MapFrom(src => src.Status ? "Activo" : "Incativo"))
                .ForMember(e => e.Rols, opt => opt.MapFrom(src => src.UserRol.Select(e => e.Rol)));
            this.CreateMap<UserDto, UserModel>()
                .ForMember(e => e.Status, opt => opt.MapFrom(src => src.Status.Equals("Activo") ? true : false));

        }
    }
}
﻿using AutoMapper;
using Identity.Application.Models.Authentications;
using Identity.Application.Models.Enums;
using Identity.Application.Responses;
using Identity.Domain.Entities.Authentications;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Application.Features.Queries.Authentications.GetUser
{
    public class GetUserByEmailAndPasswordQueryHandler : IRequestHandler<GetUserByEmailAndPasswordQuery, ServiceResponse<UserModel>>
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<Role> _roleManager;

        public GetUserByEmailAndPasswordQueryHandler(UserManager<User> userManager,
                 RoleManager<Role> roleManager,
                 IMapper mapper
                 )
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public async Task<ServiceResponse<UserModel>> Handle(GetUserByEmailAndPasswordQuery request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Email == request.Email);
            if (user is null)
            {
                return null;
            }

            var userModel = _mapper.Map<UserModel>(user);

            var userSigninResult = await _userManager.CheckPasswordAsync(user, request.Password);

            if (userSigninResult)
            {
                userModel.Roles = await _userManager.GetRolesAsync(user);
            }
            else
            {
                return null;
            }

            var response = new ServiceResponse<UserModel>(ResultTypeEnum.Success, "", userModel);

            return response;
        }
    }
}

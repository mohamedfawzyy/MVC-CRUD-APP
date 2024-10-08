﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MVC.DAL.Models;
using MVC.PL.Models;

namespace MVC.PL.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() {

            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
            CreateMap<ApplicationUser, UserViewModel>().
                ForMember(d=>d.FName,o=>o.MapFrom(s=>s.FirstName))
                .ForMember(d=>d.LName,o=>o.MapFrom(s=>s.LastName)).ReverseMap();
            CreateMap<IdentityRole,RoleViewModel>()
                .ForMember(d=>d.RoleName,o=>o.MapFrom(s=>s.Name)).ReverseMap();
                
        }
    }
}

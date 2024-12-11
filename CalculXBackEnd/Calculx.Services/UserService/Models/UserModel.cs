using AutoMapper;
using CalculX.Base.Enums;
using CalculX.Base.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;
using UserService.Enum;

namespace UserService.Models
{
    public class UserModel:IMapBoth<User>
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public required string Address { get; set; }
        public Status Status { get; set; }
        public AuthProvider AuthProvider { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserModel, User>().ReverseMap();
        }
    }

}

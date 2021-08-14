﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class UserService
    {
        public static List<UserModel> GetAllUsers()
        {
            var users = UserRepo.GetAllUsers();
            return AutoMapper.Mapper.Map<List<User>, List<UserModel>>(users);
        }
    }
}
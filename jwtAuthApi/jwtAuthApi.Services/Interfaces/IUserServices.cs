﻿using System;
using System.Collections.Generic;
using System.Text;
using jwtAuthApi.Domain.Entities;
using jwtAuthApi.Domain.ViewModel;

namespace jwtAuthApi.Services.Interfaces
{
    public interface IUserServices
    {
        string Auth(UserModel userModel);
    }
}

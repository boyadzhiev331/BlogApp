using BlogApp.Models.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Services
{
    public interface ITokenService
    {
        public string CreateToken(ApplicationUserIdentity user);
    }
}

using DemoApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.Service.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<UserMasters> WithoutPasswords(this IEnumerable<UserMasters> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static UserMasters WithoutPassword(this UserMasters user)
        {
            user.Password = null;
            return user;
        }
    }
}

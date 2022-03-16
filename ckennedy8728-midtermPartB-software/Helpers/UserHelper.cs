using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ckennedy8728_midtermPartB_software.Helpers
{
    public class UserHelper
    {
        //saving the player's name 
        public static void SavePlayerName(HttpContext context, string userName)
        {
            context.Session.SetString("userName", userName);
        }

        public static string GetPlayerName(HttpContext context)
        {
            return context.Session.GetString("userName");
        }
    }
}

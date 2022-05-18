using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.Login
{
    internal class LoggedUser
    {   
        public static int UserId { get; set; } 
        public static string Username { get; set; }

        public static bool IsAdmin { get; set; }
    }
}

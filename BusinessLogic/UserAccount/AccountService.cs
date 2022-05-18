using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using ArtefactsManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.Login;

namespace ArtefactsManager.BusinessLogic.UserAccount
{
    public class AccountService
    {
        private readonly UserDAO userDAO;

        public AccountService()
        {
            userDAO = new UserDAO();
        }
        public bool validate(string password, string confirmation)
        {
            if (password == confirmation && password != "" && confirmation != "")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool Save(string password)
        {
            try
            {
                User user = userDAO.GetById(LoggedUser.UserId);
                user.Password = Encryption.ComputeMd5Hash(password);
                userDAO.Update(user);
                userDAO.Save();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}

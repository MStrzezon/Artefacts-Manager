using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data.Models;
using ArtefactsManager.BusinessLogic.DAO;
using System.Data;

namespace ArtefactsManager.BusinessLogic
{
    public class UsersManagementService
    {
        private readonly UserDAO userDAO;

        public UsersManagementService()
        {
            userDAO = new UserDAO();
        }

        public DataTable loadUsers()
        {
            List<User> users = userDAO.GetAll().ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id").ReadOnly = true;
            dataTable.Columns.Add("Username").ReadOnly = true;
            dataTable.Columns.Add("Role").ReadOnly= true;

            DataRow tmp;
            foreach (User user in users)
            {
                tmp = dataTable.NewRow();
                tmp["Id"] = user.UserId;
                tmp["Username"] = user.Username;
                if (user.Role != null)
                {
                    tmp["Role"] = user.Role.RoleName;
                } else
                {
                    tmp["Role"] = "----------";
                }
                dataTable.Rows.Add(tmp);
            }
            return dataTable;
        }


    }
}

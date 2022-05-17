using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtefactsManager.BusinessLogic
{
    public class AddEditService
    {
        private readonly CategoryDAO categoryDAO;
        private readonly ArtefactTypeDAO artefactTypeDAO;
        private readonly RoleDAO roleDAO;
        private readonly PermissionDAO permissionDAO;
        Role role;

        public AddEditService()
        {
            categoryDAO = new CategoryDAO();
            artefactTypeDAO = new ArtefactTypeDAO();
            roleDAO = new RoleDAO();
            permissionDAO = new PermissionDAO();
            role = new Role();
        }

        public IEnumerable<Category> getCategories()
        {
            return categoryDAO.GetAll();
        }

        public IEnumerable<ArtefactType> getArtefactsTypes()
        {
            return artefactTypeDAO.GetAll();
        }

        public Role getRole(int roleId)
        {
            role = roleDAO.GetById(roleId);
            return role;
        }

        public bool updateRole(DataGridViewRowCollection rows)
        {
            Permission permissionToAdd;
            try
            {
                foreach (Permission permission in getPermissions(rows))
                {
                    if (!ifExist(permission))
                    {
                        role.rolePermissions.Add(new RolePermission { Role = role, Permission = permission });

                    }
                    else
                    {
                        permissionToAdd = getPermission(permission);
                        role.rolePermissions.Add(new RolePermission { Role = role, Permission = permissionToAdd });
                    }
                }
                roleDAO.Save();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool addRole(string name, DataGridViewRowCollection rows)
        {
            try
            {
                role = new Role { RoleName = name, rolePermissions = new List<RolePermission>() };
                roleDAO.Insert(role);
                updateRole(rows);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public IEnumerable<Permission> getPermissions(DataGridViewRowCollection rows)
        {
            List<Permission> permissions = new List<Permission>();
            foreach (DataGridViewRow row in rows)
            {
                permissions.Add(new Permission { CategoryName = row.Cells[0].Value.ToString(), TypeName = row.Cells[1].Value.ToString(), Visible = Convert.ToBoolean(row.Cells[2].Value), Editable = Convert.ToBoolean(row.Cells[3].Value), CanAdd = Convert.ToBoolean(row.Cells[4].Value) });
            }
            return permissions;
        }

        private bool ifExist(Permission permission)
        {
            if (permissionDAO.GetByAttributes(permission.CategoryName, permission.TypeName, permission.Visible, permission.Editable, permission.CanAdd) != null)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private Permission getPermission(Permission permission)
        {
            return permissionDAO.GetByAttributes(permission.CategoryName, permission.TypeName, permission.Visible, permission.Editable, permission.CanAdd);
        } 
    }
}

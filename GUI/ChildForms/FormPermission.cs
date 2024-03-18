using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.ChildForms
{
    public partial class FormPermission : Form
    {
        PermissionBLL perBll = new PermissionBLL();
        List<Role> roles = new List<Role>();
        List<Permission> permissions = new List<Permission>();

        public FormPermission()
        {
            InitializeComponent();
        }

        private void FormPermission_Load(object sender, EventArgs e)
        {
            this.roles = perBll.getRoles();
            this.permissions = perBll.getPermissions();

            foreach (Permission per in this.permissions)
            {
                lstFull.Items.Add(per.sCode);
            }

            foreach (Role role in this.roles)
            {
                lstRole.Items.Add(role.sName);
            }
        }

        private void lstRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTextBoxRoleError.Text = "";

            string selectedRole = lstRole.Text;

            txtRole.Text = selectedRole;

            foreach (Role role in this.roles)
            {
                if (role.sName == selectedRole)
                {
                    lstRolePer.Items.Clear();
                    lstFull.Items.Clear();

                    foreach (Permission per in role.sPermission)
                    {
                        lstRolePer.Items.Add(per.sCode);
                    }

                    bool check = true;

                    foreach (Permission per in this.permissions)
                    {
                        check = true;

                        foreach (Permission per2 in role.sPermission)
                        {
                            if (per.sCode == per2.sCode)
                            {
                                check = false;

                                break;
                            }
                        }

                        if (check)
                        {
                            lstFull.Items.Add(per.sCode);
                        }
                    }

                    break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role role = new Role();

            role.sName = txtRole.Text;

            if(role.sName != "")
            {
                bool res = this.perBll.addRole(role);

                if (res)
                {
                    lstRole.Items.Add(role.sName);

                    lblTextBoxRoleError.Text = "";

                    this.roles.Add(role);
                }
                else
                {
                    lblTextBoxRoleError.Text = "Role existed !";
                }
            }
            else
            {
                lblTextBoxRoleError.Text = "Role name can not null !";
            }
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            lblTextBoxRoleError.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Role role = new Role();

            role.sName = txtRole.Text;

            if(role.sName != "")
            {
                bool res = this.perBll.removeRole(role);

                if (res)
                {
                    lstRole.Items.Remove(role.sName);

                    lblTextBoxRoleError.Text = "";

                    foreach(Role item in this.roles)
                    {
                        if(item.sName == role.sName)
                        {
                            this.roles.Remove(item);

                            break;
                        }
                    }
                }
                else
                {
                    lblTextBoxRoleError.Text = "Role have a references from user !";
                }
            }
            else
            {
                lblTextBoxRoleError.Text = "Role name can not null !";
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string roleName = lstRole.Text;
            string perCode = lstFull.Text;

            Permission per = new Permission(perCode);

            if (roleName != null && perCode != "")
            {
                this.perBll.addRolePer(roleName, perCode);

                lstFull.Items.Remove(perCode);
                lstRolePer.Items.Add(perCode);

                foreach(Role item in this.roles)
                {
                    if(item.sName == roleName)
                    {
                        item.sPermission.Add(per);

                        break;
                    }
                }
            }
        }

        private void btnRemovePerOfRole_Click(object sender, EventArgs e)
        {
            string roleName = lstRole.Text;
            string perCode = lstRolePer.Text;

            Permission per = new Permission(perCode);

            if (roleName != null && perCode != "")
            {
                this.perBll.removeRolePer(roleName, perCode);

                lstRolePer.Items.Remove(perCode);
                lstFull.Items.Add(perCode);

                foreach (Role item in this.roles)
                {
                    if (item.sName == roleName)
                    {
                        foreach(Permission perItem in item.sPermission)
                        {
                            if(perItem.sCode == perCode)
                            {
                                item.sPermission.Remove(perItem);

                                break;
                            }
                        }

                        break;
                    }
                }
            }
        }
    }
}

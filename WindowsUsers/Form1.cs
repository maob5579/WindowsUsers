using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Additional libraries
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Management;
using System.Security.AccessControl;

namespace WindowsUsers
{
    public partial class Form1 : Form
    {
        bool onNextLogon = false;
        bool canChangePass = false;
        bool passNeverExpires = false;
        bool accDisabled = false;
        bool selectedUser = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            try
            {
                lstUsers.Items.Clear();

                //Creating a query to retrieve users/
                SelectQuery query = new SelectQuery("Win32_UserAccount", "Domain='" + Environment.MachineName + "'");
                ManagementObjectSearcher objSearcher = new ManagementObjectSearcher(query); //retriecin objects (user account in our case)

                foreach (var item in objSearcher.Get()) //iterating through the elements
                {
                    lstUsers.Items.Add(item["Name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); //if we get an error
            }
            btnDeleteUser.Enabled = true;
        }

        private void chkPasswordOnLogon_CheckedChanged(object sender, EventArgs e)
        {
            onNextLogon = chkPasswordOnLogon.Checked;
        }

        private void chkCannotChangePass_CheckedChanged(object sender, EventArgs e)
        {
            canChangePass = chkCannotChangePass.Checked;
        }

        private void chkAccDisabled_CheckedChanged(object sender, EventArgs e)
        {
            accDisabled = chkAccDisabled.Checked;
        }

        private void chkNeverExpires_CheckedChanged(object sender, EventArgs e)
        {
            passNeverExpires = chkNeverExpires.Checked;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Machine, Environment.MachineName);
                UserPrincipal user = new UserPrincipal(context);

                user.Name = txtUsername.Text;
                user.SetPassword(txtPassword.Text);

                if (onNextLogon) //If user must change passwordo next logon
                {
                    user.ExpirePasswordNow(); //manually expire password
                }

                //setting user parameters
                user.PasswordNeverExpires = passNeverExpires;
                user.Enabled = !accDisabled; //enabled by default.
                user.UserCannotChangePassword = canChangePass;
                user.Save(); //saving the user

                //We have to add the user to the user group
                GroupPrincipal group = GroupPrincipal.FindByIdentity(context, "Users");
                group.Members.Add(user); //adding the user to the group
                MessageBox.Show("User created");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUser) //if user was selected
            {
                try
                {
                    DirectoryEntry host = new DirectoryEntry("WinNT://" + Environment.MachineName);
                    DirectoryEntries entries = host.Children;
                    DirectoryEntry user = entries.Find(lstUsers.SelectedItem.ToString());

                    entries.Remove(user); //deleting user

                    MessageBox.Show("User deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex != -1) //if any element in the list box was selected
            {
                selectedUser = true;
            }
        }
    }
}

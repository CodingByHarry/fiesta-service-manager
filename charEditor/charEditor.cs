using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class charEditor : Form
    {
        public charEditor()
        {
            InitializeComponent();
        }

        bool loggedIn = false;
        string username, password = "";
        string serverUrl = "http://fiesta.codingbyharry.com/";

        string characterName;

        private void serviceManagerBtn_Click(object sender, EventArgs e)
        {
            Process.Start("serviceManager.exe");
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            
            characterName = charNameField.Text;
            
            if(characterName == "")
            {
                MessageBox.Show("You didn't enter a character name");
                return;
            }

            if (loggedIn != true)
            {
                MessageBox.Show("Your not logged in?");
                return;
            }
            /*
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                HttpResponseMessage response = await client.GetAsync("api/CharacterEditor?command=charDetails&characterName=" + characterName + "&username="  + username + " & password=" + password);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    if (result == "\"login\"")
                    {

                    }
                }
            }
            */

            editingTxt.Text = "You are now editing: " + characterName;

        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (characterName == "")
            {
                MessageBox.Show("You didn't enter a character name");
                return;
            }

            if (loggedIn != true)
            {
                MessageBox.Show("Your not logged in?");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                HttpResponseMessage response = await client.GetAsync("api/CharacterEditor?command=charDetails&characterName=" + characterName + "&username=" + username + " & password=" + password);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    if (result == "\"login\"")
                    {

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            username = usernameField.Text;
            password = passwordField.Text;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                HttpResponseMessage response = await client.GetAsync("api/WindowService?command=logincheck&serviceName=Account&username=" + username + "&password=" + password);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    if (result == "\"login\"")
                    {

                        usernameField.Enabled = false;
                        passwordField.Enabled = false;
                        loginBtn.Enabled = false;
                        usernameTxt.Enabled = false;
                        passwordTxt.Enabled = false;

                        loggedIn = true;

                        infoTxt.ForeColor = System.Drawing.Color.Green;
                        infoTxt.Text = "Logged in";

                        charNameTxt.Visible = true;
                        charNameField.Visible = true;
                        searchBtn.Visible = true;
                        charInfo.Visible = true;

                    }
                    else
                    {
                        infoTxt.Text = "Wrong login details";
                        infoTxt.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("error: unsuccesful web response");
                }
            }
        } 



    }
}

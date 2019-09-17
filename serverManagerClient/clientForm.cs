using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace serverManagerClient
{
    public partial class clientForm : Form
    {

        bool loggedIn = false;
        string username, password;
        string serverUrl = "http://fiesta.codingbyharry.com/";

        string licenseNumber = "LICENSE";
        bool licensed = false;

        public clientForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            logBox.AppendText("You need to login before you can do anything" + Environment.NewLine);
            logBox.AppendText("To avoid excessive stress on the server, the status of the services only updates every 30 seconds." + Environment.NewLine);

            /* LICENSING
             * Unfortunate need to license my work :(
             * Hello you sad cunt that has actually bothered to decompile my stuff to get around my licensing lol.
            */

            string licenseFile = Application.StartupPath + @"\license.txt";

            if (!File.Exists(licenseFile))
            {
                var newLicenseFile = File.Create(licenseFile);
                newLicenseFile.Close();
                File.AppendAllText(licenseFile, "[License]\r\nLICENSE"
                                               );
                newLicenseFile.Close();
            }

            string[] license = File.ReadAllLines(licenseFile);

            licenseNumber = license[1];
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers["Content-Type"] = "application/json;charset=UTF-8";
                    string s = client.DownloadString("http://codingbyharry.com/licensing/servicemanager/clientlicense.php?licenseNumber=" + licenseNumber);
                    if (s == "success")
                    {
                        licenseTxt.Text = "Licensed";
                        licenseTxt.ForeColor = System.Drawing.Color.Green;
                        licensed = true;
                    }
                    else
                    {
                        licenseTxt.Text = "Unlicensed";
                        licenseTxt.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error loading licensing information. Please restart the application or contact Harry if the issue continues.");
                licenseTxt.Text = "Unlicensed";
                licenseTxt.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Status.ToString());
            }
            /*
             * END LICENSING 
             * 
            */


            //Check sedrvices status
        }

        private async void startAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void stopAllBtn_Click(object sender, EventArgs e)
        {
            logBox.Text += "\r\nSending request to STOP ALL services";
        }

        private void restartAllBtn_Click(object sender, EventArgs e)
        {
            logBox.Text += "\r\nSending request to RESTART ALL services";
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            string serviceName = serviceList.Text;

            if (serviceName == "")
            {
                infoTxt.Text = "You didnt select a service!";
            } else
            {
                if (loggedIn == true)
                {
                    logBox.AppendText("Sending request to START " + serviceName + Environment.NewLine);

                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(serverUrl);
                        HttpResponseMessage response = await client.GetAsync("api/WindowService?command=start&serviceName=" + serviceName + "&username=" + username + "&password=" + password);
                        if (response.IsSuccessStatusCode)
                        {
                            string result = await response.Content.ReadAsStringAsync();
                            logBox.AppendText(result + Environment.NewLine);
                        }
                    }
                }
                else
                {
                    infoTxt.Text = "Login first";
                }
            }
        }

        private async void stopBtn_Click(object sender, EventArgs e)
        {
            string serviceName = serviceList.Text;

            if (serviceName == "")
            {
                infoTxt.Text = "You didnt select a service!";
            }
            else
            {
                if (loggedIn == true)
                {
                    logBox.AppendText("Sending request to STOP " + serviceName + Environment.NewLine);

                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(serverUrl);
                        HttpResponseMessage response = await client.GetAsync("api/WindowService?command=stop&serviceName=" + serviceName + "&username=" + username + "&password=" + password);
                        if (response.IsSuccessStatusCode)
                        {
                            string result = await response.Content.ReadAsStringAsync();
                            logBox.AppendText(result + Environment.NewLine);
                        }
                    }
                }
                else
                {
                    infoTxt.Text = "Login first";
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if(loggedIn == false)
            {
                MessageBox.Show("You're not logged in.");
                return;
            } 

            serviceStatusCheck("Account", accountStatusTxt);
            serviceStatusCheck("AccountLog", accountLogStatusTxt);
            serviceStatusCheck("Character", characterStatusTxt);
            serviceStatusCheck("GameLog", gamelogStatusTxt);
            serviceStatusCheck("Login", loginStatusTxt);
            serviceStatusCheck("WorldManager", worldManagerStatusTxt);
            serviceStatusCheck("Zone0", zone0StatusTxt);
            serviceStatusCheck("Zone1", zone1StatusTxt);
            serviceStatusCheck("Zone2", zone2StatusTxt);
            serviceStatusCheck("Zone3", zone3StatusTxt);
        }

        public async void serviceStatusCheck(string serviceName, Label labelName)
        {

            if (loggedIn == false)
            {
                MessageBox.Show("You're not logged in.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                HttpResponseMessage response = await client.GetAsync("api/WindowService?command=status&serviceName=" + serviceName + "&username=" + username + "&password=" + password);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    result = result.ToString();
                    if (result == "\"running\"")
                    {
                        labelName.Text = "Running";
                        labelName.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (result == "\"stopped\"")
                    {
                        labelName.Text = "Stopped";
                        labelName.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        labelName.Text = "Error";
                        labelName.ForeColor = System.Drawing.Color.DarkOrange;
                    }
                    logBox.AppendText(serviceName + result + Environment.NewLine);
                }
                
            }
            System.Threading.Thread.Sleep(1000);
        }

        private async void refreshStatus_Click(object sender, EventArgs e)
        {
            string serviceName = serviceList.Text;
            if (serviceName == "")
            {
                infoTxt.Text = "You didnt select a service!";
            }
            else
            {
                if (loggedIn == true)
                {
                    switch (serviceName)
                    {
                        case "Account":
                            serviceStatusCheck("Account", accountStatusTxt);
                            break;

                        case "AccountLog":
                            serviceStatusCheck("AccountLog", accountLogStatusTxt);
                            break;

                        case "Character":
                            serviceStatusCheck("Character", characterStatusTxt);
                            break;

                        case "GameLog":
                            serviceStatusCheck("GameLog", gamelogStatusTxt);
                            break;

                        case "Login":
                            serviceStatusCheck("Login", loginStatusTxt);
                            break;

                        case "WorldManager":
                            serviceStatusCheck("WorldManager", worldManagerStatusTxt);
                            break;

                        case "Zone0":
                            serviceStatusCheck("Zone0", zone0StatusTxt);
                            break;

                        case "Zone1":
                            serviceStatusCheck("Zone1", zone1StatusTxt);
                            break;

                        case "Zone2":
                            serviceStatusCheck("Zone2", zone2StatusTxt);
                            break;

                        case "Zone3":
                            serviceStatusCheck("Zone3", zone3StatusTxt);
                            break;
                    }
                }
                else
                {
                    infoTxt.Text = "Login first";
                }
            }
        }

        private async void charEditBtn_Click(object sender, EventArgs e)
        {
            Process.Start("charEditor.exe");
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

                        logBox.AppendText("Logged in as " + username + " - everything you do is logged!" + Environment.NewLine);

                        usernameField.Visible = false;
                        passwordField.Visible = false;
                        loginBtn.Visible = false;
                        usernameTxt.Visible = false;
                        passwordTxt.Visible = false;

                        loggedIn = true;

                        infoTxt.ForeColor = System.Drawing.Color.Green;
                        infoTxt.Text = "Logged in";

                        startBtn.Enabled = true;
                        stopBtn.Enabled = true;
                        tempRefreshBtn.Enabled = true;
                        refreshStatus.Enabled = true;

                        logBox.Height = 154;

                        //Simulate the refresh all button click event
                        tempRefreshBtn.PerformClick();

                        //Get the services list and add to the combobox

                    } else
                    {
                        logBox.AppendText("Wrong login details");
                    }
                } else
                {
                    MessageBox.Show("error: unsuccesful web response");
                }
            }

        }
    }
}

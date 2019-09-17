using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace OnlineServiceManager
{
    public partial class serverForm : Form
    {

        bool acceptingRestarts = true;
        public string accountService, accountLogService, characterService, gameLogService, 
               loginService, worldManagerService, zone0Service, zone1Service, zone2Service, zone3Service, zone4Service;

        string licenseIP = "IP", licenseNumber = "LICENSE";
        bool licensed = false;

        public serverForm()
        {
            InitializeComponent();
        }

        private void closeUserPanelBtn_Click(object sender, EventArgs e)
        {
            userEditPanel.Visible = false;
            infoTxt.Text = "";
        }

        private void serviceStatusCheck_Tick(object sender, EventArgs e)
        {
            checkServices();
        }

        public void InitTimer()
        {
            //Start timer to check the service status
            serviceStatusCheck = new Timer();
            serviceStatusCheck.Tick += new EventHandler(serviceStatusCheck_Tick);
            serviceStatusCheck.Interval = 2000; // in miliseconds
            serviceStatusCheck.Start();
        }

        private void usersEditBtn_Click(object sender, EventArgs e)
        {
            if(licensed == true)
            {
                userEditPanel.Visible = true;
                infoTxt.Text = "This currently does nothing. Still a work in progress.";
            } else
            {
                infoTxt.Text = "License is invalid.";
            }
        }

        private void serverForm_Load(object sender, EventArgs e)
        {
            //Make a config/services file if it doesnt already exist
            string configFile = Application.StartupPath + @"\services.txt";

            string licenseFile = Application.StartupPath + @"\license.txt";

            if (!File.Exists(configFile))
            {
                var newConfigFile = File.Create(configFile);
                newConfigFile.Close();
                File.AppendAllText(configFile, "[Account Service]\r\nAccount\r\n" +
                                               "[AccountLog Service]\r\nAccountLog\r\n" +
                                               "[Character Service]\r\nCharacter\r\n" +
                                               "[GameLog Service]\r\nGameLog\r\n" +
                                               "[Login Service]\r\nLogin\r\n" +
                                               "[WorldManager Service]\r\nWorldManager\r\n" +
                                               "[Zone0 Service]\r\nZone0\r\n" +
                                               "[Zone1 Service]\r\nZone1\r\n" +
                                               "[Zone2 Service]\r\nZone2\r\n" +
                                               "[Zone3 Service]\r\nZone3\r\n" +
                                               "[Zone4 Service]\r\nZone4"
                                               );
                newConfigFile.Close();
            }

            
            if (!File.Exists(licenseFile))
            {
                var newLicenseFile = File.Create(licenseFile);
                newLicenseFile.Close();
                File.AppendAllText(licenseFile, "[IP]\r\n127.0.0.1\r\n" +
                                               "[License]\r\nLICENSE\r\n"
                                               );
                newLicenseFile.Close();
            }

            //Read the config files
            string[] license = File.ReadAllLines(licenseFile);
            string[] services = File.ReadAllLines(configFile);

            //Unfortunate need to license my work :(
            //Hello you sad cunt that has actually bothered to decompile my stuff to get around my licensing lol.

            licenseIP = license[1];
            licenseNumber = license[3];

            if (licenseIP != GetLocalIPAddress())
            {
                MessageBox.Show("Your license IP address is incorrect. " + GetLocalIPAddress() + " " + licenseIP);
                return;
            }

            try
            {
                using (WebClient client = new WebClient())
                {
                    string s = client.DownloadString("http://codingbyharry.com/licensing/servicemanager/license.php?licenseIP=" + licenseIP + "&licenseNumber=" + licenseNumber);
                    if (s == "success")
                    {
                        licenseTxt.Text = "Licensed";
                        licenseTxt.ForeColor = System.Drawing.Color.Green;
                        licensed = true;
                    }
                    else
                    {
                        licenseTxt.Text = "Not Licensed - Functionality disabled. Reason: " + s;
                        licenseTxt.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error loading licensing information. Please restart the application or contact Harry if the issue continues.");
            }

            //Read all of the service names
            accountService = services[1];
            accountLogService = services[3];
            characterService = services[5];
            gameLogService = services[7];
            loginService = services[9];
            worldManagerService = services[11];
            zone0Service = services[13];
            zone1Service = services[15];
            zone2Service = services[17];
            zone3Service = services[19];
            zone4Service = services[21];

            //Add service names to the Combobox
            serviceList.Items.Clear(); // Make sure there is no shit in there first.
            serviceList.Items.Add(accountService);
            serviceList.Items.Add(accountLogService);
            serviceList.Items.Add(characterService);
            serviceList.Items.Add(gameLogService);
            serviceList.Items.Add(loginService);
            serviceList.Items.Add(worldManagerService);
            serviceList.Items.Add(zone0Service);
            serviceList.Items.Add(zone1Service);
            serviceList.Items.Add(zone2Service);
            serviceList.Items.Add(zone3Service);
            serviceList.Items.Add(zone4Service);

            //Make sure the services are all correct so it doesn't crash

            //Comment out for testing

            /*
            if (!(ServiceClass.serviceExists(accountService)) || !(ServiceClass.serviceExists(accountLogService)) || !(ServiceClass.serviceExists(characterService)) || !(ServiceClass.serviceExists(gameLogService)) || !(ServiceClass.serviceExists(loginService)) || !(ServiceClass.serviceExists(worldManagerService)) || !(ServiceClass.serviceExists(zone0Service)) || !(ServiceClass.serviceExists(zone1Service)) || !(ServiceClass.serviceExists(zone2Service)) | !(ServiceClass.serviceExists(zone3Service)) || !(ServiceClass.serviceExists(zone4Service)))
            {
                MessageBox.Show("One of the services doesnt exist. Check the services.txt config and make sure it matches your services name then restart this application.");
                return;
            }
            

            InitTimer();
            checkServices();

            */

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void actionCommand(string serviceName, string action, string user)
        {
            if(licensed == false)
            {
                MessageBox.Show("Licensing error");
                return;
            }

            if (acceptingRestarts == true)
            {
                // Restart/Stop/Start particular service
                if (action == "RESTARTALL")
                {
                    //Restart all
                    if ((ServiceClass.serviceExists(accountService)) && (ServiceClass.serviceExists(accountLogService)) && (ServiceClass.serviceExists(characterService)) && (ServiceClass.serviceExists(gameLogService)) && (ServiceClass.serviceExists(loginService)) && (ServiceClass.serviceExists(worldManagerService)) && (ServiceClass.serviceExists(zone0Service)) && (ServiceClass.serviceExists(zone1Service)) && (ServiceClass.serviceExists(zone2Service)) && (ServiceClass.serviceExists(zone3Service)))
                    {
                        ServiceClass.rebootService(accountService);
                        ServiceClass.rebootService(accountLogService);
                        ServiceClass.rebootService(characterService);
                        ServiceClass.rebootService(gameLogService);
                        ServiceClass.rebootService(loginService);
                        ServiceClass.rebootService(worldManagerService);
                        ServiceClass.rebootService(zone0Service);
                        ServiceClass.rebootService(zone1Service);
                        ServiceClass.rebootService(zone2Service);
                        ServiceClass.rebootService(zone3Service);
                        ServiceClass.rebootService(zone4Service);
                    }
                    else
                    {
                        MessageBox.Show("Service doesnt exist.");
                        logBox.Text += "\r\nERROR: Service doesnt exist. Caused by: " + user + " ACTION:" + action;
                        return;
                    }
                }
                else if (action == "STOPALL")
                {
                    //Stop all
                    if ((ServiceClass.serviceExists(accountService)) && (ServiceClass.serviceExists(accountLogService)) && (ServiceClass.serviceExists(characterService)) && (ServiceClass.serviceExists(gameLogService)) && (ServiceClass.serviceExists(loginService)) && (ServiceClass.serviceExists(worldManagerService)) && (ServiceClass.serviceExists(zone0Service)) && (ServiceClass.serviceExists(zone1Service)) && (ServiceClass.serviceExists(zone2Service)) && (ServiceClass.serviceExists(zone3Service)))
                    {
                        ServiceClass.stopService(accountService);
                        ServiceClass.stopService(accountLogService);
                        ServiceClass.stopService(loginService);
                        ServiceClass.stopService(gameLogService);
                        ServiceClass.stopService(characterService);
                        ServiceClass.stopService(worldManagerService);
                        ServiceClass.stopService(zone0Service);
                        ServiceClass.stopService(zone1Service);
                        ServiceClass.stopService(zone2Service);
                        ServiceClass.stopService(zone3Service);
                        ServiceClass.stopService(zone4Service);
                    }
                    else
                    {
                        MessageBox.Show("Service doesnt exist.");
                        logBox.Text += "\r\nERROR: Service doesnt exist. Caused by: " + user + " ACTION:" + action;
                        return;
                    }
                }
                else if (action == "STARTALL")
                {
                    //Start all
                    if ((ServiceClass.serviceExists(accountService)) && (ServiceClass.serviceExists(accountLogService)) && (ServiceClass.serviceExists(characterService)) && (ServiceClass.serviceExists(gameLogService)) && (ServiceClass.serviceExists(loginService)) && (ServiceClass.serviceExists(worldManagerService)) && (ServiceClass.serviceExists(zone0Service)) && (ServiceClass.serviceExists(zone1Service)) && (ServiceClass.serviceExists(zone2Service)) && (ServiceClass.serviceExists(zone3Service)))
                    {
                        ServiceClass.startService(accountService);
                        ServiceClass.startService(accountLogService);
                        ServiceClass.startService(loginService);
                        ServiceClass.startService(gameLogService);
                        ServiceClass.startService(characterService);
                        ServiceClass.startService(worldManagerService);
                        ServiceClass.startService(zone0Service);
                        ServiceClass.startService(zone1Service);
                        ServiceClass.startService(zone2Service);
                        ServiceClass.startService(zone3Service);
                        ServiceClass.startService(zone4Service);
                    } else
                    {
                        MessageBox.Show("Service doesnt exist.");
                        logBox.Text += "\r\nERROR: Service doesnt exist. Caused by: " + user + " ACTION:" + action;
                        return;
                    }
                }
                else if (action == "STOP")
                {
                    if (ServiceClass.serviceExists(serviceName))
                    {
                        ServiceClass.stopService(serviceName);
                    }
                    else
                    {
                        MessageBox.Show("Service doesnt exist");
                        logBox.Text += "\r\nERROR: Service doesnt exist. Caused by: " + user + " ACTION:" + action + " SERVICE: " + serviceName;
                        return;
                    }
                }
                else if (action == "START")
                {
                    if (ServiceClass.serviceExists(serviceName))
                    {
                        ServiceClass.startService(serviceName);
                    }
                    else
                    {
                        MessageBox.Show("Service doesnt exist");
                        logBox.Text += "\r\nERROR: Service doesnt exist. Caused by: " + user + " ACTION:" + action + " SERVICE: " + serviceName;
                        return;
                    }
                }
                else if (action == "RESTART")
                {
                    if (ServiceClass.serviceExists(serviceName))
                    {
                        ServiceClass.rebootService(serviceName);
                    }
                    else
                    {
                        MessageBox.Show("Service doesnt exist");
                        logBox.Text += "\r\nERROR: Service doesnt exist. Caused by: " + user + " ACTION:" + action + " SERVICE: " + serviceName;
                        return;
                    }
                }

                logBox.Text += "\r\n" + user + " has executed command " + action + " on service " + serviceName;

            } else if (acceptingRestarts == false)
            {
                infoTxt.Text = "Restarts are not currently allowed.";
                logBox.Text += "\r\n" + user + " tried to execute " + action + " on service " + serviceName + " while restarts were set to NOT ALLOW";
                return;
            } else
            {
                infoTxt.Text = "Error executing command.";
                logBox.Text += "\r\n" + user + " tried to execute " + action + " on service " + serviceName + " but an error occured.";
                return;
            }
        }

        private void restartToggleBtn_Click(object sender, EventArgs e)
        {

            if((acceptingRestarts == true) && (licensed == true))
            {
                statusTxt.Text = "Accepting Restarts: No";
                acceptingRestarts = false;
            } else if (acceptingRestarts == false)
            {
                statusTxt.Text = "Accepting Restarts: Yes";
                acceptingRestarts = true;
            } else
            {
                statusTxt.Text = "License is invalid.";
            }

        }

        private void startAllBtn_Click(object sender, EventArgs e)
        {
            string serviceName = "ALL";
            string action = "STARTALL";
            string user = "LOCAL SERVER";
            actionCommand(serviceName, action, user);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            string serviceName = serviceList.Text;
            string action = "START";
            string user = "LOCAL SERVER";

            if (serviceName == "")
            {
                MessageBox.Show("You didnt select a service.");
            }
            else
            {
                actionCommand(serviceName, action, user);
            }

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            string serviceName = serviceList.Text;
            string action = "STOP";
            string user = "LOCAL SERVER";

            if (serviceName == "")
            {
                MessageBox.Show("You didnt select a service.");
            } else
            {
                actionCommand(serviceName, action, user);
            }
        }

        private void restartAllBtn_Click(object sender, EventArgs e)
        {
            string serviceName = "ALL";
            string action = "RESTARTALL";
            string user = "LOCAL SERVER";
            actionCommand(serviceName, action, user);
        }

        private void stopAllBtn_Click(object sender, EventArgs e)
        {
            string serviceName = "ALL";
            string action = "STOPALL";
            string user = "LOCAL SERVER";
            actionCommand(serviceName, action, user);
        }

        public void checkServices()
        {
            ServiceController sc = new ServiceController();

            sc.ServiceName = accountService;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                accountStatusTxt.Text = "Stopped";
                accountStatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                accountStatusTxt.Text = "Started";
                accountStatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                accountStatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = accountLogService;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                accountLogStatusTxt.Text = "Stopped";
                accountLogStatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                accountLogStatusTxt.Text = "Started";
                accountLogStatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                accountLogStatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = characterService;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                characterStatusTxt.Text = "Stopped";
                characterStatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                characterStatusTxt.Text = "Started";
                characterStatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                characterStatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = gameLogService;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                gamelogStatusTxt.Text = "Stopped";
                gamelogStatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                gamelogStatusTxt.Text = "Started";
                gamelogStatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                gamelogStatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = loginService;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                loginStatusTxt.Text = "Stopped";
                loginStatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                loginStatusTxt.Text = "Started";
                loginStatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                loginStatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = worldManagerService;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                worldManagerStatusTxt.Text = "Stopped";
                worldManagerStatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                worldManagerStatusTxt.Text = "Started";
                worldManagerStatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                worldManagerStatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = zone0Service;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                zone0StatusTxt.Text = "Stopped";
                zone0StatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                zone0StatusTxt.Text = "Started";
                zone0StatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                zone0StatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = zone1Service;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                zone1StatusTxt.Text = "Stopped";
                zone1StatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                zone1StatusTxt.Text = "Started";
                zone1StatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                zone1StatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = zone2Service;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                zone2StatusTxt.Text = "Stopped";
                zone2StatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                zone2StatusTxt.Text = "Started";
                zone2StatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                zone2StatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = zone3Service;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                zone3StatusTxt.Text = "Stopped";
                zone3StatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                zone3StatusTxt.Text = "Started";
                zone3StatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                zone3StatusTxt.Text = "Starting or Stopping";
            }

            sc.ServiceName = zone4Service;

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                zone4StatusTxt.Text = "Stopped";
                zone4StatusTxt.ForeColor = System.Drawing.Color.Red;
            }
            else if (sc.Status == ServiceControllerStatus.Running)
            {
                zone4StatusTxt.Text = "Started";
                zone4StatusTxt.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                zone4StatusTxt.Text = "Starting or Stopping";
            }
        }
    }
}

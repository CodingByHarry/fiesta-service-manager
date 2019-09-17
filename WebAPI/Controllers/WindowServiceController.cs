using OnlineServiceManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceProcess;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class WindowServiceController : ApiController
    {
        // GET: api/WindowService
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WindowService?command=start&serviceName=ed&username=ed&password=ed
        public string Get([FromUri] string command, [FromUri] string serviceName, [FromUri] string username, [FromUri] string password)
        {
            // Will need to check and make sure the service name isnt something dodgy.

            ServiceController serviceController = new ServiceController(serviceName);
            try
            {
                int timeoutMilliseconds = 1000;

                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                DatabaseClass.logAction(username, serviceName, command);

                if (DatabaseClass.checkUser(username, password)) {
                    if (command == "start")
                    {
                        ServiceClass.startService(serviceName);
                        return "started";
                    }
                    else if (command == "stop")
                    {
                        ServiceClass.stopService(serviceName);
                        return "stopped";
                    } else if (command == "restart") {
                        ServiceClass.rebootService(serviceName);
                        return "restarted";
                    }
                    else if (command == "status")
                    {

                        if (ServiceClass.serviceIsRunning(serviceName))
                        {
                            return "running";
                        } else
                        {
                            return "stopped";
                        }
                        
                        
                    } else if (command == "logincheck")
                    {
                        serviceName = "Login";
                        return "login";

                    }

                } else
                {
                    return "Wrong Login Details";

                }
              //  serviceController.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch
            {
                // ...
            }

            //return string.Empty;
            return "Bad Service/Commad";
        }

            // POST: api/WindowService/start/servicename
            // api/WindowsService/stop
            public void Post([FromBody]string value)
        {
        }

        // PUT: api/WindowService/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WindowService/5
        public void Delete(int id)
        {
        }
    }
}

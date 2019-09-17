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
    public class CharacterEditor : ApiController
    {
        // GET: api/WindowService
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CharacteREditor?command=start&characterName=ed&username=ed&password=ed
        public string Get([FromUri] string command, [FromUri] string characterName, [FromUri] string username, [FromUri] string password)
        {           
            try
            {
                int timeoutMilliseconds = 1000;

                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                DatabaseClass.logAction(username, characterName, command);

                if (DatabaseClass.checkUser(username, password)) {
                    if (command == "charDetails")
                    {
                        DatabaseClass.getCharInfo(characterName);
                        return "started";
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

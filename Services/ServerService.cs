using Services.Contracts;
using Services.Models;
using System.Collections.Generic;
using System.Linq;
using Data.Models;
using Data.Contacts;

namespace Services
{
    public class ServerService : IServerService
    {
        private readonly IEfDbSetWrapper<Server> serverSetWrapper;

        public ServerService(IEfDbSetWrapper<Server> serverSetWrapper)
        {
            this.serverSetWrapper = serverSetWrapper;
        }

        public IEnumerable<ServerModel> GetAll()
        {
            return new List<ServerModel> { new ServerModel() { Id = new System.Guid() } };
        }
    }
}

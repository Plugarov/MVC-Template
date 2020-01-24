using Services.Models;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IServerService
    {
        IEnumerable<ServerModel> GetAll();
    }
}

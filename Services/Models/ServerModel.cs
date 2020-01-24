using System;
using System.Linq.Expressions;
using Data.Models;

namespace Services.Models
{
    public class ServerModel
    {
        public Guid Id { get; set; }

        public DateTime DateTimeCreated { get; set; }

        public static Expression<Func<Server, ServerModel>> Create
        {
            get
            {
                return server => new ServerModel()
                {
                    Id = server.Id,
                    DateTimeCreated = server.DateTimeCreated
                };
            }
        }
    }
}

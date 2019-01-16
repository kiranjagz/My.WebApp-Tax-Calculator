using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Consumer.ForMongo
{
    public interface IMongoRepository
    {
        Task<bool> SaveAsync(object message);
    }
}

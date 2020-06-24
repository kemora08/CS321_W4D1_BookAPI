using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W4D1_BookAPI.Services
{
    public interface IPublisherService
    {
        Publisher Add(Publisher Publisher);

        Publisher Get(int id);

        IEnumerable<Publisher> GetAll();

        Publisher Update(Publisher updatedPublisher);

        void Remove(Publisher Publisher);
    }
}

using System.Collections.Generic;
using DB.Models;

namespace Services.Interfaces
{
    public interface IUserRepository
    {
        public List<User> Get();
        
        public void Add(User user);
        
        public void Update(User user);
        
        public void Remove(User user);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LectureRegistrationSystem.Data.Models;

namespace LectureRegistrationSystem.Data.Repos
{
    public interface IUserRepo
    {
        User GetByUsername(string username);
        List<User> Get();
        void Add(User user);
    }
}

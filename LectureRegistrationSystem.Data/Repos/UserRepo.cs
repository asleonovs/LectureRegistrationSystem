using System.Collections.Generic;
using System.Linq;
using LectureRegistrationSystem.Data.Models;

namespace LectureRegistrationSystem.Data.Repos
{
    public class UserRepo : IUserRepo
    {
        public User GetByUsername(string username)
        {
            using (var db = new LectureRegistrationSystemDbContext())
            {
                return db.Users
                    .FirstOrDefault(u => u.Username == username);
            }
        }

        public List<User> Get()
        {
            using (var db = new LectureRegistrationSystemDbContext())
            {
                return db.Users
                    .ToList();
            }
        }

        public void Add(User user)
        {
            using (var db = new LectureRegistrationSystemDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}

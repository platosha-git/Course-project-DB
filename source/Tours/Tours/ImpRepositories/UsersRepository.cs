using System;
using System.Collections.Generic;
using System.Linq;
using Tours.Repositories;
using Serilog.Core;

namespace Tours.ImpRepositories
{
    public class UsersRepository : IUsersRepository, IDisposable
    {
        private readonly ToursContext db;
        private readonly Logger logger;

        public UsersRepository(ToursContext createDB, Logger logDB)
        {
            db = createDB;
            logger = logDB;
        }

        public List<User> FindAll()
        {
            return db.Users.ToList();
        }

        public User FindByID(int id)
        {
            return db.Users.Find(id);
        }

        public void Add(User obj)
        {
            try
            {
                obj.Userid = db.Users.Count() + 1;
                db.Users.Add(obj);
                db.SaveChanges();
                logger.Information("+UsersRep : User {Number} was added to Users", obj.Userid);
            }
            catch (Exception err)
            {
                logger.Error(err.Message, "+UsersRep : Error trying to add user to Users");
            }
        }

        public void Update(User obj)
        {
            try
            {
                db.Users.Update(obj);
                db.SaveChanges();
                logger.Information("+UsersRep : User {Number} was updated at Users", obj.Userid);
            }
            catch (Exception err)
            {
                logger.Error(err.Message, "+UsersRep : Error trying to update user at Users");
            }
        }

        public void DeleteAll()
        {
            try
            {
                List<User> allUsers = FindAll();
                db.Users.RemoveRange(allUsers);
                db.SaveChanges();
                logger.Information("+UsersRep : All users were deleted from Users");
            }
            catch (Exception err)
            {
                logger.Error(err.Message, "+UsersRep : Error trying to delete all users from Users");
            }
        }

        public void DeleteByID(int id)
        {
            try
            {
                User user = FindByID(id);
                db.Users.Remove(user);
                db.SaveChanges();
                logger.Information("+UsersRep : User {Number} was deleted from Users");
            }
            catch (Exception err)
            {
                logger.Error(err.Message, "+UsersRep : Error trying to delete user {Number} from Users", id);
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

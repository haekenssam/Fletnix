using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fletnix.Repositories
{
    public class UserprofileRepository : IRepository<Userprofile>
    {
        public bool Create(Userprofile item)
        {
            try
            {
                var context = new FletnixContext();
                context.Userprofiles.Add(item);
                context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool Delete(Userprofile item)
        {
            try
            {
                var context = new FletnixContext();
                context.Userprofiles.Remove(item);
                context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IList<Userprofile> Get()
        {
            var context = new FletnixContext();
            return context.Userprofiles.ToList();
        }

        public Userprofile GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Userprofile item)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDAL;

namespace VisitorBL
{
    public class VisitorManagementBL
    {
        private VisitorManagementEntities db = new VisitorManagementEntities();
        public IList<Visitor> GetVisitorList()
        {
            try
            {
                return db.Visitors.ToList();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Visitor getVisitorById(int id)
        {
            try
            {
                if (id > 0)
                {
                    Visitor visitor = db.Visitors.Find(id);
                    if (visitor != null)
                    {
                        return visitor;
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
            return null;
        }

        public Visitor AddEditVisitor(Visitor visitor)
        {
            try
            {
                if (visitor.VisitorId > 0)
                {
                    db.Entry(visitor).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    db.Visitors.Add(visitor);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            { throw ex; }
            return null;
        }

        public Visitor DeleteVisitor(int id)
        {
            try
            {
                Visitor visitor = db.Visitors.Find(id);
                db.Visitors.Remove(visitor);
                db.SaveChanges();
            }
            catch (Exception ex)
            { throw ex; }
            return null;
        }

    }
}

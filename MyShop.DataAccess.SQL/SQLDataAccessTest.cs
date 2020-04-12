using MyShop.Core.Contracts;
using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.SQL
{
    public class SQLDataAccessTest<Product> : IRepository<Product> where Product : BaseEntity
    {
        public IQueryable<Product> Collection()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public Product Find(string Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product t)
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }
    }
}

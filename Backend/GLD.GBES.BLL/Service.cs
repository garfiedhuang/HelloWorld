using System;
using GLD.GBES.Contract;
using System.Collections.Generic;
using GLD.GBES.Models;
using GLD.GBES.IDAL;
using System.Linq.Expressions;
using GLD.GBES.Common;
using GLD.GBES.WCFExtension;

namespace GLD.GBES.BLL
{
    public class Service : IService
    {
        public IDAO dao;
        
        public Service()
        {
            //Need to inject dynamic later
            this.dao = new GLD.GBES.DAL.DAO();
        }

        public PagedList<Product> GetProducts(int pageSize, int pageIndex, int categoryId = 0)
        {
            //Test WCFContext
            var context = WCFContext.Current.Operater;
            
            return this.dao.FindAllByPage<Product, int>(p => categoryId == 0 ? true : p.CategoryId == categoryId, p => p.Id, pageSize, pageIndex);
        }
    }
}

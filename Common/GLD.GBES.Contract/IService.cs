using System;
using System.ServiceModel;
using System.Collections.Generic;
using GLD.GBES.Models;
using GLD.GBES.Common;

namespace GLD.GBES.Contract
{
    [ServiceContract]
    public interface IService
    {   
        [OperationContract(IsOneWay = false)]
        PagedList<Product> GetProducts(int pageSize, int pageIndex, int categoryId = 0);
    }
}

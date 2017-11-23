using System;
using GLD.GBES.Contract;
using GLD.GBES.BLL;

namespace GLD.GBES.WCFClientProxy
{
    public class RefServiceFactory : IServiceFactory
    {
        public IService CreateService()
        {
            return new Service();
        }
    }
}

using System;
using GLD.GBES.Contract;

namespace GLD.GBES.WCFClientProxy
{
    public  interface IServiceFactory
    {
        IService CreateService();
    }
}

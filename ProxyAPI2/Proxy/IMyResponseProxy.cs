using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyAPI2.Proxy
{
    public interface IMyResponseProxy
    {
        ApiModel.MyResponse getMyResponse(int userId);
    }
}

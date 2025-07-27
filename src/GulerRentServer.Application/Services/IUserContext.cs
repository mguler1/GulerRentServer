using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulerRentServer.Application.Services
{
    public interface IUserContext
    {
        Guid GetUserId();
    }
}

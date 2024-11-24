
using Kursobaya.Storage.DataBase;
using Kursobaya.Storage.Models;

namespace Kursobaya.Storage.Repository
{
    public class DetailRepository
    {
        public Guid AddToDataBase(MyDbContext context,Detail detail)
        {
            context.Details.Add(detail);
            return detail.DetailCode;
        }

    }
}

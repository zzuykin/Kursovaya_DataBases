using Kursobaya.Storage.DataBase;
using Kursobaya.Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace Kursobaya.Storage.Repository
{
    public class UnitRepository
    {
        public Guid AddToDataBase(MyDbContext context, Unit unit)
        {
            context.Units.Add(unit);
            return unit.UnitCode;
        }

        public Unit GetUnitById(MyDbContext context,Guid id)
        {
            var unit = context.Units.FirstOrDefault(x => x.UnitCode == id)
                ?? throw new Exception($"Нет такого узла с id: {id}");
            return unit;
        }

        public List<Guid> GetAllUnitsCodes(MyDbContext context)
        {
            var list = context.Units.Select(x => x.UnitCode).ToList();
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairEquipment.scripts
{
    /// <summary>
    /// Внос данных таблицы
    /// </summary>
    public class FirmModelItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Model}";
        }
    }
}

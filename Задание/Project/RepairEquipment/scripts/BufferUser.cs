using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairEquipment.scripts
{
    /// <summary>
    /// Хранение временных данных пользователя
    /// </summary>
    class BufferUser
    {
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string Middlename { get; set; }
        public static int Role { get; set; }
    }
}

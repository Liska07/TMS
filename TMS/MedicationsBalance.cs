using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    internal class MedicationsBalance
    {
        public Dictionary<string, int> MedicsBalance;
        
        public MedicationsBalance()
        {
            MedicsBalance = new Dictionary<string, int>()
            {
                {"Супракс", 13},
                {"Стрепсилс", 3},
                {"Тонзилгон", 4},
                {"Анаферон", 7},
                {"Снуп", 0},
                {"Назонекс", 20}
            };
        }
        int minQuantity = 10;
       
        public Dictionary<string, int> GetMedToOrder()
        {
            Dictionary<string, int> ListToOrder =
                MedicsBalance
                    .Where(a => a.Value < minQuantity)
                    .Select(a => new KeyValuePair<string, int>(a.Key,minQuantity - a.Value))
                    .ToDictionary();

            return ListToOrder;
        }
    }
}

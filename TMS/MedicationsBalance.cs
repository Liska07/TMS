using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public class MedicationsBalance
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
       
        public Dictionary<string, int> GetMedToOrder()
        {
            int minBalance = 10;
            int stock = 5;
            Dictionary<string, int> ListToOrder =
                MedicsBalance
                    .Where(a => a.Value < minBalance)
                    .Select(a => new KeyValuePair<string, int>(a.Key,minBalance - a.Value + stock))
                    .ToDictionary();

            return ListToOrder;
        }
    }
}

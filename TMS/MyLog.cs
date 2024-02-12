using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public static class MyLog
    {
        const string Path = "C:\\Users\\Liska\\Desktop\\LiskaLog.txt";
      
        public static void LogException(Exception ex)
        {
            File.AppendAllText(Path, DateTime.Now + $" Исключение: {ex.Message}" + Environment.NewLine);
            File.AppendAllText(Path, DateTime.Now + $" Трассировка стека: {ex.StackTrace}" + Environment.NewLine + Environment.NewLine);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    internal static class MyLog
    {
        const string Path = "C:\\Users\\Liska\\Desktop\\LiskaLog.txt";
      
        public static void LogException(Exception ex)
        {
            File.AppendAllText(Path, $"Исключение: {ex.Message}" + Environment.NewLine);
            File.AppendAllText(Path, $"Трассировка стека: {ex.StackTrace}" + Environment.NewLine + Environment.NewLine);
        }
    }
}

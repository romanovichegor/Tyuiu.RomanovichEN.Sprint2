﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RomanovichEN.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth;
            switch (m)
            {
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10: 
                case 12: 
                    daysInMonth = 31;
                    break;
                case 4: 
                case 6: 
                case 9:
                case 11: 
                    daysInMonth = 30;
                    break;
                case 2:
                       
                    if ((g % 4 == 0 && g % 100 != 0) || (g % 400 == 0))
                        daysInMonth = 29; 
                    else
                        daysInMonth = 28; 
                    break;
                default:
                    throw new ArgumentException("Некорректный месяц");
            }
            n += 1;            
            if (n > daysInMonth)
            {
                n = 1;
                m += 1;
                
                if (m > 12)
                {
                    m = 1; 
                    g += 1; 
                }
            }
            string date = $"0{n}.0{m}.{g}";
            return date;
        }
    }
}

﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RomanovichEN.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            string res;
            switch(n % 12)
            {
                case 0:
                    res = "Январь";
                    break;
                case 1:
                    res = "Февраль";
                    break;
                case 2:
                    res = "Март";
                    break;
                case 3:
                    res = "Апрель";
                    break;
                case 4:
                    res = "Май";
                    break;
                case 5:
                    res = "Июнь";
                    break;
                case 6:
                    res = "Июль";
                    break;
                case 7:
                    res = "Август";
                    break;
                case 8:
                    res = "Сентябрь";
                    break;
                case 9:
                    res = "Октябрь";
                    break;
                case 10:
                    res = "Ноябрь";
                    break;
                case 11:
                    res = "Декабрь";
                    break;
                default: throw new ArgumentException("Месяц должен быть положительным числом");
                
            }
            return res;
        }
    }
}

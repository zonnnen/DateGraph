using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Date 
{
    //поле, где храняться все дни недели под нужными индексами
    private readonly List<string> DaysWeek = new List<string> { "Суббота", "Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница" };

    //данные о дате
    private byte _day;
    private byte _month;
    private int _year;
    private byte DayOfTheWeek;


    //Год
    public int Year
    {
        get => this._year;
        set
        {
            if (value > 0) this._year = value;
            else throw new ArgumentException("Неверно указан год");
        }

    }

    //Месяц
    public byte Month
    {
        get => this._month;
        set
        {
            if (value > 0 & value <= 12) this._month = value;
            else throw new ArgumentException("Неверно указан месяц");
        }
    }

    //День
    public byte Day
    {
        get => this._day;
        set
        {
            if (value > 0 & value <= MonthDays) this._day = value;
            else throw new ArgumentException("Неверно указан день месяца");
        }
    }

    //Пустой конструктор
    public Date() {}

    //Конструктор с начальными значениями
    public Date(byte day, byte month, int year)
    {
        Year = year;
        Month = month;
        Day = day;

        SetDayOfTheWeek(day, month, year);
    }

    //Добавление дня, месяца и года к дате
    public void PlusDate(uint day, uint month, uint year)
    {
        Year += (int)year;
        JoinMonths((int)month);
        JoinDays((int)day);
        SetDayOfTheWeek(Day, Month, Year);
    }

    //Прибавление месяца к дате
    private void JoinMonths(int month)
    {
        if (Month + month > 12)
        {
            Year += (Month + month) / 12;
            Month = (byte)((Month + month) % 12);
        }
        else Month += (byte)month;

    }

    //Прибавление дней к дате
    private void JoinDays(int days)
    {
        while (days + Day > MonthDays)
        {
            days -= MonthDays - Day + 1;
            Day = 1;
            JoinMonths(1);
        }
        Day += (byte)days;
    }

    //проверка кол-ва дней в месяце _month года _year
    private byte CheckMonthDays()
    {
        byte d;
        if ((_month == 2) & CheckLeapYear(_year)) d = 29;
        else
        {
            d = (byte)(28 + (_month + (byte)(_month / 8)) % 2 + 2 % _month + 2 * (byte)(1 / _month));
        }

        return d;
    }

    //свойство, выводящее кол-во дней в месяце 
    public byte MonthDays
    {
        get => CheckMonthDays();
    }

    //Проверка на високосный год
    private bool CheckLeapYear(int year)
    {
        return ((year % 4 == 0 | year % 400 == 0) & (year % 100 != 0));
    }

    //определение дня недели по дате
    private void SetDayOfTheWeek(byte day, byte month, int year)
    {
        byte m = month;
        if (month == 1 | month == 2)
        {
            m = (byte)(month + 12);
            --year;
        }
        DayOfTheWeek = (byte)Math.Abs((day + 13 * (m + 1) / 5 +
            (year % 100) + (year % 100) / 4 + (year / 400) - 2 * (year / 100)) % 7);
    }

    //Вывод всех данных по объекту
    public string GetDate
    {
        get
        {
            return (_day.ToString("00") + "." + _month.ToString("00") + "." + _year.ToString("") + " - " + DaysWeek[DayOfTheWeek]);
        }
    }
}
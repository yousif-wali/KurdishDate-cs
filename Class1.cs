using System;
using System.Collections.Generic;

namespace KurdishDate
{
    public static class KurdishDateConverter
    {
        private static readonly List<string> KurdishMonths = new List<string>
        {
            "نەوروز", "گوڵان", "جۆزەردان", "پوشپەڕ", "گەلاوێژ",
            "خەرمانان", "ڕەزبەر", "گەڵاڕێزان", "سەرماوەرز", 
            "بەفرانبار", "ڕیبەندان", "ڕەشەمێ"
        };

        public static string GetDate()
        {
            return ConvertGregorianToKurdish(DateTime.Now);
        }

        public static string ConvertGregorianToKurdish(DateTime gregorianDate)
        {
            int year = gregorianDate.Year;
            bool isLeapYear = DateTime.IsLeapYear(year);
            int totalDays = isLeapYear ? 366 : 365;

            int firstSixMonths = 31;
            int seventhToEleventh = 30;
            int twelveth = isLeapYear ? 30 : 29;

            DateTime kurdishDateStart = new DateTime(year, 3, 21);
            TimeSpan daysDifference = gregorianDate - kurdishDateStart;

            int calculateDate;
            if (daysDifference.Days < 0)
            {
                calculateDate = totalDays - Math.Abs(daysDifference.Days);
            }
            else
            {
                calculateDate = daysDifference.Days;
            }

            int month = 0;
            bool found = false;
            while (!found)
            {
                if (month <= 5 && (calculateDate - firstSixMonths) > 0)
                {
                    calculateDate -= firstSixMonths;
                    month++;
                }
                else if (month >= 6 && month < 11 && (calculateDate - seventhToEleventh) > 0)
                {
                    calculateDate -= seventhToEleventh;
                    month++;
                }
                else if (month == 11 && (calculateDate - twelveth) > 0)
                {
                    calculateDate -= twelveth;
                    month++;
                }

                if (calculateDate <= 29)
                {
                    found = true;
                }
            }

            int kurdishYear = year;
            if (month > 9 || month < 2)
            {
                kurdishYear += 700;
            }
            else
            {
                kurdishYear += 699;
            }

            return $"{kurdishYear}, {calculateDate} {KurdishMonths[month]}";
        }
    }
}

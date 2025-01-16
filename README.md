
# KurdishDate

A library to convert Gregorian dates to Kurdish dates.

## Description

The `KurdishDate` library provides functionality to convert Gregorian calendar dates to the Kurdish calendar, which originates in Mesopotamia (modern-day Kurdistan region, located in northern Iraq). The Kurdish calendar starts from 700 B.C. on March 21st and is used among many people in the Middle East. Each month has a specific name and corresponds to a season-specific event.

## Installation

You can install the package via NuGet:

```sh
dotnet add package KurdishDate
```

## Usage

To use the `KurdishDate` library, simply import the namespace and call the `KurdishDateConverter` class methods:

```csharp
using System;
using KurdishDate;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(KurdishDateConverter.GetDate());
    }
}
```

### Methods

- `GetDate()`: Returns the current date in the Kurdish calendar.
- `ConvertGregorianToKurdish(DateTime gregorianDate)`: Converts a given Gregorian date to the Kurdish date.

### Example

```csharp
using System;
using KurdishDate;

class Program
{
    static void Main(string[] args)
    {
        // Get the current Kurdish date
        string currentKurdishDate = KurdishDateConverter.GetDate();
        Console.WriteLine($"Current Kurdish Date: {currentKurdishDate}");

        // Convert a specific Gregorian date to Kurdish date
        DateTime specificGregorianDate = new DateTime(2024, 6, 5);
        string specificKurdishDate = KurdishDateConverter.ConvertGregorianToKurdish(specificGregorianDate);
        Console.WriteLine($"Specific Kurdish Date: {specificKurdishDate}");
    }
}
```

## Kurdish Months

The Kurdish calendar months have specific names:

1. نەوروز (Newroz) - "New Day"
2. گوڵان (Gulan) - "Flowers are blooming"
3. جۆزەردان (Jozardan) - "Wheats are turning into yellow color"
4. پوشپەڕ (Pushpar) - "When winds blow leaves off in a hot day"
5. گەلاوێژ (Galawezh) - "A 'Galawezh' star will appear in this month"
6. خەرمانان (Kharmanan) - "Harvesting month"
7. ڕەزبەر (Razbar) - "Vegetables and fruits growth rate increases"
8. گەڵاڕێزان (Gala rezan) - "Falling leaves"
9. سەرماوەرز (Sarma warz) - "Cold season"
10. بەفرانبار (Bafranbar) - "Usually snows in this month in Mesopotamia region"
11. ڕیبەندان (Rebandan) - "Roads and streets are blocked due to heavy rains and snow"
12. ڕەشەمێ (Rashame) - "Sun gets so hot that tanning process rate increases"

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Authors

- Yousif Wali

## Contributing

If you would like to contribute, please fork the repository and use a feature branch. Pull requests are welcome.

## Acknowledgements

Thanks to the creators and maintainers of the Kurdish calendar and the contributors to this project.

namespace ClassCitylibrary;

public class City
{
    private string title;
    private int countOfPeople;
    private double square;
    private int counOfSights;
    private double priceOfDayLiving;

    public City()
    {
        title = "";
        countOfPeople = 0;
        square = 0;
        counOfSights = 0;
        priceOfDayLiving = 0;
    }

    public City(string CityTitle, int People, double CitySquare, int Sights, double PriceOfDayLiving)
    {
        title = CityTitle;
        countOfPeople = People;
        square = CitySquare;
        counOfSights = Sights;
        priceOfDayLiving = PriceOfDayLiving;
    }
    public virtual double PeoplePerSquareKilometer(double countOfPeople, double squareOfCity)
    {
        if (squareOfCity == 0)
        {
            return 0;
        }
        return Math.Ceiling(countOfPeople / squareOfCity);
    }

    public double DaysToVisitCity(double counOfSights, double canVisitPerDay)
    {
        if (canVisitPerDay == 0)
        {
            return 0;
        }
        return Math.Ceiling(counOfSights / canVisitPerDay);
    }

    static bool IsPositiveNumber(double value)
    {
        bool isRight = false;
        if (value >= 0)
        {
            isRight = true;
        }
        return isRight;
    }

    public string Title
    {
        get { return title; }
        set
        {
            try
            {
                if (value.Length != 0)
                {
                    title = value;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public int CountOfPeople
    {
        get { return countOfPeople; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) countOfPeople = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public double Square
    {
        get { return square; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) square = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public int CounOfSights
    {
        get { return counOfSights; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) counOfSights = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public double PriceOfDayLiving
    {
        get { return priceOfDayLiving; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) priceOfDayLiving = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    // public struct CityInfo
    // {
    //     public string title;
    //     public double square;
    //     public double peoplePerSquareKilometer;
    // }

    public virtual string Info()
    {
        // CityInfo info = new CityInfo();
        // info.title = title;
        // info.square = square;
        // info.peoplePerSquareKilometer = PeoplePerSquareKilometer(countOfPeople, square);
        //Console.OutputEncoding = System.Text.Encoding.UTF8;

        return "Название: " + title + ", площадь: " + square + ", человек на квадратный метр: " + PeoplePerSquareKilometer(countOfPeople, square) + ".";
    }
}

public class Tourist(string Name, double Money, int СanVisitSightsPerDay)
{
    private string name = Name;
    private double money = Money;
    private int canVisitSightsPerDay = СanVisitSightsPerDay;

    static bool IsPositiveNumber(double value)
    {
        bool isRight = false;
        if (value >= 0)
        {
            isRight = true;
        }
        return isRight;
    }

    public string Name
    {
        get { return name; }
        set
        {
            try
            {
                if (value.Length != 0)
                {
                    name = value;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public double Money
    {
        get { return money; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) money = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public int CanVisitPerDay
    {
        get { return canVisitSightsPerDay; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) canVisitSightsPerDay = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

}

public class Capital : City
{
    public Capital(string governmentAddress, int countVisitors,
        string CityTitle, int People, double CitySquare, int Sights, double PriceOfDayLiving)
    {
        this.governmentAddress = governmentAddress;
        this.countVisitors = countVisitors;
        this.Title = CityTitle;
        this.CountOfPeople = People;
        this.Square = CitySquare;
        this.CounOfSights = Sights;
        this.PriceOfDayLiving = PriceOfDayLiving;
    }

    public Capital()
    {
        this.governmentAddress = "";
        this.countVisitors = 0;
    }

    static bool IsPositiveNumber(double value)
    {
        bool isRight = false;
        if (value >= 0)
        {
            isRight = true;
        }
        return isRight;
    }

    public override double PeoplePerSquareKilometer(double countOfPeople, double squareOfCity)
    {
        if (squareOfCity == 0)
        {
            return 0;
        }
        return Math.Ceiling((countOfPeople + countVisitors) / squareOfCity);
    }

    private string governmentAddress;
    private int countVisitors;

    public string GovernmentAddress
    {
        get { return governmentAddress; }
        set
        {
            try
            {
                if (value.Length != 0)
                {
                    governmentAddress = value;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public int CountVisitors
    {
        get { return countVisitors; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) countVisitors = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public override string Info()
    {        
        return "Название: " + Title + ", адрес правительства: " + GovernmentAddress + ", число человек: " + CountVisitors + ".";
    }
}

public class PortCity : City
{
    public PortCity()
    {
        portSquare = 0;
    }

    public PortCity(double portSquare,
        string CityTitle, int People, double CitySquare, int Sights, double PriceOfDayLiving)
    {
        this.portSquare = portSquare;
        this.Title = CityTitle;
        this.CountOfPeople = People;
        this.Square = CitySquare;
        this.CounOfSights = Sights;
        this.PriceOfDayLiving = PriceOfDayLiving;
    }

    static bool IsPositiveNumber(double value)
    {
        bool isRight = false;
        if (value >= 0)
        {
            isRight = true;
        }
        return isRight;
    }

    public double GetOnlyCitySquare(double value)
    {
        return Square - portSquare;
    }

    private double portSquare;

    public double PortSquare
    {
        get { return portSquare; }
        set
        {
            try
            {
                if (IsPositiveNumber(value)) portSquare = value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    public override string Info()
    {        
        return "Название: " + Title + ", площадь: " + Square + ".";
    }

}
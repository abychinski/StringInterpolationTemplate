using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date2 = _date.Now.ToString("yyyy.MM.dd");
        var answer2 = $"{date2}";
        Console.WriteLine(answer2);

        return answer2;
    }   

    public string Number03()
    {
        var year = _date.Now.ToString("yyyy");
        var month = _date.Now.ToString("MMMM");
        var day = _date.Now.ToString("dd");
        var answer = $"Day {day} of {month}, {year}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var year = _date.Now.ToString("yyyy");
        var month = _date.Now.ToString("MM");
        var day = _date.Now.ToString("dd");
        var answer = $"Year: {year}, Month: {month}, Day: {day}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        
        var day = _date.Now.ToString("dddd");
        var answer = $"{day}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        throw new NotImplementedException();
    }

    public string Number07()
    {
        throw new NotImplementedException();
    }

    public string Number08()
    {
        throw new NotImplementedException();
    }

    public string Number09()
    {
        throw new NotImplementedException();
    }

    public string Number10()
    {
        throw new NotImplementedException();
    }

    public string Number11()
    {
        throw new NotImplementedException();
    }

    //2.2019.01.22
}

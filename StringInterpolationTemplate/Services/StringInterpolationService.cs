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
        var answer = $"{day,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var time = _date.Now.ToString("t");
    
        var day = _date.Now.ToString("dddd");
        var answer = $"{time,10}{day,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var hour = _date.Now.ToString("hh");
        var min = _date.Now.ToString("mm");
        var sec = _date.Now.ToString("ss");
        var answer = $"h:{hour}, m:{min}, s:{sec}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number08()
    {
        var year = _date.Now.ToString("yyyy");
        var month = _date.Now.ToString("MM");
        var day = _date.Now.ToString("dd");
        var hour = _date.Now.ToString("hh");
        var min = _date.Now.ToString("mm");
        var sec = _date.Now.ToString("ss");
        var answer = $"{year}.{month}.{day}.{hour}.{min}.{sec}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;

        var answer = $"{pi:C}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;

        var answer = $"{pi,10:n3}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number11()
    {
        var year = _date.Now.ToString("yyyy");
        var month = _date.Now.ToString("MMMM");
        var day = _date.Now.ToString("dddd");
        var day2 = _date.Now.ToString("dd");
       
        var answer = $"{day}, {month} {day2}, {year}";
        Console.WriteLine(answer);

        return answer;
    }

    //2.2019.01.22
}

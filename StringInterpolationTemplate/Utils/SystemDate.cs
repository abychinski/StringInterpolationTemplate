using NPOI.SS.Formula.Functions;
using System;

namespace StringInterpolationTemplate.Utils;

public class SystemDate : ISystemDate
{
    public DateTime Now => DateTime.Now;
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App
{
    public class GraficTO
    {
    public string CodeTOIR { get; set; }= "";
    public string Name { get; set; } = "";
    public int Period { get; set; }
    public DateOnly PlanDate { get; set; }
    public int SpendTime { get; set; }
    public DateOnly FactDate { get; set; }

    public string OtchetResult { get; set; } = "";
    }
}
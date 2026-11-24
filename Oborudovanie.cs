using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App
{
    public class Oborudovanie
    {
    public int Id_Nomer { get; set; }
    public string Name { get; set; } = "";
    public string Model { get; set; } = "";
    public string Status { get; set; } = "";
    public string Unit { get; set; } = ""; 
    public string ZakrepTsekh { get; set; } = "";

    public bool NeedsService => Status is "Требует ремонта" or "На обслуживании";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App
{
    public class Zaiavka
    {
    public string Type { get; set; }= "";
    public string Priority { get; set; } = "";
    public string Reason { get; set; } = "";
    public string Status { get; set; } = "";
    public string Brigada { get; set; } = ""; 
    public string Employees { get; set; } = "";

    public bool NeedsStatus => Status is "Выполнены" or "Ожидает" or "В работе";

    public bool NeedsPriority => Priority is "Низкий" or "Средний" or "Критический";
    }
    
}
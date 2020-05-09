using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_Game.ASP.Pages
{
    public class CounterBase : ComponentBase
    {
        public int SampleMethod(int a, int b)
        {
            return a + b;
        }
    }
}

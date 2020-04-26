using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using XE_Programming_Exercise.Services;

namespace XE_Programming_Exercise
{
    class Startup
    {
        internal static ITerminalService Init()
        {
            var ServiceProvider = new ServiceCollection()
                                 .AddTransient<IScanService, ScanService>()
                                 .AddTransient<IPriceService, PriceService>()
                                 .AddTransient<ITotalCalculatorService, TotalCalculatorService>()
                                 .AddTransient<ICalculationService, CalculationService>()
                                 .AddTransient<ITerminalService, TerminalService>()
                                 .BuildServiceProvider().GetService<ITerminalService>();
            return ServiceProvider;
        }
    }
}

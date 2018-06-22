using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Blazored.Storage;

namespace demo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                services.AddLocalStorage();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}

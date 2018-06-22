using System.Collections.Generic;
using Blazored.Storage;
using Microsoft.AspNetCore.Blazor.Browser.Interop;
using Microsoft.AspNetCore.Blazor.Components;

namespace demo1
{
    public class ToDoComponent : BlazorComponent
    {
        [Inject]
        public ILocalStorage Storage { get; set;}
        
        public string NewItem { get; set; }

        public IList<string> List { get; set; }

        protected override void OnInit()
        {
            var storage = Storage.GetItem<List<string>>("list");
            List = storage ?? new List<string>();
        }
        
        public void AddItem()
        {
            List.Add(NewItem);
            Storage.SetItem("list", List);
            DisplayNotice();
            NewItem = string.Empty;
        }
        
        public void DisplayNotice()
        {
            RegisteredFunction.Invoke<bool>("say", new { message = $"{NewItem} has been added to your list" });
        }
    }
}
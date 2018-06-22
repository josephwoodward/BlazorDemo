using System.Collections;
using System.Collections.Generic;
using Blazored.Storage;
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
            NewItem = string.Empty;
        }
    }
}
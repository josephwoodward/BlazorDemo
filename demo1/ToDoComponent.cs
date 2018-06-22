using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Blazor.Components;

namespace demo1
{
    public class ToDoComponent : BlazorComponent
    {
        public string NewItem { get; set; }

        public IList<string> List { get; set; }

        protected override void OnInit()
        {
            List = new List<string>();
        }
        
        public void AddItem()
        {
            List.Add(NewItem);
            NewItem = string.Empty;
        }
    }
}
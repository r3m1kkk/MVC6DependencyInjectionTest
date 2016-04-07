using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Interfaces
{
    public interface IToDoItemRepository
    {
        IEnumerable<ToDoItem> List();
    }
}
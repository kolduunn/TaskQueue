using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTask
{
    //TaskItem: ID, Название.
    internal class TaskItem
    {
        public int _id;
        public string _name;

        public TaskItem(string name)
        {
            _name = name;
        }
    }
}

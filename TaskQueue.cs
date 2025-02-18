using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTask
{
    //TaskQueue:
    //Queue<TaskItem> – очередь задач.
    //Stack<TaskItem> – стек отменённых задач.
    //Методы:
    //AddTask(string name): Добавить задачу.
    //CompleteTask(): Завершить задачу.
    //UndoLastTask(): Отменить завершение.
    internal class TaskQueue
    {
        public Queue<TaskItem> itemsQueue = new Queue<TaskItem>();
        public Stack<TaskItem> itemsStack = new Stack<TaskItem>();

        public void AddTask(string name)
        {
            TaskItem taskItem = new TaskItem(name);
            itemsQueue.Enqueue(taskItem);
        }

        public void CompleteTask()
        {
            itemsStack.Push(itemsQueue.Peek());
            itemsQueue.Dequeue();
        }

        public void UndoLastTask()
        {
            itemsQueue.Enqueue(itemsStack.Peek());
            itemsStack.Pop();
        }
    }
}

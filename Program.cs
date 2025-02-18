namespace QueueTask
{
    internal class Program
    {
        //        2. Очередь задач(Queue + Stack)
        //Задача:
        //Реализовать очередь задач с возможностью отмены последней.
        //Входные данные примерные, напиши свои с клавиатуры:
        //var queue = new TaskQueue();
        //        queue.AddTask("Сделать отчёт");
        //queue.CompleteTask();
        //queue.UndoLastTask();
        //Ожидаемый результат:
        //После UndoLastTask() отменённая задача снова появится в очереди.
        static void Main()
        {
            var queue = new TaskQueue();
            queue.AddTask("Сделать отчёт");
            queue.CompleteTask();
            queue.UndoLastTask();
            Console.WriteLine(queue.itemsQueue.Peek()._name); 
        }
    }
}

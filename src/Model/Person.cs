using static Model.Worker;

namespace Model
{
    public class Worker : IWorker, IFriend //реализует implements
    {
        public int Age { get; set; }

        public void Work(object data)
        {
            Console.WriteLine("Doing my Job");
        }

        public void HangoutWith(IFriend friend)
        {
            Console.WriteLine("Party with friends");
        }
    }

    public class AiBot : IWorker
    {
        public int Age => 0;

        public void Work(object data)
        {
            Console.WriteLine("Done");
        }
    }

    public interface IWorker
    {
        public int Age { get; }

        public void Work(object data);
    }

    public interface IFriend
    {
        public void HangoutWith(IFriend friend);
    }

}

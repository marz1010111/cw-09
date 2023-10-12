namespace Model
{
    public class Account<MyType> where MyType : struct
    {
        public MyType Id { get; set; }
        public int Sum { get; set; }
    }
}

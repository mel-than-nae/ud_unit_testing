namespace TestNinja.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService(new FileReader());
            service.ReadVideoTitle();
        }
    }
}
namespace Car
{
    using CarExample.Builder;

    class StartPoint
    {
        static void Main(string[] args)
        {
            MyCarDirector director = new MyCarDirector();

            CarBuilder builder = new CarBuilder();

            director.Construct(builder);

            var car = builder.GetResult();

            car.Show();
        }
    }
}

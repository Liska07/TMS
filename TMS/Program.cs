namespace TMS
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Task_1();

            static void Task_1()
            {
                Square s1Green = new Square(5, "Green");
                s1Green.ShowInfo("зелёного");

                Square s2Blue = new Square(2, "Blue");
                s2Blue.ShowInfo("синего");

                Square s3LightBlue = new Square(15, "LightBlue");
                s3LightBlue.ShowInfo("голубого");

                s1Green.SideLength = s2Blue.SideLength * 3;

                s1Green.ShowInfo("зелёного");
                s2Blue.ShowInfo("синего");
                s3LightBlue.ShowInfo("голубого");
            }
        }
    }
}
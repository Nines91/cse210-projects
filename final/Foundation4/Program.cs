using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running activity1 = new Running(30,"Running",4.8);
        activities.Add(activity1);

        Cycling activity2 = new Cycling(60,"Cycling",24);
        activities.Add(activity2);

        Swimming activity3 = new Swimming(25,"Swimming",8);
        activities.Add(activity3);

        foreach (Activity activity in activities) 
        {
            double distance = activity.Distance();
            double speed = activity.Speed();
            double pace = activity.Pace();
            //Console.WriteLine(distance);
            //Console.WriteLine(pace);
            //Console.WriteLine(speed);
            activity.GetSummary(distance, speed, pace);
        }
    }
}
using task14;

TrafficLight trafficLight = new TrafficLight(TrafficLight.Color.Yellow);

Console.WriteLine($"Current Color: {trafficLight.GetCurrentColor()}");
trafficLight.ChangeColor();
Console.WriteLine(trafficLight.GetCurrentColor());
trafficLight.ChangeColor();
Console.WriteLine(trafficLight.GetCurrentColor());
trafficLight.ChangeColor();
Console.WriteLine(trafficLight.GetCurrentColor());
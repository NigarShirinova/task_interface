using task5;

Car car1 = new Car("mercedes", "black");
Bus bus1 = new Bus("no2", "red");
Motocycle motocycle1 = new Motocycle("motosiklet", "blue");
car1.GetDetails();
car1.Start();
car1.Stop();

bus1.Start();
bus1.Stop();
bus1.GetDetails();

motocycle1.Start();
motocycle1.Stop();
motocycle1.GetDetails();

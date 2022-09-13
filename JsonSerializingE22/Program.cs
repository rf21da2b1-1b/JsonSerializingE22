// See https://aka.ms/new-console-template for more information
using JsonLib.model;
using System.Drawing;
using System.Text.Json;

/*
 * Exercise 1
 */
Console.WriteLine("Exercise 1");
Car car = new Car();
Console.WriteLine(car);
Car car2 = new Car("BMW", "330e", "Green", 45721);
Console.WriteLine(car2);
Console.WriteLine();





/*
 * Exercise 2
 */
Console.WriteLine("Exercise 2");
String json1 = JsonSerializer.Serialize(car);
Console.WriteLine(json1);

String json2 = JsonSerializer.Serialize(car2);
Console.WriteLine(json2);

List<Car> cars = new List<Car> { car, car2 };
String json3 = JsonSerializer.Serialize(cars);
Console.WriteLine(json3);
Console.WriteLine();


/*
 * Exercise 3
 */
Console.WriteLine("Exercise 3");
Car? newCar = JsonSerializer.Deserialize<Car>(json2);
Console.WriteLine(newCar);

List<Car>? newCars = JsonSerializer.Deserialize<List<Car>>(json3);
Console.WriteLine("Liste af cars");
if(newCars is not null)
foreach (var c in newCars)
{
    Console.WriteLine(c);
}
Console.WriteLine("Liste af cars -- SLUT");
Console.WriteLine();


/*
 * Exercise 4
 */
Console.WriteLine("Exercise 4");
String jsonMedSjove = "{\"Brand\":\"Dette er med sjove tegn\",\"Model\":\"her kommer dobbelt quote \\\" og her backslash \\\\ ... \",\"Color\":\"Green\",\"Mileage\":45721}";

Console.WriteLine("Json string = " + jsonMedSjove);
Car? newCar2 = JsonSerializer.Deserialize<Car>(jsonMedSjove);
Console.WriteLine(newCar2);
Console.WriteLine();

/*
 * Exercise 5
 */
Console.WriteLine("Exercise 5");
String JsonKonpleks = "{\"Name\":\"Move Cars\",\"Address\":\"MagleGaardsvej 2\",\"Cars\":[{\"Brand\":\"BMW\",\"Model\":\"330e\",\"Color\":\"Green\",\"Mileage\":45721},{\"Brand\":\"VW\",\"Model\":\"Golf\",\"Color\":\"Red\",\"Mileage\":20},{\"Brand\":\"Ford\",\"Model\":\"Galaxy\",\"Color\":\"Black\",\"Mileage\":124326}],\"Employees\":[{\"Name\":\"Move\",\"Salary\":1000000,\"MonthsEmployed\":28,\"JobAreas\":[\"President\",\"Mechanic\"]},{\"Name\":\"Not Move\",\"Salary\":100,\"MonthsEmployed\":13,\"JobAreas\":[\"Vice-President\",\"Mechanic\"]}]}";
UnKnown? unKnwon = JsonSerializer.Deserialize<UnKnown>(JsonKonpleks);
Console.WriteLine(unKnwon);
Console.WriteLine();


//string emjson = "{\"Name\":\"Move\",\"Salary\":1000000,\"MonthsEmployed\":28,\"JobAreas\":[\"President\",\"Mechanic\"]}";
//Employee emp = JsonSerializer.Deserialize<Employee>(emjson);
//Console.WriteLine(emp);

//string emjsonlist = "[{\"Name\":\"Move\",\"Salary\":1000000,\"MonthsEmployed\":28,\"JobAreas\":[\"President\",\"Mechanic\"]},{\"Name\":\"Not Move\",\"Salary\":100,\"MonthsEmployed\":13,\"JobAreas\":[\"Vice-President\",\"Mechanic\"]}]";
//List<Employee> emplist = JsonSerializer.Deserialize<List<Employee>>(emjsonlist);
//Console.WriteLine("::" + String.Join(", ", emplist) + "::");


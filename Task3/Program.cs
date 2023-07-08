//Point 
System.Console.WriteLine("Point");
var point = new Point(3, 4);
System.Console.WriteLine(point.GetX());
point.SetX(4);
System.Console.WriteLine(point.GetY());
point.SetY(5);
System.Console.WriteLine(point.ToString());
point.GetXY();
foreach (var item in point.GetXY())
{
    System.Console.WriteLine($"({item},");
}
System.Console.WriteLine(")");
point.SetXY(6, 7);
System.Console.WriteLine(point.Distance(8, 9));
var point2 = new Point(1, 2);
System.Console.WriteLine(point.Distance(point2));
System.Console.WriteLine(point.Distance());

//Circle
System.Console.WriteLine("Circle");
var circle = new Circle(3, 4, 2);
var circle2 = new Circle(point, 3);
System.Console.WriteLine(circle.GetRadius());
circle.SetRadius(4);
System.Console.WriteLine(circle.GetCenter());
circle.SetCenter(point);
System.Console.WriteLine(circle.GetCenterX());
circle.SetCenterX(3);
System.Console.WriteLine(circle.GetCenterY());
circle.SetCenterY(5);
circle.GetCenterXY();
foreach (var item in circle.GetCenterXY())
{
    System.Console.WriteLine($"({item},");
}
System.Console.WriteLine(")");
circle.SetCenterXY(6, 7);
System.Console.WriteLine(circle.ToString());
System.Console.WriteLine(circle.GetArea());
System.Console.WriteLine(circle.GetCircumference());
System.Console.WriteLine(circle.Distance(circle2));


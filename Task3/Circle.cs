public class Circle : Point
{
    private Point _center = new Point(0, 0);
    private double _radius = 1.0;

    public Circle()
    {

    }
    public Circle(int xCenter, int yCenter, double radius) : base(xCenter, yCenter)
    {
        _radius = radius;
    }
    public Circle(Point center, int radius)
    {
        _center = center;
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public Point GetCenter()
    {
        return _center;
    }
    public void SetCenter(Point center)
    {
        _center = center;
    }
    public int GetCenterX()
    {
        return base.GetX();
    }
    public void SetCenterX(int x)
    {
        base.SetX(x);
    }
    public int GetCenterY()
    {
        return base.GetY();
    }
    public void SetCenterY(int y)
    {
        base.SetY(y);
    }
    public int[] GetCenterXY()
    {
        return base.GetXY();
    }
    public void SetCenterXY(int x, int y)
    {
        base.SetXY(x, y);
    }
    public override string ToString()
    {
        return $"{base.ToString()}, radius={_radius}";
    }
    public double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
    public double GetCircumference()
    {
        return 3.14 * 2 * _radius;
    }
    public double Distance(Circle another)
    {
        return base.Distance(another.GetX(), another.GetY());
    }
}
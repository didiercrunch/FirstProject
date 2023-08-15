namespace Algorithms;
using System;


class Point
{

    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X()
    {
        return x;
    }

    public double Y()
    {
        return y;
    }

    public double Distance()
    {
        return Math.Sqrt(X() * X() + Y() * Y());
    }

}

class Point2
{

    private double x;
    private double y;

    public Point2(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X
    {
        get => x;
        set => x = value;
    }
}


class Manager
{
    internal string name;
    private int level;

    public Manager(string name, int level){
        this.name = name;
        this.level = level;
    }
   
}
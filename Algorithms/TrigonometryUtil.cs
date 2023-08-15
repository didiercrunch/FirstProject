using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms;


class TrigonometryUtil {

    public static double Side(double hypothenuse, double otherSide){
        return Math.Sqrt(hypothenuse * hypothenuse  -  otherSide * otherSide);
    }

    public static double Hypothenuse(double a, double b){
        return Math.Sqrt(a * a + b * b);
    }

    public static double Area(double hypothenuse, double side){
        double otherSide = Side(hypothenuse, side);
        return side * otherSide * 0.5;
    }
}
using System;

public class Size
{
    public double Width, Height;

    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public static Size GetRotatedSize(
        Size size, 
        double rotationAngle)
    {
        var cosineOfAngle = Math.Abs(Math.Cos(rotationAngle));
        var sineOfAngle = Math.Abs(Math.Sin(rotationAngle));

        var widthXProjeciton = cosineOfAngle * size.Width;
        var widthYProjection = sineOfAngle * size.Width;
        var heightXProjection = cosineOfAngle * size.Height;
        var heightYProjection = sineOfAngle * size.Height;

        return new Size(
            widthXProjeciton + heightYProjection,
            widthYProjection + heightXProjection);
    }
}
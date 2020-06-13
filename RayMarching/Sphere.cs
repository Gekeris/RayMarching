using System;
using System.Drawing;

namespace RayMarching
{
	class Sphere : RMObject
	{
		double radius;
		public Sphere(double x, double y, double z, int red, int green, int blue, double radius)
		{
			Position = new Coordinate(x, y, z);
			color = Color.FromArgb(red, green, blue);
			this.radius = radius;
		}
		public override double GetDist(Coordinate coordinate)
		{
			distance = Coordinate.CoordGetDist(coordinate, Position) - radius;
			return distance;
		}
	}
}

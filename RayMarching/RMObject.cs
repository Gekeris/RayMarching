using System;
using System.Drawing;

namespace RayMarching
{
	abstract class RMObject
	{
		protected Coordinate Position;
		public Color color;
		public double distance;
		public virtual double GetDist(Coordinate coordinate)
		{
			throw new ArgumentNullException("Exception 1");
		}
	}

	class Floor : RMObject
	{
		public Floor()
		{
		}
		public override double GetDist(Coordinate coordinate)
		{
			distance = coordinate.y;
			double tempX = coordinate.x % 1;
			double tempZ = coordinate.z % 1;
			if (((tempX >= -0.1) && (tempX <= 0.1)) || ((tempZ >= -0.1) && (tempZ <= 0.1)))
				color = Color.FromArgb(140, 140, 140);
			else
				color = Color.FromArgb(200, 200, 200);
			return distance;
		}
	}

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

using System;
using System.Drawing;

namespace RayMarching
{
	public abstract class RMObject
	{
		public Coordinate Position;
		public Color color;
		public double distance;
		public virtual double GetDist(Coordinate coordinate)
		{
			throw new ArgumentNullException("Error RMObject.GetDist()");
		}
		public virtual string ToFile(int num)
		{
			throw new ArgumentNullException("Error RMObject.ToFile()");
		}
		public virtual string ToListBox(int num)
		{
			throw new ArgumentNullException("Error RMObject.ToListBox()");
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
		public double Radius;
		public Sphere(double x, double y, double z, int red, int green, int blue, double radius)
		{
			Position = new Coordinate(x, y, z);
			color = Color.FromArgb(red, green, blue);
			Radius = radius;
		}
		public override double GetDist(Coordinate coordinate)
		{
			if (Radius >= 0)
				distance = Coordinate.CoordGetDist(coordinate, Position) - Radius;
			else
				distance = -1 * Coordinate.CoordGetDist(coordinate, Position) - Radius;
			return distance;
		}
		public override string ToFile(int num)
		{
			return $"object{num}=Sphere#{Position.x}#{Position.y}#{Position.z}#{color.R}#{color.G}#{color.B}#{Radius}";
		}
		public override string ToListBox(int num)
		{
			return $"object{num}=Sphere [x = {Position.x}, y = {Position.y}, z = {Position.z}]";
		}
	}

	public class Cube : RMObject
	{
		public double Size;
		public Cube(double x, double y, double z, int red, int green, int blue, double size)
		{
			Position = new Coordinate(x, y, z);
			color = Color.FromArgb(red, green, blue);
			Size = size;
		}
		public override double GetDist(Coordinate p)
		{
			Vector q = new Vector
			(
				Math.Abs(p.x - Position.x) - Size,
				Math.Abs(p.y - Position.y) - Size,
				Math.Abs(p.z - Position.z) - Size
			);
			Vector temp = new Vector
			(
				Math.Max(0, q.x),
				Math.Max(0, q.y),
				Math.Max(0, q.z)
			);

			distance = Vector.length(temp) + Math.Min(0, Math.Max(q.x, Math.Max(q.y, q.z)));
			return distance;
		}
		public override string ToFile(int num)
		{
			return $"object{num}=Cube#{Position.x}#{Position.y}#{Position.z}#{color.R}#{color.G}#{color.B}#{Size}";
		}
		public override string ToListBox(int num)
		{
			return $"object{num}=Cube [x = {Position.x}, y = {Position.y}, z = {Position.z}]";
		}
	}
}

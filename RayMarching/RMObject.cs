using System;
using System.Drawing;

namespace RayMarching
{
	public abstract class RMObject
	{
		public Coordinate Position; // Позиция объекта
		public Color color; // Цвет объекта
		public double distance; // Дистанция до объекта из точки
		public virtual double GetDist(Coordinate coordinate) // Узнать дистанцию от точки до объекта и записать в distance
		{
			throw new ArgumentNullException("Error RMObject.GetDist()");
		}
		public virtual string ToFile(int num) // Вызывается при запись в файл
		{
			throw new ArgumentNullException("Error RMObject.ToFile()");
		}
		public virtual string ToListBox(int num) // Вызывается при запись в листбокс
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
			if (((tempX >= -0.1) && (tempX <= 0.1)) || ((tempZ >= -0.1) && (tempZ <= 0.1))) // Отрисовка сетки пола
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
		public override double GetDist(Coordinate coordinate) // Узнать дистанцию от точки до объекта и записать в distance
		{
			if (Radius >= 0) // Если радиус меньше нуля инвертировать
				distance = Coordinate.CoordGetDist(coordinate, Position) - Radius;
			else
				distance = -1 * Coordinate.CoordGetDist(coordinate, Position) - Radius;
			return distance;
		}
		public override string ToFile(int num) // Вызывается при запись в файл
		{
			return $"object{num}=Sphere#{Position.x}#{Position.y}#{Position.z}#{color.R}#{color.G}#{color.B}#{Radius}";
		}
		public override string ToListBox(int num) // Вызывается при запись в листбокс
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
		public override double GetDist(Coordinate p) // Узнать дистанцию от точки до объекта и записать в distance
		{
			Vector q;
			if (Size >= 0) // Если размер меньше нуля инвертировать
				q = new Vector
				(
					Math.Abs(p.x - Position.x) - Size,
					Math.Abs(p.y - Position.y) - Size,
					Math.Abs(p.z - Position.z) - Size
				);
			else
				q = new Vector
				(
					Math.Abs(p.x - Position.x) + Size,
					Math.Abs(p.y - Position.y) + Size,
					Math.Abs(p.z - Position.z) + Size
				);
			Vector temp = new Vector
			(
				Math.Max(0, q.x),
				Math.Max(0, q.y),
				Math.Max(0, q.z)
			);

			distance = Vector.length(temp) + Math.Min(0, Math.Max(q.x, Math.Max(q.y, q.z)));
			if (Size < 0)
				distance *= -1;
			return distance;
		}
		public override string ToFile(int num) // Вызывается при запись в файл
		{
			return $"object{num}=Cube#{Position.x}#{Position.y}#{Position.z}#{color.R}#{color.G}#{color.B}#{Size}";
		}
		public override string ToListBox(int num) // Вызывается при запись в листбокс
		{
			return $"object{num}=Cube [x = {Position.x}, y = {Position.y}, z = {Position.z}]";
		}
	}
}

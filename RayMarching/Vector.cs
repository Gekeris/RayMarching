using System;

namespace RayMarching
{
	public class Vector
	{
		public double x;
		public double y;
		public double z;

		public Vector(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Vector GetVect(Coordinate from, Coordinate to) // Расстояние между точками
		{
			return new Vector(to.x - from.x, to.y - from.y, to.z - from.z);
		}

		public static Vector Normalize(Vector vect) // Нормализация вектора(длина = 1)
		{
			Vector newVect = new Vector(vect.x, vect.y, vect.z);
			newVect *= 1 / length(newVect);
			return newVect;
		}

		public static Vector operator *(Vector vect, double num) // Умножение вектора на число
		{
			double x = vect.x * num;
			double y = vect.y * num;
			double z = vect.z * num;
			return new Vector(x, y, z);
		}

		public static double length(Vector vect) // Длина вектора
		{
			return Math.Sqrt(vect.x * vect.x + vect.y * vect.y + vect.z * vect.z);
		}
		public static double Scalar(Vector vector1, Vector vector2) // Скалярное произведение векторов
		{
			return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
		}
	}
}

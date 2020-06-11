using System;

namespace RayMarching
{
	class Vector
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

		public static Vector GetVect(Coordinate from, Coordinate to)
		{
			return new Vector(to.x - from.x, to.y - from.y, to.z - from.z);
		}

		public static Vector Normalize(Vector vect)
		{
			Vector newVect = new Vector(vect.x, vect.y, vect.z);
			newVect *= 1 / length(newVect);
			return newVect;
		}

		public static Vector operator *(Vector vect, double num)
		{
			double x = vect.x * num;
			double y = vect.y * num;
			double z = vect.z * num;
			return new Vector(x, y, z);
		}

		public static double length(Vector vect)
		{
			return Math.Sqrt(vect.x * vect.x + vect.y * vect.y + vect.z * vect.z);
		}
	}
}

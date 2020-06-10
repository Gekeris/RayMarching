using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			vect *= 1 / length(vect);
			return vect;
		}

		public static Vector operator *(Vector vect, double num)
		{
			//double x = vect.x * num;
			//double y = vect.y * num;
			//double z = vect.z * num;
			//return new Vector(x, y, z);

			vect.x *= num;
			vect.y *= num;
			vect.z *= num;
			return vect;
		}

		public static double length(Vector vect)
		{
			return Math.Sqrt(vect.x * vect.x + vect.y * vect.y + vect.z * vect.z);
		}
	}
}

using System;
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
	}
}

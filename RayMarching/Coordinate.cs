﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayMarching
{
	class Coordinate
	{
		public double x;
		public double y;
		public double z;
		public Coordinate(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public static Coordinate operator +(Coordinate coord, Vector vect)
		{
			coord.x += vect.x;
			coord.y += vect.y;
			coord.z += vect.z;
			return coord;
		}
	}
}
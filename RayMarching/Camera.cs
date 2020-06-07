using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RayMarching
{
	static class Camera
	{
		public static Coordinate CameraPos;
		public static Vector CameraVec;
		public static void Initialize(double CameraPosX, double CameraPosY, double CameraPosZ)
		{
			CameraPos = new Coordinate(CameraPosX, CameraPosY, CameraPosZ);
			CameraVec = Vector.GetVect(CameraPos, new Coordinate(5, 0, 5));
		}
	}
}

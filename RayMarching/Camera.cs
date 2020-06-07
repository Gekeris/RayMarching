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
		public static double CameraPosX;
		public static double CameraPosZ;

		public static void Initialize(double CameraPosX, double CameraPosZ)
		{
			Camera.CameraPosX = CameraPosX;
			Camera.CameraPosZ = CameraPosZ;
		}
	}
}

using System;

namespace RayMarching
{
	static class Camera
	{
		public const int Width = 640; // Ширина
		public const int Height = 480; // Высота
		public static Coordinate Position = new Coordinate(0, 0, 0); // Позиция
		public static Coordinate LookAt = new Coordinate(0, 0, 0); // Точка куда смотрит
		public static Vector[] Basis; // Базис

		public static void Initialize() // Фиксирование позиции камеры и Создание базиса камеры 
		{
			// Расстояние от камеры до точки, на которую она смотрит
			Vector vector = Vector.Normalize(Vector.GetVect(Position, LookAt));
			
			// Если x1 ~= 0, изменяем его
			if ((vector.x >= 0) && (vector.x < 0.0001))
				vector.x = 0.0001;
			else if ((vector.x > -0.0001) && (vector.x < 0))
				vector.x = -0.0001;
			
			// Если y1 ~= 0, изменяем его
			if ((vector.y >= 0) && (vector.y < 0.001))
				vector.y = 0.001;
			else if ((vector.y > -0.001) && (vector.y < 0))
				vector.y = -0.001;

			vector = Vector.Normalize(vector); // Нормализируем вектор

			double x1 = vector.x; // Начальный вектор
			double y1 = vector.y;
			double z1 = vector.z;

			double z2 = ((double) Width / Height) * Math.Sqrt((x1 * x1) / (z1 * z1 + x1 * x1)); // Вектор параллелен плоскостям X и Z и перпендикулярен начальному вектору
			double x2 = -1 * (z1 * z2) / x1;

			if ((x1 > 0) && (z2 > 0))
			{
				z2 *= -1;
				x2 *= -1;
			}

			// Вычисление вектора, перпендикулярного первому и второму
			double x3 = 1 / Math.Sqrt((x1 * x1) / (y1 * y1) - ((2 * x1 * x2 * z1) / (y1 * y1 * z2)) + ((x2 * x2 * z1 * z1) / (y1 * y1 * z2 * z2)) + ((x2 * x2) / (z2 * z2)) + 1); 
			double y3 = (x3 * z1 * x2 - x1 * x3 * z2) / (y1 * z2);
			double z3 = -1 * ((x2 * x3) / z2);

			if (y3 < 0)
			{
				x3 *= -1;
				y3 *= -1;
				z3 *= -1;
			}

			Basis = new Vector[3]
			{
				new Vector(x1, x2, x3),
				new Vector(y1, 0, y3),
				new Vector(z1, z2, z3)
			};
		}
	}
}

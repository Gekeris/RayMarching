﻿using System;

namespace RayMarching
{
	static class Camera
	{
		public const int Width = 640; // Ширина
		public const int Height = 480; // Высота
		public static Coordinate Position; // Позиция
		public static Vector[] Basis; // Базис

		public static void Initialize(Form1 form) // Фиксирование позиции камеры и Создание базиса камеры 
		{
			// Положение камеры по x y z
			Position = new Coordinate(Convert.ToDouble(form.CameraPositionXNumericUpDown.Value), Convert.ToDouble(form.CameraPositionYNumericUpDown.Value), Convert.ToDouble(form.CameraPositionZNumericUpDown.Value));

			// Расстояние от камеры до точки, на которую она смотрит
			Vector vector = Vector.Normalize(Vector.GetVect(Position, new Coordinate(Convert.ToDouble(form.CameraLookAtXNumericUpDown.Value), Convert.ToDouble(form.CameraLookAtYNumericUpDown.Value), Convert.ToDouble(form.CameraLookAtZNumericUpDown.Value))));
			
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

			double x1 = vector.x;
			double y1 = vector.y;
			double z1 = vector.z;

			double z2 = ((double) Width / Height) * Math.Sqrt((x1 * x1) / (z1 * z1 + x1 * x1)); // Documents/doc1.doc
			double x2 = -1 * (z1 * z2) / x1;

			if ((x1 > 0) && (z2 > 0))
			{
				z2 *= -1;
				x2 *= -1;
			}

			double x3 = 1 / Math.Sqrt((x1 * x1) / (y1 * y1) - ((2 * x1 * x2 * z1) / (y1 * y1 * z2)) + ((x2 * x2 * z1 * z1) / (y1 * y1 * z2 * z2)) + ((x2 * x2) / (z2 * z2)) + 1); // Documents/doc2.doc
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

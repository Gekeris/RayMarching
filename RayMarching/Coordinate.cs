namespace RayMarching
{
	public class Coordinate
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
		public static Coordinate operator +(Coordinate coord, Vector vect) // Перемещение координаты на вектор
		{
			Coordinate newCoord = new Coordinate(coord.x, coord.y, coord.z);
			newCoord.x += vect.x;
			newCoord.y += vect.y;
			newCoord.z += vect.z;
			return newCoord;
		}

		public static double CoordGetDist(Coordinate coordinate1, Coordinate coordinate2)
		{
			return Vector.length(Vector.GetVect(coordinate1, coordinate2));
		}
	}
}

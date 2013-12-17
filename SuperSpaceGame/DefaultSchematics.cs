using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSpaceGame
{
	class DefaultSchematics
	{
		public static Schematic SmallChasis;
		public static Schematic SmallBlaster;

		static DefaultSchematics()
		{
			SmallChasis = new Schematic
			{
				ShapePoints = new List<List<Tuple<Vector2d, Vector4>>>
				{
					new List<Tuple<Vector2d, Vector4>>()
					{
						Tuple.Create(new Vector2d(0, -100), new Vector4(1, 1, 1, 1)),
						Tuple.Create(new Vector2d(50, 10), new Vector4(1, 1, 1, 1)),
						Tuple.Create(new Vector2d(-50, 10), new Vector4(1, 1 ,1, 1)),
					}
				},
				AttachmentPoints = new List<Tuple<Vector2d, double>>
				{
					Tuple.Create(new Vector2d(-25, -45), 0D),
					Tuple.Create(new Vector2d(25, -45), 0D),
				}
			};
			SmallBlaster = new Schematic
			{
				ShapePoints = new List<List<Tuple<Vector2d, Vector4>>>
				{
					new List<Tuple<Vector2d, Vector4>>()
					{
						Tuple.Create(new Vector2d(5, 5), new Vector4(0.7F, 0.7F, 0.7F, 1)),
						Tuple.Create(new Vector2d(-5, 5), new Vector4(0.7F, 0.7F, 0.7F, 1)),
						Tuple.Create(new Vector2d(-5, -20), new Vector4(0.7F, 0.7F, 0.7F, 1)),
						Tuple.Create(new Vector2d(0, -25), new Vector4(0.7F, 0.7F, 0.7F, 1)),
						Tuple.Create(new Vector2d(5, -20), new Vector4(0.7F, 0.7F, 0.7F, 1)),
					}
				}
			};
		}
	}
}

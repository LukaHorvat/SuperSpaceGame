using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSpaceGame
{
	class Schematic
	{
		public List<List<Tuple<Vector2d, Vector4>>> ShapePoints;
		public List<Tuple<Vector2d, double>> AttachmentPoints;

		public Schematic()
		{
			ShapePoints = new List<List<Tuple<Vector2d, Vector4>>>();
			AttachmentPoints = new List<Tuple<Vector2d, double>>();
		}
	}
}

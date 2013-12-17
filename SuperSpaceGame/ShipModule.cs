using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSpaceGame
{
	class ShipModule : DisplayObject
	{
		public Schematic Schema;

		public ShipModule(Schematic schema)
		{
			Schema = schema;
			foreach (var poly in schema.ShapePoints)
			{
				foreach (var vertex in poly)
				{
					Geometry.Add(vertex.Item1);
					ShapeColor.Add(vertex.Item2);
				}
				Geometry.Add(poly[0].Item1);
				ShapeColor.Add(poly[0].Item2);
			}
		}

		public void AttachModule(ShipModule module, int attachmentPointIndex)
		{
			TreeNode.AddChild(module);
			module.Transform.X = Schema.AttachmentPoints[attachmentPointIndex].Item1.X;
			module.Transform.Y = Schema.AttachmentPoints[attachmentPointIndex].Item1.Y;
			module.Transform.Rotation = Schema.AttachmentPoints[attachmentPointIndex].Item2;
		}
	}
}

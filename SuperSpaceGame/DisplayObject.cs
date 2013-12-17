using Firefly2;
using Firefly2.Components;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSpaceGame
{
	abstract class DisplayObject : Entity
	{
		[Shorthand]
		public TransformComponent Transform { get; set; }
		[Shorthand]
		public TreeNodeComponent TreeNode { get; set; }
		[Shorthand]
		public ShapeColorComponent ShapeColor { get; set; }
		[Shorthand]
		public GeometryComponent Geometry { get; set; }

		public DisplayObject()
		{
			AddComponent<RenderBufferComponent>();
			AddComponent<TransformComponent>();
			AddComponent<TreeNodeComponent>();
			AddComponent<ShapeColorComponent>();
			AddComponent<GeometryComponent>();
		}

		public void AddVertices(params Vector2d[] vectors)
		{
			foreach (var vect in vectors) Geometry.Add(vect);
		}

		public void AddColors(params Vector4[] colors)
		{
			foreach (var color in colors) ShapeColor.Add(color);
		}
	}
}

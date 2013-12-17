using Firefly2;
using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSpaceGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var stage = new Stage(800, 500, "Super Space Game");
			var module = new ShipModule(DefaultSchematics.SmallChasis);
			module.AttachModule(new ShipModule(DefaultSchematics.SmallBlaster), 0);
			module.AttachModule(new ShipModule(DefaultSchematics.SmallBlaster), 1);
			stage.TreeNode.AddChild(module);
			stage.Run();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSpaceGame
{
	static class Extensions
	{
		public static void AddMany<T>(this ICollection<T> collection, params T[] items)
		{
			foreach (var item in items) collection.Add(item);
		}
	}
}

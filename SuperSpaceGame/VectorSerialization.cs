using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SuperSpaceGame
{
	class VectorSerialization : DefaultContractResolver
	{
		protected override JsonContract CreateContract(Type objectType)
		{
			var contract = base.CreateContract(objectType);

			if (objectType == typeof(Vector4))
			{
				contract.Converter = new VectorConverter();
			}

			return base.CreateContract(objectType);
		}
	}

	class VectorConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return 
				objectType == typeof(Vector4) || 
				objectType == typeof(Vector2d) || 
				objectType == typeof(Tuple<Vector2d, Vector4>);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var obj = JToken.Load(reader);
			if (obj.Type == JTokenType.Array)
			{
				var arr = (JArray)obj;
				if (arr.All(token => token.Type == JTokenType.Float))
				{
					if (arr.Count == 4)
					{
						return new Vector4(arr[0].Value<float>(), arr[1].Value<float>(), arr[2].Value<float>(), arr[3].Value<float>());
					}
					else if (arr.Count == 2)
					{
						return new Vector2d(arr[0].Value<float>(), arr[1].Value<float>());
					}
				}
			}
			throw new InvalidOperationException("Malformed JSON");
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value is Vector4)
			{
				var vector = (Vector4)value;
				writer.WriteStartArray();
				writer.WriteValue(vector.X);
				writer.WriteValue(vector.Y);
				writer.WriteValue(vector.Z);
				writer.WriteValue(vector.W);
				writer.WriteEndArray();
			}
			else if (value is Vector2d)
			{
				var vector = (Vector2d)value;
				writer.WriteStartArray();
				writer.WriteValue(vector.X);
				writer.WriteValue(vector.Y);
				writer.WriteEndArray();
			}
		}
	}
}

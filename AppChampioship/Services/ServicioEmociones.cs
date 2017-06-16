using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Emotion;

namespace AppChampioship.Services
{
		public class ServicioEmociones

		{

			static string key = "89e00f774bb345a7b1edfbb8d58cc5e2";

			public static async Task<Dictionary<string, float>> ObtenerEmociones(System.IO.Stream stream)

			{

				EmotionServiceClient cliente = new EmotionServiceClient(key);
				var emociones = await cliente.RecognizeAsync(stream);

				if (emociones == null || emociones.Count() == 0)
					return null;


				return emociones[0].Scores.ToRankedList().ToDictionary(x => x.Key, x => x.Value);

			}

		}

}

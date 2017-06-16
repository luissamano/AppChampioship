﻿    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace AppChampioship.Views
{
	public class ServicioImagenes
	{
		public static async Task<MediaFile> TomarFoto(bool usarCamara)
		{

			await CrossMedia.Current.Initialize();
			if (usarCamara)
			{
				if (!CrossMedia.Current.IsCameraAvailable ||
					!CrossMedia.Current.IsTakePhotoSupported)
				{
					return null;
				}
			}

			var file = usarCamara ? await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
			{
				Directory = "Cognitive",
				Name = "test.jpg"
			}) :

			await CrossMedia.Current.PickPhotoAsync();


			return file;
		}
	}
}

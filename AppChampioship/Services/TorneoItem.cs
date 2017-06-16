using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace AppChampioship.Services
{
    public class TorneoItem
    {
		private string _id;
		private string _email;
		private string _nom;


		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return _id; }
			set
			{
				_id = value;
			}
		}



		[JsonProperty(PropertyName = "nombre")]
        public string Nombre
		{
			get { return _nom; }
			set
			{
				_nom = value;
			}
		}

		[JsonProperty(PropertyName = "email")]
		public string Email
		{
			get { return _email; }
			set
			{
				_email = value;
			}
		}


		[JsonProperty(PropertyName = "emotion")]
		public string Emotion { get; set; }

	}

}

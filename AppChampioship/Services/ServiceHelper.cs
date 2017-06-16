using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace AppChampioship.Services
{
	class ServiceHelper
	{
		MobileServiceClient clienteServicio = new MobileServiceClient(@"http://appcham.azurewebsites.net");

		private IMobileServiceTable<TorneoItem> _TorneoItemTable;

		public async Task InsertarEntidad(string id , string nombre, string email, string emotion)
		{
			_TorneoItemTable = clienteServicio.GetTable<TorneoItem>();


			await _TorneoItemTable.InsertAsync(new TorneoItem
			{
				Id = id,
				Nombre = nombre,
				Email = email,
                Emotion = emotion
			});
		}
	}
}

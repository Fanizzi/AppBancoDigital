using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

using AppBancoDigital.Model;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        // Obtem a lista de Correntistas

        public static async Task<List<Correntista>> GetCorrentistasAsync()
        {
            string json = await DataService.GetDataFromService("/correntista");
            List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_correntistas;
        }

        // Envia um model em forma de json para insert no banco

        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/save");

            Correntista co = JsonConvert.DeserializeObject<Correntista>(json);

            return co;
        }


    }
}

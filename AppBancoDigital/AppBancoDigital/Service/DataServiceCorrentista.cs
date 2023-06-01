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
        // Realiza o Login do Cliente

        public static async Task<Correntista> LoginAsync(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);


            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/entrar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

        // Envia um model 

        public static async Task<Correntista> SaveAsync(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/salvar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }


    }
}

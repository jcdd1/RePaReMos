using API_REPAREMOS.Common.Interface;
using API_REPAREMOS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_REPAREMOS.Common
{
    public class ManejoResiduosService : ManejoResiduosServicesInt
    {
        private JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<List<DataInputDto>> ObtenerResiduos()
        {

            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://www.datos.gov.co/resource/m2y3-brbe.json");
                var contentResult = result.Content.ReadAsStringAsync();
                //var a = JsonConvert.DeserializeObject<DataInput>(await contentResult,);
                var jsonResult = JsonSerializer.Deserialize<List<DataInputDto>>(contentResult.Result, options);

                //return CrearDataInput(JsonConvert.DeserializeObject());
                return jsonResult;

            }

        }

        public async Task<List<DataOutputDto>> jsonsalida()
        {
            List<DataOutputDto> datosalida = new List<DataOutputDto>();
            List<DataInputDto> entrada = await ObtenerResiduos();
            //var residuos = JsonSerializer.Serialize(entrada.ToArray());
            Random r = new Random();
            Random dia = new Random();

            foreach (var element in entrada)
            {
                DataOutputDto dataOutputDto = new DataOutputDto();
                dataOutputDto.Ciudad = element.Ciudad;
                dataOutputDto.Departamento = element.Departamento;
                dataOutputDto.Pa_s = element.Pa_s;
                dataOutputDto.Categoria_residuo = element.Categoria_residuo;
                dataOutputDto.Tipo_residuo = element.Tipo_residuo;
                dataOutputDto.Ubicacion = element.Ubicacion;
                dataOutputDto.Horario = element.Horario;
                dataOutputDto.Cantidad_residuo = r.Next (1000,100000);
                dataOutputDto.Date_generacion = new DateTime(2022, 06, dia.Next(1, 31));


                datosalida.Add(dataOutputDto);

            }

           

            return datosalida;

        }



        public async Task<List<DataInputDto>> ObtenerResiduosXCiudad(string ciudad)
        {
            using (var client = new HttpClient())
            {

                var result = await client.GetAsync("https://www.datos.gov.co/resource/m2y3-brbe.json?ciudad=" + ciudad);
                var contentResult = result.Content.ReadAsStringAsync();
                var jsonResult = JsonSerializer.Deserialize<List<DataInputDto>>(contentResult.Result, options);
                return jsonResult;

            }

        }


    }
}

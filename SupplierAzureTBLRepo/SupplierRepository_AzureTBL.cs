using Newtonsoft.Json;
using RestSharp;
using SupplierRepoModels_AzureTBL.Entities;
using SupplierRepoModels_AzureTBL.Exceptions;
using SupplierRepoModels_AzureTBL.ViewModels;
using System;
using System.Threading.Tasks;

namespace SupplierAzureTBLRepo
{
    public class SupplierRepository_AzureTBL
    {

        public async Task<Supplier> AddSupplier(SupplierAddVM model)
        {
            var client = new RestClient("http://localhost:7071/api/AddSupplier");
            
            var request = new RestRequest("http://localhost:7071/api/AddSupplier",Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(model);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = await  client.PostAsync(request);
           
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseModel = JsonConvert.DeserializeObject<ResponseModel>(response.Content);
                if (responseModel.Success)
                {
                    return (Supplier) responseModel.Data;
                }
                throw new FunctionException((string)responseModel.Data);
            }

            throw new FunctionException($"Exception from function. Status Code:{response.StatusCode}. Content : {response.Content}");
        }

    }
}

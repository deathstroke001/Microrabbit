using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;
        public TransferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "https://localhost:5001/api/Banking/TansferFund";
            var tansferContent = new StringContent(JsonConvert.SerializeObject(transferDTO),
                System.Text.Encoding.UTF8,"application/json");
            var response = await _httpClient.PostAsync(uri, tansferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}

using Coinbase;
using Coinbase.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoinBaseClient
{
    class GetFromAPI
    {
        private CoinbaseClient client;
        private ApiKeyValues apiKeyValue;

        public GetFromAPI()
        {
            //initia the basic
            this.apiKeyValue = new ApiKeyValues();

            //initia the Coinbase API with a API-key and a API-secret key
            this.client = new CoinbaseClient(new ApiKeyConfig { ApiKey = apiKeyValue.GetApiKey(), ApiSecret = apiKeyValue.GetApiSecret() });
        }

        public CoinbaseClient getClient() { return this.client; }

        public string Get_spotprice(String currency, String coin)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;

            Task<Response<Money>> Get_spotprice = Task.Run(async () =>
            {
                var spot = await getClient().Data.GetSpotPriceAsync(coin + "-" + currency);
                spot.Data.Amount.Should().BeGreaterThan((decimal)0.01);
                spot.Data.Currency.Should().Be(currency);
                spot.Data.Base.Should().Be(coin);
                return spot;
            }, token
                );

            Get_spotprice.Wait();
            return Get_spotprice.Result.Data.Amount.ToString("N2");
        }
    }
}

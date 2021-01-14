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
        private CancellationTokenSource source;
        private CancellationToken token;

        public GetFromAPI()
        {
            //initia the basic
            this.apiKeyValue = new ApiKeyValues();

            //initia the Coinbase API with a API-key and a API-secret key
            this.client = new CoinbaseClient(new ApiKeyConfig { ApiKey = apiKeyValue.GetApiKey(), ApiSecret = apiKeyValue.GetApiSecret() });

            this.source = new CancellationTokenSource();
            this.token = source.Token;
        }

        public CoinbaseClient getClient() { return this.client; }

        public string Get_spotprice(String currency, String coin)
        {


            Task<Response<Money>> spotprice = Task.Run(async () =>
            {
                var spot = await getClient().Data.GetSpotPriceAsync(coin + "-" + currency);
                spot.Data.Amount.Should().BeGreaterThan((decimal)0.01);
                spot.Data.Currency.Should().Be(currency);
                spot.Data.Base.Should().Be(coin);
                return spot;
            }, this.token
                );

            spotprice.Wait();
            return spotprice.Result.Data.Amount.ToString("N2");
        }

        public String Get_CoinsFromWallet(String coin)
        {
            Task<Response<Account>> getCoinsFromWallet = Task.Run(async () =>
            {
                var coins = await getClient().Accounts.GetAccountAsync(coin);
                return coins;
            }, this.token
                );

            getCoinsFromWallet.Wait();
            return getCoinsFromWallet.Result.Data.Balance.Amount.ToString();
        }
    }
}

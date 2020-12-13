using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Info.Blockchain.API.Wallet;
using System.Net.Http;
using Info.Blockchain.API.Client;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocalCrytoTrading.Controllers
{
    public class BitcoinController : Controller
    {
        private readonly WalletCreator wallet = new WalletCreator();

        // GET: /<controller>/
        public WalletCreator CreateWallet()
        {
            var httpClient = new BlockchainHttpClient("api-code", "http://127.0.0.1:3000");
            var walletCreator = new WalletCreator(httpClient);
            return walletCreator;
        }

        public void Test()
        {
            Task<Info.Blockchain.API.Models.CreateWalletResponse> a = wallet.CreateAsync("pppp");
            a.ToString();
        }
    }
}
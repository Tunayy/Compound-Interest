using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Paycore_patika_hw1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Interest_faiz : ControllerBase
    {

        [HttpGet("Compound İnterest Calculation")]
        public string Get(float MainMoney, double compound , double paried_amount)
        {
            double anlik_Sureli = 2.71;

            for (int i = 0; i < paried_amount * compound - 1; i++)
            {
                anlik_Sureli *= 2.71;
            }
            double FaizGetirisi = MainMoney * anlik_Sureli;
            return "Toplam Bakiye: " + Convert.ToString(FaizGetirisi) + " Toplam Kazanılan Faiz Tutarı: " + Convert.ToString(FaizGetirisi - MainMoney);
        }
    }
}

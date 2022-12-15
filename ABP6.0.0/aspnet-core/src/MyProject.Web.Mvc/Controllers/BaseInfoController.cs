using Microsoft.AspNetCore.Mvc;
using MyProject.BaseInfo;
using MyProject.Controllers;
using MyProject.Web.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Web.Controllers
{
    public class BaseInfoController : MyProjectControllerBase
    {
        private readonly ICardFeeInfoAppService _cardFeeInfoAppService;
        public BaseInfoController(ICardFeeInfoAppService cardFeeInfoAppService)
        {
            _cardFeeInfoAppService = cardFeeInfoAppService;
        }
        public async Task<ActionResult> Index()
        {
            var cardFeeInfos = (await _cardFeeInfoAppService.GetCardFeeInfos()).Items;
            var model = new CardFeeInfoViewModel
            {
                cardFeeInfoDtos = cardFeeInfos,
                Count = 20
            };
            return View(model);
        }
        //public async Task<ActionResult> Edit()
        //{
        //    return PartialView();
        //}
    }
}

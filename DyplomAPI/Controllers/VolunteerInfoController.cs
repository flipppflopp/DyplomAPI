﻿using DB.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("volonteer-infoes")]
    public class VolonteerInfoController : Controller
    {
        private IVolonteerInfoRepository volonteerInfoService;

        public VolonteerInfoController(IVolonteerInfoRepository _volonteerInfoService)
        {
            volonteerInfoService = _volonteerInfoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<VolonteerInfo>>> Get()
        {
            return volonteerInfoService.Get();
        }

        [HttpPost]
        public async Task<ActionResult<VolonteerInfo>> Add(VolonteerInfo volonteerInfo)
        {
            volonteerInfoService.Add(volonteerInfo);

            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<VolonteerInfo>> Update(VolonteerInfo volonteerInfo)
        {
            volonteerInfoService.Update(volonteerInfo);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<VolonteerInfo>> Remove(VolonteerInfo volonteerInfo)
        {
            volonteerInfoService.Remove(volonteerInfo);

            return NoContent();
        }
    }
}

﻿using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Marathon.API.Models.Charity;
using Marathon.API.Repositories.Interfaces;

namespace Marathon.API.Controllers
{
    [Route("[controller]")]
    public class CharitiesController : Controller
    {
        private readonly ICharityRepository _charityRepository;

        public CharitiesController(ICharityRepository charityRepository)
        {
            _charityRepository = charityRepository;
        }

        [HttpGet]
        [Route("All")]
        [ProducesResponseType(typeof(IEnumerable<Charity>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var charities = _charityRepository.GetAll();

            return Ok(charities);
        }

        [HttpGet]
        [Route("About/{id}")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(AboutCharity), (int)HttpStatusCode.OK)]
        public IActionResult AboutCharity(int id)
        {
            if (id <= default(int))
                return BadRequest();

            try
            {
                var aboutCharity = _charityRepository.GetInfoAboutCharity(id);

                return Ok(aboutCharity);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}

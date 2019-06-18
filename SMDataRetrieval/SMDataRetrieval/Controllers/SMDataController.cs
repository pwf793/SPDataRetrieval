using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMDataRetrieval.Models;


namespace SMDataRetrieval.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityByCtryCodeController : ControllerBase
    {
        private readonly SMDataRetrievalContext _context;

		public CityByCtryCodeController(SMDataRetrievalContext context)
		{
			_context = context;
		}

		// GET: api/CityByCtryCode/AFG
		//Return list of city names by Country Code
		[HttpGet("{CtryCd}")]
		public async Task<ActionResult<IEnumerable<CityNames>>> GetCities(string CtryCd)
		{
			var cities = await _context.CityNames.Where(x => x.CountryCode == CtryCd).ToListAsync();

			if (cities == null)
			{
				return NotFound();
			}

			return cities;
		}
    }


	[Route("api/[controller]")]
	[ApiController]
	public class CountryByRegionController : ControllerBase
	{
		private readonly SMDataRetrievalContext _context;

		public CountryByRegionController(SMDataRetrievalContext context)
		{
			_context = context;
		}

		// GET: api/CountryByRegion
		//Return list of country name, population, LifeExpentancy by Region
		[HttpGet("{Regn}")]
		public async Task<ActionResult<IEnumerable<country>>> GetCountryByRegion(string Regn)
		{
			var countries = await _context.country.Where(x => x.Region == Regn).ToListAsync();

			if (countries == null)
			{
				return NotFound();
			}

			return countries;
		}

	}


	[Route("api/[controller]")]
	[ApiController]
	public class CountryByCodeController : ControllerBase
	{
		private readonly SMDataRetrievalContext _context;

		public CountryByCodeController(SMDataRetrievalContext context)
		{
			_context = context;
		}

		// GET: api/CountryByCode
		//Return country name, total population by Country Code
		[HttpGet("{CountryCode}")]
		public async Task<ActionResult<IEnumerable<country>>> GetCountryByCode(string CountryCode)
		{
			var countries = await _context.country.Where(x => x.Code == CountryCode).ToListAsync();

			if (countries == null)
			{
				return NotFound();
			}

			return countries;
		}

	}
}

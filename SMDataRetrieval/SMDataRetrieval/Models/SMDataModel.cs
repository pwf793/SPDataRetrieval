using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace SMDataRetrieval.Models
{

	/*
	 * Create a .NetCore WebApi that connects to the MySql Database below.

	Create the following routes:
	Return list of city names by Country Code
	Return list of country name, population, LifeExpentancy by Region
	Return country name, total population by Country Code

	Once you have this developed please upload to your git repository at github.com

	Database Connection and Credentials:
	Connection String: appdevtesting.ceoujokqo18f.us-east-1.rds.amazonaws.com
	Database: world
	Username: Patrick
	Password: dKmyEEX3
	*/

	[Table("City")]
	public class CityNames
	{
//ID Name  CountryCode District  Population
//1	Kabul AFG		   Kabol     1780000
		[JsonIgnore]
		public int Id { get; set; }
		public string Name { get; set; }
		[JsonIgnore]
		public string CountryCode { get; set; }

	}


	public class Country
	{
//Code Name  Continent     Region    SurfaceArea IndepYear Population LifeExpectancy GNP    GNPOld    LocalName GovernmentForm                                HeadOfState Capital   Code2
//ABW  Aruba North America Caribbean 193.00	    NULL	    103000	78.4	          828.00 793.00	  Aruba     Nonmetropolitan Territory of The Netherlands  Beatrix     129	     AW
		[Key]
		[JsonIgnore]
		public string Code { get; set; }
		public string Name { get; set; }
		[JsonIgnore]
		public string Region { get; set; }
		public int? Population { get; set; }
		public decimal? LifeExpectancy { get; set; }

	}
}

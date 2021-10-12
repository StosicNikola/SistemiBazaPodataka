using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkPrirodeProjekat3.DTOs;

namespace ParkPrirodeProjekat3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BiljkaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveBiljke")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBiljke()
        {
            try
            {
                return new JsonResult(DataProvaider.GetBiljkaInfos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSveZasticeneBiljke")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetZasticeneBiljke()
        {
            try
            {
                return new JsonResult(DataProvaider.GetZasticenaBiljkaInfos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSveBiljkeOblasti/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBiljkeOblasti(int oblastID)
        {
            try
            {
                return new JsonResult(DataProvaider.GetBiljkeOblasti(oblastID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajBiljku/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddBiljka([FromRoute(Name = "oblastID")]int oblastID,[FromBody]BiljkaView b)
        {
            try
            {
                OblastView o = DataProvaider.GetOblast(oblastID);
                DataProvaider.DodajBiljku(b,o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

         [HttpPost]
        [Route("DodajZasticenuBiljku/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddZasticenuBiljka([FromRoute(Name = "oblastID")]int oblastID,[FromBody]ZasticenaBiljkaView b)
        {
            try
            {
                OblastView o = DataProvaider.GetOblast(oblastID);
                DataProvaider.DodajZasticenuBiljku(b,o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniLatinskiNazivBiljke/{biljkaID}/{latinskiNaziv}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeLatinskiNazivBiljke(int biljkaID,String latinskiNaziv)
        {
            try
            {
                DataProvaider.IzmeniLatinskiNaziv(biljkaID,latinskiNaziv);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniZasticenuBiljku")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeZasticenuBiljku([FromBody]ZasticenaBiljkaView z)
        {
            try
            {
                DataProvaider.IzmeniZasticenuBiljku(z);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiBiljku/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteBiljku(int id)
        {
            try
            {
                DataProvaider.ObrisiVezuRasteBiljka(id);
                DataProvaider.ObrisiBiljku(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkPrirodeProjekat3.DTOs;



namespace ParkPrirodeProjekat3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZivotinjaController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveZivotinje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetZivotinje()
        {
            try
            {
                return new JsonResult(DataProvaider.getZivotinje());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSvePticeSelice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPriceSelice()
        {
            try
            {
                return new JsonResult(DataProvaider.GetPticeSelice());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSveZivotinjeOblasti/{idOblasti}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetZivotinjeOblasti(int idOblasti)
        {
            try
            {
                return new JsonResult(DataProvaider.getZivotinjeOblasti(idOblasti));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajZivotinju/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddZivotinja([FromRoute(Name = "oblastID")]int oblastID,[FromBody]ZivotinjaView z)
        {
            try
            {
                OblastView o = DataProvaider.GetOblast(oblastID);
                DataProvaider.DodajZivotinju(z,o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPticuSelicu/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPticaSelica([FromRoute(Name = "oblastID")]int oblastID,[FromBody]PticaSelicaView z)
        {
            try
            {
                OblastView o = DataProvaider.GetOblast(oblastID);
                DataProvaider.DodajPticuSelicu(z,o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniZivotinju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeZivotinju([FromBody]ZivotinjaView z)
        {
            try
            {
                DataProvaider.IzmeniZivotinju(z);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiZivotinju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteZivotinja(int id)
        {
            try
            {
                DataProvaider.ObrisiVezuPripadaZivotinja(id);
                DataProvaider.ObrisiZivotinju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
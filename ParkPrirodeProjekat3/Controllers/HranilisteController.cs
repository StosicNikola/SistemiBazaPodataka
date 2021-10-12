using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkPrirodeProjekat3.DTOs;



namespace ParkPrirodeProjekat3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HranilisteController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSvaHranilista/{oblastId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetHranilista(int oblastId)
        {
            try
            {
                return new JsonResult(DataProvaider.GetHranilistaOblasti(oblastId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajHraniliste/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddZivotinja([FromRoute(Name = "oblastID")]int oblastID,[FromBody]HranilisteView h)
        {
            try
            {
                OblastView o = DataProvaider.GetOblast(oblastID);
                if(o.GetType() == typeof(StalnaZastitaView)){
                    DataProvaider.DodajHraniliste(h,o);
                    return Ok();
                }
                else{
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniHraniliste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeHraniliste([FromBody]HranilisteView h)
        {
            try
            {
                DataProvaider.IzmeniHraniliste(h);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiHraniliste/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteHraniliste(int id)
        {
            try
            {
                DataProvaider.ObrisiVezuPrimecenaJeHraniliste(id);
                DataProvaider.ObrisiHraniliste(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
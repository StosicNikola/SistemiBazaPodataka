using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkPrirodeProjekat3.DTOs;

namespace ParkPrirodeProjekat3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OblastController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiOblasti")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetOblasti()
        {
            try
            {
                return new JsonResult(DataProvaider.GetOblasti( ));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        

        [HttpGet]
        [Route("PreuzmiStalnoZasticeneOblasti")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetStalnoZasticeneOblasti()
        {
            try
            {
                return new JsonResult(DataProvaider.GetStalnoZasticeneOblasti());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajOblastMonitoring")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOblastMonitoring([FromBody]MonitoringView mv)
        {
            try
            {
                DataProvaider.DodajOblast(mv);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajOblastPovremenaZastita")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOblastPovremenaZastita([FromBody]PovremenaIntervencijaView piv)
        {
            try
            {
                DataProvaider.DodajOblast(piv);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajOblastStalnaZastita")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOblastStalnaZastita([FromBody]StalnaZastitaView szv)
        {
            try
            {
                DataProvaider.DodajOblast(szv);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniOblast")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeOblast([FromBody]OblastView o )
        {
            try
            {
                DataProvaider.IzmeniOblast(o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiOblast/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteOblast(int id)
        {
            try
            {
                DataProvaider.ObrisiVezuPripadaOblast(id);
                DataProvaider.ObrisiVezuRasteOblast(id);
                DataProvaider.ObrisiOblast(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


    }
}

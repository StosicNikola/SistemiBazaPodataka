using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkPrirodeProjekat3.DTOs;

namespace ParkPrirodeProjekat3.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RadnikController :ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveRadnike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadnici()
        {
            try
            {
                return new JsonResult(DataProvaider.GetRadnikInfos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        
        [HttpGet]
        [Route("PreuzmiSveRadnikeOblasti/{oblastiID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadniciOblasti(int oblastiID)
        {
            try
            {
                return new JsonResult(DataProvaider.GetRadnikeOblasti(oblastiID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVolontera/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVolontera([FromRoute(Name = "oblastID")]int oblastID,[FromBody]VolonterView r)
        {
            try
            {
                var oblast = DataProvaider.GetOblast(oblastID);
                if(oblast.GetType() != typeof(StalnaZastitaView)){
                    DataProvaider.DodajVolontera(r,oblastID);
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

        [HttpPost]
        [Route("DodajStalnoZaposljen/{oblastID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddStalnoZaposljenog([FromRoute(Name = "oblastID")]int oblastID,[FromBody]StalnoZaposljenView r)
        {
            try
            {
                var oblast = DataProvaider.GetOblast(oblastID);
                if(oblast.GetType() == typeof(StalnaZastitaView)){
                    DataProvaider.DodajStalnoZaposljenog(r,oblastID);
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
        [Route("IzmeniVolontera")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeVolonter([FromBody]VolonterView v)
        {
            try
            {
                DataProvaider.IzmeniRadnika(v);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiRadnika/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRadnik(int id)
        {
            try
            {
               
                DataProvaider.ObrisiRadnika(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
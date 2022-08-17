using Pet.Vet.Services.Implementation;
using Pet.Vet.Services.Interfaces;
using Petzey.Vet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Petzey.Vet.API.Controllers
{
    [RoutePrefix("api/vetschedule")]
    public class AvaliabilitySlotsController : ApiController
    {
        private IAvailabilitySlotServices service = new AvaliableSlotService();
        

        [HttpGet]
        [Route("getAllSlotsForADay/{date}/{doctorId}")]
        public IHttpActionResult getAllSlotsForADay(int doctorId, DateTime date)
        {
            try
            {
                var slots = service.getAllAvailableSlotsForADay(doctorId, date);
                if (slots == null)
                {
                    return NotFound();
                }
                return Ok(slots);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("saveSlot")]
        public IHttpActionResult saveSlot(AvailabilitySlotDTO availabilitySlot)
        {
            try
            {
                var result = service.addSlot(availabilitySlot);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("BookOrCancelSlot")]

        public IHttpActionResult BooKOrCancel(int id,bool IsBooked) 
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid Request");
                }
                var result = service.ChangeSlotsStatus( id, IsBooked);
                if (result)
                    return Ok();
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

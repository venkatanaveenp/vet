using Pet.Vet.Services.Interfaces;
using Petzey.Vet.DTOs;
using Petzey.Vet.Model;
using Petzey.Vet.Repository;
using Petzey.Vet.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Petzey.Vet.API.Controllers
{
    [RoutePrefix("api/Vets")]
    public class VetController : ApiController
    {
        private IVetService service;
        public VetController(IVetService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("getallVets")]
        public IHttpActionResult GetAllVets()
        {
            try
            {
                ICollection<VetDTO> vetDTOs = service.GetAllVets();
                return Ok(vetDTOs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("addVets")]
        public IHttpActionResult AddVets(VetDTO vetDTO)
        {
            try
            {
                var result = service.AddVet(vetDTO);
                return Created($"api/Vets/getallVets/{result.VetId}", result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            }
            //[HttpPut]
            //[Route("updateVet")]
            //public IHttpActionResult UpdateVet(VetDTO vet)
            //{
            //    try
            //    {
            //        if (!ModelState.IsValid)
            //        {
            //            return BadRequest("Invalid Request");
            //        }
            //        var result = service.UpdateVet(vet);
            //        if (result)
            //            return Ok();
            //        return NotFound();
            //    }
            //    catch (Exception ex)
            //    {
            //        return BadRequest(ex.Message);
            //    }
            //}
            [HttpPut]
        [Route("UpdateVetProfileDetails")]
        public IHttpActionResult UpdateVetDetails(VetCardDTO vet)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid Request");
                }
                var result = service.UpdateVetProfile(vet);
                if (result)
                    return Ok();
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpGet]
        //[Route("allVetsDetails/{VetId}")]
        //public IHttpActionResult GetAllDetailByVetId(int VetId)
        //{
        //    try
        //    {
        //        VetCardDTO vetCardDTO = service.GetProfileDetails(VetId);
        //        return Ok(vetCardDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);

        //    }
        //}
        [HttpGet]
        [Route("GetVetProfileDetails/{ID}")]
        public IHttpActionResult GetProfileDetailsByVetId(int ID)
        {
            try
            {
                VetCardDTO vetCardDTO = service.GetProfileDetails(ID);
                return Ok(vetCardDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }


        }
        [HttpGet]
        [Route("GetProfileInPet/{ID}")]
        public IHttpActionResult GetProfileVetId(int ID)
        {
            try
            {
                VetCardInPetDTO vetCardDTO = service.GetProfilecardinVet(ID);
                return Ok(vetCardDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }


        }
       
 
        }
}
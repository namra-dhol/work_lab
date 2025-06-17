using HospitalManagement.Models;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalAPIController : ControllerBase
    {
        #region Configuration Fields
        private readonly HospitalContext _context;

        public HospitalAPIController(HospitalContext context)
        {
            _context = context;
        }
        #endregion

        #region GetAllHospitals
        [HttpGet]
        public IActionResult GetHospitals()
        {
            var hospitals = _context.HospitalMasters.ToList();
            ;
            return Ok(hospitals);
        }
        #endregion

        #region GetHospitalById
        [HttpGet("{id}")]
        public IActionResult GetHospitalById(int id)
        {
            var hospital = _context.HospitalMasters.Find(id);
            if (hospital == null)
            {
                return NotFound();
            }
            return Ok(hospital);
        }
        #endregion

        #region DeleteHospitalById
        [HttpDelete("{id}")]
        public IActionResult DeleteHospitalById(int id)
        {
            var hospital = _context.HospitalMasters.Find(id);
            if (hospital == null)
            {
                return NotFound();
            }

            _context.HospitalMasters.Remove(hospital);
            _context.SaveChanges();
            return NoContent();
        }
        #endregion

        //#region InsertHospital
        //[HttpPost]
        //public IActionResult InsertHospital(HospitalMaster hospital)
        //{
        //    _context.HospitalMasters.Add(hospital);
        //    _context.SaveChanges();
        //    return NoContent();
        //}
        //#endregion




        #region UpdateHospital
        [HttpPut("{id}")]
        public async Task<ActionResult<HospitalMaster>> UpdateHospital(int id, HospitalMaster hst)
        {
            if (id != hst.HospitalId)
            {
                return BadRequest();
            }
            _context.Entry(hst).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(hst);
        }
        #endregion




        #region SerializeObject
        [HttpPost]
        public IActionResult Create([FromBody] HospitalMaster hospital)
        {
            if (ModelState.IsValid)
            {

                var jsonOutput = JsonConvert.SerializeObject(hospital, Formatting.Indented);

                return Ok(new
                {
                    Message = "JSON serialized successfully",
                    Data = jsonOutput
                });
            }
            return BadRequest("Invalid data received.");
        }
        #endregion


    }
}

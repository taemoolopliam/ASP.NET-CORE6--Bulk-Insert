using EFCore.BulkExtensions;
using EFCoreBulk.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCoreBulk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EFBulkController : ControllerBase
    {
        private readonly Adventureworksdw2019Context _context = new Adventureworksdw2019Context();

        // GET: api/<EFBulkController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.DimCustomer.CountAsync());
        }


        [HttpPost]
        public async Task<IActionResult> Post()
        {
            //หมายเหตุการให้เวลาการวัดประสิทธิภาพได้เบื่องต้น หากต้องการประสิทธิภาพต้องคำนึงเรื่องของ CPU RAM หรือมีการทำงานของโปรแกรมใดทำให้ผลลัพธ์การทดสอบผิดพลาดหรือไม่ หากผิดพลาดประการใดขออภัย ณ ที่นี้ด้วยครับ
            DateTime Start = DateTime.Now;
            TimeSpan TimeSpan;
            List<DimCustomer> dimCustomers = new List<DimCustomer>();
            for (int i = 0; i < 10000; i++)
            {
                dimCustomers.Add(new DimCustomer
                {
                    GeographyKey = 1,
                    FirstName = "Bulk",
                    MiddleName = "EF",
                    LastName = "Core",
                    NameStyle = true,
                    BirthDate = DateTime.Now.Date,
                    MaritalStatus = "M",
                    Gender = "M",
                    EmailAddress = "Test@gmail.com",
                    YearlyIncome = 150000,
                    TotalChildren = 2,
                    NumberChildrenAtHome = 3,
                    EnglishEducation = "Partial College",
                    SpanishEducation = "Estudios universitarios (en curso)",
                    FrenchEducation = "Baccalauréat",
                    EnglishOccupation = "Professional",
                    SpanishOccupation = "Profesional",
                    FrenchOccupation = "Cadre",
                    HouseOwnerFlag = "1",
                    NumberCarsOwned = 1,
                    AddressLine1 = "1",
                    AddressLine2 = "1",
                    Phone = "1",
                    DateFirstPurchase = DateTime.Now.Date,
                    CommuteDistance = "1",

                });
            }
            await _context.BulkInsertAsync(dimCustomers);
            //await _context.DimCustomer.AddRangeAsync(dimCustomers);
            //await _context.SaveChangesAsync();
            TimeSpan = DateTime.Now - Start;
            return Ok(TimeSpan);
        }

    }
}

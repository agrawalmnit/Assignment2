using Assignment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DataAccess.Models;
using System.Net;
using System.Xml.Linq;

namespace Assignment
{
    


        [Route("api/[Controller]")]

        [ApiController]

    public class Controller : ControllerBase
    {
        public List<Students> StudentsList = new List<Students>
        {
            new Students {rollNo = 1,
            Name = "Ishansi agrawal",
            familyName = "meenakshi mangal",
            contactNumber = "123",
            Address = "jaipur"


        } };
        private readonly ISqlDataAccess _db;


        [HttpGet]
        [Route("getall")]


        public async Task<IEnumerable<Students>> GetUsers(StudentsList user)
        {
            try
            {
               var results = await _db.LoadData<Students, dynamic>

                (storedProcedure: "dbo.GetAll", new {
                    Name = Name,
                    familyName = familyName,
                    Address = Address,
                    contactNumber = contactNumber
                })
                return results.ToList().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        [HttpGet]
        [Route("get")]

        public async Task<Students> GetUser
            (int rollNo)
        {
            try
            {
                var results = await _db.LoadData<Students, dynamic>
                    (
                    storedProcedure: "dbo.Get",
                        new { rollNo = rollNo });
                return results.ToList().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    




    public Task InsertUser(Students user) =>

        _db.SaveData(storedProcedure: "dbo.Insert", new { user.Name, user.familyName });

    public Task UpdateUser(Students user) =>

        _db.SaveData(storedProcedure: "dbo.Update", user);

    public Task DeleteUser(int rollNo) =>

        _db.SaveData(storedProcedure: "dbo.Delete", new { rollNo = rollNo });
}


}


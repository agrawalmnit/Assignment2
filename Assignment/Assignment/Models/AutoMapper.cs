using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DataAccess.Models
{
    public class AutoMapper
    {

        public static void Main(string[] args)
        {


            var config = new MapperConfiguration(cfg => cfg.CreateMap<Students, Students2>());

            var Mapper = new Mapper(config);
            Students stu = new Students()
            {
                rollNo = 1,
                Name = "Ishansi agrawal",
                familyName = "meenakshi mangal",
                contactNumber = "123",
                Address = "jaipur"


            };
            var stu2 = Mapper.Map<Students2>(stu);
            Console.WriteLine("roll No" + stu2.rollNo + "Name" + stu2.Name + "familyName" + stu2.familyName
                + "contactNumber" + stu2.contactNumber + "Address" + stu2.Address);


            Console.ReadLine();
        }
    }



}


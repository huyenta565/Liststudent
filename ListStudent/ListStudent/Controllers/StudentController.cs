using ListStudent.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Data;

namespace ListStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public StudentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            String query = @"
                select id as ""id"",
                       name as ""name""
                       age as ""age"" 
                       sex as ""sex"" 
                       address as ""address"" 
                from Student
            ";

            DataTable table = new DataTable();
            string sqlDataSource = "Server=localhost;Database=StudentManagement;Port=5432; User Id=postgres; Password=Huyen352000";
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Student st)
        {
            String query = @"
                insert into Student(id,name,age,sex,address)
                values (@id,@name,@age,@sex,@address)
            ";

            DataTable table = new DataTable();
            string sqlDataSource = "Server=localhost;Database=StudentManagement;Port=5432; User Id=postgres; Password=Huyen352000";
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", st.Id);
                    myCommand.Parameters.AddWithValue("@name", st.Name!);
                    myCommand.Parameters.AddWithValue("@age", st.Age);
                    myCommand.Parameters.AddWithValue("@sex", st.Sex!);
                    myCommand.Parameters.AddWithValue("@name", st.Address!);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added succesfully");
        }

        [HttpPut]
        public JsonResult Put(Student st)
        {
            String query = @"
                update Student
                set name = @name
                    age = @age
                    sex = @sex
                    address = @address
                where id = @id
            ";

            DataTable table = new DataTable();
            string sqlDataSource = "Server=localhost;Database=StudentManagement;Port=5432; User Id=postgres; Password=Huyen352000";
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", st.Id);
                    myCommand.Parameters.AddWithValue("@name", st.Name!);
                    myCommand.Parameters.AddWithValue("@age", st.Age);
                    myCommand.Parameters.AddWithValue("@sex", st.Sex!);
                    myCommand.Parameters.AddWithValue("@name", st.Address!);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Update Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            String query = @"
                delete from Student
                where id = @id
            ";

            DataTable table = new DataTable();
            string sqlDataSource = "Server=localhost;Database=StudentManagement;Port=5432; User Id=postgres; Password=Huyen352000";
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }
    }
}

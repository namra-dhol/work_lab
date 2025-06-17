using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using SEM5.Models;

namespace SEM5.Controllers
{
    public class CountryController : Controller
    {
        private IConfiguration Configuration;

        public CountryController(IConfiguration _Configuration)
        {
            Configuration = _Configuration;
        }


        #region Country List
        public IActionResult CountryList()
        {
            string connectionString = this.Configuration.GetConnectionString("ConnectionString");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PR_Country_SelectAll";
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return View(table);
            }
        }
        #endregion


        #region Add Edit Country
        public IActionResult AddEditCountry(int? CountryID)
        {
            if (CountryID == null)
            {
                return View();
            }
            else
            {
                string connectionString = this.Configuration.GetConnectionString("ConnectionString");
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PR_Country_SelectByPK";
                command.Parameters.Add("@country_id", SqlDbType.Int).Value = CountryID;
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                CountryModel country = new CountryModel();

                foreach (DataRow row in table.Rows)
                {
                    country.CountryID = Convert.ToInt32(row["CountryID"]);
                    country.CountryName = row["CountryName"].ToString();
                }
                return View(country);
            }
        }
        #endregion


        #region Delete Country
        public IActionResult DeleteCountry(int CountryID)
        {
            try
            {
                string connectionString = Configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_Country_Delete";
                    command.Parameters.Add("@country_id", SqlDbType.Int).Value = CountryID;
                    command.ExecuteNonQuery();
                }
                TempData["MessageType"] = "Deleted";
                TempData["SuccessMessage"] = "Country deleted successfully.";
                return RedirectToAction("CountryList");
            }
            catch (Exception ex)
            {
                TempData["MessageType"] = "Error";
                TempData["ErrorMessage"] = "An error occurred while deleting the Country: " + ex.Message;
                return RedirectToAction("CountryList");
            }
        }
        #endregion


        #region Country Save
        public IActionResult CountrySave(CountryModel country)
        {
            try
            {
                ModelState.Clear();
                string messageType;
                string successMessage;
                string connectionString = Configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    if (country.CountryID == null)
                    {
                        command.CommandText = "PR_Country_Insert";
                        messageType = "Inserted";
                        successMessage = "Country inserted successfully";
                    }
                    else
                    {
                        messageType = "Updated";
                        successMessage = "Country updated successfully";
                        command.CommandText = "PR_Country_Update";
                        command.Parameters.Add("@country_id", SqlDbType.Int).Value = country.CountryID;
                    }
                    command.Parameters.Add("@country_name", SqlDbType.VarChar).Value = country.CountryName;
                    command.ExecuteNonQuery();
                }
                TempData["MessageType"] = messageType;
                TempData["SuccessMessage"] = successMessage;
                return RedirectToAction("CountryList");
            }
            catch (Exception ex)
            {
                TempData["MessageType"] = "Error";
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("CountryList");
            }
        }
        #endregion
    }
}

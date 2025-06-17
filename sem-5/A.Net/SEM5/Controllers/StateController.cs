using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using SEM5.Models;

namespace SEM5.Controllers
{
    public class StateController : Controller
    {
        private IConfiguration Configuration;

        public StateController(IConfiguration _Configuration)
        {
            Configuration = _Configuration;
        }


        #region State List
        public IActionResult StateList()
        {
            string connectionString = this.Configuration.GetConnectionString("ConnectionString");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PR_State_SelectAll";
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return View(table);
            }
        }
        #endregion


        #region Add Edit State
        public IActionResult AddEditState(int? StateID)
        {
            CountryDropDown();
            if (StateID == null)
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
                command.CommandText = "PR_State_SelectByPK";
                command.Parameters.Add("@state_id", SqlDbType.Int).Value = StateID;
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                StateModel state = new StateModel();

                foreach (DataRow row in table.Rows)
                {
                    state.StateID = Convert.ToInt32(row["StateID"]);
                    state.StateName = row["StateName"].ToString();
                    state.StateCode = row["StateCode"].ToString();
                    state.CountryID = Convert.ToInt32(row["CountryID"]);
                }
                return View(state);
            }
        }
        #endregion


        #region State Save
        public IActionResult StateSave(StateModel state)
        {
            try
            {
                string messageType;
                string successMessage;
                string connectionString = Configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    if (state.StateID == null)
                    {
                        command.CommandText = "PR_State_Insert";
                        messageType = "Inserted";
                        successMessage = "State inserted successfully";
                    }
                    else
                    {
                        messageType = "Updated";
                        successMessage = "State updated successfully";
                        command.CommandText = "PR_State_Update";
                        command.Parameters.Add("@state_id", SqlDbType.Int).Value = state.StateID;
                    }
                    command.Parameters.Add("@state_name", SqlDbType.VarChar).Value = state.StateName;
                    command.Parameters.Add("@state_code", SqlDbType.VarChar).Value = state.StateCode;
                    command.Parameters.Add("@country_id", SqlDbType.Int).Value = state.CountryID;
                    command.ExecuteNonQuery();
                }
                TempData["MessageType"] = messageType;
                TempData["SuccessMessage"] = successMessage;
                return RedirectToAction("StateList");
            }
            catch (Exception ex)
            {
                TempData["MessageType"] = "Error";
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("StateList");
            }
        }
        #endregion


        #region Delete State
        public IActionResult DeleteState(int StateID)
        {
            try
            {
                string connectionString = Configuration.GetConnectionString("ConnectionString");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PR_State_Delete";
                    command.Parameters.Add("@state_id", SqlDbType.Int).Value = StateID;
                    command.ExecuteNonQuery();
                }
                TempData["MessageType"] = "Deleted";
                TempData["SuccessMessage"] = "State deleted successfully.";
                return RedirectToAction("StateList");
            }
            catch (Exception ex)
            {
                TempData["MessageType"] = "Error";
                TempData["ErrorMessage"] = "An error occurred while deleting the State: " + ex.Message;
                return RedirectToAction("StateList");
            }
        }
        #endregion


        #region Country DropDown
        public void CountryDropDown()
        {
            string connectionString = this.Configuration.GetConnectionString("ConnectionString");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PR_Country_DropDown";
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                List<CountryDropDownModel> countryList = new List<CountryDropDownModel>();
                foreach (DataRow row in table.Rows)
                {
                    countryList.Add(new CountryDropDownModel()
                    {
                        CountryID = Convert.ToInt32(row["CountryID"].ToString()),
                        CountryName = row["CountryName"].ToString()
                    });
                }
                ViewBag.CountryList = countryList;
            }
        }
        #endregion
    }
}

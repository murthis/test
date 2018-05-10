using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Assignments.Models;

namespace Assignments.DataAccess
{
    public class DAAddressBook
    {
        SqlConnection _SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AssignmentDB"].ConnectionString);
        public List<AddressBookModels> GetAddressBook()
        {
            List<AddressBookModels> _AddressBook = new List<AddressBookModels>();
            try
            {
                string query = "GetAddressBook";
                SqlCommand cmd = new SqlCommand(query, _SqlConnection);
                _SqlConnection.Open();

                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dtSchema = dr.GetSchemaTable();
                DataTable dt = new DataTable();
                while (dr.Read())
                {
                    _AddressBook.Add(new AddressBookModels()
                    {
                        AddressID = Convert.ToInt16(dr["AddressID"]),
                        PersonName = dr["PersonName"].ToString(),
                        ContactNumber = dr["ContactNumber"].ToString(),
                        Address = dr["AddressLine"].ToString(),
                        StateName = dr["StateName"].ToString(),
                        CityName = dr["CityName"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _AddressBook;
        }

    }
}
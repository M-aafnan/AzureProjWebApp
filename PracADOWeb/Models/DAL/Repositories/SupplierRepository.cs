using PracADOWeb.Models.DAL.IRepositories;
using PracADOWeb.Models.DBModels.CoreModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PracADOWeb.Models.DAL.Repositories
{
    public class SupplierRepository: ISupplierRepository
    {
        SqlConnection connection = DBConnection.GetConnection();

        public async Task<List<Supplier>> GetAll()
        {
            List<Supplier> suppliers = new List<Supplier>();

            SqlCommand cmd = new SqlCommand("GetAllSuppliers", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataReader dataReader = await cmd.ExecuteReaderAsync();
            while (dataReader.Read())
            {
                var supplier = new Supplier()
                {
                   Id = dataReader["Id"].ToString().Trim(),
                   Address = dataReader["Address"].ToString(),
                   Contact = dataReader["ContactNo"].ToString(),
                   EmailID = dataReader["EmailID"].ToString(),
                   SupplierName = dataReader["SupplierName"].ToString()
                };
                suppliers.Add(supplier);

            }
            dataReader.Close();
            
            return (suppliers);
        }
        public async  Task<Supplier> GetById(string id)
        {
            Supplier supplier = new Supplier();

            SqlCommand cmd = new SqlCommand("GetSupplierById", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            
            SqlDataReader dataReader = await cmd.ExecuteReaderAsync();
            while (dataReader.Read())
            {
                supplier.Id = dataReader["Id"].ToString().Trim();
                supplier.Address = dataReader["Address"].ToString();
                supplier.Contact = dataReader["ContactNo"].ToString();
                supplier.EmailID = dataReader["EmailID"].ToString();
                supplier.SupplierName = dataReader["SupplierName"].ToString();
            }
            dataReader.Close();
            return supplier;

        }
        public async Task Insert(Supplier supplier)
        {
            
            var cmd = new SqlCommand("CreateSupplier", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Guid.NewGuid().ToString());
            cmd.Parameters.AddWithValue("@address", supplier.Address);
            cmd.Parameters.AddWithValue("@emailID", supplier.EmailID);
            cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
            cmd.Parameters.AddWithValue("@contact", supplier.Contact);
            await cmd.ExecuteNonQueryAsync();
            

        }
        public async Task Update(Supplier supplier)
        {
            var cmd = new SqlCommand("EditSupplier", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", supplier.Id);
            cmd.Parameters.AddWithValue("@address", supplier.Address);
            cmd.Parameters.AddWithValue("@emailID", supplier.EmailID);
            cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
            cmd.Parameters.AddWithValue("@contact", supplier.Contact);
            await cmd.ExecuteNonQueryAsync();
        }
        public async Task Delete(Supplier supplier)
        {
            var cmd = new SqlCommand("DeleteSupplier", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@id", supplier.Id);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}
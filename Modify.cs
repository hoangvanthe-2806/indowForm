using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace demo
{
    public class Modify
    {
        SqlDataAdapter dataAdapter;//se truy xuat toan bo du lieu vao datatable
        SqlCommand SqlCommand;//dung de truy van va cap nhap toi CSDL
        public Modify()
        {
        }
        //dataset se tra ve nhieu bang
        //datatable tra ve 1 bang
        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from NhanVien1";
            using(SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(NhanVien nhanVien)
        {
            
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into NhanVien1 values(@id,@ten,@tuoi,@gioiTinh)";
            try
            {
                sqlConnection.Open() ;
                SqlCommand SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.Parameters.Add("@id", SqlDbType.NChar).Value = nhanVien.Id;
                SqlCommand.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nhanVien.Name;
                SqlCommand.Parameters.Add("@tuoi", SqlDbType.NChar).Value = nhanVien.Tuoi;
                SqlCommand.Parameters.Add("@gioiTinh", SqlDbType.NChar).Value = nhanVien.GioiTinh;
                SqlCommand.ExecuteNonQuery();//thuc thi lenh truy van
            
            
            }catch 
            {
                return false;
            }finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(NhanVien nhanVien)
        {

            SqlConnection sqlConnection = Connection.getConnection();
            string query = "update  NhanVien1 set ten=@ten,tuoi=@tuoi,gioitinh=@gioitinh Where id=@id ";
            try
            {
                sqlConnection.Open();
                SqlCommand SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.Parameters.Add("@id", SqlDbType.NChar).Value = nhanVien.Id;
                SqlCommand.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nhanVien.Name;
                SqlCommand.Parameters.Add("@tuoi", SqlDbType.NChar).Value = nhanVien.Tuoi;
                SqlCommand.Parameters.Add("@gioiTinh", SqlDbType.NChar).Value = nhanVien.GioiTinh;
                SqlCommand.ExecuteNonQuery();//thuc thi lenh truy van


            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool delete(string id)
        {

            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete NhanVien1 Where id=@id ";
            try
            {
                sqlConnection.Open();
                SqlCommand SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.Parameters.Add("@id", SqlDbType.NChar).Value = id;
                
             
                SqlCommand.ExecuteNonQuery();//thuc thi lenh truy van


            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}

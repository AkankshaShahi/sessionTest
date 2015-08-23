using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DALStudent
    {
       static SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        private static  SqlCommand createCommand(EntityStudent estud)
        {
          
            SqlCommand cmd = new SqlCommand("SPDDLDMLStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@task", estud.Task);
            cmd.Parameters.AddWithValue("@name", estud.Name);
            cmd.Parameters.AddWithValue("@address", estud.Address);
            cmd.Parameters.AddWithValue("@age", estud.Age);
            cmd.Parameters.AddWithValue("@DOB", estud.DOB1);
            cmd.Parameters.AddWithValue("@contactnum", estud.Contactnumb);
            cmd.Parameters.AddWithValue("@id", estud.Id);
            cmd.Parameters.AddWithValue("@EmailId", estud.Emailid);
            cmd.Parameters.AddWithValue("@gender", estud.Gender);
            //cmd.Parameters.AddWithValue("@PageSize", estud.pagesize);
            //cmd.Parameters.AddWithValue("@PageIndex", estud.PageIndex);
            //cmd.Parameters.AddWithValue("@task", estud.Task);
            //cmd.Parameters.AddWithValue("@task", estud.Task);
            return cmd;
        } //Creating command to pass the value and interact with SQL
        #region DMLOperation
        public static  bool insertStudent(EntityStudent estud)
        {
            bool b = false;
            try
            {
               
                SqlCommand cmd = createCommand(estud);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                b = true;
               
            }
            catch (Exception ex)
            {
                b = false;
            }
            return b;
        }//insert Student Record 
        public static  bool updateStudent(EntityStudent estud)
        {
            bool b = false;
            try
            {
                SqlCommand cmd = createCommand(estud);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                b = true;
            }
            catch (Exception ex)
            {
                b = false;
            }
           
            return b;
        }//Update Student Record
        public static bool deleteStudent(EntityStudent estud)
        {
            bool b = false;
            try
            {
                SqlCommand cmd = createCommand(estud);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                b = true;
            }
            catch (Exception ex)
            {
                b = false;
            }
            return b;
        }//Delete student Record
        #endregion
        #region DDLOperation
        public static DataSet getStudentData(EntityStudent estud)
        {
            DataSet dsget = new DataSet();
            try
            {
                SqlCommand cmd = createCommand(estud);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(dsget);
            }
            catch (Exception ex)
            {
                dsget = null;
            }
            return dsget;
        }//Fetching all record Of Student
        public static DataSet getSingeStudentData(EntityStudent estud)
        {
            DataSet dsget = new DataSet();
            try
            {
                SqlCommand cmd = createCommand(estud);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                
                adp.Fill(dsget);
            }
            catch (Exception ex)
            {
                dsget = null;
            }
            return dsget;
        }//fetching Single record Of Student For Updation
        #endregion
    }
       
}

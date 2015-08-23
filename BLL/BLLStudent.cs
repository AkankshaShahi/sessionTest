using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;

namespace BLL
{
    public class BLLStudent
    {
        public static bool insertStudent(EntityStudent estud)
        {
            bool b = DALStudent.insertStudent(estud);
            return b;
        }//insertion() call
        public static bool updateStudent(EntityStudent estud)
        {
            bool b = DALStudent.updateStudent(estud);
            return b;
        }//update() call
        public static bool deleteStudent(EntityStudent estud)
        {
            bool b =  DALStudent.deleteStudent(estud);
            return b;
        }//delete() call
        public static DataSet getStudentData(EntityStudent estud)
        {
            DataSet dsget = DALStudent.getStudentData(estud);
            return dsget;
        }//get all rec() call
        public static DataSet getSingeStudentData(EntityStudent estud)
        {
            DataSet dsget = DALStudent.getSingeStudentData(estud);
            return dsget;
        } //fetch record according to id call
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityStudent
    {
        private int task;
        public int Task
        {
            get { return task; }
            set { task = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private DateTime DOB=DateTime.Today.Date;
        public DateTime DOB1
        {
            get { return DOB; }
            set { DOB = value; }
        }
        private bool gender;
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private bool isactive;
        public bool Isactive
        {
            get { return isactive; }
            set { isactive = value; }
        }
        private string emailid;
        public string Emailid
        {
            get { return emailid; }
            set { emailid = value; }
        }
        private double contactnumb;
        public double Contactnumb
        {
            get { return contactnumb; }
            set { contactnumb = value; }
        }
        public int pagesize;
        public int PageIndex;

    }
}

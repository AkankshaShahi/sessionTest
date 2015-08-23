using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BLL;
using System.Data;
namespace WebApplication1
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnclose.Visible = false;
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    assignvaluesToControl(id);
                    ViewState["Id"] = id;
                }
            }
        }
        private void assignvaluesToControl(int id)
        {
            EntityStudent es = new EntityStudent();
            btnsave.Text = "Update";
            DataSet ds = new DataSet();
            es.Task = 5;
            es.Id = id;
            ds = BLLStudent.getSingeStudentData(es);
            if (ds.Tables.Count > 0)
            {
                txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["EmailId"].ToString();
                txtcntnum.Text = ds.Tables[0].Rows[0]["ContactNum"].ToString();
                txtAge.Text = ds.Tables[0].Rows[0]["Age"].ToString();
                txtaddress.Text = ds.Tables[0].Rows[0]["Addresses"].ToString();
                if (ds.Tables[0].Rows[0]["Gender"].ToString().Equals("0"))
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
                clddate.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
            }


        }//assigning values to Control
        private void insertStudent()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtcntnum.Text) && !string.IsNullOrEmpty(txtAge.Text) && !string.IsNullOrEmpty(txtaddress.Text))
                {
                    EntityStudent es = new EntityStudent();

                    es.Name = txtName.Text;
                    es.Address = txtaddress.Text;
                    es.Age = Convert.ToInt16(txtAge.Text);
                    es.DOB1 = DateTime.Parse(clddate.Text);
                    es.Emailid = txtEmail.Text;
                    es.Contactnumb = Convert.ToDouble(txtcntnum.Text);
                    if (rdMale.Checked == true)
                    {

                        es.Gender = false;
                    }
                    else
                    {
                        es.Gender = true;
                    }
                    if (btnsave.Text.Equals("Save"))
                    {
                        es.Task = 1;
                        bool b = BLLStudent.insertStudent(es);
                        clearControls();
                        if (b == true)
                        {
                            Response.Redirect("StudentView.aspx?stud={0}");
                            clearControls();
                        }
                        else
                        {
                            btnclose.Visible = true;
                            ltrlerror.Text = "Error while insertion";
                        }
                    }
                    if (btnsave.Text.Equals("Update"))
                    {
                        es.Task = 2;
                        es.Id = int.Parse(ViewState["Id"].ToString());
                        bool b = BLLStudent.updateStudent(es);
                        if (b == true)
                        {
                            Response.Redirect("StudentView.aspx?stud1={1}");
                            clearControls();
                        }
                        else
                        {
                            btnclose.Visible = true;
                            ltrlerror.Text = "Error while Updation";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ltrlerror.Text = "Error";
                btnclose.Visible = true;
            }
        }//insertion and updation
        protected void btnsave_Click(object sender, EventArgs e)
        {
            insertStudent();
        }
        private void clearControls()
        {
            txtaddress.Text = "";
            txtAge.Text = "";
            txtcntnum.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            clddate.Text = "";
            rdFemale.Checked = false;
            rdMale.Checked = true;
            btnsave.Text = "Save";
        }//clear all control
        protected void btnclose_Click(object sender, EventArgs e)
        {
            ltrlerror.Text = "";
            btnclose.Visible = false;
        }
    }
}
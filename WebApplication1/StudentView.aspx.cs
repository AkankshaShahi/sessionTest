using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
namespace WebApplication1
{
    public partial class StudentView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnclose.Visible = false;
          
            if (!string.IsNullOrEmpty(Request.QueryString["id1"]))
            {
                int id = int.Parse(Request.QueryString["id1"].ToString());
                deleteStudent(id);
                loadStudent();
            }
            if (!IsPostBack)
            {
               if (!string.IsNullOrEmpty(Request.QueryString["stud"]))
               {
                  ltrlerror.Text = "Record Inserted SuccessFully";
                  btnclose.Visible = true;
                 //  loadStudent();
              }
              if (!string.IsNullOrEmpty(Request.QueryString["stud1"]))
              {
                   ltrlerror.Text = "Record Updated SuccessFully";
                   btnclose.Visible = true;
                  // loadStudent();
                  
              }

              loadStudent();
            }
        }
        private void deleteStudent(int id)
        {
            try
            {
                EntityStudent es = new EntityStudent();
                es.Task = 3;
                es.Id = id;
                bool b = BLLStudent.deleteStudent(es);
                if (b == true)
                {
                    //  Response.Write("<script language=javascript>alert('Deleted Successfully');</script>");
                    ltrlerror.Text = "Deleted Successfully";
                    btnclose.Visible = true;
                }
                else
                {
                    ltrlerror.Text = "Error while deletion";
                    btnclose.Visible = true;
                    // Response.Write("<script language=javascript>alert('Error');</script>");
                }
            }
            catch (Exception ex)
            {
                ltrlerror.Text = "Error while deletion";
                btnclose.Visible = true;
            }


        }//deleting record
        private void loadStudent()//string pagesize,int pageindex)
        {
            try
            {
                EntityStudent es = new EntityStudent();
                es.Task = 4;
                es.pagesize = grdStudent.PageSize;
                if (ViewState["OBJ"]!=null)
                {
                    es.PageIndex = int.Parse(ViewState["OBJ"].ToString());
                }
                else
                {
                    es.PageIndex = 1;
                }
                DataSet ds = new DataSet();
                ds = BLLStudent.getStudentData(es);
                if (ds.Tables.Count > 0)
                {
                    grdStudent.DataSource = ds;
                    grdStudent.DataBind();
                }
                else
                {
                    ltrlerror.Text = "No Records Found";
                    btnclose.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ltrlerror.Text = "Error .. Could not Load data";
                btnclose.Visible = true;
            }


        }//fetching all record
        protected void grdStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdStudent.PageIndex = e.NewPageIndex;
            string ss = grdStudent.PageIndex.ToString();
            loadStudent();
            ViewState["OBJ"] = ss;
        }
        protected void btnclose_Click(object sender, EventArgs e)
        {
            ltrlerror.Text = "";
            btnclose.Visible = false;
            loadStudent();
        }
        protected void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                EntityStudent es = new EntityStudent();
                es.Task = 7;
                if (!string.IsNullOrEmpty(txtname.Text) || !string.IsNullOrEmpty(txtcntnum.Text) || !string.IsNullOrEmpty(txtEID.Text) || !string.IsNullOrEmpty(txtID.Text))
                {
                    if (!string.IsNullOrEmpty(txtID.Text))
                    {
                    es.Id = int.Parse(txtID.Text);}
                    es.Name = txtname.Text;
                    if (!string.IsNullOrEmpty(txtcntnum.Text))
                    {
                        es.Contactnumb = double.Parse(txtcntnum.Text);
                    }
                   
                    es.Emailid = txtEID.Text;
                    es.pagesize = grdStudent.PageSize;
                    if (ViewState["OBJ"] != null)
                    {
                        es.PageIndex = int.Parse(ViewState["OBJ"].ToString());
                    }
                    else
                    {
                        es.PageIndex = 1;
                    }
                    DataSet ds = new DataSet();
                    ds = BLLStudent.getStudentData(es);
                    if (ds.Tables.Count > 0)
                    {
                        grdStudent.DataSource = ds;
                        grdStudent.DataBind();
                    }
                    else
                    {
                        ltrlerror.Text = "No Records Found";
                        btnclose.Visible = true;
                    }
                }
                else
                {
                    loadStudent();
                }
            }
          
            catch (Exception ex)
            {
                ltrlerror.Text = "Error .. Could not Load data";
                btnclose.Visible = true;
            }
        }
    }
}
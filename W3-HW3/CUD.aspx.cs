using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationDB;

namespace HW3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)  //新增按鈕
        {
            string newID = this.txtID.Text;
            string firstname = this.txtfirstname.Text;
            string lastname = this.txtlastname.Text;
            string account = this.txtaccount.Text;
            string password = this.txtpassword.Text;
            string birthday = this.txtBirthday.Text;
            string email = this.txtemail.Text;
            string cellphone = this.txtcellphone.Text;
            string address = this.txtaddress.Text;
            DataBaseExecutor.InsertTestTable1(newID, firstname, lastname, account, password, birthday, email, cellphone, address);
        }

        protected void Button2_Click(object sender, EventArgs e)  //刪除按鈕
        {
            this.Response.Write("削除しました。");
            string newID = this.txtID.Text;
            DataBaseExecutor.DeleteTestTable1(newID);
        }

        protected void Button3_Click(object sender, EventArgs e)  //查詢按鈕
        {
            string id = this.txtID.Text;
            this.GridView1.DataSource = DataBaseExecutor.SelectTable1DT(id);
            this.GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)  //修改按鈕
        {
            string newID = this.txtID.Text;
            string firstname = this.txtfirstname.Text;
            string lastname = this.txtlastname.Text;
            string account = this.txtaccount.Text;
            string password = this.txtpassword.Text;
            string birthday = this.txtBirthday.Text;
            string email = this.txtemail.Text;
            string cellphone = this.txtcellphone.Text;
            string address = this.txtaddress.Text;
            DataBaseExecutor.UpdateTable1(newID, firstname, lastname, account, password, birthday, email, cellphone, address);
        }

        protected void Button5_Click(object sender, EventArgs e)  //顯示所有資料按鈕
        {

            this.GridView1.DataSource = DataBaseExecutor.SelectTableDT();
            this.GridView1.DataBind();
        }

    }
}
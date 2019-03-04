using People_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace People_CRUD
{
    public partial class people : System.Web.UI.Page
    {
        PersonRepo repo = new PersonRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        //add person
        protected void LinkButton_AddPerson_Click1(object sender, EventArgs e)
        {
           //1. bind
            TextBox txtbx_name = (TextBox)GridView1.FooterRow.FindControl("TextBox_AddPersonName");
            TextBox txtbx_phone = (TextBox)GridView1.FooterRow.FindControl("TextBox_AddPersonPhone");
            TextBox txtbx_bdate = (TextBox)GridView1.FooterRow.FindControl("TextBox_AddPersonBirthDate");
            DropDownList ddl_gender = (DropDownList)GridView1.FooterRow.FindControl("DropDownList_AddPersonGender");
            CheckBox chkbx_ismarried = (CheckBox)GridView1.FooterRow.FindControl("CheckBox_AddPersonIsMarried");
            person p = new person()
            {
                Name = txtbx_name.Text,
                Phone = (String.IsNullOrEmpty(txtbx_phone.Text)) ? null : txtbx_phone.Text,
                IsMarried = chkbx_ismarried.Checked,
                Gender = (String.IsNullOrEmpty(ddl_gender.SelectedValue)) ? (Nullable<Gender>)null : (Gender)Enum.Parse(typeof(Gender), ddl_gender.SelectedValue),
                BDate = (String.IsNullOrEmpty(txtbx_bdate.Text)) ? (Nullable<System.DateTime>)null : DateTime.ParseExact(txtbx_bdate.Text, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            };
            //2. add
            //repo.AddPerson(p);

            PeopleServiceReference2.peopleSoapClient peopleSoap = new PeopleServiceReference2.peopleSoapClient();
            PeopleServiceReference2.personServic personService = new PeopleServiceReference2.personServic();
            personService.Name = p.Name;
            personService.Phone = p.Phone;
            personService.IsMarried = p.IsMarried;
            //personService.Gender = (PeopleServiceReference2.Gender)p.Gender;
            personService.Gender = (p.Gender == Gender.Male) ? (PeopleServiceReference2.Gender.Male) : (PeopleServiceReference2.Gender.Female);
            personService.BDate = p.BDate;
            peopleSoap.AddPerson(personService);
            GridView1.DataBind();
        }


        //custom validator for dates   ---> not working
        protected void CustomValidator_AddPersonBDate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                DateTime dummy = DateTime.ParseExact(args.Value, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                args.IsValid = (dummy.Month > 12) ? false : true;
            }
            catch(System.FormatException ex)
            {
                args.IsValid = false;
            }
        }

        protected void Button_GetNames_Service_Click(object sender, EventArgs e)
        {
            PeopleServiceReference2.peopleSoapClient peopleSoap = new PeopleServiceReference2.peopleSoapClient();
            List<string> names = peopleSoap.GetNames();
            Label_DisplayNames.Text = "<ul class=\"list-group\" style=\"list-style-type:none; \" >";
            foreach(string name in names)
            {
                //Label_DisplayNames.Text += ("-"+name + "<br />");
                Label_DisplayNames.Text += ("<li class=\"list-group-item\" >" + name + "<li />");
            }
            Label_DisplayNames.Text += "</ ul>";
        }


        //delete person
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //1.get target person id
            LinkButton DeleteButton = (LinkButton)sender;
            //string id = DeleteButton.Attributes["PersonId"].ToString();
            int Id = int.Parse(DeleteButton.CssClass);

            //2. delete the peson
            //PersonRepo repo = new PersonRepo();
            //repo.DeletePerson(Id);
            PeopleServiceReference2.peopleSoapClient peopleSoap = new PeopleServiceReference2.peopleSoapClient();
            peopleSoap.DeletePerson(Id);
            //3.refresh grid
            GridView1.DataBind();
        }


        //update person
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //1.get target person id
            LinkButton DeleteButton = (LinkButton)sender;
            int id = int.Parse(DeleteButton.CssClass);
            GridViewRow row = (GridViewRow)DeleteButton.NamingContainer;

            //2. bind model
            

            TextBox txtbx_name = (TextBox)row.FindControl("TextBox4");
            TextBox txtbx_phone = (TextBox)row.FindControl("TextBox3");
            TextBox txtbx_bdate = (TextBox)row.FindControl("TextBox1");
            DropDownList ddl_gender = (DropDownList)row.FindControl("DropDownList1");
            CheckBox chkbx_ismarried = (CheckBox)row.FindControl("CheckBox1");

            person p = new person()
            {
                Id = id,
                Name = txtbx_name.Text,
                Phone = (String.IsNullOrEmpty(txtbx_phone.Text)) ? null : txtbx_phone.Text,
                IsMarried = chkbx_ismarried.Checked,
                Gender = (String.IsNullOrEmpty(ddl_gender.SelectedValue)) ? (Nullable<Gender>)null : (Gender)Enum.Parse(typeof(Gender), ddl_gender.SelectedValue),
                BDate = (String.IsNullOrEmpty(txtbx_bdate.Text)) ? (Nullable<System.DateTime>)null : DateTime.ParseExact(txtbx_bdate.Text, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            };

            PeopleServiceReference2.personServic personService = new PeopleServiceReference2.personServic();
            personService.Id = id;
            personService.Name = p.Name;
            personService.Phone = p.Phone;
            personService.IsMarried = p.IsMarried;
            personService.Gender = (p.Gender == Gender.Male) ? (PeopleServiceReference2.Gender.Male) : (PeopleServiceReference2.Gender.Female);
            personService.BDate = p.BDate;


            //3.update model
            PeopleServiceReference2.peopleSoapClient peopleSoap = new PeopleServiceReference2.peopleSoapClient();
            peopleSoap.EditPerson(personService);

            //4.refresh
            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }
    }
}
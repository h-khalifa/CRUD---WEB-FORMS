using People_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace People_CRUD.service
{
    /// <summary>
    /// Summary description for people
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class people : System.Web.Services.WebService
    {
        


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public void AddPerson(person person)
        {
            PersonRepo repo = new PersonRepo();
            repo.AddPerson(person);
        }

        [WebMethod]
        public List<string> GetNames()
        {
            PersonRepo repo = new PersonRepo();
            return repo.GetPeopleFullNames().ToList();
        }


        [WebMethod]
        public void DeletePerson(int Id)
        {
            PersonRepo repo = new PersonRepo();
            repo.DeletePerson(Id);
        }

        [WebMethod]
        public void EditPerson(person person)
        {
            PersonRepo repo = new PersonRepo();
            repo.EditPerson(person);
        }

        //[WebMethod]
        //public IEnumerable<person> GetAll()
        //{
        //    PersonRepo repo = new PersonRepo();
        //    return repo.GetAll();
        //}


    }
}

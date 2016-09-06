using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadeMeuMedico.Models;
using System.Data.SqlClient;

namespace CadeMeuMedico.Controllers
{
    public class MedicoController : Controller
    {
        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();

        //
        // GET: /Medico/
        public ActionResult Index()
        {
            try
            {
               var medicos = db.Medicos.Include("Cidades").Include("Especialidades").ToList();
               return View(medicos);
            }
            catch (Exception e)
            {
                //generic exception
            }

            return View();
        }
	}
}
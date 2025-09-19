using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Techly.BLL.Interfaces;
using Techly.DAL.Models;
using Techly.DAL.ViewModels;
using Utility;

namespace Techly.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Company> companies = _unitOfWork.Company.GetAll().ToList();

            return View(companies);
        }
        
        public IActionResult Upsert(int? id)
        {
           
            if (id is null || id == 0)
            {
                //create
            return View(new Company());

            }
            else
            {
                //update
                Company company = _unitOfWork.Company.Get(u=>u.Id == id);
                return View(company);
            }
           
        }
        [HttpPost]
        public IActionResult Upsert(Company Companyobj)
        {
            if(ModelState.IsValid)
            {
                if (Companyobj.Id==0)
                {
                    _unitOfWork.Company.Add(Companyobj);
                }
                else
                {
                    _unitOfWork.Company.Update(Companyobj);
                }
                _unitOfWork.Save();
                TempData["success"] = "Company created successfully";
                return RedirectToAction("Index");
            }
            else
            {
            return View(Companyobj);
            }
        }
      
  
        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> Companys = _unitOfWork.Company.GetAll().ToList();
            return Json(new { data = Companys });

        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var CompanysToBeDeleted = _unitOfWork.Company.Get(u=>u.Id==id);
            if (CompanysToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Company.Delete(CompanysToBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true,message = "Deleted Successful" });

        }
        #endregion
    }
}

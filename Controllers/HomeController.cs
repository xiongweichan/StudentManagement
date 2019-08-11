using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        //操作方法
        public string Index()
        {
            return _studentRepository.GetStudent(1).Name;
            //return Json(new { id = "1", name = "张三" });
        }
        //public JsonResult Details()
        //{
        //    return Json(_studentRepository.GetStudent(1));
        //    //return Json(new { id = "1", name = "张三" });
        //}
        //内容协商，根据请求来返回格式，要什么格式给什么格式
        //public ObjectResult Details()
        //{
        //    return new ObjectResult(_studentRepository.GetStudent(1));
        //}
        public IActionResult Details()
        {
            var model = _studentRepository.GetStudent(1);

            //ViewBag.PageTitle = "学生详情";
            //ViewBag.Student = model;
            //ViewData["PageTitle"] = "Student Details";
            //ViewData["Student"] = model;

            return View(model);
        }
    }
}
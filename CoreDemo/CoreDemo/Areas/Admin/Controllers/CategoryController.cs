﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var values = cm.GetList().ToPagedList(page,5);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {

            CategoryValidator bv = new CategoryValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                //bloğun durumunu false yaparak admine onaylatılabilir
                p.CategoryStatus = true;
                 cm.TAdd(p);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();

        }
        public IActionResult CategoryDelete(int id)
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}

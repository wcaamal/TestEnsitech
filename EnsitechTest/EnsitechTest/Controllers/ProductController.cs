using EnsitechTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ensitech.BusinessLogic.Services;
using Ensitech.BusinessLogic.Interfaces;
using Ensitech.Entities;

namespace EnsitechTest.Controllers
{
    public class ProductController : Controller
    {
        IService<Product> _productService;
        IService<string> _originService;
        public ProductController()
        {
            if (_productService == null)
                _productService = new ProductService();
            if (_originService == null)
                _originService = new OriginService();
        }
        // GET: Product
        public ActionResult Index()
        {
            try
            {
                var products = _productService.Get();
                return View(products);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(new List<Product>());
            }
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            try
            {
                ViewBag.Origins = _originService.Get();
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    if (!_productService.Create(product))
                        throw new Exception("Error al guardar la informacion");
                    return RedirectToAction("Index");                     
                }
                else
                {
                    ViewBag.Origins = _originService.Get();
                    return View(product);
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
    }
}

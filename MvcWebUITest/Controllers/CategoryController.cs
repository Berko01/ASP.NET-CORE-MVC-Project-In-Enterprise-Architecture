using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUITest.Models;

namespace MvcWebUITest.Controllers
{
    public class CategoryController:Controller
    {
        private ICategoryService _categoryService;

        public CategoryController (ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

    }
}

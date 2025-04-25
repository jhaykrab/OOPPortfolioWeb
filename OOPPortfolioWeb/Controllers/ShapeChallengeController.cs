using Microsoft.AspNetCore.Mvc;
using OOPPortfolioWeb.Models;
using System.Collections.Generic;

namespace OOPPortfolioWeb.Controllers
{
    public class ShapeChallengeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ShapeInputModel());
        }

        [HttpPost]
        public IActionResult Index(ShapeInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }

            string result = string.Empty;

            // Process the input based on the shape type
            switch (input.ShapeType?.ToLower())
            {
                case "circle":
                    if (input.Radius.HasValue)
                    {
                        var circle = new Circle(input.Color, input.Radius.Value);
                        result = $"Circle Area: {circle.CalculateArea()} (Color: {circle.Color})";
                    }
                    break;

                case "rectangle":
                    if (input.Width.HasValue && input.Height.HasValue)
                    {
                        var rectangle = new Rectangle(input.Color, input.Width.Value, input.Height.Value);
                        result = $"Rectangle Area: {rectangle.CalculateArea()} (Color: {rectangle.Color})";
                    }
                    break;

                case "triangle":
                    if (input.BaseLength.HasValue && input.Height.HasValue)
                    {
                        var triangle = new Triangle(input.Color, input.BaseLength.Value, input.Height.Value);
                        result = $"Triangle Area: {triangle.CalculateArea()} (Color: {triangle.Color})";
                    }
                    break;
            }

            ViewBag.Result = result;
            return View(input);
        }
        
    }
}

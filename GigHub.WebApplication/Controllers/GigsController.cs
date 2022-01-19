﻿using GigHub.WebApplication.Models;
using GigHub.WebApplication.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.WebApplication.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}
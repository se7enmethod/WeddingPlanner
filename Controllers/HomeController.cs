using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http; // for session
using Microsoft.AspNetCore.Identity; // for password hashing
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {

        private WPContext dbContext;

        public HomeController(WPContext context)
        {
            dbContext = context;
        }

        // ROUTE:               METHOD:                VIEW:
        // -----------------------------------------------------------------------------------
        // GET("")              Index()                Index.cshtml
        // POST("/register")    Create(User user)      ------ (Index.cshtml to display errors)
        // POST("/login")       Login(LoginUser user)  ------ (Index.cshtml to display errors)
        // GET("/logout")       Logout()               ------
        // GET("/success")      Success()              Success.cshtml

        [HttpGet("")]
        public IActionResult Index()
        {
            //List<User> AllUsers = dbContext.Users.ToList();
            return View();
        }

        [HttpPost("/register")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (dbContext.Users.Any(u => u.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }

                // hash password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

                // create user
                dbContext.Add(user);
                dbContext.SaveChanges();

                // sign user into session
                var NewUser = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                int UserId = NewUser.UserId;
                HttpContext.Session.SetInt32("UserId", UserId);

                // go to success
                return RedirectToAction("Dashboard");
            }
            // display errors
            else
            {
                return View("Index");
            }
        }

        [HttpPost("/login")]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();

                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LoginPassword", "Password is invalid.");
                    return View("Index");
                }

                // sign user into session
                int UserId = userInDb.UserId;
                HttpContext.Session.SetInt32("UserId", UserId);

                return RedirectToAction("Dashboard");
            }
            // display errors
            else
            {
                return View("Index");
            }
        }

        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        ///////////// BEGINNING OF CRUD METHODS FOR WEDDING MODEL /////////////

        // GET ALL Weddings
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToAction("Index");
            }
            Wedding[] AllWeddings = dbContext.Weddings
                .Include(w => w.Guests)
                .ThenInclude(g => g.User)
                .Include(w => w.Creator)
                .ToArray();

            ViewBag.UserId = userId;

            return View("Dashboard", AllWeddings);
        }

        //  GET One Single Wedding 
        [HttpGet("wedding/{weddingId}")]
        public IActionResult Wedding(int weddingId)
        {
            Wedding OneSingleWedding = dbContext.Weddings
                .Include(w => w.Guests)
                .ThenInclude(g => g.User)
                .FirstOrDefault(b => b.WeddingId == weddingId);

            return View("Wedding", OneSingleWedding);
        }

        // POST RSVP for wedding
        [HttpPost("wedding/{weddingId}/rsvp")]
        public IActionResult RSVP(int weddingId)
        {
            User user = dbContext.Users.FirstOrDefault(u => u.UserId == Convert.ToInt32(HttpContext.Session.GetInt32("UserId")));
            Wedding wedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            Association newAssociation = new Association() { UserId = user.UserId, WeddingId = wedding.WeddingId, User = user, Wedding = wedding };
            dbContext.Add(newAssociation);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        // POST UN-RSVP for wedding
        [HttpPost("wedding/{weddingId}/unrsvp")]
        public IActionResult UNRSVP(int weddingId)
        {
            //User user = dbContext.Users.FirstOrDefault(u => u.UserId == Convert.ToInt32(HttpContext.Session.GetInt32("UserId")));
            //Wedding wedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            Association AssociationToDelete = dbContext.Associations
                .FirstOrDefault(a => a.WeddingId == weddingId && a.UserId == Convert.ToInt32(HttpContext.Session.GetInt32("UserId")));
            dbContext.Remove(AssociationToDelete);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        // POST Delete One Single Wedding
        [HttpPost("wedding/{weddingId}/delete")]
        public IActionResult DeleteWedding(int weddingId)
        {
            Wedding OneSingleWedding = dbContext.Weddings
                .Include(w => w.Creator)
                .FirstOrDefault(b => b.WeddingId == weddingId);

            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToAction("Index");
            }
            else if (userId != OneSingleWedding.UserId)
            {
                return RedirectToAction("Dashboard");
            }

            dbContext.Weddings.Remove(OneSingleWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        // GET Wedding/create Page
        [HttpGet("wedding/create")]
        public IActionResult CreateWeddingForm()
        {
            return View();
        }

        // POST Create One Single Wedding
        [HttpPost("wedding/create")]
        public IActionResult CreateWedding(Wedding wedding)
        {

            wedding.UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));

            if (ModelState.IsValid)
            {
                dbContext.Add(wedding);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("CreateWeddingForm");
        }

        ///////////// END OF CRUD METHODS FOR WEDDING MODEL /////////////

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


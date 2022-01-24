using GigHub.WebApplication.Models;
using GigHub.WebApplication.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.WebApplication.Controllers
{
    public class ArtistFollowingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistFollowingController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: ArtistFollowing
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            var artists = _context.Followings
             .Where(f => f.FollowerId == userId)
             .Select(s => s.Followee)
             .Select(s => new FollowingArtistsViewModel
             {
                 ArtistName = s.Name
             });

            return View(artists);
        }
    }
}
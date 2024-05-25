using Library.Entities;
using Library.ExtensionMethods;
using Library.Repositories;
using Library.Services;
using Library.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using CreateVM = Library.ViewModels.Users.CreateVM;

namespace Library.Controllers
{
    
    public class UsersController : Controller
    {
        private readonly UserRepository _userRepository;

        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {

            IndexVM model = new IndexVM();
            model.Items = _userRepository.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateVM model = new CreateVM();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            User item = new User();
            PasswordService.HashPassword(model.Password, out string hash, out string salt);
            item.PasswordHash = hash;
            item.PasswordSalt = salt;

            if (_userRepository.IsUsernameTaken(item.Username))
            { 
                item.Username = model.Username;
            }
            else
            {
                this.ModelState.AddModelError("authError", "This username is already taken!");
            }

            _userRepository.Save(item);

            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            User? item = _userRepository.GetFirstOrDefault(u => u.Id == id);

            if (item == null)
            {
                return RedirectToAction("Index", "Users");
            }

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
           

            return View(model);
        }



        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User item = new User();
            item.Id = model.Id;
            PasswordService.HashPassword(model.Password, out string hash, out string salt);
            item.PasswordHash = hash;
            item.PasswordSalt = salt;

            User? user = _userRepository.GetFirstOrDefault(u => u.Id == item.Id);

            if (!_userRepository.IsUsernameTaken(model.Username) || user!.Username == model.Username)
            {
                item.Username = model.Username;
            }
            else
            {
                this.ModelState.AddModelError("authError", "This username is already taken!");
            }

            return RedirectToAction("Index", "Users");
        }


        public IActionResult Delete(Guid id)
        {
            User? item = _userRepository.GetFirstOrDefault(u => u.Id == id);

            if(item != null)
            {
                _userRepository.Delete(item);
            }
            
            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User? loggedUser = _userRepository.GetByUsername(model.Username);

            if (loggedUser == null)
            {
                ModelState.AddModelError("authError", "Invalid username or password!");
                return View(model);
            }

            if (!PasswordService.VerifyHashedPassword(model.Password, loggedUser.PasswordHash, loggedUser.PasswordSalt))
            {
                ModelState.AddModelError("authError", "Invalid username or password!");
                return View(model);
            }


            return RedirectToAction("Index", "Users");
        }



        public IActionResult Logout()
        {

            return RedirectToAction("Login", "Users");
        }
    }
}

using BLL;
using BOL;
using BOL.ViewModel;
using OnlineElection.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineElection.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private GenderManager _genderManager;
        private UserManager _userManager;
        public LoginController()
        {
            _genderManager = new GenderManager();
            _userManager = new UserManager();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                if(ModelState.IsValid)
                {
                  
                    if(Membership.ValidateUser(user.email,Encryption.Encrypt(user.password)))
                    {
                        //valid user
                        FormsAuthentication.SetAuthCookie(user.email, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        //invalid user
                        TempData["Msg"] = "Login failed";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                TempData["Msg"] = "Login failed" + ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Register()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.listGender = _genderManager.GetAll().ToList();
            //loginViewModel.user = new BOL.User();
            return View(loginViewModel);
        }

        [HttpPost]
        public ActionResult Register(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_userManager.FindUserByEmail(model.email)==null)
                    {
                        BOL.User user = new BOL.User()
                        {
                            userId=model.userId,
                            email=model.email,
                            password=Encryption.Encrypt(model.password),
                            firstName=model.firstName,
                            lastName=model.lastName,
                            middleName=model.lastName,
                            genderId=model.genderId,
                            photo=model.photo
                        };
                        _userManager.Insert(user);
                        TempData["Msg"] = "User created successfully";
                    }
                    else
                    {
                        TempData["Msg"] = "User already exists";
                    }
                }
                return RedirectToAction("Register");
            }
            catch(Exception ex)
            {
                TempData["Msg"] = "An error occured " + ex.Message;
                return RedirectToAction("Register");
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult Profile()
        {
            string email=User.Identity.Name;
            ViewBag.listGender = _genderManager.GetAll().ToList();
            BOL.User user=_userManager.GetAll().FirstOrDefault(x => x.email == email);
            LoginViewModel loginViewModel = new LoginViewModel()
            {
                firstName = user.firstName,
                lastName = user.lastName,
                middleName = user.middleName,
                email=user.email,
                genderId=user.genderId,
                userId=user.userId,
                photo=user.photo
            };
            
            return View(loginViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult UpdateProfile(BOL.ViewModel.LoginViewModel user)
        {
            using (var binaryReader = new BinaryReader(user.UploadImages.InputStream))
            {
                user.photo = binaryReader.ReadBytes(user.UploadImages.ContentLength);
            }


            BOL.User useEntity = new BOL.User()
            {
                email=user.email,
                firstName=user.firstName,
                middleName=user.middleName,
                lastName=user.lastName,
                genderId=user.genderId,
                photo=user.photo,
                userId=user.userId
            };
            _userManager.Update(useEntity);
            return RedirectToAction("Profile");
        }

        [HttpGet]
        public ActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgetPassword(ForgetPassword model)
        {
            if(ModelState.IsValid)
            {
                var entity=_userManager.GetAll().FirstOrDefault(x => x.email == model.email);
                if(entity==null)
                {
                    //the user with the email does not exists
                    TempData["Msg"] = "Email does not exist";
                }
                else
                {
                    string password = entity.password;
                    SendPasswordResetEmail(model.email, password);
                    TempData["Msg"] = "Please check your mail for the password";
                }
            }
            return View();
        }

        private void SendPasswordResetEmail(string ToEmail, string password)
        {
            // MailMessage class is present is System.Net.Mail namespace
            MailMessage mailMessage = new MailMessage("sumanbasyal02@gmail.com", ToEmail);


            // StringBuilder class is present in System.Text namespace
            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("Dear " + ToEmail + ",<br/><br/>");
            sbEmailBody.Append("Please see your password");
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("your password is " +Encryption.Decrypt(password));
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b>Online Election</b>");

            mailMessage.IsBodyHtml = true;

            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = " Your Password";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "sumanbasyal02@gmail.com",
                Password = "sumannisha"
            };

            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }

    }
}
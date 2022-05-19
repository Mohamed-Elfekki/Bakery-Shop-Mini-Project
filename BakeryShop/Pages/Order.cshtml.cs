using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BakeryShop.Pages
{
    public class OrderModel : PageModel
    {
        private readonly BakeryShopContext db;
        public OrderModel(BakeryShopContext db) => this.db = db;
        public Product Product { set; get; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        //Binding
        [BindProperty, EmailAddress, Required(ErrorMessage = "Email is required"), Display(Name = "Your Email Address!")]
        public string OrderEmail { get; set; }
        [BindProperty, Required(ErrorMessage = "Please Supply A Shipping Address!"), Display(Name = "Your Shipping Address! ")]
        public string OrderShipping { get; set; }
        [BindProperty, Display(Name = "Your Order Quantity! ")]
        public int OrderQuantity { get; set; }
        public async Task OnGetAsync()
        {
            Product = await db.Products.FindAsync(Id);
        }
        //OnPostAysnc
        public async Task<IActionResult> OnPostAsync()
        {
            Product = await db.Products.FindAsync(Id);
            if (ModelState.IsValid)
            {
                var body = $@"<p>Thank you, we have received your order for {OrderQuantity} unit(s) of {Product.Name}!</p>
        <p>Your address is: <br/>{OrderShipping.Replace("\n", "<br/>")}</p>
        Your total is ${Product.Price * OrderQuantity}.<br/>
        We will contact you if we have questions about your order.  Thanks!<br/>";
                using (var smtp = new SmtpClient())
                {
                    var googleCredential = new NetworkCredential
                    {
                        UserName = "************",
                        Password = "*************"
                    };

                    smtp.Credentials = googleCredential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "Fourth Coffee - New Order";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("***********");
                    await smtp.SendMailAsync(message);
                }
                return RedirectToPage("OrderSucess");
            }
            return Page();
        }
    }
}

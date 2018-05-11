namespace AddressBookManagementSystem.Controllers
{
    using Models;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    // due to time constraint I couldnot able to complete update and delete address functionality. 
    // I have done only showing and adding new address
    public class AddressBookController : Controller
    {
        // GET: AddressBook
        public async Task<ActionResult> Index()
        {
            var addresses = await HttpClientHelper.GetAddressBookAsync("api/AddressBook");
            return View(addresses);
        }

        [HttpGet]
        public ActionResult AddNewAddress()
        {
            return View(new AddressBookModel());
        }

        [HttpPost]        
        public async Task<ActionResult> AddNewAddress(AddressBookModel address)
        {
            await HttpClientHelper.CreateAddressBookAsync("api/AddressBook", address);
            return RedirectToAction("Index");
        }
    }
}
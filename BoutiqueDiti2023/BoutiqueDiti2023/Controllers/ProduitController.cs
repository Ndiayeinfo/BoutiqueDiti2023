using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueDiti2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {

        MetierService.Service1Client _service = new MetierService.Service1Client();
        ServiceFile.Service1Client _fileService = new ServiceFile.Service1Client();

        public void getlistProduit()
        {
            var liste=_service.getListeProduitAsync();
        }

        public void getFile(string filename) { 
        _fileService.GetFileFromFolderAsync(filename).Wait();
        }
    }
}

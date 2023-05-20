using AppData.IRepositories;
using AppData.Models;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MausacController : ControllerBase
    {
        IAllRepositories<MauSac> irepos;
        // Tạo luôn DbContext để không bị null
        FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context context =
            new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public MausacController()
        {
            // Tạo 1 AllRepo để gán cho IALlrepo (Dependency Injection)
            AllRepositories<MauSac> repos =
                new AllRepositories<MauSac>(context, context.MauSacs);
            irepos = repos;
        }
        [HttpGet("get-all-color")] 
        public IEnumerable<MauSac> GetAll()
        {
            return irepos.GetAllItem();
        }
        [HttpPost("create-color")]
        public bool CreateColor(string ma, string ten)
        {
            MauSac color = new MauSac();
            color.Id = Guid.NewGuid(); // ID tự sinh
            color.Ma = ma; color.Ten = ten; // Lấy data truyền vào
            return irepos.CreateItem(color);
        }

    }
}

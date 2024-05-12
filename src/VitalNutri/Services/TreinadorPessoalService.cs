using Microsoft.AspNetCore.Identity;
using VitalNutri.Data;
using VitalNutri.Models;

namespace VitalNutri.Services
{
    public class TreinadorPessoalService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TreinadorPessoalService(
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IQueryable<Nutricionista> ObterNutricionistasDoUsuarioAtual()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            return _context.Nutricionistas.Where(n => n.Id == userId);
        }
    }
}

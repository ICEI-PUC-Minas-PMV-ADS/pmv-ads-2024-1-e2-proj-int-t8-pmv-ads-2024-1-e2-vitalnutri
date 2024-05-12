using Microsoft.AspNetCore.Identity;
using VitalNutri.Data;
using VitalNutri.Models;

namespace VitalNutri.Services
{
    public class AlimentoService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AlimentoService(
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<Alimento> ObterAlimentosDoUsuarioAtual()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var nutricionista = _context.Nutricionistas.FirstOrDefault(n => n.Id == userId);

            if (nutricionista != null)
            {
                return _context.Alimentos.Where(a => a.NutricionistaId == nutricionista.NutricionistaId).ToList();
            }

            return Enumerable.Empty<Alimento>();
        }
    }
}

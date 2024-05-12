using Microsoft.AspNetCore.Identity;
using VitalNutri.Data;
using VitalNutri.Models;

namespace VitalNutri.Services
{
    public class ExercicioService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ExercicioService(
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<Exercicio> ObterExerciciosDoUsuarioAtual()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var treinadorPessoal = _context.TreinadoresPessoais.FirstOrDefault(n => n.Id == userId);

            if (treinadorPessoal != null)
            {
                return _context.Exercicios.Where(e => e.TreinadorPessoalId == treinadorPessoal.TreinadorPessoalId).ToList();
            }

            return Enumerable.Empty<Exercicio>();
        }
    }
}

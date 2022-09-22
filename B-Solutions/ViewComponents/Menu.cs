using B_Solutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace B_Solutions.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(UsuariosModel usuario)
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            usuario = JsonConvert.DeserializeObject<UsuariosModel>(sessaoUsuario);
            return View(usuario);
        }
    }
}

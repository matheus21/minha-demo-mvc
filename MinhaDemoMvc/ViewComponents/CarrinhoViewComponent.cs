using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MinhaDemoMvc.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        //Aqui poderíamos alem de um inteiro, uma MODEL, por exemplo
        public CarrinhoViewComponent()
        {
            ItensCarrinho = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Para cada componente VIEW comum, teremos uma pasta em Shared/NomeViewComponent
            return View(ItensCarrinho);
        }

    }
}

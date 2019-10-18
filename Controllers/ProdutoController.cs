using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;



namespace LojaVirtual.Controllers{
    public class ProdutoController : Controller{
        public ActionResult Visualizar(){
            Produto produto = GetProduto();



            return View(produto);
            //return new ContentResult()  { Content = "<h3>Produto -> Visualizar<h3>" , ContentType = "text/html" };
        }

        private Produto GetProduto(){
            return new Produto(){
                Id = 1,
                Nome = "Xbox One x",
                Descricao = "Jogue em 4k",
                Valor = 399.00M
            };
        }




    }
}
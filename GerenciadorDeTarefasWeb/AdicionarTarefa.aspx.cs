using GerenciadorDeTarefasWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GerenciadorDeTarefasWeb
{
         public partial class AdicionarTarefa : System.Web.UI.Page
         {
                  string conexaoDoBanco = ConfigurationManager.AppSettings["ConexaoBancoDeDados"];
                  protected void Page_Load(object sender, EventArgs e)
                  {

                  }

                  protected void btnAdicionar_Click(object sender, EventArgs e)
                  {

                           GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas(conexaoDoBanco);

                           gerenciador.AdicionarTarefas(txtTitulo.Text, txtDescricao.Text, txtStatus.Text, txtPrioridade.Text);

                  }
         }
}
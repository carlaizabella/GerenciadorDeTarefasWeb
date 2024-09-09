<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdicionarTarefa.aspx.cs" Inherits="GerenciadorDeTarefasWeb.AdicionarTarefa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="row">

		<div class="col-12">
			<div class="form-group">
				<label for="titulo">Título</label>
				<asp:TextBox runat="server" class="form-control" ID="txtTitulo" Placeholder="Informe o Titulo" CssClass="form-control"></asp:TextBox>
			</div>
			<div class="form-group">
				<label for="descricao">Descrição</label>
				<asp:TextBox runat="server" class="form-control" ID="txtDescricao" Placeholder="Informe a Descrição" CssClass="form-control" TextMode="MultiLine" Rows="4"></asp:TextBox>
			</div>
		</div>

		<div class="col-12 d-flex">
			<!-- <asp:TextBox runat="server" class="form-control" ID="txtStatus" Placeholder="Informe o Status"></asp:TextBox>
          -->
			<div class="form-group col-6">
				<label runat="server" for="inlineFormSelectPref">Informe o status: </label>
				<select class="form-control me-2" id="inlineFormSelectPref">
					<option selected>Em Atendimento</option>
					<option value="1">Pendente</option>
					<option value="2">Concluído</option>
				</select>
			</div>


			<div class="form-group col-6">
				<!-- <asp:TextBox runat="server" class="form-control" ID="txtPrioridade" Placeholder="Informe a Prioridade"></asp:TextBox> -->
				<label runat="server" for="inlineFormSelectPref">Informe a prioridade: </label>
				<select class="form-control ms-2">
					<option selected>Baixa</option>
					<option value="1">Média</option>
					<option value="2">Alta</option>
					<option value="2">Urgente</option>
				</select>
			</div>
		</div>
		<asp:Button runat="server" ID="btnAdicionar" Text="Adicionar Tarefa" Class="btn btn-success mt-4" OnClick="btnAdicionar_Click" />

	</div>
</asp:Content>

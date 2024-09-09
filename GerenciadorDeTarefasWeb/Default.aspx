<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GerenciadorDeTarefasWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<div class="row">
		<div class="col-md-12 text-center h2">
			<asp:Label runat="server" ID="lblTitulo" Text="Gerenciador de Tarefa"></asp:Label>
		</div>
	</div>

	<div class="row">


		<div class="text-center">
			<a class="btn btn-primary" runat="server" href="~/AdicionarTarefa.aspx">Adicionar Tarefa</a>
		</div>
	</div>

</asp:Content>

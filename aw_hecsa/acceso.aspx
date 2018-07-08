<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="acceso.aspx.cs" Inherits="aw_hecsa.acceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="section">
                <div class="container">
                    <br />
                    <div class="row">
                        <div class="col-lg-4"></div>
                        <div class="col-lg-4">
                            <div class="panel panel-default" id="pnl_empresa" runat="server" visible="true">
                                <div class="panel-heading">
                                    <h3 class="text-center">Control de Acceso</h3>
                                </div>
                                <div class="panel-body">
                                    <asp:Image CssClass="center-block img-responsive img-thumbnail" ID="Image1" runat="server" ImageUrl="~/img/logo_liec256.png" Width="128" Height="128" />
                                    <br />

                                    <div class="form-group text-left">
                                        <h5>
                                            <asp:Label CssClass="control-label" ID="lbl_usuario" runat="server" Text="*Usuario"></asp:Label>
                                        </h5>
                                        <asp:TextBox CssClass="form-control" ID="txt_usuario" runat="server" TabIndex="1" placeholder="Capturar Usuario"></asp:TextBox>
                                        <div class="text-right">
                                            <asp:RequiredFieldValidator ID="rfv_usuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_usuario" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="form-group text-left">
                                        <h5>
                                            <asp:Label CssClass="control-label" ID="lbl_clave" runat="server" Text="*Contraseña"></asp:Label>
                                        </h5>
                                        <asp:TextBox CssClass="form-control" ID="txt_clave" runat="server" TabIndex="2" placeholder="Capturar Contraseña" TextMode="Password"></asp:TextBox>
                                        <div class="text-right">
                                            <asp:RequiredFieldValidator ID="rfv_clave" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_clave" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <h5>
                                            <asp:Button CssClass="btn btn-block" ID="lbtn_acceso" runat="server" Text="Entrar" TabIndex="3" OnClick="lbtn_acceso_Click" />
                                        </h5>
                                    </div>
                                </div>
                                <div class="panel-footer">
                                    <div class="form-group">
                                        <h5 class="text-right">
                                            <asp:LinkButton ID="lkb_registro" runat="server" Visible="false" Text="Registrar" OnClick="lkb_registro_Click"></asp:LinkButton>
                                        </h5>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4"></div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">x</button>
                            <h4 class="modal-title">
                                <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label>
                            </h4>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="modal-footer">
                            <button class="btn" data-dismiss="modal" aria-hidden="true">Ok </button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
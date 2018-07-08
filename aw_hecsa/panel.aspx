<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="panel.aspx.cs" Inherits="aw_hecsa.panel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="page-content">
        <div class="row">
            <div class="col-lg-12">
                <div class="sidebar content-box" style="display: block;">
                    <div class="text-right">
                        <p class="text-right">
                            <asp:Label CssClass="buttonClass" ID="lbl_bienvenida" runat="server" Text="BIENVENIDO@: "></asp:Label>
                            <asp:LinkButton CssClass="buttonClass" ID="lkb_edita_usuariof" runat="server" OnClick="lkb_edita_usuariof_Click">
                                <asp:Label CssClass="buttonClass" ID="lbl_edita_usuariof" runat="server" Text=""></asp:Label>&nbsp;<i class="glyphicon glyphicon-barcode" id="i_edita_usuariof" runat="server"></i>
                            </asp:LinkButton>
                            <br />
                            <asp:Label CssClass="buttonClass" ID="lbl_tipousuario" runat="server" Text="PERFIL: "></asp:Label>
                            <asp:Label CssClass="buttonClass" ID="lbl_ftipousuario" runat="server" Text=""></asp:Label>
                            <br />
                            <asp:Label CssClass="buttonClass" ID="lbl_fnegocio" runat="server" Text="EMPRESA: "></asp:Label>
                            <asp:LinkButton CssClass="buttonClass" ID="lkb_fnegocio" runat="server" OnClick="lkb_fnegocio_Click">
                                <asp:Label CssClass="buttonClass" ID="lbl_ffnegocio" runat="server" Text=""></asp:Label>&nbsp;<i class="glyphicon glyphicon-briefcase" id="i_editafnegocio" runat="server"></i>
                            </asp:LinkButton>
                        </p>
                    </div>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="sidebar-nav">
                    <div class="navbar-default" role="navigation">
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-navbar-collapse"><span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
                            <span class="visible-xs navbar-brand">Menú</span>
                        </div>
                        <div class="navbar-collapse collapse sidebar-navbar-collapse">
                            <br />
                            <div class="sidebar content-box " style="display: block;">
                                <ul class="nav">
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_resumen" runat="server" OnClick="lkb_resumen_Click">
                                            <i class="glyphicon glyphicon-equalizer" id="i_resumen" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_resumen" runat="server" Text="Resumen"> </asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_cotizacion" runat="server">
                                            <i class="glyphicon glyphicon-edit" id="i_cotizacion" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_cotizacion" runat="server" Text="Cotización"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_orden_compra" runat="server">
                                            <i class="glyphicon glyphicon-transfer" id="i_orden_compra" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_orden_compra" runat="server" Text="Orden de Compra"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_envios" runat="server">
                                            <i class="glyphicon glyphicon-copy" id="i_envios" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_envios" runat="server" Text="Envios"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_gastos" runat="server">
                                            <i class="glyphicon glyphicon-usd" id="i_gastos" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_gastos" runat="server" Text="Gastos"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_recepcion" runat="server">
                                            <i class="glyphicon glyphicon-inbox" id="i_recepcion" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_recepcion" runat="server" Text="Recepción"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_inventario" runat="server">
                                            <i class="glyphicon glyphicon-indent-left" id="i_inventario" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_inventario" runat="server" Text="Inventario"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_clientes" runat="server">
                                            <i class="glyphicon glyphicon-lock" id="i_clientes" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_clientes" runat="server" Text="Clientes"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_proveedores" runat="server">
                                            <i class="glyphicon glyphicon-transfer" id="i_proveedores" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_proveedores" runat="server" Text="Proveedores"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_usuarios" runat="server" OnClick="lkb_usuarios_Click">
                                            <i class="glyphicon glyphicon-user" id="i_usuarios" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_usuarios" runat="server" Text="Usuarios"></asp:Label>
                                        </asp:LinkButton>
                                    </li>

                                    <br />
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_salir" runat="server" OnClick="lkb_salir_Click">
                                            <i class="glyphicon glyphicon-off" id="i_salir" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_salir" runat="server" Text="Salir"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>
            <div class="col-lg-9">
                <div class="form-group">
                    <asp:UpdatePanel ID="up_usuariof" runat="server">
                        <ContentTemplate>
                            <div class="panel panel-default" id="pnl_usuariof" runat="server" visible="false">
                                <div class="panel-heading">
                                    <h3 class="panel-title text-left">Datos de Administrador</h3>
                                    <h3 class="panel-title text-right">
                                        <asp:CheckBox ID="chkbox_edita_fusuario" runat="server" OnCheckedChanged="chkbox_edita_fusuario_CheckedChanged" AutoPostBack="true" Text="Editar" />
                                    </h3>
                                </div>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-6">
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_nombres_fusuario" runat="server" Text="*Nombre(s)"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_nombres_fusuario" runat="server" placeholder="Capturar nombre(s)"></asp:TextBox>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_nombres_fusuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombres_fusuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_apaterno_fusuario" runat="server" Text="*Apellido Paterno"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_apaterno_fusuario" runat="server" placeholder="Capturar apellido paterno"></asp:TextBox>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_apaterno_fusuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_apaterno_fusuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_amaterno_fusuario" runat="server" Text="*Apellido Materno"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_amaterno_fusuario" runat="server" placeholder="Capturar apellido materno"></asp:TextBox>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_amaterno_fusuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_amaterno_fusuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-6">
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_usuario_fusuario" runat="server" Text="*Usuario"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_usuario_fusuario" runat="server" placeholder="Capturar usuario"></asp:TextBox>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_usuario_fusuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_usuario_fusuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_clave_fusuario" runat="server" Text="*Contraseña"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_clave_fusuario" runat="server" TextMode="Password" placeholder="Capturar contraseña"></asp:TextBox>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_clave_fusuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_clave_fusuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="text-right">
                                                    <br />
                                                    <asp:Button CssClass="btn" ID="btn_guarda_fusuario" runat="server" Text="GUARDAR" OnClick="btn_guarda_fusuario_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:UpdatePanel ID="up_fnegocio" runat="server">
                        <ContentTemplate>
                            <div class="panel panel-default" id="pnl_fnegocio" runat="server" visible="false">
                                <div class="panel-heading">
                                    <h3 class="panel-title text-left">Datos de Empresa</h3>
                                    <h3 class="panel-title text-right">
                                        <asp:CheckBox ID="chkbox_edita_fnegocio" runat="server" OnCheckedChanged="chkbox_edita_fnegocio_CheckedChanged" AutoPostBack="true" Text="Editar" />
                                    </h3>
                                </div>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-6">
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_nombre_empresa" runat="server" Text="*Nombre de Empresa"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_nombre_empresa" runat="server" placeholder="Capturar nombre de empresa" OnTextChanged="txt_nombre_empresa_TextChanged" AutoPostBack="true"></asp:TextBox>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_nombre_empresa" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombre_empresa" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_telefono_empresa" runat="server" Text="Teléfono"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_telefono_empresa" runat="server" placeholder="Capturar Teléfono" TextMode="Phone"></asp:TextBox>
                                                <br />
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_email_empresa" runat="server" Text="e-mail"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_email_empresa" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                <br />
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_callenum_empresa" runat="server" Text="Calle ý número"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_callenum_empresa" runat="server" placeholder="Captura Calle ý número" OnTextChanged="txt_callenum_empresa_TextChanged" AutoPostBack="true"></asp:TextBox>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_callenum_empresa" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_callenum_empresa" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-6">
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_cp_empresa" runat="server" Text="Código Postal"></asp:Label>
                                                </h5>

                                                <asp:TextBox CssClass="form-control" ID="txt_cp_empresa" runat="server" placeholder="Capturar Código Postal" MaxLength="5" OnTextChanged="txt_cp_empresa_TextChanged" AutoPostBack="true"></asp:TextBox>
                                                <ajaxToolkit:MaskedEditExtender ID="mee_cp_empresa" runat="server" TargetControlID="txt_cp_empresa" Mask="99999" />

                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_cp_empresa" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_cp_empresa" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_colonia_empresa" runat="server" Text="Colonia"></asp:Label>
                                                </h5>
                                                <asp:DropDownList CssClass="form-control" ID="ddl_colonia_empresa" runat="server"></asp:DropDownList>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_colonia_empresa" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_colonia_empresa" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_municipio_empresa" runat="server" Text="Municipio"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_municipio_empresa" runat="server" placeholder="Captura Municipio" Enabled="false"></asp:TextBox>
                                                <br />
                                            </div>
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_estado_empresa" runat="server" Text="Estado"></asp:Label>
                                                </h5>
                                                <asp:TextBox CssClass="form-control" ID="txt_estado_empresa" runat="server" placeholder="Captura Estado" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-12 text-right">
                                            <div class="form-group">
                                                <br />
                                                <asp:Button CssClass="btn" ID="btn_guarda_fnegocio" runat="server" Text="GUARDAR" OnClick="btn_guarda_fnegocio_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:UpdatePanel ID="up_cliente" runat="server">
                        <ContentTemplate>
                            <div class="panel panel-default" id="pnl_cliente" runat="server" visible="true">
                                <div class="panel-heading">
                                    <h3 class="text-center">Registro de Cliente y Contacto</h3>
                                </div>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="form-group">
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_nombre_cliente" runat="server" Text="*Nombre de cliente"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_nombre_cliente" runat="server" placeholder="Capturar nombre de cliente" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_nombre_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombre_cliente" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_telefono_cliente" runat="server" Text="Teléfono"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_cliente" runat="server" placeholder="Capturar Teléfono" TextMode="Phone"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RegularExpressionValidator ID="rfv_telefono_cliente" runat="server" ErrorMessage="*Teléfono incorrecto" ControlToValidate="txt_telefono_ccontacto" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ForeColor="DarkRed"></asp:RegularExpressionValidator>
                                                    </div>
                                                    <br />
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_email_cliente" runat="server" Text="e-mail"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_cliente" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                    <br />
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_callenum_cliente" runat="server" Text="Calle ý número"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_callenum_cliente" runat="server" placeholder="Captura Calle ý número" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_callenum_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_callenum_cliente" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_cp_cliente" runat="server" Text="Código Postal"></asp:Label>
                                                    </h5>

                                                    <asp:TextBox CssClass="form-control" ID="txt_cp_cliente" runat="server" placeholder="Capturar Código Postal" MaxLength="5" AutoPostBack="true"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="mee_cp_cliente" runat="server" TargetControlID="txt_cp_cliente" Mask="99999" />

                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_cp_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_cp_cliente" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_colonia_cliente" runat="server" Text="Colonia"></asp:Label>
                                                    </h5>
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_colonia_cliente" runat="server"></asp:DropDownList>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_colonia_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_colonia_cliente" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_municipio_cliente" runat="server" Text="Municipio"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_municipio_cliente" runat="server" placeholder="Captura Municipio" Enabled="false"></asp:TextBox>
                                                    <br />
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_estado_cliente" runat="server" Text="Estado"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_estado_cliente" runat="server" placeholder="Captura Estado" Enabled="false"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_nombres_ccontacto" runat="server" Text="*Nombre(s)"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_nombres_ccontacto" runat="server" placeholder="Captura Nombre(s)"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_nombres_ccontacto" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombres_ccontacto" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_apaterno_ccontacto" runat="server" Text="*Apellido Paterno"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_apaterno_ccontacto" runat="server" placeholder="Captura Apellido Paterno"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_apaterno_ccontacto" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_apaterno_ccontacto" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_amaterno_ccontacto" runat="server" Text="*Apellido Materno"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_amaterno_ccontacto" runat="server" placeholder="Captura Apellido Materno" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_amaterno_ccontacto" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_amaterno_ccontacto" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_telefono_ccontacto" runat="server" Text="Teléfono"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_ccontacto" runat="server" placeholder="Capturar Teléfono" TextMode="Phone"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RegularExpressionValidator ID="rfv_telefono_ccontacto" runat="server" ErrorMessage="*Teléfono incorrecto" ControlToValidate="txt_telefono_ccontacto" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ForeColor="DarkRed"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_email_ccontacto" runat="server" Text="e-mail"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_ccontacto" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                    <br />
                                                </div>
                                                <div class="text-right">
                                                    <br />
                                                    <asp:Button CssClass="btn" ID="btn_salir_cliente" runat="server" Text="Salir" />
                                                    <asp:Button CssClass="btn" ID="btn_guardar_cliente" runat="server" Text="Guardar" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:UpdatePanel ID="up_usuarios" runat="server">
                        <ContentTemplate>
                            <div class="panel panel-default" id="pnl_usuarios" runat="server" visible="false">
                                <div class="panel-heading">
                                    <h3 class="panel-title text-left">CONTROL DE USUARIOS</h3>
                                    <h3 class="panel-title text-right">
                                        <asp:CheckBox ID="chkbox_agregar_u" runat="server" AutoPostBack="true" Text="Agregar" OnCheckedChanged="chkbox_agregar_u_CheckedChanged" />
                                        <asp:CheckBox ID="chkbox_editar_u" runat="server" AutoPostBack="true" Text="Editar" OnCheckedChanged="chkbox_editar_u_CheckedChanged" />
                                    </h3>
                                </div>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-2">
                                            <asp:CheckBox ID="chkb_administrador" runat="server" Text="ADMINISTRADOR" OnCheckedChanged="chkb_administrador_CheckedChanged" AutoPostBack="true" />
                                            <br />
                                        </div>
                                        <div class="col-lg-2">
                                            <asp:CheckBox ID="chkb_ejecutivo" runat="server" Text="EJECUTIVO" OnCheckedChanged="chkb_ejecutivo_CheckedChanged" AutoPostBack="true" />
                                            <br />
                                        </div>
                                        <div class="col-lg-2">
                                            <asp:CheckBox ID="chkb_invitado" runat="server" Text="INVITADO" OnCheckedChanged="chkb_invitado_CheckedChanged" AutoPostBack="true" />
                                            <br />
                                        </div>
                                    </div>
                                    <br />
                                    <div class="col-lg-12">
                                        <asp:GridView CssClass="table" ID="gv_usuarios" runat="server" AutoGenerateColumns="False" AllowPaging="true" OnPageIndexChanging="gv_usuarios_PageIndexChanging" PageSize="5">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chk_usuario" runat="server" onclick="CheckOne(this)" AutoPostBack="true" OnCheckedChanged="chk_usuario_CheckedChanged" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="codigo_usuario" HeaderText="CÓDIGO" SortExpression="codigo_usuario" Visible="true" />
                                                <asp:BoundField DataField="desc_estatus" HeaderText="ESTATUS" SortExpression="desc_estatus" />
                                                <asp:BoundField DataField="nombres" HeaderText="NOMBRE(S)" SortExpression="nombres" />
                                                <asp:BoundField DataField="a_paterno" HeaderText="APELLIDO PATERNO" SortExpression="a_paterno" />
                                                <asp:BoundField DataField="a_materno" HeaderText="APELLIDO MATERNO" SortExpression="a_materno" />
                                                <asp:BoundField DataField="fecha_registro" HeaderText="FECHA DE REGISTRO" SortExpression="fecha_registro" DataFormatString="{0:dd/MM/yyyy}" />
                                            </Columns>
                                        </asp:GridView>
                                        <br />
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="form-group text-left">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_nombres_usuario" runat="server" Text="*Nombre(s)"></asp:Label>
                                            </h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_nombres_usuario" runat="server" TabIndex="1" placeholder="Capturar nombre(S)"></asp:TextBox>
                                            <div class="text-right">
                                                <asp:RequiredFieldValidator ID="rfv_nombres_usuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombres_usuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="form-group text-left">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_apaterno_usuario" runat="server" Text="*Apellido paterno"></asp:Label>
                                            </h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_apaterno_usuario" runat="server" TabIndex="1" placeholder="Capturar apellido paterno"></asp:TextBox>
                                            <div class="text-right">
                                                <asp:RequiredFieldValidator ID="rfv_apaterno_usuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_apaterno_usuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="form-group text-left">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_amaterno_usuario" runat="server" Text="*Apellido materno"></asp:Label>
                                            </h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_amaterno_usuario" runat="server" TabIndex="1" placeholder="Capturar apellido materno"></asp:TextBox>
                                            <div class="text-right">
                                                <asp:RequiredFieldValidator ID="rfv_amaterno_usuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_amaterno_usuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-3">
                                        <div class="form-group text-left">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_usuario_usuario" runat="server" Text="*Usuario"></asp:Label>
                                            </h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_usuario_usuario" runat="server" TabIndex="1" placeholder="Capturar Usuario"></asp:TextBox>
                                            <div class="text-right">
                                                <asp:RequiredFieldValidator ID="rfv_usuario_usuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_usuario_usuario" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="form-group text-left">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_perfil" runat="server" Text="*Perfil"></asp:Label>
                                            </h5>
                                            <asp:DropDownList CssClass="form-control" ID="ddl_perfil" runat="server" enable="false"></asp:DropDownList>
                                            <div class="text-right">
                                                <asp:RequiredFieldValidator ID="rfv_usuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_perfil" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-3">
                                        <div class="form-group text-left">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_clave_usuario" runat="server" Text="*Usuario"></asp:Label>
                                            </h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_clave_usuario" runat="server" TabIndex="1" placeholder="Capturar contraseña" TextMode="Password"></asp:TextBox>
                                            <div class="text-right">
                                                <asp:RequiredFieldValidator ID="rfv_clave_usuario" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_clave_usuario" ForeColor="DarkRed" Enabled="false"> </asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="form-group text-right">
                                            <br />
                                            <asp:CheckBox ID="chkb_activar_usuario" runat="server" Text="Desactivar" enable="false" />
                                            <asp:Button CssClass="btn" ID="btn_guardar_usuario" runat="server" Text="GUARDAR" OnClick="btn_guardar_usuario_Click" />
                                        </div>
                                        <div class="form-group">
                                            <br />
                                        </div>
                                    </div>

                                    <div class="col-lg-12 text-right">
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel"
         aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            <h4 class="modal-title">
                                <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label>
                            </h4>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="modal-footer">
                            <button class="btn" data-dismiss="modal" aria-hidden="true">Ok</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
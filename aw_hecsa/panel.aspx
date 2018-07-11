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
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_clientes" runat="server" OnClick="lkb_clientes_Click">
                                            <i class="glyphicon glyphicon-lock" id="i_clientes" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_clientes" runat="server" Text="Clientes"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_proveedores" runat="server" OnClick="lkb_proveedores_Click">
                                            <i class="glyphicon glyphicon-transfer" id="i_proveedores" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_proveedores" runat="server" Text="Proveedores"></asp:Label>
                                        </asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton CssClass="buttonClass" ID="lkb_contribuyente" runat="server" OnClick="lkb_contribuyente_Click">
                                            <i class="glyphicon glyphicon-transfer" id="i_contribuyente" runat="server"></i>
                                            <asp:Label CssClass="buttonClass" ID="lbl_contribuyente" runat="server" Text="Contribuyentes"></asp:Label>
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
                            <div class="panel panel-default" id="pnl_cliente" runat="server" visible="false">
                                <div class="panel-heading">
                                    <h3 class="text-center">Registro de cliente y contacto</h3>
                                    <h3 class="panel-title text-right">
                                        <asp:CheckBox ID="chkbox_agregar_c" runat="server" AutoPostBack="true" Text="Agregar" OnCheckedChanged="chkbox_agregar_c_CheckedChanged" />
                                        <asp:CheckBox ID="chkbox_editar_c" runat="server" AutoPostBack="true" Text="Editar" OnCheckedChanged="chkbox_editar_c_CheckedChanged" />
                                    </h3>
                                </div>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-4"></div>
                                        <div class="col-lg-4">
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_buscar_cliente" runat="server" Text="*Buscar" Visible="false"></asp:Label>
                                                </h5>
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_buscar_cliente" runat="server" placeholder="Buscar rubro" Visible="false" TextMode="Search" AutoPostBack="true"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="btn_buscar_cliente" runat="server" Text="Ir" Visible="false" />
                                                    </span>
                                                </div>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_buscar_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_buscar_cliente" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-4"></div>
                                    </div>
                                    <div class="col-lg-12">
                                        <asp:GridView CssClass="table" ID="gv_cliente" runat="server" AutoGenerateColumns="False" AllowPaging="true" PageSize="10" OnRowCommand="gv_cliente_RowCommand" OnSelectedIndexChanged="gv_cliente_SelectedIndexChanged">
                                            <Columns>
                                                <asp:BoundField DataField="codigo_cliente" HeaderText="ID" SortExpression="codigo_cliente" />
                                                <asp:BoundField DataField="desc_tipo_rfc" HeaderText="Tipo de RFC" SortExpression="desc_tipo_rfc" />
                                                <asp:BoundField DataField="rfc" HeaderText="RFC" SortExpression="rfc" />
                                                <asp:BoundField DataField="razon_social" HeaderText="Razón Social" SortExpression="razon_social" />
                                                <asp:BoundField DataField="fecha_registro" HeaderText="Fecha de Registro" SortExpression="fecha_registro" DataFormatString="{0:dd-MM-yyyy}" HtmlEncode="false" />
                                                <asp:TemplateField HeaderText="Seleccionar">
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chk_cliente" runat="server" onclick="CheckOne(this)" AutoPostBack="true" OnCheckedChanged="chk_cliente_CheckedChanged" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                        <br />
                                    </div>
                                    <div class="row">
                                        <div class="form-group">
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_tiporfc_cliente" runat="server" Text="Tipo de RFC"></asp:Label>
                                                    </h5>
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_tiporfc_cliente" runat="server"></asp:DropDownList>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_tiporfc_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_tiporfc_cliente" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_rfc_cliente" runat="server" Text="*RFC"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_rfc_cliente" runat="server" placeholder="Capturar RFC de cliente"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_rfc_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_rfc_cliente" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_nombre_cliente" runat="server" Text="*Nombre de cliente"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_nombre_cliente" runat="server" placeholder="Capturar nombre de cliente" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_nombre_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombre_cliente" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
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
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_email_cliente" runat="server" Text="e-mail"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_cliente" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                    <br />
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_callenum_cliente" runat="server" Text="Calle ý número"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_callenum_cliente" runat="server" placeholder="Captura Calle ý número" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_callenum_cliente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_callenum_cliente" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_cp_cliente" runat="server" Text="Código Postal"></asp:Label>
                                                    </h5>
                                                    <div class="input-group">
                                                        <asp:TextBox CssClass="form-control" ID="txt_cp_cliente" runat="server" placeholder="Capturar Código Postal" MaxLength="5"></asp:TextBox>
                                                        <span class="input-group-btn">
                                                            <asp:Button CssClass="btn btn-default" ID="btn_cp_cliente" runat="server" Text="Validar" OnClick="btn_cp_cliente_Click" />
                                                        </span>
                                                    </div>
                                                    <div class="text-right">
                                                        <ajaxToolkit:MaskedEditExtender ID="mee_cp_cliente" runat="server" TargetControlID="txt_cp_cliente" Mask="99999" />
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
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_amaterno_ccontacto" runat="server" Text="*Apellido Materno"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_amaterno_ccontacto" runat="server" placeholder="Captura Apellido Materno" AutoPostBack="true"></asp:TextBox>
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
                                                    <asp:Button CssClass="btn" ID="btn_guardar_cliente" runat="server" Text="Guardar" OnClick="btn_guardar_cliente_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:UpdatePanel ID="up_proveedor" runat="server">
                        <ContentTemplate>
                            <div class="panel panel-default" id="pnl_proveedor" runat="server" visible="false">
                                <div class="panel-heading">
                                    <h3 class="text-center">Registro de proveedor y proveedor</h3>
                                    <h3 class="panel-title text-right">
                                        <asp:CheckBox ID="chkbox_agregar_p" runat="server" AutoPostBack="true" Text="Agregar" OnCheckedChanged="chkbox_agregar_p_CheckedChanged" />
                                        <asp:CheckBox ID="chkbox_editar_p" runat="server" AutoPostBack="true" Text="Editar" OnCheckedChanged="chkbox_editar_p_CheckedChanged" />
                                    </h3>
                                </div>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-4"></div>
                                        <div class="col-lg-4">
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_buscar_proveedor" runat="server" Text="*Buscar" Visible="false"></asp:Label>
                                                </h5>
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_buscar_proveedor" runat="server" placeholder="Buscar rubro" Visible="false" TextMode="Search" AutoPostBack="true"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="btn_buscar_proveedor" runat="server" Text="Ir" Visible="false" />
                                                    </span>
                                                </div>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_buscar_proveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_buscar_proveedor" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-4"></div>
                                    </div>
                                    <div class="col-lg-12">
                                        <asp:GridView CssClass="table" ID="gv_proveedor" runat="server" AutoGenerateColumns="False" AllowPaging="true" PageSize="10" OnRowCommand="gv_proveedor_RowCommand" OnSelectedIndexChanged="gv_proveedor_SelectedIndexChanged">
                                            <Columns>
                                                <asp:BoundField DataField="codigo_proveedor" HeaderText="ID" SortExpression="codigo_proveedor" />
                                                <asp:BoundField DataField="desc_tipo_rfc" HeaderText="Tipo de RFC" SortExpression="desc_tipo_rfc" />
                                                <asp:BoundField DataField="rfc" HeaderText="RFC" SortExpression="rfc" />
                                                <asp:BoundField DataField="razon_social" HeaderText="Razón Social" SortExpression="razon_social" />
                                                <asp:BoundField DataField="fecha_registro" HeaderText="Fecha de Registro" SortExpression="fecha_registro" DataFormatString="{0:dd-MM-yyyy}" HtmlEncode="false" />
                                                <asp:TemplateField HeaderText="Seleccionar">
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chk_proveedor" runat="server" onclick="CheckOne(this)" AutoPostBack="true" OnCheckedChanged="chk_proveedor_CheckedChanged" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                        <br />
                                    </div>
                                    <div class="row">
                                        <div class="form-group">
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_tiporfc_proveedor" runat="server" Text="Tipo de RFC"></asp:Label>
                                                    </h5>
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_tiporfc_proveedor" runat="server"></asp:DropDownList>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_tiporfc_proveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_tiporfc_proveedor" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_rfc_proveedor" runat="server" Text="*RFC"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_rfc_proveedor" runat="server" placeholder="Capturar RFC de proveedor"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_rfc_proveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_rfc_proveedor" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_nombre_proveedor" runat="server" Text="*Nombre de proveedor"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_nombre_proveedor" runat="server" placeholder="Capturar nombre de proveedor" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_nombre_proveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombre_proveedor" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_telefono_proveedor" runat="server" Text="Teléfono"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_proveedor" runat="server" placeholder="Capturar Teléfono" TextMode="Phone"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RegularExpressionValidator ID="rfv_telefono_proveedor" runat="server" ErrorMessage="*Teléfono incorrecto" ControlToValidate="txt_telefono_cproveedor" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ForeColor="DarkRed"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_email_proveedor" runat="server" Text="e-mail"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_proveedor" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                    <br />
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_callenum_proveedor" runat="server" Text="Calle ý número"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_callenum_proveedor" runat="server" placeholder="Captura Calle ý número" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_callenum_proveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_callenum_proveedor" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_cp_proveedor" runat="server" Text="Código Postal"></asp:Label>
                                                    </h5>
                                                    <div class="input-group">
                                                        <asp:TextBox CssClass="form-control" ID="txt_cp_proveedor" runat="server" placeholder="Capturar Código Postal" MaxLength="5"></asp:TextBox>
                                                        <span class="input-group-btn">
                                                            <asp:Button CssClass="btn btn-default" ID="btn_cp_proveedor" runat="server" Text="Validar" OnClick="btn_cp_proveedor_Click" />
                                                        </span>
                                                    </div>
                                                    <div class="text-right">
                                                        <ajaxToolkit:MaskedEditExtender ID="mee_cp_proveedor" runat="server" TargetControlID="txt_cp_proveedor" Mask="99999" />
                                                        <asp:RequiredFieldValidator ID="rfv_cp_proveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_cp_proveedor" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_colonia_proveedor" runat="server" Text="Colonia"></asp:Label>
                                                    </h5>
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_colonia_proveedor" runat="server"></asp:DropDownList>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_colonia_proveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_colonia_proveedor" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_municipio_proveedor" runat="server" Text="Municipio"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_municipio_proveedor" runat="server" placeholder="Captura Municipio" Enabled="false"></asp:TextBox>
                                                    <br />
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_estado_proveedor" runat="server" Text="Estado"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_estado_proveedor" runat="server" placeholder="Captura Estado" Enabled="false"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_nombres_cproveedor" runat="server" Text="*Nombre(s)"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_nombres_cproveedor" runat="server" placeholder="Captura Nombre(s)"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_nombres_cproveedor" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombres_cproveedor" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_apaterno_cproveedor" runat="server" Text="*Apellido Paterno"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_apaterno_cproveedor" runat="server" placeholder="Captura Apellido Paterno"></asp:TextBox>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_amaterno_cproveedor" runat="server" Text="*Apellido Materno"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_amaterno_cproveedor" runat="server" placeholder="Captura Apellido Materno" AutoPostBack="true"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_telefono_cproveedor" runat="server" Text="Teléfono"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_cproveedor" runat="server" placeholder="Capturar Teléfono" TextMode="Phone"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RegularExpressionValidator ID="rfv_telefono_cproveedor" runat="server" ErrorMessage="*Teléfono incorrecto" ControlToValidate="txt_telefono_cproveedor" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ForeColor="DarkRed"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_email_cproveedor" runat="server" Text="e-mail"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_cproveedor" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                    <br />
                                                </div>
                                                <div class="text-right">
                                                    <br />
                                                    <asp:Button CssClass="btn" ID="btn_guardar_proveedor" runat="server" Text="Guardar" OnClick="btn_guardar_proveedor_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:UpdatePanel ID="up_contribuyente" runat="server">
                        <ContentTemplate>
                            <div class="panel panel-default" id="pnl_contribuyente" runat="server" visible="false">
                                <div class="panel-heading">
                                    <h3 class="text-center">Registro de contribuyente y contribuyente</h3>
                                    <h3 class="panel-title text-right">
                                        <asp:CheckBox ID="chkbox_agregar_co" runat="server" AutoPostBack="true" Text="Agregar" OnCheckedChanged="chkbox_agregar_co_CheckedChanged" />
                                        <asp:CheckBox ID="chkbox_editar_co" runat="server" AutoPostBack="true" Text="Editar" OnCheckedChanged="chkbox_editar_co_CheckedChanged" />
                                    </h3>
                                </div>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-4"></div>
                                        <div class="col-lg-4">
                                            <div class="form-group text-left">
                                                <h5>
                                                    <asp:Label CssClass="control-label" ID="lbl_buscar_contribuyente" runat="server" Text="*Buscar" Visible="false"></asp:Label>
                                                </h5>
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_buscar_contribuyente" runat="server" placeholder="Buscar rubro" Visible="false" TextMode="Search" AutoPostBack="true"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="btn_buscar_contribuyente" runat="server" Text="Ir" Visible="false" />
                                                    </span>
                                                </div>
                                                <div class="text-right">
                                                    <asp:RequiredFieldValidator ID="rfv_buscar_contribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_buscar_contribuyente" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-4"></div>
                                    </div>
                                    <div class="col-lg-12">
                                        <asp:GridView CssClass="table" ID="gv_contribuyente" runat="server" AutoGenerateColumns="False" AllowPaging="true" PageSize="10" OnRowCommand="gv_contribuyente_RowCommand" OnSelectedIndexChanged="gv_contribuyente_SelectedIndexChanged">
                                            <Columns>
                                                <asp:BoundField DataField="codigo_contribuyente" HeaderText="ID" SortExpression="codigo_contribuyente" />
                                                <asp:BoundField DataField="desc_tipo_rfc" HeaderText="Tipo de RFC" SortExpression="desc_tipo_rfc" />
                                                <asp:BoundField DataField="rfc" HeaderText="RFC" SortExpression="rfc" />
                                                <asp:BoundField DataField="razon_social" HeaderText="Razón Social" SortExpression="razon_social" />
                                                <asp:BoundField DataField="fecha_registro" HeaderText="Fecha de Registro" SortExpression="fecha_registro" DataFormatString="{0:dd-MM-yyyy}" HtmlEncode="false" />
                                                <asp:TemplateField HeaderText="Seleccionar">
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chk_contribuyente" runat="server" onclick="CheckOne(this)" AutoPostBack="true" OnCheckedChanged="chk_contribuyente_CheckedChanged" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                        <br />
                                    </div>
                                    <div class="row">
                                        <div class="form-group">
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_tiporfc_contribuyente" runat="server" Text="Tipo de RFC"></asp:Label>
                                                    </h5>
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_tiporfc_contribuyente" runat="server"></asp:DropDownList>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_tiporfc_contribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_tiporfc_contribuyente" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_rfc_contribuyente" runat="server" Text="*RFC"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_rfc_contribuyente" runat="server" placeholder="Capturar RFC de contribuyente"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_rfc_contribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_rfc_contribuyente" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_nombre_contribuyente" runat="server" Text="*Nombre de contribuyente"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_nombre_contribuyente" runat="server" placeholder="Capturar nombre de contribuyente" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_nombre_contribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombre_contribuyente" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_telefono_contribuyente" runat="server" Text="Teléfono"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_contribuyente" runat="server" placeholder="Capturar Teléfono" TextMode="Phone"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RegularExpressionValidator ID="rfv_telefono_contribuyente" runat="server" ErrorMessage="*Teléfono incorrecto" ControlToValidate="txt_telefono_ccontribuyente" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ForeColor="DarkRed"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_email_contribuyente" runat="server" Text="e-mail"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_contribuyente" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                    <br />
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_callenum_contribuyente" runat="server" Text="Calle ý número"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_callenum_contribuyente" runat="server" placeholder="Captura Calle ý número" AutoPostBack="true"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_callenum_contribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_callenum_contribuyente" ForeColor="DarkRed" Enable="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_cp_contribuyente" runat="server" Text="Código Postal"></asp:Label>
                                                    </h5>
                                                    <div class="input-group">
                                                        <asp:TextBox CssClass="form-control" ID="txt_cp_contribuyente" runat="server" placeholder="Capturar Código Postal" MaxLength="5"></asp:TextBox>
                                                        <span class="input-group-btn">
                                                            <asp:Button CssClass="btn btn-default" ID="btn_cp_contribuyente" runat="server" Text="Validar" OnClick="btn_cp_contribuyente_Click" />
                                                        </span>
                                                    </div>
                                                    <div class="text-right">
                                                        <ajaxToolkit:MaskedEditExtender ID="mee_cp_contribuyente" runat="server" TargetControlID="txt_cp_contribuyente" Mask="99999" />
                                                        <asp:RequiredFieldValidator ID="rfv_cp_contribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_cp_contribuyente" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_colonia_contribuyente" runat="server" Text="Colonia"></asp:Label>
                                                    </h5>
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_colonia_contribuyente" runat="server"></asp:DropDownList>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_colonia_contribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="ddl_colonia_contribuyente" InitialValue="0" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_municipio_contribuyente" runat="server" Text="Municipio"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_municipio_contribuyente" runat="server" placeholder="Captura Municipio" Enabled="false"></asp:TextBox>
                                                    <br />
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_estado_contribuyente" runat="server" Text="Estado"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_estado_contribuyente" runat="server" placeholder="Captura Estado" Enabled="false"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_nombres_ccontribuyente" runat="server" Text="*Nombre(s)"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_nombres_ccontribuyente" runat="server" placeholder="Captura Nombre(s)"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RequiredFieldValidator ID="rfv_nombres_ccontribuyente" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txt_nombres_ccontribuyente" ForeColor="DarkRed" Enabled="false"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_apaterno_ccontribuyente" runat="server" Text="*Apellido Paterno"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_apaterno_ccontribuyente" runat="server" placeholder="Captura Apellido Paterno"></asp:TextBox>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_amaterno_ccontribuyente" runat="server" Text="*Apellido Materno"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_amaterno_ccontribuyente" runat="server" placeholder="Captura Apellido Materno" AutoPostBack="true"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-3">
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_telefono_ccontribuyente" runat="server" Text="Teléfono"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_ccontribuyente" runat="server" placeholder="Capturar Teléfono" TextMode="Phone"></asp:TextBox>
                                                    <div class="text-right">
                                                        <asp:RegularExpressionValidator ID="rfv_telefono_ccontribuyente" runat="server" ErrorMessage="*Teléfono incorrecto" ControlToValidate="txt_telefono_ccontribuyente" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ForeColor="DarkRed"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group text-left">
                                                    <h5>
                                                        <asp:Label CssClass="control-label" ID="lbl_email_ccontribuyente" runat="server" Text="e-mail"></asp:Label>
                                                    </h5>
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_ccontribuyente" runat="server" placeholder="Capturar e-mail" TextMode="Email"></asp:TextBox>
                                                    <br />
                                                </div>
                                                <div class="text-right">
                                                    <br />
                                                    <asp:Button CssClass="btn" ID="btn_guardar_contribuyente" runat="server" Text="Guardar" OnClick="btn_guardar_contribuyente_Click" />
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
                                        <div class="col-lg-3">
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

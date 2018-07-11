using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aw_hecsa
{
    public partial class panel : System.Web.UI.Page
    {
        private static Guid guid_iduser, guid_fnegocio;
        private static int int_idtipousuario, int_tipousuario, int_accion_cliente, int_accion_proveedor, int_accion_contribuyente, int_accion_usuario;

        #region panel

        protected void lkb_edita_usuariof_Click(object sender, EventArgs e)
        {
            filtra_panel(1);
        }

        protected void lkb_fnegocio_Click(object sender, EventArgs e)
        {
            filtra_panel(2);
        }

        protected void lkb_resumen_Click(object sender, EventArgs e)
        {
            filtra_panel(3);
        }

        protected void lkb_clientes_Click(object sender, EventArgs e)
        {
            filtra_panel(8);
        }

        protected void lkb_proveedores_Click(object sender, EventArgs e)
        {
            filtra_panel(9);
        }

        protected void lkb_contribuyente_Click(object sender, EventArgs e)
        {
            filtra_panel(10);
        }
        protected void lkb_usuarios_Click(object sender, EventArgs e)
        {
            filtra_panel(11);
        }

        protected void lkb_salir_Click(object sender, EventArgs e)
        {
            filtra_panel(12);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    inf_user();
                }
                else
                {
                }
            }
            catch
            {
                Response.Redirect("acceso.aspx");
            }
        }

        //	private void default_rpt()
        //	{
        //		pnl_rpt.Visible = true;
        //		DateTime.Now.ToShortDateString().Replace("/", "");
        //		DataTable dt_rpt = new DataTable();
        //		//using (imEntities data_user = new imEntities())
        //		//{
        //		//	var inf_user = (from a in data_user.rpt
        //		//					select a).ToList();
        //		//}

        //		string str_date = DateTime.Now.ToShortDateString().Replace("/", "");
        //		ReportViewer1.ProcessingMode = ProcessingMode.Local;
        //		ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/rpt_liec.rdl");
        //		System.Data.DataSet ds = new System.Data.DataSet();

        //		SqlDataAdapter da = new SqlDataAdapter();
        //		SqlCommand cmd = new SqlCommand(@"SELECT  [dia_mes]
        //  ,[mes]
        //  ,[año]
        //  ,[dia]
        //  ,[etiqueta_rubro]
        //  ,[desc_tipo_rubro]
        //  ,[rubro]
        //  ,[monto]
        //  ,[desc_gasto]
        // FROM [db_liec].[dbo].[v_rpt01]
        //order by dia_mes asc;");
        //		cmd.CommandType = CommandType.Text;
        //		cmd.Connection = new SqlConnection(cn.cn_SQL);
        //		da.SelectCommand = cmd;

        //		da.Fill(ds, "DataSet1");
        //		ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
        //		ReportViewer1.LocalReport.DataSources.Clear();
        //		ReportViewer1.LocalReport.DataSources.Add(datasource);
        //		ReportViewer1.LocalReport.DisplayName = "rpt_" + str_date + "";
        //		ReportViewer1.LocalReport.Refresh();
        //	}

        private void filtra_panel(int int_idpanel)
        {
            switch (int_idpanel)
            {
                case 1:

                    chkbox_edita_fusuario.Checked = false;
                    pnl_usuariof.Visible = true;
                    pnl_fnegocio.Visible = false;
                    pnl_cliente.Visible = false;
                    pnl_proveedor.Visible = false;
                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:lightgray";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";
                    i_salir.Attributes["style"] = "color:darkblue";

                    limpia_txt_fusuario();

                    try
                    {
                        using (db_hecsaEntities m_fusuario = new db_hecsaEntities())
                        {
                            var i_fusuario = (from i_c in m_fusuario.inf_usuarios
                                              where i_c.id_usuario == guid_iduser
                                              select new
                                              {
                                                  i_c.nombres,
                                                  i_c.a_paterno,
                                                  i_c.a_materno,
                                                  i_c.fecha_nacimiento,
                                                  i_c.codigo_usuario,
                                                  i_c.clave,
                                              }).FirstOrDefault();

                            txt_nombres_fusuario.Text = i_fusuario.nombres;
                            txt_apaterno_fusuario.Text = i_fusuario.a_paterno;
                            txt_amaterno_fusuario.Text = i_fusuario.a_materno;
                            txt_usuario_fusuario.Text = i_fusuario.codigo_usuario;
                            txt_clave_fusuario.Text = i_fusuario.clave;
                        }
                    }
                    catch
                    {
                    }

                    break;

                case 2:
                    chkbox_edita_fnegocio.Checked = false;
                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = true;
                    pnl_cliente.Visible = false;
                    pnl_proveedor.Visible = false;
                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:lightgray";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";
                    i_salir.Attributes["style"] = "color:darkblue";

                    limpia_txt_fnegocio();

                    using (db_hecsaEntities data_user = new db_hecsaEntities())
                    {
                        var inf_user = (from i_u in data_user.inf_empresa
                                        where i_u.id_empresa == guid_fnegocio
                                        select new
                                        {
                                            i_u.razon_social,
                                            i_u.telefono,
                                            i_u.email,
                                            i_u.callenum,
                                            i_u.id_codigo,
                                        }).FirstOrDefault();

                        txt_nombre_empresa.Text = inf_user.razon_social;
                        txt_telefono_empresa.Text = inf_user.telefono;
                        txt_email_empresa.Text = inf_user.email;
                        txt_callenum_empresa.Text = inf_user.callenum;

                        using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                        {
                            var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                               where c.id_codigo == inf_user.id_codigo
                                               select c).ToList();
                            ddl_colonia_empresa.DataSource = tbl_sepomex;
                            ddl_colonia_empresa.DataTextField = "d_asenta";
                            ddl_colonia_empresa.DataValueField = "id_asenta_cpcons";
                            ddl_colonia_empresa.DataBind();
                            ddl_colonia_empresa.SelectedValue = tbl_sepomex[0].id_asenta_cpcons.ToString();

                            txt_cp_empresa.Text = tbl_sepomex[0].d_codigo;
                            txt_municipio_empresa.Text = tbl_sepomex[0].d_mnpio;
                            txt_estado_empresa.Text = tbl_sepomex[0].d_estado;
                        }
                    }
                    break;

                case 3:

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;
                    pnl_cliente.Visible = false;
                    pnl_proveedor.Visible = false;
                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";
                    i_salir.Attributes["style"] = "color:darkblue";

                    //default_rpt();
                    Mensaje("Construyendo");

                    break;

                case 8:

                    int_accion_cliente = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;
                    pnl_cliente.Visible = true;
                    pnl_proveedor.Visible = false;
                    pnl_usuarios.Visible = false;

                    rfv_nombre_cliente.Enabled = false;
                    rfv_callenum_cliente.Enabled = false;
                    rfv_cp_cliente.Enabled = false;
                    rfv_colonia_cliente.Enabled = false;
                    rfv_nombres_ccontacto.Enabled = false;

                    limpia_txt_cliente();

                    break;

                case 9:

                    int_accion_proveedor = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;
                    pnl_cliente.Visible = false;
                    pnl_proveedor.Visible = true;
                    pnl_usuarios.Visible = false;

                    rfv_nombre_proveedor.Enabled = false;
                    rfv_callenum_proveedor.Enabled = false;
                    rfv_cp_proveedor.Enabled = false;
                    rfv_colonia_proveedor.Enabled = false;
                    rfv_nombre_proveedor.Enabled = false;

                    break;

                case 10:
                    int_accion_contribuyente = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;
                    pnl_cliente.Visible = false;
                    pnl_proveedor.Visible = false;
                    pnl_contribuyente.Visible = true;
                    pnl_usuarios.Visible = false;

                    rfv_nombre_contribuyente.Enabled = false;
                    rfv_callenum_contribuyente.Enabled = false;
                    rfv_cp_contribuyente.Enabled = false;
                    rfv_colonia_contribuyente.Enabled = false;
                    rfv_nombre_contribuyente.Enabled = false;

                    break;

                case 11:

                    int_accion_usuario = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;
                    pnl_cliente.Visible = false;
                    pnl_proveedor.Visible = false;
                    pnl_usuarios.Visible = true;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:lightgray";
                    i_salir.Attributes["style"] = "color:darkblue";

                    limpia_txt_usuarios();

                    break;
                case 12:

                    Session.Abandon();
                    Response.Redirect("acceso.aspx");
                    //Server.Transfer("acceso.aspx", true);

                    break;

                default:

                    break;
            }
        }

        private void inf_user()
        {
            guid_iduser = (Guid)(Session["ss_id_user"]);

            using (db_hecsaEntities m_usuario = new db_hecsaEntities())
            {
                var i_usuario = (from i_u in m_usuario.inf_usuarios
                                 join i_tu in m_usuario.fact_tipo_usuario on i_u.id_tipo_usuario equals i_tu.id_tipo_usuario
                                 join i_c in m_usuario.inf_empresa on i_u.id_empresa equals i_c.id_empresa

                                 where i_u.id_usuario == guid_iduser
                                 select new
                                 {
                                     i_u.nombres,
                                     i_u.a_paterno,
                                     i_u.a_materno,
                                     i_tu.desc_tipo_usuario,
                                     i_tu.id_tipo_usuario,
                                     i_c.razon_social,
                                     i_c.id_empresa
                                 }).FirstOrDefault();

                lbl_edita_usuariof.Text = i_usuario.nombres + " " + i_usuario.a_paterno + " " + i_usuario.a_materno;
                lbl_ftipousuario.Text = i_usuario.desc_tipo_usuario;
                int_idtipousuario = i_usuario.id_tipo_usuario;
                lbl_ffnegocio.Text = i_usuario.razon_social;
                guid_fnegocio = i_usuario.id_empresa;
            }
            switch (int_idtipousuario)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    //lkb_resumen.Visible = false;
                    //i_resumen.Visible = false;
                    //lbl_resumen.Visible = false;

                    //lkb_rubro.Visible = false;
                    //i_rubro.Visible = false;
                    //lbl_rubro.Visible = false;

                    chkb_administrador.Visible = false;

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;

                case 8:

                    break;

                case 9:

                    break;

                case 10:

                    break;

                case 11:

                    break;

                case 12:

                    break;

                case 13:

                    break;

                case 14:

                    break;

                default:

                    break;
            }
        }

        #endregion panel

        #region usuariof

        protected void btn_guarda_fusuario_Click(object sender, EventArgs e)
        {
            if (chkbox_edita_fusuario.Checked)
            {
                string str_nombres = txt_nombres_fusuario.Text.ToUpper();
                string str_apaterno = txt_apaterno_fusuario.Text.ToUpper();
                string str_amaterno = txt_amaterno_fusuario.Text.ToUpper();

                string str_codigousuario = txt_usuario_fusuario.Text;
                string str_password = encriptar.Encrypt(txt_clave_fusuario.Text);

                using (var m_fusuario = new db_hecsaEntities())
                {
                    var i_fusuario = (from c in m_fusuario.inf_usuarios
                                      where c.codigo_usuario == str_codigousuario
                                      select c).ToList();

                    if (i_fusuario.Count == 0)
                    {
                        using (var m_fusuariof = new db_hecsaEntities())
                        {
                            var i_fusuariof = (from c in m_fusuariof.inf_usuarios
                                               where c.codigo_usuario == str_codigousuario
                                               select c).ToList();

                            if (i_fusuariof.Count == 0)
                            {
                                using (var m_fusuarioff = new db_hecsaEntities())
                                {
                                    var i_fusuarioff = (from c in m_fusuarioff.inf_usuarios
                                                        where c.id_usuario == guid_iduser
                                                        select c).FirstOrDefault();

                                    i_fusuarioff.nombres = str_nombres;
                                    i_fusuarioff.a_paterno = str_apaterno;
                                    i_fusuarioff.a_materno = str_amaterno;

                                    i_fusuarioff.codigo_usuario = str_codigousuario;
                                    i_fusuarioff.clave = str_password;

                                    m_fusuarioff.SaveChanges();

                                    limpia_txt_fusuario();
                                    Mensaje("Datos de Usuario actualizados con éxito.");
                                }
                            }
                            else
                            {
                                txt_usuario_fusuario.Text = null;
                                Mensaje("Código de usuario ya existe en la base de datos, favor de reintentar.");
                            }
                        }
                    }
                    else
                    {
                        i_fusuario[0].nombres = str_nombres;
                        i_fusuario[0].a_paterno = str_apaterno;
                        i_fusuario[0].a_materno = str_amaterno;

                        i_fusuario[0].codigo_usuario = str_codigousuario;
                        i_fusuario[0].clave = str_password;

                        m_fusuario.SaveChanges();

                        limpia_txt_fusuario();
                        Mensaje("Datos de Usuario actualizados con éxito.");
                    }
                }
            }
            else
            {
                Mensaje("Favor de activar la edición de los campos.");
            }
        }

        protected void chkbox_edita_fusuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_edita_fusuario.Checked)
            {
                rfv_nombres_fusuario.Enabled = true;
                rfv_apaterno_fusuario.Enabled = true;
                rfv_amaterno_fusuario.Enabled = true;
                rfv_usuario_fusuario.Enabled = true;
                rfv_clave_fusuario.Enabled = true;
                try
                {
                    using (db_hecsaEntities m_fusuario = new db_hecsaEntities())
                    {
                        var i_fusuario = (from i_c in m_fusuario.inf_usuarios
                                          where i_c.id_usuario == guid_iduser
                                          select new
                                          {
                                              i_c.nombres,
                                              i_c.a_paterno,
                                              i_c.a_materno,
                                              i_c.fecha_nacimiento,
                                              i_c.codigo_usuario,
                                              i_c.clave,
                                          }).FirstOrDefault();

                        txt_nombres_fusuario.Text = i_fusuario.nombres;
                        txt_apaterno_fusuario.Text = i_fusuario.a_paterno;
                        txt_amaterno_fusuario.Text = i_fusuario.a_materno;
                        txt_usuario_fusuario.Text = i_fusuario.codigo_usuario;
                        txt_clave_fusuario.Text = i_fusuario.clave;
                    }
                }
                catch
                {
                }
            }
            else
            {
                rfv_nombres_fusuario.Enabled = false;
                rfv_apaterno_fusuario.Enabled = false;
                rfv_amaterno_fusuario.Enabled = false;
                rfv_usuario_fusuario.Enabled = false;
                rfv_clave_fusuario.Enabled = false;
            }
        }

        private void limpia_txt_fusuario()
        {
            ddl_colonia_empresa.Items.Insert(0, new ListItem("Seleccionar", "0"));

            txt_nombres_fusuario.Text = null;
            txt_apaterno_fusuario.Text = null;
            txt_amaterno_fusuario.Text = null;
            txt_usuario_fusuario.Text = null;
            txt_clave_fusuario.Text = null;
        }

        #endregion usuariof

        #region negociof

        protected void btn_guarda_fnegocio_Click(object sender, EventArgs e)
        {
            guarda_fnegocio();
        }

        protected void chkbox_edita_fnegocio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_edita_fnegocio.Checked)
            {
                using (db_hecsaEntities data_user = new db_hecsaEntities())
                {
                    var inf_user = (from i_u in data_user.inf_empresa
                                    where i_u.id_empresa == guid_fnegocio
                                    select new
                                    {
                                        i_u.razon_social,
                                        i_u.telefono,
                                        i_u.email,
                                        i_u.callenum,
                                        i_u.id_codigo,
                                    }).FirstOrDefault();

                    txt_nombre_empresa.Text = inf_user.razon_social;
                    txt_telefono_empresa.Text = inf_user.telefono;
                    txt_email_empresa.Text = inf_user.email;
                    txt_callenum_empresa.Text = inf_user.callenum;

                    using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                    {
                        var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                           where c.id_codigo == inf_user.id_codigo
                                           select c).ToList();

                        ddl_colonia_empresa.DataSource = tbl_sepomex;
                        ddl_colonia_empresa.DataTextField = "d_asenta";
                        ddl_colonia_empresa.DataValueField = "id_asenta_cpcons";
                        ddl_colonia_empresa.DataBind();

                        txt_cp_empresa.Text = tbl_sepomex[0].d_codigo;
                        txt_municipio_empresa.Text = tbl_sepomex[0].d_mnpio;
                        txt_estado_empresa.Text = tbl_sepomex[0].d_estado;
                    }

                    rfv_nombre_empresa.Enabled = true;
                    rfv_callenum_empresa.Enabled = true;
                    rfv_cp_empresa.Enabled = true;
                    rfv_colonia_empresa.Enabled = true;
                }
            }
            else
            {
                rfv_nombre_empresa.Enabled = false;
                rfv_callenum_empresa.Enabled = false;
                rfv_cp_empresa.Enabled = false;
                rfv_colonia_empresa.Enabled = false;
            }
        }

        protected void txt_callenum_empresa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_callenum_empresa.Text))
            { }
            else
            {
                rfv_callenum_empresa.Enabled = true;
                rfv_cp_empresa.Enabled = true;
                rfv_colonia_empresa.Enabled = true;
                txt_cp_empresa.Focus();
            }
        }

        protected void txt_cp_empresa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cp_empresa.Text))
            {
            }
            else
            {
                string str_codigo = txt_cp_empresa.Text;

                datos_sepomex(str_codigo);
            }
        }

        protected void txt_nombre_empresa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre_empresa.Text))
            {
                rfv_callenum_empresa.Enabled = false;
            }
            else
            {
                rfv_callenum_empresa.Enabled = true;
            }
        }

        private void datos_sepomex(string str_codigo)
        {
            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_codigo
                                   select c).ToList();

                ddl_colonia_empresa.DataSource = tbl_sepomex;
                ddl_colonia_empresa.DataTextField = "d_asenta";
                ddl_colonia_empresa.DataValueField = "id_asenta_cpcons";
                ddl_colonia_empresa.DataBind();

                if (tbl_sepomex.Count == 1)
                {
                    txt_municipio_empresa.Text = tbl_sepomex[0].d_mnpio;
                    txt_estado_empresa.Text = tbl_sepomex[0].d_estado;
                    rfv_colonia_empresa.Enabled = true;

                    txt_cp_empresa.Focus();
                }
                if (tbl_sepomex.Count > 1)
                {
                    ddl_colonia_empresa.Items.Insert(0, new ListItem("Seleccionar", "0"));

                    txt_municipio_empresa.Text = tbl_sepomex[0].d_mnpio;
                    txt_estado_empresa.Text = tbl_sepomex[0].d_estado;
                    rfv_colonia_empresa.Enabled = true;

                    txt_cp_empresa.Focus();
                }
                else if (tbl_sepomex.Count == 0)
                {
                    ddl_colonia_empresa.Items.Clear();
                    ddl_colonia_empresa.Items.Insert(0, new ListItem("Seleccionar", "0"));
                    txt_municipio_empresa.Text = null;
                    txt_estado_empresa.Text = null;
                    rfv_colonia_empresa.Enabled = false;

                    txt_cp_empresa.Focus();
                }
            }
        }

        private void guarda_fnegocio()
        {
            if (chkbox_edita_fnegocio.Checked)
            {
                Guid guid_nfnegocio = Guid.NewGuid();
                string str_corporativo = txt_nombre_empresa.Text.ToUpper();

                string str_telefono = txt_telefono_empresa.Text;
                string str_email = txt_email_empresa.Text;
                string str_callenum = txt_callenum_empresa.Text.ToUpper();
                string str_cp = txt_cp_empresa.Text;
                int int_colony = Convert.ToInt32(ddl_colonia_empresa.SelectedValue);
                int int_idcodigocp;

                using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                {
                    var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                       where c.d_codigo == str_cp
                                       where c.id_asenta_cpcons == int_colony
                                       select c).ToList();

                    int_idcodigocp = tbl_sepomex[0].id_codigo;
                }

                using (var m_fempresa = new db_hecsaEntities())
                {
                    var i_fempresa = (from c in m_fempresa.inf_empresa
                                      where c.id_empresa == guid_fnegocio
                                      select c).FirstOrDefault();

                    i_fempresa.razon_social = str_corporativo;
                    i_fempresa.telefono = str_telefono;
                    i_fempresa.email = str_email;
                    i_fempresa.callenum = str_callenum;
                    i_fempresa.id_codigo = int_idcodigocp;

                    m_fempresa.SaveChanges();
                }

                limpia_txt_fnegocio();

                Mensaje("Datos de Empresa actualizados con éxito");
            }
            else
            {
                Mensaje("Favor de activar la edición de los campos.");
            }
        }

        private void limpia_txt_fnegocio()
        {
            ddl_colonia_empresa.Items.Clear();

            ddl_colonia_empresa.Items.Insert(0, new ListItem("Seleccionar", "0"));
            txt_nombre_empresa.Text = null;
            txt_telefono_empresa.Text = null;
            txt_email_empresa.Text = null;
            txt_callenum_empresa.Text = null;
            txt_cp_empresa.Text = null;
            txt_municipio_empresa.Text = null;
            txt_estado_empresa.Text = null;
        }

        #endregion negociof

        #region cliente

        protected void chkbox_agregar_c_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_agregar_c.Checked)
            {
                chkbox_editar_c.Checked = false;

                lbl_buscar_cliente.Visible = false;
                txt_buscar_cliente.Visible = false;
                btn_buscar_cliente.Visible = false;
                txt_buscar_cliente.Text = null;

                limpia_txt_cliente();

                rfv_tiporfc_cliente.Enabled = true;
                rfv_rfc_cliente.Enabled = true;
                rfv_nombre_cliente.Enabled = true;
                rfv_callenum_cliente.Enabled = true;
                rfv_cp_cliente.Enabled = true;
            }
            else
            {
                chkbox_editar_c.Checked = false;

                lbl_buscar_cliente.Visible = false;
                txt_buscar_cliente.Visible = false;
                btn_buscar_cliente.Visible = false;
                txt_buscar_cliente.Text = null;

                limpia_txt_cliente();


                rfv_tiporfc_cliente.Enabled = false;
                rfv_rfc_cliente.Enabled = false;
                rfv_nombre_cliente.Enabled = false;
                rfv_callenum_cliente.Enabled = false;
                rfv_cp_cliente.Enabled = false;
                rfv_colonia_cliente.Enabled = false;
                rfv_nombres_ccontacto.Enabled = false;
            }
        }

        protected void chkbox_editar_c_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_editar_c.Checked)
            {
                chkbox_agregar_c.Checked = false;

                lbl_buscar_cliente.Visible = true;
                txt_buscar_cliente.Visible = true;
                btn_buscar_cliente.Visible = true;
                txt_buscar_cliente.Text = null;

                limpia_txt_cliente();

                using (db_hecsaEntities data_user = new db_hecsaEntities())
                {
                    var inf_user = (from i_u in data_user.inf_clientes
                                    join i_e in data_user.fact_tipo_rfc on i_u.id_tipo_rfc equals i_e.id_tipo_rfc
                                    select new
                                    {
                                        i_u.codigo_cliente,
                                        i_e.desc_tipo_rfc,
                                        i_u.rfc,
                                        i_u.razon_social,
                                        i_u.fecha_registro
                                    }).ToList();

                    gv_cliente.DataSource = inf_user;
                    gv_cliente.DataBind();
                    gv_cliente.Visible = true;
                }
            }
            else
            {
                chkbox_agregar_c.Checked = false;
                lbl_buscar_cliente.Visible = false;
                txt_buscar_cliente.Visible = false;
                btn_buscar_cliente.Visible = false;
                txt_buscar_cliente.Text = null;

                limpia_txt_cliente();

                rfv_tiporfc_cliente.Enabled = false;
                rfv_rfc_cliente.Enabled = false;
                rfv_nombre_cliente.Enabled = false;
                rfv_callenum_cliente.Enabled = false;
                rfv_cp_cliente.Enabled = false;
                rfv_colonia_cliente.Enabled = false;
                rfv_nombres_ccontacto.Enabled = false;
            }
        }

        //protected void txt_rfc_cliente_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txt_rfc_cliente.Text))
        //    {
        //    }
        //    else
        //    {
        //        if (Regex.IsMatch(txt_rfc_cliente.Text, @"^[a-zA-Z]{3,4}(\d{6})((\D|\d){3})?$"))
        //        {
        //            txt_rfc_cliente.Focus();
        //        }
        //        else
        //        {
        //            Mensaje("RFC no tiene un formato valido.");
        //            txt_rfc_cliente.Text = null;
        //        }
        //    }
        //}

        protected void chk_cliente_CheckedChanged(object sender, EventArgs e)
        {
            Guid guid_codigocliente;
            string str_codigoclientef;
            int int_idcolonia;

            foreach (GridViewRow row in gv_cliente.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_cliente") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.FromArgb(224, 153, 123);
                        str_codigoclientef = row.Cells[0].Text;

                        using (db_hecsaEntities data_user = new db_hecsaEntities())
                        {
                            var items_user = (from c in data_user.inf_clientes
                                              where c.codigo_cliente == str_codigoclientef
                                              select c).FirstOrDefault();

                            guid_codigocliente = items_user.id_cliente;
                        }

                        using (db_hecsaEntities edm_cliente = new db_hecsaEntities())
                        {
                            var i_cliente = (from u in edm_cliente.inf_clientes
                                             join i_e in edm_cliente.inf_contacto_cliente on u.id_cliente equals i_e.id_cliente
                                             where u.id_cliente == guid_codigocliente
                                             select new
                                             {
                                                 u.id_tipo_rfc,
                                                 u.rfc,
                                                 u.razon_social,
                                                 u.callenum,
                                                 u.telefono,
                                                 u.email,
                                                 u.id_codigo,
                                                 i_e.nombres,
                                                 i_e.a_paterno,
                                                 i_e.a_materno,
                                                 telefonoc = i_e.telefono,
                                                 emailc = i_e.email,
                                             }).FirstOrDefault();

                            ddl_tiporfc_cliente.SelectedValue = i_cliente.id_tipo_rfc.ToString();
                            txt_rfc_cliente.Text = i_cliente.rfc;
                            txt_nombre_cliente.Text = i_cliente.razon_social;
                            txt_telefono_cliente.Text = i_cliente.telefono;
                            txt_email_cliente.Text = i_cliente.email;
                            txt_callenum_cliente.Text = i_cliente.callenum;

                            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                            {
                                var i_sepomex = (from c in db_sepomex.inf_sepomex
                                                 where c.id_codigo == i_cliente.id_codigo
                                                 select c).ToList();

                                txt_cp_cliente.Text = i_sepomex[0].d_codigo;
                                txt_municipio_cliente.Text = i_sepomex[0].d_mnpio;
                                txt_estado_cliente.Text = i_sepomex[0].d_estado;

                                int_idcolonia = int.Parse(i_sepomex[0].id_asenta_cpcons.ToString());

                                using (db_hecsaEntities edm_colonia = new db_hecsaEntities())
                                {
                                    var i_colonia = (from c in db_sepomex.inf_sepomex
                                                     where c.id_codigo == i_cliente.id_codigo
                                                     select c).ToList();

                                    ddl_colonia_cliente.DataSource = i_colonia;
                                    ddl_colonia_cliente.DataTextField = "d_asenta";
                                    ddl_colonia_cliente.DataValueField = "id_asenta_cpcons";
                                    ddl_colonia_cliente.DataBind();
                                }
                            }

                            txt_nombres_ccontacto.Text = i_cliente.nombres;
                            txt_apaterno_ccontacto.Text = i_cliente.a_paterno;
                            txt_amaterno_ccontacto.Text = i_cliente.a_materno;

                            txt_telefono_ccontacto.Text = i_cliente.telefonoc;
                            txt_email_ccontacto.Text = i_cliente.emailc;
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }

        protected void gv_cliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }

        protected void gv_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void limpia_txt_cliente()
        {
            ddl_tiporfc_cliente.Items.Clear();
            ddl_colonia_cliente.Items.Clear();
            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc
                                   select c).ToList();

                ddl_tiporfc_cliente.DataSource = tbl_sepomex;
                ddl_tiporfc_cliente.DataTextField = "desc_tipo_rfc";
                ddl_tiporfc_cliente.DataValueField = "id_tipo_rfc";
                ddl_tiporfc_cliente.DataBind();
            }
            ddl_tiporfc_cliente.Items.Insert(0, new ListItem("Seleccionar", "0"));

            ddl_colonia_cliente.Items.Insert(0, new ListItem("Seleccionar", "0"));

            txt_rfc_cliente.Text = null;
            txt_nombre_cliente.Text = null;
            txt_telefono_cliente.Text = null;
            txt_email_cliente.Text = null;
            txt_callenum_cliente.Text = null;

            txt_cp_cliente.Text = null;
            txt_municipio_cliente.Text = null;
            txt_estado_cliente.Text = null;

            txt_nombres_ccontacto.Text = null;
            txt_apaterno_ccontacto.Text = null;
            txt_amaterno_ccontacto.Text = null;

            txt_telefono_ccontacto.Text = null;
            txt_email_ccontacto.Text = null;
        }

        protected void btn_cp_cliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cp_cliente.Text))
            {
            }
            else
            {
                string str_codigo = txt_cp_cliente.Text;

                using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                {
                    var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                       where c.d_codigo == str_codigo
                                       select c).ToList();

                    ddl_colonia_cliente.DataSource = tbl_sepomex;
                    ddl_colonia_cliente.DataTextField = "d_asenta";
                    ddl_colonia_cliente.DataValueField = "id_asenta_cpcons";
                    ddl_colonia_cliente.DataBind();

                    if (tbl_sepomex.Count == 1)
                    {
                        txt_municipio_cliente.Text = tbl_sepomex[0].d_mnpio;
                        txt_estado_cliente.Text = tbl_sepomex[0].d_estado;
                        rfv_colonia_cliente.Enabled = true;
                        rfv_nombres_ccontacto.Enabled = true;

                        txt_cp_cliente.Focus();
                    }
                    if (tbl_sepomex.Count > 1)
                    {
                        ddl_colonia_cliente.Items.Insert(0, new ListItem("Seleccionar", "0"));

                        txt_municipio_cliente.Text = tbl_sepomex[0].d_mnpio;
                        txt_estado_cliente.Text = tbl_sepomex[0].d_estado;
                        rfv_colonia_cliente.Enabled = true;
                        rfv_nombres_ccontacto.Enabled = true;

                        txt_cp_cliente.Focus();
                    }
                    else if (tbl_sepomex.Count == 0)
                    {
                        ddl_colonia_cliente.Items.Clear();
                        ddl_colonia_cliente.Items.Insert(0, new ListItem("Seleccionar", "0"));
                        txt_municipio_cliente.Text = null;
                        txt_estado_cliente.Text = null;
                        rfv_colonia_cliente.Enabled = false;
                        rfv_nombres_ccontacto.Enabled = false;

                        txt_cp_cliente.Focus();
                    }
                }
            }
        }

        protected void btn_guardar_cliente_Click(object sender, EventArgs e)
        {
            Guid guid_ncliente, guid_contacto_c;
            int int_tiporfc, int_colonia, int_idcodigocp;
            string str_rfc, str_nombrecliente, str_telefono, str_correo, str_callenum, str_cp, str_nombre_c, str_apeterno_c, str_amaterno_c, str_telefono_c, str_correo_c;

            guid_ncliente = Guid.NewGuid();
            guid_contacto_c = Guid.NewGuid();
            int_tiporfc = int.Parse(ddl_tiporfc_cliente.SelectedValue);
            str_rfc = txt_rfc_cliente.Text.ToUpper();
            str_nombrecliente = txt_nombre_cliente.Text.ToUpper();
            str_telefono = txt_telefono_cliente.Text;
            str_correo = txt_email_cliente.Text;
            str_callenum = txt_callenum_cliente.Text.ToUpper();
            str_cp = txt_cp_cliente.Text;
            int_colonia = int.Parse(ddl_colonia_cliente.SelectedValue);
            str_nombre_c = txt_nombres_ccontacto.Text.ToUpper();
            str_apeterno_c = txt_apaterno_ccontacto.Text.ToUpper();
            str_amaterno_c = txt_amaterno_ccontacto.Text.ToUpper();
            str_telefono_c = txt_telefono_cliente.Text;
            str_correo_c = txt_email_ccontacto.Text;

            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_cp
                                   where c.id_asenta_cpcons == int_colonia
                                   select c).ToList();

                int_idcodigocp = tbl_sepomex[0].id_codigo;
            }

            if (chkbox_agregar_c.Checked)
            {
                using (db_hecsaEntities edm_rfc = new db_hecsaEntities())
                {
                    var i_rfc = (from c in edm_rfc.inf_clientes
                                 where c.rfc == str_rfc
                                 select c).ToList();

                    if (i_rfc.Count == 0)
                    {
                        using (db_hecsaEntities edm_rfcf = new db_hecsaEntities())
                        {
                            var i_rfcf = (from c in edm_rfcf.inf_clientes
                                          select c).ToList();
                            using (var m_empresa = new db_hecsaEntities())
                            {
                                var i_empresa = new inf_clientes

                                {
                                    id_cliente = guid_ncliente,
                                    id_estatus = 1,
                                    id_tipo_rfc = int_tiporfc,
                                    rfc = str_rfc,
                                    razon_social = str_nombrecliente,
                                    telefono = str_telefono,
                                    email = str_correo,
                                    callenum = str_callenum,
                                    id_codigo = int_idcodigocp,
                                    codigo_cliente = "clte_" + string.Format("{0:000}", i_rfcf.Count + 1),
                                    fecha_registro = DateTime.Now,
                                    id_empresa = guid_fnegocio
                                };

                                m_empresa.inf_clientes.Add(i_empresa);
                                m_empresa.SaveChanges();
                            }

                            using (var m_usuario = new db_hecsaEntities())
                            {
                                var i_usuario = new inf_contacto_cliente
                                {
                                    id_contacto_cliente = guid_contacto_c,
                                    id_estatus = 1,
                                    nombres = str_nombre_c,
                                    a_paterno = str_apeterno_c,
                                    a_materno = str_amaterno_c,
                                    telefono = str_telefono_c,
                                    email = str_correo_c,
                                    fecha_registro = DateTime.Now,
                                    id_cliente = guid_ncliente
                                };
                                m_usuario.inf_contacto_cliente.Add(i_usuario);
                                m_usuario.SaveChanges();
                            }

                            limpia_txt_cliente();
                            Mensaje("Datos de Cliente y Contacto agregados con éxito.");
                        }
                    }
                    else
                    {
                        Mensaje("RFC ya existe en la base de datos, favor de cambiarlo.");
                    }
                }
            }
            else if (chkbox_editar_c.Checked)
            {
            }
        }

        #endregion cliente

        #region proveedor

        protected void chkbox_agregar_p_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_agregar_p.Checked)
            {
                chkbox_editar_p.Checked = false;

                lbl_buscar_proveedor.Visible = false;
                txt_buscar_proveedor.Visible = false;
                btn_buscar_proveedor.Visible = false;
                txt_buscar_proveedor.Text = null;

                limpia_txt_proveedor();

                rfv_tiporfc_proveedor.Enabled = true;
                rfv_rfc_proveedor.Enabled = true;
                rfv_nombre_proveedor.Enabled = true;
                rfv_callenum_proveedor.Enabled = true;
                rfv_cp_proveedor.Enabled = true;
            }
            else
            {
                chkbox_editar_p.Checked = false;

                lbl_buscar_proveedor.Visible = false;
                txt_buscar_proveedor.Visible = false;
                btn_buscar_proveedor.Visible = false;
                txt_buscar_proveedor.Text = null;

                limpia_txt_proveedor();


                rfv_tiporfc_proveedor.Enabled = false;
                rfv_rfc_proveedor.Enabled = false;
                rfv_nombre_proveedor.Enabled = false;
                rfv_callenum_proveedor.Enabled = false;
                rfv_cp_proveedor.Enabled = false;
                rfv_colonia_proveedor.Enabled = false;
                rfv_nombres_cproveedor.Enabled = false;
            }
        }

        protected void chkbox_editar_p_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_editar_p.Checked)
            {
                chkbox_agregar_p.Checked = false;

                lbl_buscar_proveedor.Visible = true;
                txt_buscar_proveedor.Visible = true;
                btn_buscar_proveedor.Visible = true;
                txt_buscar_proveedor.Text = null;

                limpia_txt_proveedor();

                using (db_hecsaEntities data_user = new db_hecsaEntities())
                {
                    var inf_user = (from i_u in data_user.inf_proveedores
                                    join i_e in data_user.fact_tipo_rfc on i_u.id_tipo_rfc equals i_e.id_tipo_rfc
                                    select new
                                    {
                                        i_u.codigo_proveedor,
                                        i_e.desc_tipo_rfc,
                                        i_u.rfc,
                                        i_u.razon_social,
                                        i_u.fecha_registro
                                    }).ToList();

                    gv_proveedor.DataSource = inf_user;
                    gv_proveedor.DataBind();
                    gv_proveedor.Visible = true;
                }
            }
            else
            {
                chkbox_agregar_p.Checked = false;
                lbl_buscar_proveedor.Visible = false;
                txt_buscar_proveedor.Visible = false;
                btn_buscar_proveedor.Visible = false;
                txt_buscar_proveedor.Text = null;

                limpia_txt_proveedor();

                rfv_tiporfc_proveedor.Enabled = false;
                rfv_rfc_proveedor.Enabled = false;
                rfv_nombre_proveedor.Enabled = false;
                rfv_callenum_proveedor.Enabled = false;
                rfv_cp_proveedor.Enabled = false;
                rfv_colonia_proveedor.Enabled = false;
                rfv_nombres_cproveedor.Enabled = false;
            }
        }

        //protected void txt_rfc_proveedor_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txt_rfc_proveedor.Text))
        //    {
        //    }
        //    else
        //    {
        //        if (Regex.IsMatch(txt_rfc_proveedor.Text, @"^[a-zA-Z]{3,4}(\d{6})((\D|\d){3})?$"))
        //        {
        //            txt_rfc_proveedor.Focus();
        //        }
        //        else
        //        {
        //            Mensaje("RFC no tiene un formato valido.");
        //            txt_rfc_proveedor.Text = null;
        //        }
        //    }
        //}

        protected void chk_proveedor_CheckedChanged(object sender, EventArgs e)
        {
            Guid guid_codigoproveedor;
            string str_codigoproveedorf;
            int int_idcolonia;

            foreach (GridViewRow row in gv_proveedor.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_proveedor") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.FromArgb(224, 153, 123);
                        str_codigoproveedorf = row.Cells[0].Text;

                        using (db_hecsaEntities data_user = new db_hecsaEntities())
                        {
                            var items_user = (from c in data_user.inf_proveedores
                                              where c.codigo_proveedor == str_codigoproveedorf
                                              select c).FirstOrDefault();

                            guid_codigoproveedor = items_user.id_proveedor;
                        }

                        using (db_hecsaEntities edm_proveedor = new db_hecsaEntities())
                        {
                            var i_proveedor = (from u in edm_proveedor.inf_proveedores
                                               join i_e in edm_proveedor.inf_contacto_proveedor on u.id_proveedor equals i_e.id_proveedor
                                               where u.id_proveedor == guid_codigoproveedor
                                               select new
                                               {
                                                   u.id_tipo_rfc,
                                                   u.rfc,
                                                   u.razon_social,
                                                   u.callenum,
                                                   u.telefono,
                                                   u.email,
                                                   u.id_codigo,
                                                   i_e.nombres,
                                                   i_e.a_paterno,
                                                   i_e.a_materno,
                                                   telefonoc = i_e.telefono,
                                                   emailc = i_e.email,
                                               }).FirstOrDefault();

                            ddl_tiporfc_proveedor.SelectedValue = i_proveedor.id_tipo_rfc.ToString();
                            txt_rfc_proveedor.Text = i_proveedor.rfc;
                            txt_nombre_proveedor.Text = i_proveedor.razon_social;
                            txt_telefono_proveedor.Text = i_proveedor.telefono;
                            txt_email_proveedor.Text = i_proveedor.email;
                            txt_callenum_proveedor.Text = i_proveedor.callenum;

                            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                            {
                                var i_sepomex = (from c in db_sepomex.inf_sepomex
                                                 where c.id_codigo == i_proveedor.id_codigo
                                                 select c).ToList();

                                txt_cp_proveedor.Text = i_sepomex[0].d_codigo;
                                txt_municipio_proveedor.Text = i_sepomex[0].d_mnpio;
                                txt_estado_proveedor.Text = i_sepomex[0].d_estado;

                                int_idcolonia = int.Parse(i_sepomex[0].id_asenta_cpcons.ToString());

                                using (db_hecsaEntities edm_colonia = new db_hecsaEntities())
                                {
                                    var i_colonia = (from c in db_sepomex.inf_sepomex
                                                     where c.id_codigo == i_proveedor.id_codigo
                                                     select c).ToList();

                                    ddl_colonia_proveedor.DataSource = i_colonia;
                                    ddl_colonia_proveedor.DataTextField = "d_asenta";
                                    ddl_colonia_proveedor.DataValueField = "id_asenta_cpcons";
                                    ddl_colonia_proveedor.DataBind();
                                }
                            }

                            txt_nombres_cproveedor.Text = i_proveedor.nombres;
                            txt_apaterno_cproveedor.Text = i_proveedor.a_paterno;
                            txt_amaterno_cproveedor.Text = i_proveedor.a_materno;

                            txt_telefono_cproveedor.Text = i_proveedor.telefonoc;
                            txt_email_cproveedor.Text = i_proveedor.emailc;
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }

        protected void gv_proveedor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }

        protected void gv_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void limpia_txt_proveedor()
        {
            ddl_tiporfc_proveedor.Items.Clear();
            ddl_colonia_proveedor.Items.Clear();
            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc
                                   select c).ToList();

                ddl_tiporfc_proveedor.DataSource = tbl_sepomex;
                ddl_tiporfc_proveedor.DataTextField = "desc_tipo_rfc";
                ddl_tiporfc_proveedor.DataValueField = "id_tipo_rfc";
                ddl_tiporfc_proveedor.DataBind();
            }
            ddl_tiporfc_proveedor.Items.Insert(0, new ListItem("Seleccionar", "0"));

            ddl_colonia_proveedor.Items.Insert(0, new ListItem("Seleccionar", "0"));

            txt_rfc_proveedor.Text = null;
            txt_nombre_proveedor.Text = null;
            txt_telefono_proveedor.Text = null;
            txt_email_proveedor.Text = null;
            txt_callenum_proveedor.Text = null;

            txt_cp_proveedor.Text = null;
            txt_municipio_proveedor.Text = null;
            txt_estado_proveedor.Text = null;

            txt_nombres_cproveedor.Text = null;
            txt_apaterno_cproveedor.Text = null;
            txt_amaterno_cproveedor.Text = null;

            txt_telefono_cproveedor.Text = null;
            txt_email_cproveedor.Text = null;
        }

        protected void btn_cp_proveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cp_proveedor.Text))
            {
            }
            else
            {
                string str_codigo = txt_cp_proveedor.Text;

                using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                {
                    var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                       where c.d_codigo == str_codigo
                                       select c).ToList();

                    ddl_colonia_proveedor.DataSource = tbl_sepomex;
                    ddl_colonia_proveedor.DataTextField = "d_asenta";
                    ddl_colonia_proveedor.DataValueField = "id_asenta_cpcons";
                    ddl_colonia_proveedor.DataBind();

                    if (tbl_sepomex.Count == 1)
                    {
                        txt_municipio_proveedor.Text = tbl_sepomex[0].d_mnpio;
                        txt_estado_proveedor.Text = tbl_sepomex[0].d_estado;
                        rfv_colonia_proveedor.Enabled = true;
                        rfv_nombres_cproveedor.Enabled = true;

                        txt_cp_proveedor.Focus();
                    }
                    if (tbl_sepomex.Count > 1)
                    {
                        ddl_colonia_proveedor.Items.Insert(0, new ListItem("Seleccionar", "0"));

                        txt_municipio_proveedor.Text = tbl_sepomex[0].d_mnpio;
                        txt_estado_proveedor.Text = tbl_sepomex[0].d_estado;
                        rfv_colonia_proveedor.Enabled = true;
                        rfv_nombres_cproveedor.Enabled = true;

                        txt_cp_proveedor.Focus();
                    }
                    else if (tbl_sepomex.Count == 0)
                    {
                        ddl_colonia_proveedor.Items.Clear();
                        ddl_colonia_proveedor.Items.Insert(0, new ListItem("Seleccionar", "0"));
                        txt_municipio_proveedor.Text = null;
                        txt_estado_proveedor.Text = null;
                        rfv_colonia_proveedor.Enabled = false;
                        rfv_nombres_cproveedor.Enabled = false;

                        txt_cp_proveedor.Focus();
                    }
                }
            }
        }

        protected void btn_guardar_proveedor_Click(object sender, EventArgs e)
        {
            Guid guid_nproveedor, guid_proveedor_c;
            int int_tiporfc, int_colonia, int_idcodigocp;
            string str_rfc, str_nombreproveedor, str_telefono, str_correo, str_callenum, str_cp, str_nombre_c, str_apeterno_c, str_amaterno_c, str_telefono_c, str_correo_c;

            guid_nproveedor = Guid.NewGuid();
            guid_proveedor_c = Guid.NewGuid();
            int_tiporfc = int.Parse(ddl_tiporfc_proveedor.SelectedValue);
            str_rfc = txt_rfc_proveedor.Text.ToUpper();
            str_nombreproveedor = txt_nombre_proveedor.Text.ToUpper();
            str_telefono = txt_telefono_proveedor.Text;
            str_correo = txt_email_proveedor.Text;
            str_callenum = txt_callenum_proveedor.Text.ToUpper();
            str_cp = txt_cp_proveedor.Text;
            int_colonia = int.Parse(ddl_colonia_proveedor.SelectedValue);
            str_nombre_c = txt_nombres_cproveedor.Text.ToUpper();
            str_apeterno_c = txt_apaterno_cproveedor.Text.ToUpper();
            str_amaterno_c = txt_amaterno_cproveedor.Text.ToUpper();
            str_telefono_c = txt_telefono_proveedor.Text;
            str_correo_c = txt_email_cproveedor.Text;

            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_cp
                                   where c.id_asenta_cpcons == int_colonia
                                   select c).ToList();

                int_idcodigocp = tbl_sepomex[0].id_codigo;
            }

            if (chkbox_agregar_c.Checked)
            {
                using (db_hecsaEntities edm_rfc = new db_hecsaEntities())
                {
                    var i_rfc = (from c in edm_rfc.inf_proveedores
                                 where c.rfc == str_rfc
                                 select c).ToList();

                    if (i_rfc.Count == 0)
                    {
                        using (db_hecsaEntities edm_rfcf = new db_hecsaEntities())
                        {
                            var i_rfcf = (from c in edm_rfcf.inf_proveedores
                                          select c).ToList();
                            using (var m_empresa = new db_hecsaEntities())
                            {
                                var i_empresa = new inf_proveedores

                                {
                                    id_proveedor = guid_nproveedor,
                                    id_estatus = 1,
                                    id_tipo_rfc = int_tiporfc,
                                    rfc = str_rfc,
                                    razon_social = str_nombreproveedor,
                                    telefono = str_telefono,
                                    email = str_correo,
                                    callenum = str_callenum,
                                    id_codigo = int_idcodigocp,
                                    codigo_proveedor = "clte_" + string.Format("{0:000}", i_rfcf.Count + 1),
                                    fecha_registro = DateTime.Now,
                                    id_empresa = guid_fnegocio
                                };

                                m_empresa.inf_proveedores.Add(i_empresa);
                                m_empresa.SaveChanges();
                            }

                            using (var m_usuario = new db_hecsaEntities())
                            {
                                var i_usuario = new inf_contacto_proveedor
                                {
                                    id_contacto_proveedor = guid_proveedor_c,
                                    id_estatus = 1,
                                    nombres = str_nombre_c,
                                    a_paterno = str_apeterno_c,
                                    a_materno = str_amaterno_c,
                                    telefono = str_telefono_c,
                                    email = str_correo_c,
                                    fecha_registro = DateTime.Now,
                                    id_proveedor = guid_nproveedor
                                };
                                m_usuario.inf_contacto_proveedor.Add(i_usuario);
                                m_usuario.SaveChanges();
                            }

                            limpia_txt_proveedor();
                            Mensaje("Datos de proveedor y proveedor agregados con éxito.");
                        }
                    }
                    else
                    {
                        Mensaje("RFC ya existe en la base de datos, favor de cambiarlo.");
                    }
                }
            }
            else if (chkbox_editar_c.Checked)
            {
            }
        }

        #endregion proveedor

        #region contribuyente

        protected void chkbox_agregar_co_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_agregar_c.Checked)
            {
                chkbox_editar_c.Checked = false;

                lbl_buscar_contribuyente.Visible = false;
                txt_buscar_contribuyente.Visible = false;
                btn_buscar_contribuyente.Visible = false;
                txt_buscar_contribuyente.Text = null;

                limpia_txt_contribuyente();

                rfv_tiporfc_contribuyente.Enabled = true;
                rfv_rfc_contribuyente.Enabled = true;
                rfv_nombre_contribuyente.Enabled = true;
                rfv_callenum_contribuyente.Enabled = true;
                rfv_cp_contribuyente.Enabled = true;
            }
            else
            {
                chkbox_editar_c.Checked = false;

                lbl_buscar_contribuyente.Visible = false;
                txt_buscar_contribuyente.Visible = false;
                btn_buscar_contribuyente.Visible = false;
                txt_buscar_contribuyente.Text = null;

                limpia_txt_contribuyente();


                rfv_tiporfc_contribuyente.Enabled = false;
                rfv_rfc_contribuyente.Enabled = false;
                rfv_nombre_contribuyente.Enabled = false;
                rfv_callenum_contribuyente.Enabled = false;
                rfv_cp_contribuyente.Enabled = false;
                rfv_colonia_contribuyente.Enabled = false;
                rfv_nombres_ccontribuyente.Enabled = false;
            }
        }

        protected void chkbox_editar_co_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_editar_c.Checked)
            {
                chkbox_agregar_c.Checked = false;

                lbl_buscar_contribuyente.Visible = true;
                txt_buscar_contribuyente.Visible = true;
                btn_buscar_contribuyente.Visible = true;
                txt_buscar_contribuyente.Text = null;

                limpia_txt_contribuyente();

                using (db_hecsaEntities data_user = new db_hecsaEntities())
                {
                    var inf_user = (from i_u in data_user.inf_contribuyentes
                                    join i_e in data_user.fact_tipo_rfc on i_u.id_tipo_rfc equals i_e.id_tipo_rfc
                                    select new
                                    {
                                        i_u.codigo_contribuyente,
                                        i_e.desc_tipo_rfc,
                                        i_u.rfc,
                                        i_u.razon_social,
                                        i_u.fecha_registro
                                    }).ToList();

                    gv_contribuyente.DataSource = inf_user;
                    gv_contribuyente.DataBind();
                    gv_contribuyente.Visible = true;
                }
            }
            else
            {
                chkbox_agregar_c.Checked = false;
                lbl_buscar_contribuyente.Visible = false;
                txt_buscar_contribuyente.Visible = false;
                btn_buscar_contribuyente.Visible = false;
                txt_buscar_contribuyente.Text = null;

                limpia_txt_contribuyente();

                rfv_tiporfc_contribuyente.Enabled = false;
                rfv_rfc_contribuyente.Enabled = false;
                rfv_nombre_contribuyente.Enabled = false;
                rfv_callenum_contribuyente.Enabled = false;
                rfv_cp_contribuyente.Enabled = false;
                rfv_colonia_contribuyente.Enabled = false;
                rfv_nombres_ccontribuyente.Enabled = false;
            }
        }

        //protected void txt_rfc_contribuyente_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txt_rfc_contribuyente.Text))
        //    {
        //    }
        //    else
        //    {
        //        if (Regex.IsMatch(txt_rfc_contribuyente.Text, @"^[a-zA-Z]{3,4}(\d{6})((\D|\d){3})?$"))
        //        {
        //            txt_rfc_contribuyente.Focus();
        //        }
        //        else
        //        {
        //            Mensaje("RFC no tiene un formato valido.");
        //            txt_rfc_contribuyente.Text = null;
        //        }
        //    }
        //}

        protected void chk_contribuyente_CheckedChanged(object sender, EventArgs e)
        {
            Guid guid_codigocontribuyente;
            string str_codigocontribuyentef;
            int int_idcolonia;

            foreach (GridViewRow row in gv_contribuyente.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_contribuyente") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.FromArgb(224, 153, 123);
                        str_codigocontribuyentef = row.Cells[0].Text;

                        using (db_hecsaEntities data_user = new db_hecsaEntities())
                        {
                            var items_user = (from c in data_user.inf_contribuyentes
                                              where c.codigo_contribuyente == str_codigocontribuyentef
                                              select c).FirstOrDefault();

                            guid_codigocontribuyente = items_user.id_contribuyente;
                        }

                        using (db_hecsaEntities edm_contribuyente = new db_hecsaEntities())
                        {
                            var i_contribuyente = (from u in edm_contribuyente.inf_contribuyentes
                                                   join i_e in edm_contribuyente.inf_contacto_contribuyente on u.id_contribuyente equals i_e.id_contribuyente
                                                   where u.id_contribuyente == guid_codigocontribuyente
                                                   select new
                                                   {
                                                       u.id_tipo_rfc,
                                                       u.rfc,
                                                       u.razon_social,
                                                       u.callenum,
                                                       u.telefono,
                                                       u.email,
                                                       u.id_codigo,
                                                       i_e.nombres,
                                                       i_e.a_paterno,
                                                       i_e.a_materno,
                                                       telefonoc = i_e.telefono,
                                                       emailc = i_e.email,
                                                   }).FirstOrDefault();

                            ddl_tiporfc_contribuyente.SelectedValue = i_contribuyente.id_tipo_rfc.ToString();
                            txt_rfc_contribuyente.Text = i_contribuyente.rfc;
                            txt_nombre_contribuyente.Text = i_contribuyente.razon_social;
                            txt_telefono_contribuyente.Text = i_contribuyente.telefono;
                            txt_email_contribuyente.Text = i_contribuyente.email;
                            txt_callenum_contribuyente.Text = i_contribuyente.callenum;

                            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                            {
                                var i_sepomex = (from c in db_sepomex.inf_sepomex
                                                 where c.id_codigo == i_contribuyente.id_codigo
                                                 select c).ToList();

                                txt_cp_contribuyente.Text = i_sepomex[0].d_codigo;
                                txt_municipio_contribuyente.Text = i_sepomex[0].d_mnpio;
                                txt_estado_contribuyente.Text = i_sepomex[0].d_estado;

                                int_idcolonia = int.Parse(i_sepomex[0].id_asenta_cpcons.ToString());

                                using (db_hecsaEntities edm_colonia = new db_hecsaEntities())
                                {
                                    var i_colonia = (from c in db_sepomex.inf_sepomex
                                                     where c.id_codigo == i_contribuyente.id_codigo
                                                     select c).ToList();

                                    ddl_colonia_contribuyente.DataSource = i_colonia;
                                    ddl_colonia_contribuyente.DataTextField = "d_asenta";
                                    ddl_colonia_contribuyente.DataValueField = "id_asenta_cpcons";
                                    ddl_colonia_contribuyente.DataBind();
                                }
                            }

                            txt_nombres_ccontribuyente.Text = i_contribuyente.nombres;
                            txt_apaterno_ccontribuyente.Text = i_contribuyente.a_paterno;
                            txt_amaterno_ccontribuyente.Text = i_contribuyente.a_materno;

                            txt_telefono_ccontribuyente.Text = i_contribuyente.telefonoc;
                            txt_email_ccontribuyente.Text = i_contribuyente.emailc;
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }

        protected void gv_contribuyente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }

        protected void gv_contribuyente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void limpia_txt_contribuyente()
        {
            ddl_tiporfc_contribuyente.Items.Clear();
            ddl_colonia_contribuyente.Items.Clear();
            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc
                                   select c).ToList();

                ddl_tiporfc_contribuyente.DataSource = tbl_sepomex;
                ddl_tiporfc_contribuyente.DataTextField = "desc_tipo_rfc";
                ddl_tiporfc_contribuyente.DataValueField = "id_tipo_rfc";
                ddl_tiporfc_contribuyente.DataBind();
            }
            ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar", "0"));

            ddl_colonia_contribuyente.Items.Insert(0, new ListItem("Seleccionar", "0"));

            txt_rfc_contribuyente.Text = null;
            txt_nombre_contribuyente.Text = null;
            txt_telefono_contribuyente.Text = null;
            txt_email_contribuyente.Text = null;
            txt_callenum_contribuyente.Text = null;

            txt_cp_contribuyente.Text = null;
            txt_municipio_contribuyente.Text = null;
            txt_estado_contribuyente.Text = null;

            txt_nombres_ccontribuyente.Text = null;
            txt_apaterno_ccontribuyente.Text = null;
            txt_amaterno_ccontribuyente.Text = null;

            txt_telefono_ccontribuyente.Text = null;
            txt_email_ccontribuyente.Text = null;
        }

        protected void btn_cp_contribuyente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cp_contribuyente.Text))
            {
            }
            else
            {
                string str_codigo = txt_cp_contribuyente.Text;

                using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
                {
                    var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                       where c.d_codigo == str_codigo
                                       select c).ToList();

                    ddl_colonia_contribuyente.DataSource = tbl_sepomex;
                    ddl_colonia_contribuyente.DataTextField = "d_asenta";
                    ddl_colonia_contribuyente.DataValueField = "id_asenta_cpcons";
                    ddl_colonia_contribuyente.DataBind();

                    if (tbl_sepomex.Count == 1)
                    {
                        txt_municipio_contribuyente.Text = tbl_sepomex[0].d_mnpio;
                        txt_estado_contribuyente.Text = tbl_sepomex[0].d_estado;
                        rfv_colonia_contribuyente.Enabled = true;
                        rfv_nombres_ccontribuyente.Enabled = true;

                        txt_cp_contribuyente.Focus();
                    }
                    if (tbl_sepomex.Count > 1)
                    {
                        ddl_colonia_contribuyente.Items.Insert(0, new ListItem("Seleccionar", "0"));

                        txt_municipio_contribuyente.Text = tbl_sepomex[0].d_mnpio;
                        txt_estado_contribuyente.Text = tbl_sepomex[0].d_estado;
                        rfv_colonia_contribuyente.Enabled = true;
                        rfv_nombres_ccontribuyente.Enabled = true;

                        txt_cp_contribuyente.Focus();
                    }
                    else if (tbl_sepomex.Count == 0)
                    {
                        ddl_colonia_contribuyente.Items.Clear();
                        ddl_colonia_contribuyente.Items.Insert(0, new ListItem("Seleccionar", "0"));
                        txt_municipio_contribuyente.Text = null;
                        txt_estado_contribuyente.Text = null;
                        rfv_colonia_contribuyente.Enabled = false;
                        rfv_nombres_ccontribuyente.Enabled = false;

                        txt_cp_contribuyente.Focus();
                    }
                }
            }
        }

        protected void btn_guardar_contribuyente_Click(object sender, EventArgs e)
        {
            Guid guid_ncontribuyente, guid_contribuyente_c;
            int int_tiporfc, int_colonia, int_idcodigocp;
            string str_rfc, str_nombrecontribuyente, str_telefono, str_correo, str_callenum, str_cp, str_nombre_c, str_apeterno_c, str_amaterno_c, str_telefono_c, str_correo_c;

            guid_ncontribuyente = Guid.NewGuid();
            guid_contribuyente_c = Guid.NewGuid();
            int_tiporfc = int.Parse(ddl_tiporfc_contribuyente.SelectedValue);
            str_rfc = txt_rfc_contribuyente.Text.ToUpper();
            str_nombrecontribuyente = txt_nombre_contribuyente.Text.ToUpper();
            str_telefono = txt_telefono_contribuyente.Text;
            str_correo = txt_email_contribuyente.Text;
            str_callenum = txt_callenum_contribuyente.Text.ToUpper();
            str_cp = txt_cp_contribuyente.Text;
            int_colonia = int.Parse(ddl_colonia_contribuyente.SelectedValue);
            str_nombre_c = txt_nombres_ccontribuyente.Text.ToUpper();
            str_apeterno_c = txt_apaterno_ccontribuyente.Text.ToUpper();
            str_amaterno_c = txt_amaterno_ccontribuyente.Text.ToUpper();
            str_telefono_c = txt_telefono_contribuyente.Text;
            str_correo_c = txt_email_ccontribuyente.Text;

            using (db_hecsaEntities db_sepomex = new db_hecsaEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_cp
                                   where c.id_asenta_cpcons == int_colonia
                                   select c).ToList();

                int_idcodigocp = tbl_sepomex[0].id_codigo;
            }

            if (chkbox_agregar_c.Checked)
            {
                using (db_hecsaEntities edm_rfc = new db_hecsaEntities())
                {
                    var i_rfc = (from c in edm_rfc.inf_contribuyentes
                                 where c.rfc == str_rfc
                                 select c).ToList();

                    if (i_rfc.Count == 0)
                    {
                        using (db_hecsaEntities edm_rfcf = new db_hecsaEntities())
                        {
                            var i_rfcf = (from c in edm_rfcf.inf_contribuyentes
                                          select c).ToList();
                            using (var m_empresa = new db_hecsaEntities())
                            {
                                var i_empresa = new inf_contribuyentes

                                {
                                    id_contribuyente = guid_ncontribuyente,
                                    id_estatus = 1,
                                    id_tipo_rfc = int_tiporfc,
                                    rfc = str_rfc,
                                    razon_social = str_nombrecontribuyente,
                                    telefono = str_telefono,
                                    email = str_correo,
                                    callenum = str_callenum,
                                    id_codigo = int_idcodigocp,
                                    codigo_contribuyente = "clte_" + string.Format("{0:000}", i_rfcf.Count + 1),
                                    fecha_registro = DateTime.Now,
                                    id_empresa = guid_fnegocio
                                };

                                m_empresa.inf_contribuyentes.Add(i_empresa);
                                m_empresa.SaveChanges();
                            }

                            using (var m_usuario = new db_hecsaEntities())
                            {
                                var i_usuario = new inf_contacto_contribuyente
                                {
                                    id_contacto_contribuyente = guid_contribuyente_c,
                                    id_estatus = 1,
                                    nombres = str_nombre_c,
                                    a_paterno = str_apeterno_c,
                                    a_materno = str_amaterno_c,
                                    telefono = str_telefono_c,
                                    email = str_correo_c,
                                    fecha_registro = DateTime.Now,
                                    id_contribuyente = guid_ncontribuyente
                                };
                                m_usuario.inf_contacto_contribuyente.Add(i_usuario);
                                m_usuario.SaveChanges();
                            }

                            limpia_txt_contribuyente();
                            Mensaje("Datos de contribuyente y contribuyente agregados con éxito.");
                        }
                    }
                    else
                    {
                        Mensaje("RFC ya existe en la base de datos, favor de cambiarlo.");
                    }
                }
            }
            else if (chkbox_editar_c.Checked)
            {
            }
        }

        #endregion contribuyente

        #region usuarios

        public static string RemoveAccentsWithRegEx(string inputString)
        {
            Regex replace_a_Accents = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex replace_e_Accents = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex replace_i_Accents = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex replace_o_Accents = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex replace_u_Accents = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            inputString = replace_a_Accents.Replace(inputString, "a");
            inputString = replace_e_Accents.Replace(inputString, "e");
            inputString = replace_i_Accents.Replace(inputString, "i");
            inputString = replace_o_Accents.Replace(inputString, "o");
            inputString = replace_u_Accents.Replace(inputString, "u");
            return inputString;
        }

        public int filtro_usuario()
        {
            if (chkb_administrador.Checked)
            {
                int_tipousuario = 2;
                return 2;
            }
            else if (chkb_ejecutivo.Checked)
            {
                int_tipousuario = 3;
                return 3;
            }
            else if (chkb_invitado.Checked)
            {
                int_tipousuario = 4;
                return 3;
            }
            else
            {
                return 0;
            }
        }

        protected void btn_genera_usuario_Click(object sender, EventArgs e)
        {
            if (int_tipousuario == 0)
            {
                Mensaje("Favor de seleccionar perfil.");
            }
            else
            {
                genera_usuario();
            }
        }

        protected void btn_guardar_usuario_Click(object sender, EventArgs e)
        {
            if (int_accion_usuario == 0)
            {
                Mensaje("Favor de seleccionar un acción.");
            }
            else
            {
                if (filtro_usuario() == 0)
                {
                    Mensaje("Favor de seleccionar un perfil.");
                }
                else
                {
                    guarda_registro_usuario();
                }
            }
        }

        protected void chk_usuario_CheckedChanged(object sender, EventArgs e)
        {
            Guid id_fuser;
            foreach (GridViewRow row in gv_usuarios.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_usuario") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.FromArgb(224, 153, 123);
                        string codeuser = row.Cells[1].Text;

                        using (db_hecsaEntities data_user = new db_hecsaEntities())
                        {
                            var items_user = (from c in data_user.inf_usuarios
                                              where c.codigo_usuario == codeuser
                                              select c).FirstOrDefault();

                            id_fuser = items_user.id_usuario;
                        }

                        using (db_hecsaEntities data_user = new db_hecsaEntities())
                        {
                            var inf_user = (from u in data_user.inf_usuarios
                                            where u.id_usuario == id_fuser
                                            select new
                                            {
                                                u.nombres,
                                                u.a_paterno,
                                                u.a_materno,

                                                u.fecha_nacimiento,
                                                u.codigo_usuario,
                                                u.clave
                                            }).FirstOrDefault();

                            txt_nombres_usuario.Text = inf_user.nombres;
                            txt_apaterno_usuario.Text = inf_user.a_paterno;
                            txt_amaterno_usuario.Text = inf_user.a_materno;

                            txt_usuario_usuario.Text = inf_user.codigo_usuario;
                            txt_clave_usuario.Text = inf_user.clave;
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }

        protected void chkb_administrador_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_administrador.Checked == true)
            {
                rfv_nombres_usuario.Enabled = true;
                rfv_apaterno_usuario.Enabled = true;
                rfv_amaterno_usuario.Enabled = true;
                rfv_usuario_usuario.Enabled = true;
                rfv_clave_usuario.Enabled = true;

                chkb_ejecutivo.Checked = false;
                chkb_invitado.Checked = false;

                if (filtro_usuario() == 0)
                {
                    Mensaje("Favor de seleccionar un perfil.");
                }
                else
                {
                    if (int_accion_usuario == 2)
                    {
                        grid_usuarios(int_tipousuario);

                        ddl_perfil.Items.Clear();
                        using (db_hecsaEntities m_genero = new db_hecsaEntities())
                        {
                            var i_genero = (from f_tr in m_genero.fact_tipo_usuario
                                            where f_tr.id_tipo_usuario != 1
                                            where f_tr.id_tipo_usuario != 2
                                            select f_tr).ToList();

                            ddl_perfil.DataSource = i_genero;
                            ddl_perfil.DataTextField = "desc_tipo_usuario";
                            ddl_perfil.DataValueField = "id_tipo_usuario";
                            ddl_perfil.DataBind();
                        }
                        ddl_perfil.Items.Insert(0, new ListItem("SELECCIONAR", "0"));
                    }
                }
            }
            else
            {
                limpia_txt_usuarios();
            }
        }

        protected void chkb_ejecutivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_ejecutivo.Checked == true)
            {
                rfv_nombres_usuario.Enabled = true;
                rfv_apaterno_usuario.Enabled = true;
                rfv_amaterno_usuario.Enabled = true;
                rfv_usuario_usuario.Enabled = true;
                rfv_clave_usuario.Enabled = true;

                chkb_administrador.Checked = false;
                chkb_invitado.Checked = false;

                if (filtro_usuario() == 0)
                {
                    Mensaje("Favor de seleccionar perfil.");
                }
                else
                {
                    if (int_accion_usuario == 2)
                    {
                        grid_usuarios(int_tipousuario);
                        ddl_perfil.Items.Clear();
                        using (db_hecsaEntities m_genero = new db_hecsaEntities())
                        {
                            var i_genero = (from f_tr in m_genero.fact_tipo_usuario
                                            where f_tr.id_tipo_usuario != 1
                                            where f_tr.id_tipo_usuario != 3
                                            select f_tr).ToList();

                            ddl_perfil.DataSource = i_genero;
                            ddl_perfil.DataTextField = "desc_tipo_usuario";
                            ddl_perfil.DataValueField = "id_tipo_usuario";
                            ddl_perfil.DataBind();
                        }
                        ddl_perfil.Items.Insert(0, new ListItem("SELECCIONAR", "0"));
                    }
                }
            }
            else
            {
                limpia_txt_usuarios();
            }
        }

        protected void chkb_invitado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_invitado.Checked == true)
            {
                rfv_nombres_usuario.Enabled = true;
                rfv_apaterno_usuario.Enabled = true;
                rfv_amaterno_usuario.Enabled = true;
                rfv_usuario_usuario.Enabled = true;
                rfv_clave_usuario.Enabled = true;

                chkb_administrador.Checked = false;
                chkb_ejecutivo.Checked = false;

                if (filtro_usuario() == 0)
                {
                    Mensaje("Favor de seleccionar perfil.");
                }
                else
                {
                    if (int_accion_usuario == 2)
                    {
                        grid_usuarios(int_tipousuario);
                        ddl_perfil.Items.Clear();
                        using (db_hecsaEntities m_genero = new db_hecsaEntities())
                        {
                            var i_genero = (from f_tr in m_genero.fact_tipo_usuario
                                            where f_tr.id_tipo_usuario != 1
                                            where f_tr.id_tipo_usuario != 4
                                            select f_tr).ToList();

                            ddl_perfil.DataSource = i_genero;
                            ddl_perfil.DataTextField = "desc_tipo_usuario";
                            ddl_perfil.DataValueField = "id_tipo_usuario";
                            ddl_perfil.DataBind();
                        }
                        ddl_perfil.Items.Insert(0, new ListItem("SELECCIONAR", "0"));
                    }
                }
            }
            else
            {
                limpia_txt_usuarios();
            }
        }

        protected void chkbox_agregar_u_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_agregar_u.Checked)
            {
                int_accion_usuario = 1;

                limpia_txt_usuarios();

                chkbox_editar_u.Checked = false;

                gv_usuarios.Visible = false;

                ddl_perfil.Enabled = false;
                chkb_activar_usuario.Enabled = false;
            }
            else
            {
                int_accion_usuario = 0;
                chkbox_editar_u.Checked = false;

                rfv_nombres_usuario.Enabled = false;
                rfv_apaterno_usuario.Enabled = false;
                rfv_amaterno_usuario.Enabled = false;
                rfv_usuario_usuario.Enabled = false;
                rfv_clave_usuario.Enabled = false;
            }
        }

        protected void chkbox_editar_u_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_editar_u.Checked)
            {
                int_accion_usuario = 2;

                limpia_txt_usuarios();

                chkbox_agregar_u.Checked = false;

                gv_usuarios.Visible = false;
                ddl_perfil.Enabled = true;
                chkb_activar_usuario.Enabled = true;
            }
            else
            {
                int_accion_usuario = 0;
                chkbox_agregar_u.Checked = false;

                rfv_nombres_usuario.Enabled = false;
                rfv_apaterno_usuario.Enabled = false;
                rfv_amaterno_usuario.Enabled = false;
                rfv_usuario_usuario.Enabled = false;
                rfv_clave_usuario.Enabled = false;
            }
        }

        protected void gv_usuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_usuarios.PageIndex = e.NewPageIndex;
            grid_usuarios(int_tipousuario);
        }

        private void genera_usuario()
        {
            try
            {
                int nombres_count = txt_nombres_usuario.Text.Split(' ').Count();
                string str_nombres = RemoveSpecialCharacters(RemoveAccentsWithRegEx(txt_nombres_usuario.Text.ToLower()));
                string[] separados;

                separados = str_nombres.Split(" ".ToArray());
                int count = separados.Count();

                string str_apaterno = RemoveSpecialCharacters(RemoveAccentsWithRegEx(txt_apaterno_usuario.Text.ToLower()));
                string str_amaterno = RemoveSpecialCharacters(RemoveAccentsWithRegEx(txt_amaterno_usuario.Text.ToLower()));

                string codigo_usuario = str_nombres + "_" + left_right_mid.left(str_apaterno, 2) + left_right_mid.left(str_amaterno, 2);
                txt_usuario_usuario.Text = codigo_usuario;
            }
            catch
            {
                Mensaje("Se requiere minimo 2 letras por cada campo(nombre,apellido paterno, apellido materno) para generar el usuario.");
            }
        }

    

        private void grid_usuarios(int idtipousuario)
        {
            using (db_hecsaEntities data_user = new db_hecsaEntities())
            {
                var inf_user = (from i_u in data_user.inf_usuarios
                                join i_e in data_user.fact_estatus on i_u.id_estatus equals i_e.id_estatus
                                where i_u.id_tipo_usuario == idtipousuario
                                where i_u.id_usuario != guid_iduser

                                select new
                                {
                                    i_u.codigo_usuario,
                                    i_e.desc_estatus,

                                    i_u.nombres,
                                    i_u.a_paterno,
                                    i_u.a_materno,
                                    i_u.fecha_registro
                                }).ToList();

                gv_usuarios.DataSource = inf_user;
                gv_usuarios.DataBind();
                gv_usuarios.Visible = true;
            }
        }

        private void guarda_registro_usuario()
        {
            Guid guid_fusuario;
            Guid guid_nusuario = Guid.NewGuid();

            string str_nombres = txt_nombres_usuario.Text.ToUpper();
            string str_apaterno = txt_apaterno_usuario.Text.ToUpper();
            string str_amaterno = txt_amaterno_usuario.Text.ToUpper();

            string str_usuario = txt_usuario_usuario.Text;
            string str_password = encriptar.Encrypt(txt_clave_usuario.Text);

            if (int_accion_usuario == 1)
            {
                using (db_hecsaEntities data_user = new db_hecsaEntities())
                {
                    var items_user = (from c in data_user.inf_usuarios
                                      where c.codigo_usuario == str_usuario
                                      select c).ToList();

                    if (items_user.Count == 0)
                    {
                        using (var m_usuario = new db_hecsaEntities())
                        {
                            var i_usuario = new inf_usuarios
                            {
                                id_usuario = guid_nusuario,

                                id_estatus = 1,

                                id_tipo_usuario = int_tipousuario,
                                nombres = str_nombres,
                                a_paterno = str_apaterno,
                                a_materno = str_amaterno,
                                codigo_usuario = str_usuario,
                                clave = str_password,
                                fecha_registro = DateTime.Now,
                                id_empresa = guid_fnegocio
                            };
                            m_usuario.inf_usuarios.Add(i_usuario);
                            m_usuario.SaveChanges();
                        }

                        int_accion_usuario = 0;
                        limpia_txt_usuarios();

                        Mensaje("Datos agregados con éxito.");
                        lblModalTitle.Text = "HECSA";
                        lblModalBody.Text = "Datos de usuario agregados con éxito";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                        upModal.Update();
                    }
                    else
                    {
                        Mensaje("Usuario ya existe en la base de datos, favor de reintentar.");
                    }
                }
            }
            else if (int_accion_usuario == 2)
            {
                int int_perfil;

                if (ddl_perfil.SelectedValue == "0")
                {
                    using (db_hecsaEntities data_user = new db_hecsaEntities())
                    {
                        var items_user = (from c in data_user.inf_usuarios
                                          where c.codigo_usuario == str_usuario
                                          select c).ToList();

                        int_perfil = int.Parse(items_user[0].id_tipo_usuario.ToString());
                    }
                }
                else
                {
                    int_perfil = int.Parse(ddl_perfil.SelectedValue);
                }

                int int_activar;

                if (chkb_activar_usuario.Checked == true)
                {
                    int_activar = 3;
                }
                else
                {
                    int_activar = 1;
                }
                foreach (GridViewRow row in gv_usuarios.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkRow = (row.Cells[0].FindControl("chk_usuario") as CheckBox);
                        if (chkRow.Checked)
                        {
                            row.BackColor = Color.FromArgb(224, 153, 123);
                            string codeuser = row.Cells[1].Text;

                            if (codeuser == str_usuario)
                            {
                                using (db_hecsaEntities data_user = new db_hecsaEntities())
                                {
                                    var items_user = (from c in data_user.inf_usuarios
                                                      where c.codigo_usuario == codeuser
                                                      select c).FirstOrDefault();

                                    guid_fusuario = items_user.id_usuario;
                                }
                                using (var data_user = new db_hecsaEntities())
                                {
                                    var items_user = (from c in data_user.inf_usuarios
                                                      where c.id_usuario == guid_fusuario
                                                      select c).FirstOrDefault();

                                    items_user.id_estatus = int_activar;

                                    items_user.nombres = str_nombres;
                                    items_user.a_paterno = str_apaterno;
                                    items_user.a_materno = str_amaterno;

                                    items_user.id_tipo_usuario = int_perfil;
                                    items_user.codigo_usuario = str_usuario;
                                    items_user.clave = str_password;

                                    data_user.SaveChanges();
                                }

                                limpia_txt_usuarios();

                                Mensaje("Datos actualizados con éxito.");
                            }
                            else
                            {
                                using (db_hecsaEntities data_user = new db_hecsaEntities())
                                {
                                    var items_user = (from c in data_user.inf_usuarios
                                                      where c.codigo_usuario == str_usuario
                                                      select c).ToList();

                                    if (items_user.Count == 0)
                                    {
                                        using (db_hecsaEntities data_userf = new db_hecsaEntities())
                                        {
                                            var items_userf = (from c in data_userf.inf_usuarios
                                                               where c.codigo_usuario == codeuser
                                                               select c).FirstOrDefault();

                                            guid_fusuario = items_userf.id_usuario;
                                        }
                                        using (var data_userff = new db_hecsaEntities())
                                        {
                                            var items_userff = (from c in data_userff.inf_usuarios
                                                                where c.id_usuario == guid_fusuario
                                                                select c).FirstOrDefault();

                                            items_userff.nombres = str_nombres;
                                            items_userff.a_paterno = str_apaterno;
                                            items_userff.a_materno = str_amaterno;
                                            items_userff.id_tipo_usuario = int_tipousuario;
                                            items_userff.codigo_usuario = str_usuario;
                                            items_userff.clave = str_password;
                                            data_userff.SaveChanges();
                                        }

                                        limpia_txt_usuarios();

                                        Mensaje("Usuario ya existe en la base de datos, favor de reintentar.");
                                    }
                                    else
                                    {
                                        Mensaje("Datos agregados con éxito.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            row.BackColor = Color.White;
                        }
                    }
                }
            }
            else if (int_accion_usuario == 3)
            {
                foreach (GridViewRow row in gv_usuarios.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkRow = (row.Cells[0].FindControl("chk_usuario") as CheckBox);
                        if (chkRow.Checked)
                        {
                            row.BackColor = Color.FromArgb(224, 153, 123);
                            string codeuser = row.Cells[1].Text;

                            using (db_hecsaEntities data_user = new db_hecsaEntities())
                            {
                                var items_user = (from c in data_user.inf_usuarios
                                                  where c.codigo_usuario == codeuser
                                                  select c).FirstOrDefault();

                                guid_fusuario = items_user.id_usuario;
                            }
                            using (var data_user = new db_hecsaEntities())
                            {
                                var items_user = (from c in data_user.inf_usuarios
                                                  where c.id_usuario == guid_fusuario
                                                  select c).FirstOrDefault();

                                items_user.id_estatus = 3;

                                data_user.SaveChanges();
                            }
                            int_accion_usuario = 0;
                            limpia_txt_usuarios();

                            grid_usuarios(int_tipousuario);

                            Mensaje("Usuario dado de baja con éxito.");
                        }
                        else
                        {
                            row.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void limpia_txt_usuarios()
        {
            ddl_perfil.Items.Clear();
            using (db_hecsaEntities m_genero = new db_hecsaEntities())
            {
                var i_genero = (from f_tr in m_genero.fact_tipo_usuario
                                where f_tr.id_tipo_usuario != 1

                                select f_tr).ToList();

                ddl_perfil.DataSource = i_genero;
                ddl_perfil.DataTextField = "desc_tipo_usuario";
                ddl_perfil.DataValueField = "id_tipo_usuario";
                ddl_perfil.DataBind();
            }
            ddl_perfil.Items.Insert(0, new ListItem("SELECCIONAR", "0"));

            txt_nombres_usuario.Text = null;
            txt_apaterno_usuario.Text = null;
            txt_amaterno_usuario.Text = null;
            txt_usuario_usuario.Text = null;
            txt_clave_usuario.Text = null;

            gv_usuarios.Visible = false;

            chkb_administrador.Checked = false;

            chkb_ejecutivo.Checked = false;

            chkb_invitado.Checked = false;

            chkb_activar_usuario.Checked = false;
        }

        private string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, @"[^0-9A-Za-z]", "", RegexOptions.None);
        }

        #endregion usuarios

        private void Mensaje(string contenido)
        {
            lblModalTitle.Text = "HECSA";
            lblModalBody.Text = contenido;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
    }
}
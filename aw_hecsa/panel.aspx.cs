using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aw_hecsa
{
    public partial class panel : System.Web.UI.Page
    {
        private static Guid guid_iduser, guid_fnegocio;
        private static int int_idtipousuario, int_tipousuario, int_accion_usuario, int_accion_rubro, int_accion_gasto, int_accion_caja, int_accion_email_envio, int_accion_email_recepcion;

        #region panel

        protected void lkb_caja_Click(object sender, EventArgs e)
        {
            filtra_panel(5);
        }

        protected void lkb_correos_Click(object sender, EventArgs e)
        {
            filtra_panel(8);
        }

        protected void lkb_edita_usuariof_Click(object sender, EventArgs e)
        {
            filtra_panel(1);
        }

        protected void lkb_fnegocio_Click(object sender, EventArgs e)
        {
            filtra_panel(2);
        }

        protected void lkb_gastos_Click(object sender, EventArgs e)
        {
            filtra_panel(4);
        }

        protected void lkb_resumen_Click(object sender, EventArgs e)
        {
            filtra_panel(3);
        }

        protected void lkb_rubro_Click(object sender, EventArgs e)
        {
            filtra_panel(6);
        }

        protected void lkb_salir_Click(object sender, EventArgs e)
        {
            filtra_panel(9);
        }

        protected void lkb_usuarios_Click(object sender, EventArgs e)
        {
            filtra_panel(7);
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

                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";
                    i_salir.Attributes["style"] = "color:darkblue";

                    //default_rpt();
                    Mensaje("Construyendo");

                    break;

                case 4:
                    int_accion_gasto = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;

                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";
                    i_salir.Attributes["style"] = "color:darkblue";

                    break;

                case 5:
                    int_accion_caja = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;

                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";
                    i_salir.Attributes["style"] = "color:darkblue";

                    double dml_caja, dml_monto;

                    break;

                case 6:

                    int_accion_rubro = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;

                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";
                    i_salir.Attributes["style"] = "color:darkblue";

                    break;

                case 7:
                    int_accion_usuario = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;

                    pnl_usuarios.Visible = true;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";

                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:lightgray";
                    i_salir.Attributes["style"] = "color:darkblue";

                    limpia_txt_usuarios();

                    break;

                case 8:

                    int_accion_email_envio = 0;
                    int_accion_email_recepcion = 0;

                    pnl_usuariof.Visible = false;
                    pnl_fnegocio.Visible = false;

                    pnl_usuarios.Visible = false;

                    i_edita_usuariof.Attributes["style"] = "color:darkblue";
                    i_editafnegocio.Attributes["style"] = "color:darkblue";
                    i_resumen.Attributes["style"] = "color:darkblue";

                    i_usuarios.Attributes["style"] = "color:darkblue";

                    i_salir.Attributes["style"] = "color:darkblue";

                    break;

                case 9:

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
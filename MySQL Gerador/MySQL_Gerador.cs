using System;
using System.Windows.Forms;

namespace MySQL_Gerador
{
    public partial class Frm_MySQL_Gerador : Form
    {
        public Frm_MySQL_Gerador()
        {
            InitializeComponent();
        }

        public string Campo;
        public string Tipo;

        private void Btn_Gerar_Click(object sender, EventArgs e)
        {
            Txt_Insert_Campos.Text = string.Empty;
            Txt_Insert_Values.Text = string.Empty;
            Txt_Update.Text = string.Empty;
            Txt_Parametros.Text = string.Empty;
            Txt_Propriedades.Text = string.Empty;

            Campo = string.Empty;
            Tipo = string.Empty;
            int branco = 0;
            string tipo = string.Empty;

            if (Txt_Campos.TextLength > 0)
            {
                for (int i = 0; i < Txt_Campos.TextLength; i++)
                {
                    if (Txt_Campos.Text.Substring(i, 1) != "\n")
                    {
                        if (Txt_Campos.Text.Substring(i, 1) != " ")
                        {
                            if (branco == 0)
                            {
                                Campo += Txt_Campos.Text.Substring(i, 1);
                            }
                            else
                            {
                                tipo += Txt_Campos.Text.Substring(i, 1);

                                switch (tipo)
                                {
                                    case "varchar":
                                        Tipo = "string";
                                        break;
                                    case "decimal":
                                        Tipo = "decimal";
                                        break;
                                    case "int":
                                        Tipo = "int";
                                        break;
                                    case "datetime":
                                        Tipo = "DateTime";
                                        break;
                                    case "double":
                                        Tipo = "double";
                                        break;
                                    case "longblob":
                                        Tipo = "Image";
                                        break;
                                    case "mediumblob":
                                        Tipo = "Image";
                                        break;
                                }
                            }
                        }
                        else
                        {
                            branco++;
                            if (branco == 2)
                            {
                                Parametros();
                                Comandos();
                                Propriedades();
                                branco = 0;
                                tipo = string.Empty;
                                Campo = string.Empty;
                                Tipo = string.Empty;
                            }
                        }
                    }
                }
                Parametros();
                Finalizar_Comandos();
                Propriedades();
            }
        }

        private void Parametros()
        {
            string cp1 = "\"@" + Campo + "\"";
            string cp2 = Convert.ToString(char.ToUpper(Campo[0]) + Campo.Substring(1));
            string prm = "cl_Conexao.dbcom.Parameters.AddWithValue(" + cp1 + ", " + cp2 + ");";

            Txt_Parametros.Text += prm + "\n";
        }
        
        private void Comandos()
        {
            Txt_Insert_Campos.Text += Campo + ",";
            Txt_Insert_Values.Text += "@" + Campo + ",";

            Txt_Update.Text += Campo + "=@" + Campo + ",";
        }

        private void Finalizar_Comandos()
        {
            Txt_Insert_Campos.Text += Campo;
            Txt_Insert_Campos.Text = "(" + Txt_Insert_Campos.Text + ")";

            Txt_Insert_Values.Text += "@" + Campo;
            Txt_Insert_Values.Text = "VALUES(" + Txt_Insert_Values.Text + ")";

            Txt_Update.Text += Campo + "=@" + Campo;
        }

        private void Propriedades()
        {
            string cp = Convert.ToString(char.ToUpper(Campo[0]) + Campo.Substring(1));

            Txt_Propriedades.Text += "public " + Tipo + " " + cp + " { get; set; }\n";
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Campo = string.Empty;
            Tipo = string.Empty;

            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}

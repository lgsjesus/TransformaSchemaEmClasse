using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformaSchemaEmClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBD.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            executando();
        }
        void executando()
        {
            try
            {


                if (comboBD.SelectedIndex == 0)//oracle
                {
                    char duplaAspas = '"';
                    string schemaDDL = richtxtSchema.Text;
                    StringBuilder str = new StringBuilder();
                    schemaDDL = schemaDDL.Replace('"', ' ');

                    schemaDDL = schemaDDL.Replace('\n', ' ');
                    str.Append(@"using System;
                            using System.Collections.Generic;
                            using System.ComponentModel.DataAnnotations;
                            using System.ComponentModel.DataAnnotations.Schema;
                            using System.Linq;
                            using System.Web;

                            namespace 
                            {
                                [Table(" + duplaAspas);
                    string table = schemaDDL.Substring(13),
                        tableName = "", colunas = "";
                    int inicioLeitura = 0;
                    IList<Colunas> listaColunas = new List<Colunas>();

                    //EncontraNomeTabela
                    foreach (var c in table)
                    {
                        if (c == '.')
                        {

                            tableName = "";
                        }
                        else if (c == '(')
                        {
                            break;
                        }
                        else
                        {
                            tableName += c;

                        }
                        inicioLeitura++;
                    }
                    str.Append(tableName.Trim() + duplaAspas + ")]" + Environment.NewLine);
                    str.Append(@" public class " + tableName + " {" + Environment.NewLine);
                    table = schemaDDL.Trim().Substring(inicioLeitura + 13);

                    int leitura = 0;//0 - Nome,1 - Tipo, 2 - tamanho
                    Colunas coluna = new Colunas();
                    Boolean ignora = false;
                    foreach (var c in table)
                    {
                        if (c == ';')
                        {
                            break;
                        }
                        else if (c == ' ' && colunas.Trim().Length >= 2)
                        {
                            if (!colunas.Trim().ToUpper().Equals("NOT") && !colunas.Trim().ToUpper().Equals("NULL")
                                && !colunas.Trim().ToUpper().Equals("ENABLE")
                                )
                            {
                                if (leitura == 0)
                                {
                                    ignora = false;
                                    coluna = new Colunas();
                                    coluna.name = colunas;
                                    colunas = "";
                                    leitura = 1;
                                }

                                else if (leitura == 1)
                                {
                                    coluna.tipo = colunas;
                                    colunas = "";
                                    leitura = 2;
                                }
                                else if (leitura == 2)
                                    ignora = true;
                            }
                            else
                            {
                                
                                
                                    colunas = "";
                                
                            }
                        }
                        else if (c == '(')
                        {
                            if (leitura == 1)
                            {
                                coluna.tipo = colunas;
                                colunas = "";
                                leitura = 2;
                            }
                        }
                        else if (c == ')')
                        {
                            if (leitura == 2)
                            {
                                coluna.tamanho = colunas;
                                colunas = "";
                                leitura = 0;
                                listaColunas.Add(coluna);
                            }
                        }
                        else if (c == ',')
                        {
                            if (leitura == 1)
                            {
                                
                                coluna.tipo = colunas;
                                coluna.tamanho = "";
                                colunas = "";
                                leitura = 0;
                                listaColunas.Add(coluna);
                            }
                            else if (leitura == 2)
                            {
                                colunas = colunas + ",";
                            }
                        }

                        else
                        {
                            if(leitura==2 && !ignora)
                                colunas += c;
                            else
                                colunas += c;
                        }
                    }

                    // listaColunas = colunas.Split();


                    int ordem = 0;
                    string textoString = "", tipo = "";
                    foreach(Colunas col in listaColunas)
                    {
                        // str.Append(col.name + "--" + col.tipo + "--" + col.tamanho + Environment.NewLine);
                        textoString = "";
                        tipo = "";
                        tipo = converteTiposOracleCSharp(col.tipo);
                        if (tipo.Equals("string"))
                        {
                            textoString = ",StringLength("+col.tamanho+")";
                        }
                        str.Append("[Column(Order = " + ordem + ", TypeName = " + duplaAspas + 
                            col.tipo.Trim().ToUpper() + duplaAspas + ")"+ textoString.Trim()
                            +"]" + Environment.NewLine);

                        str.Append("public " + tipo + " "+ col.name + " { get; set; } " + Environment.NewLine);
                        ordem++;
                    }




                    richTxtResult.Text = str.ToString() + 
                        @"    
                        }
                    }";
                }
                else if (comboBD.SelectedIndex == 1) //Sql Server
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string converteTiposOracleCSharp(string campoOra)
        {
            string retorno = campoOra;
            switch (campoOra.ToUpper().Trim())
            {
                case "NUMBER":
                    retorno = "float";
                    break;
                case "DATE":
                    retorno = "DateTime";
                    break;
                case "VARCHAR2":
                    retorno = "string";
                    break;
                case "VARCHAR":
                    retorno = "string";
                    break;
                case "CHAR":
                    retorno = "char";
                    break;
            }

            return retorno;
        }
    }
}

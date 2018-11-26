using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_trab.Enumeradores;
using Teste_trab.VO;

namespace Teste_trab.DAO
{
    public static class Metodos
    {
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
                
            }
        }




        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    return tabela;
                }
            }
        }

        public static DataTable ExecutaProcResultSet(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlCommand cmd = new SqlCommand(procedure, cx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        return tabela;
                    }
                }
            }
        }



        public static void ExecutaProcedure(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(procedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }



        public static string ExecutaProcedureComRetorno(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(procedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);

                    comando.Parameters.Add("retorno", SqlDbType.VarChar);
                    comando.Parameters["retorno"].Direction = ParameterDirection.ReturnValue;
                    comando.ExecuteNonQuery();
                    return comando.Parameters["retorno"].Value.ToString();
                }
            }
        }




        /// <summary>
        /// método que testa se um determinado valor string contém um inteiro válido
        /// </summary>
        /// <param name="valor">valor string a ser testado</param>
        /// <returns>true se for inteiro ou false caso contrário </returns>
        public static bool ValidaInt(string valor)
        {
            try
            {
                Convert.ToInt32(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// método que testa se um determinado valor string contém um double válido
        /// </summary>
        /// <param name="valor">valor string a ser testado</param>
        /// <returns>true se for double ou false caso contrário </returns>
        public static bool ValidaDouble(string valor)
        {
            try
            {
                Convert.ToDouble(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }



        /// <summary>
        /// Exibe uma mensagem
        /// </summary>
        /// <param name="mensagem">Texto da mensagem</param>
        /// <param name="tipoDaMensagem">tipo da mensagem</param>
        /// <returns>Quando for mensagem de confirmação, returna true se o
        /// usuário clicar em sim e retorna False caso clique em não</returns>
        public static bool Mensagem(string mensagem, TipoMensagemEnum tipoDaMensagem)
        {
            if (tipoDaMensagem == TipoMensagemEnum.alerta)
            {
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return true;
            }
            else if (tipoDaMensagem == TipoMensagemEnum.erro)
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return true;
            }
            else if (tipoDaMensagem == TipoMensagemEnum.informacao)
            {
                MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
        }

    }
}

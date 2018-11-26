
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_trab.VO;

namespace Teste_trab.DAO
{
    public abstract class PadraoDAO
    {

        #region Métodos e Propriedades Abstratas       

        protected abstract string MontaSQLInsert();
        protected abstract string MontaSQLUpdate();
        protected abstract SqlParameter[] CriaParametros(PadraoVO o);
        protected abstract string MontaSQLProximoId();
        protected abstract string MontaSQLPrimeiro();
        protected abstract string MontaSQLUltimo();
        protected abstract string MontaSQLProximo();
        protected abstract string MontaSQLAnterior();
        protected abstract string MontaSQLDelete();
        protected abstract string MontaSQLConsulta();
        protected abstract string MontaSQLConsultaNome();

        protected abstract PadraoVO MontaVO(DataRow dr);

        #endregion

       

       


        /// <summary>
        /// Método  para inserir um registro no BD
        /// </summary>        
        public virtual void Inserir(PadraoVO o)
        {
            if (Consulta(o.Id) != null)
                throw new Exception("Este código já está sendo utilizado!");
            string sql = MontaSQLInsert();

            Metodos.ExecutaProcedure(sql, CriaParametros(o));
        }

               
        public virtual void Alterar(PadraoVO o)
        {
            string sql = MontaSQLUpdate();
            Metodos.ExecutaProcedure(sql, CriaParametros(o));
        }

             
        public virtual void Excluir(int Id)
        {
            string sql = MontaSQLDelete();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", Id);
            Metodos.ExecutaProcedure(sql, parametros);
        }

                
        public PadraoVO Consulta(int id)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                string sql = MontaSQLConsulta();
                SqlParameter[] parametros =
                {
                    new SqlParameter("@id", id)
                };

                DataTable tabela = Metodos.ExecutaProcResultSet(sql, parametros);

                if (tabela.Rows.Count == 0)
                    return null;
                else
                    return MontaVO(tabela.Rows[0]);

            }
        }


        /// <summary>
        /// Obtem o Proximo id disponível 
        /// </summary>
        /// <returns></returns>
        public virtual int ProximoId()
        {
         
            string sql = MontaSQLProximoId();
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                SqlCommand cmd = new SqlCommand(sql, cx);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        /// <summary>
        /// Primeiro registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Primeiro()
        {
            string sql = MontaSQLPrimeiro();
            return ExecutaSqlLocal(sql, null);
        }



        /// <summary>
        /// Ultimo registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Ultimo()
        {
            string sql = MontaSQLUltimo();
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ExecutaSqlLocal(sql, null);
        }

        /// <summary>
        /// Próximo registro
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Proximo(int atual)
        {
            string sql = MontaSQLProximo();
            SqlParameter[] p =
            {
                new SqlParameter("idAtual", atual)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet(sql, p);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }

        
        /// <summary>
        /// Registro anterior
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Anterior(int atual)
        {
            string sql = MontaSQLAnterior();
            SqlParameter[] p =
            {
                new SqlParameter("idAtual", atual)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet(sql, p);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }


        /// <summary>
        /// Executa uma instrução SQL
        /// </summary>
        /// <param name="sql">instrução</param>
        /// <param name="parametros">parametros</param>
        /// <returns>Objeto PadraoVO</returns>
        protected PadraoVO ExecutaSqlLocal(string sql, SqlParameter[] parametros)
        {
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }

    }
}

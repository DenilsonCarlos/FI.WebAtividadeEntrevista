using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiarios
    {
        public List<Beneficiarios> ListaBeneficiarios(int id)
        {
            DAL.DaoBeneficiarios ben = new DAL.DaoBeneficiarios();
            return ben.ListaBeneficiarios(id);
        }

        public bool VerificarExistencia(string cpf, int? idCliente)
        {
            DAL.DaoBeneficiarios ben = new DAL.DaoBeneficiarios();
            return ben.VerificarExistencia(cpf, idCliente);
        }
    }
}

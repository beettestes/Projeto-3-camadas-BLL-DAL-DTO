using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto_3_camadas_BLL_DAL_DTO.Code.BLL;
using Projeto_3_camadas_BLL_DAL_DTO.Code.DTO; 

namespace Projeto_3_camadas_BLL_DAL_DTO
{
    public partial class Medicamentos : Form
    {

        MedicamentoBLL medbll = new MedicamentoBLL();
        MedicamentoDTO meddto = new MedicamentoDTO();
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            meddto.medicamento = txtMedicamento.Text;
            meddto.composicao = txtComposicao.Text;
            
            medbll.Inserir(meddto);
            
            MessageBox.Show("Cadastrado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}

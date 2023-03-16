using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class F_horarios : Form
    {
        public F_horarios()
        {
            InitializeComponent();
        }

        private void F_horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT 
                    N_IDHORARIO AS 'ID',
                    T_DSHORARIO AS 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DSHORARIO
            ";

            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 150;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas=dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                        SELECT
                            *   
                        FROM
                            tb_horarios
                        WHERE
                            N_IDHORARIO=" + vid;
               dt=Banco.dql(vquery);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mst_horario.Text = dt.Rows[0].Field<string>("T_DSHORARIO");
               
            }
            
        }

        private void btn_novoHorario_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            mst_horario.Clear();
            mst_horario.Focus();

        }

        private void btn_salvarHorario_Click(object sender, EventArgs e)
        {
            string vquery = "";
            if (tb_id.Text == "")
            {
                 vquery = "INSERT INTO tb_horarios (T_DSHORARIO) VALUES ('" + mst_horario.Text + "')";
                Banco.dml(vquery);
            }
            else
            {
                vquery = "UPDATE tb_horarios SET T_DSHORARIO='"+mst_horario.Text+"'"+ "WHERE N_IDHORARIO="+tb_id.Text;
                Banco.dml(vquery);
            }
            vquery = @"
                SELECT 
                    N_IDHORARIO AS 'ID',
                    T_DSHORARIO AS 'Horário'
                FROM
                    tb_horarios 
                ORDER BY
                    T_DSHORARIO
            ";

            dgv_horarios.DataSource = Banco.dql(vquery);

        }

        private void btn_excluirHorario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_IDHORARIO='"+tb_id.Text+"'";
                Banco.dml(vquery);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
                 
            }
        }

        private void btn_fecharHorario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

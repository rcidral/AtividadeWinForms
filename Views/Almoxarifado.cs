using Models;
using Controllers;
using System.Windows.Forms;

namespace Views {
    public class Almoxarifado {
        
        public static void store()
        {
            Form form = new Form();
            form.Text = "Adicionar Almoxarifado";
            form.Width = 420;
            form.Height = 450;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            Label lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Width = 50;
            lblNome.Height = 30;
            lblNome.Location = new Point(25, 20);
            
            TextBox txtNome = new TextBox();
            txtNome.Width = 355;
            txtNome.Height = 30;
            txtNome.Location = new Point(25, 50);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Width = 65;
            btnSalvar.Height = 30;
            btnSalvar.Location = new Point(25, 300);
            btnSalvar.Click += (sender, e) => {
                Controllers.Almoxarifado.store(new Models.Almoxarifado(txtNome.Text));
                form.Close();
                form.Dispose();
                index();
            };

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Width = 65;
            btnCancelar.Height = 30;
            btnCancelar.Location = new Point(100, 300);
            btnCancelar.Click += (sender, e) => {
                form.Close();
                form.Dispose();
                index();
            };

            form.Controls.Add(lblNome);
            form.Controls.Add(txtNome);
            form.Controls.Add(btnSalvar);
            form.Controls.Add(btnCancelar);

            form.ShowDialog();
        }

        public static void index()
        {
            Form form = new Form();
            form.Text = "Almoxarifados";
            form.Width = 420;
            form.Height = 450;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            ListView listView = new ListView();
            listView.Width = 355;
            listView.Height = 250;
            listView.Location = new Point(25, 25);
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Nome", 150);

            foreach (Models.Almoxarifado almoxarifado in Controllers.Almoxarifado.index()) {
                ListViewItem item = new ListViewItem(almoxarifado.Id.ToString());
                item.SubItems.Add(almoxarifado.Nome);
                listView.Items.Add(item);
            }

            Button btnAdicionar = new Button();
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Width = 65;
            btnAdicionar.Height = 30;
            btnAdicionar.Location = new Point(25, 300);
            btnAdicionar.Click += (sender, e) => {
                Almoxarifado.store();
                form.Close();
                form.Dispose();
            };

            Button btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Width = 65;
            btnEditar.Height = 30;
            btnEditar.Location = new Point(117, 300);
            btnEditar.Click += (sender, e) => {
                string id = listView.SelectedItems[0].SubItems[0].Text;
                Almoxarifado.update(Int32.Parse(id));
                form.Close();
                form.Dispose();
            };

            Button btnExcluir = new Button();
            btnExcluir.Text = "Excluir";
            btnExcluir.Width = 65;
            btnExcluir.Height = 30;
            btnExcluir.Location = new Point(209, 300);
            btnExcluir.Click += (sender, e) => {
                string id = listView.SelectedItems[0].SubItems[0].Text;
                Almoxarifado.delete(Int32.Parse(id));
                form.Close();
                form.Dispose();
            };

            Button btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.Width = 65;
            btnVoltar.Height = 30;
            btnVoltar.Location = new Point(301, 300);
            btnVoltar.Click += (sender, e) => {
                form.Close();
                form.Dispose();
            };

            form.Controls.Add(listView);
            form.Controls.Add(btnAdicionar);
            form.Controls.Add(btnEditar);
            form.Controls.Add(btnExcluir);
            form.Controls.Add(btnVoltar);

            form.ShowDialog();
        }

        public static void update(int id)
        {
            Form form = new Form();
            form.Text = "Editar Almoxarifado";
            form.Width = 420;
            form.Height = 450;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            Label lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Width = 50;
            lblNome.Height = 30;
            lblNome.Location = new Point(25, 20);
            
            TextBox txtNome = new TextBox();
            txtNome.Width = 355;
            txtNome.Height = 30;
            txtNome.Location = new Point(25, 50);
            txtNome.Text = Controllers.Almoxarifado.show(id).Nome;

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Width = 65;
            btnSalvar.Height = 30;
            btnSalvar.Location = new Point(25, 300);
            btnSalvar.Click += (sender, e) => {
                Controllers.Almoxarifado.update(id, new Models.Almoxarifado(txtNome.Text));
                form.Close();
                form.Dispose();
                index();
            };

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Width = 65;
            btnCancelar.Height = 30;
            btnCancelar.Location = new Point(100, 300);
            btnCancelar.Click += (sender, e) => {
                form.Close();
                form.Dispose();
                index();
            };

            form.Controls.Add(lblNome);
            form.Controls.Add(txtNome);
            form.Controls.Add(btnSalvar);
            form.Controls.Add(btnCancelar);

            form.ShowDialog();
        }

        public static void delete(int id)
        {
            Form form = new Form();
            form.Text = "Excluir Almoxarifado";
            form.Width = 300;
            form.Height = 300;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            Label lblMensagem = new Label();
            lblMensagem.Text = "Deseja excluir o almoxarifado?";
            lblMensagem.Width = 150;
            lblMensagem.Height = 30;
            lblMensagem.Location = new Point(25, 20);

            Button btnSim = new Button();
            btnSim.Text = "Sim";
            btnSim.Width = 65;
            btnSim.Height = 30;
            btnSim.Location = new Point(25, 50);
            btnSim.Click += (sender, e) => {
                Controllers.Almoxarifado.delete(id);
                form.Close();
                form.Dispose();
                index();
            };

            Button btnNao = new Button();
            btnNao.Text = "Não";
            btnNao.Width = 65;
            btnNao.Height = 30;
            btnNao.Location = new Point(100, 50);
            btnNao.Click += (sender, e) => {
                form.Close();
                form.Dispose();
                index();
            };

            form.Controls.Add(lblMensagem);
            form.Controls.Add(btnSim);
            form.Controls.Add(btnNao);
            
            form.ShowDialog();
        }
    }
}
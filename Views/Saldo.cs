using Models;
using Controllers;
using System.Windows.Forms;

namespace Views {
    public class Saldo {
        
        public static void store()
        {
            Form form = new Form();
            form.Text = "Saldo";
            form.Width = 410;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            Label lblProduto = new Label();
            lblProduto.Text = "Produto";
            lblProduto.Width = 50;
            lblProduto.Height = 30;
            lblProduto.Location = new Point(25, 20);
            
            TextBox txtProduto = new TextBox();
            txtProduto.Width = 355;
            txtProduto.Height = 30;
            txtProduto.Location = new Point(25, 50);
            
            Label lblAlmoxarifado = new Label();
            lblAlmoxarifado.Text = "Almoxarifado";
            lblAlmoxarifado.Width = 50;
            lblAlmoxarifado.Height = 30;
            lblAlmoxarifado.Location = new Point(25, 80);

            TextBox txtAlmoxarifado = new TextBox();
            txtAlmoxarifado.Width = 355;
            txtAlmoxarifado.Height = 30;
            txtAlmoxarifado.Location = new Point(25, 110);

            Label lblQuantidade = new Label();
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.Width = 50;
            lblQuantidade.Height = 30;
            lblQuantidade.Location = new Point(25, 140);

            TextBox txtQuantidade = new TextBox();
            txtQuantidade.Width = 355;
            txtQuantidade.Height = 30;
            txtQuantidade.Location = new Point(25, 170);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Width = 65;
            btnSalvar.Height = 30;
            btnSalvar.Location = new Point(25, 300);
            btnSalvar.Click += (sender, e) => {
                Controllers.Saldo.store(new Models.Saldo(Int32.Parse(txtProduto.Text), Int32.Parse(txtAlmoxarifado.Text), Int32.Parse(txtQuantidade.Text)));
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

            form.Controls.Add(lblProduto);
            form.Controls.Add(txtProduto);
            form.Controls.Add(lblAlmoxarifado);
            form.Controls.Add(txtAlmoxarifado);
            form.Controls.Add(lblQuantidade);
            form.Controls.Add(txtQuantidade);
            form.Controls.Add(btnSalvar);
            form.Controls.Add(btnCancelar);

            form.ShowDialog();
        }

        public static void index()
        {
            Form form = new Form();
            form.Text = "Saldo";
            form.Width = 410;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            ListView list = new ListView();
            list.Width = 350;
            list.Height = 250;
            list.Location = new Point(25, 25);
            list.View = View.Details;
            list.GridLines = true;
            list.FullRowSelect = true;
            list.Columns.Add("ID", 50);
            list.Columns.Add("Produto", 100);
            list.Columns.Add("Almoxarifado", 100);
            list.Columns.Add("Quantidade", 100);
            
            foreach (Models.Saldo saldo in Controllers.Saldo.index())
            {
                ListViewItem item = new ListViewItem(saldo.Id.ToString());
                item.SubItems.Add(Controllers.Produto.show(saldo.ProdutoId).Nome);
                item.SubItems.Add(Controllers.Almoxarifado.show(saldo.AlmoxarifadoId).Nome);
                item.SubItems.Add(saldo.Quantidade.ToString());
                list.Items.Add(item);
            }

            Button btnAdicionar = new Button();
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Width = 65;
            btnAdicionar.Height = 30;
            btnAdicionar.Location = new Point(25, 300);
            btnAdicionar.Click += (sender, e) => {
                store();
                form.Close();
                form.Dispose();
            };

            Button btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Width = 65;
            btnEditar.Height = 30;
            btnEditar.Location = new Point(117, 300);
            btnEditar.Click += (sender, e) => {
                string id = list.SelectedItems[0].Text;
                update(Int32.Parse(id));
                form.Close();
                form.Dispose();
            };

            Button btnExcluir = new Button();
            btnExcluir.Text = "Excluir";
            btnExcluir.Width = 65;
            btnExcluir.Height = 30;
            btnExcluir.Location = new Point(209, 300);
            btnExcluir.Click += (sender, e) => {
                string id = list.SelectedItems[0].Text;
                delete(Int32.Parse(id));
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

            form.Controls.Add(list);
            form.Controls.Add(btnAdicionar);
            form.Controls.Add(btnEditar);
            form.Controls.Add(btnExcluir);
            form.Controls.Add(btnVoltar);

            form.ShowDialog();
        }

        public static void update(int id)
        {
            Form form = new Form();
            form.Text = "Saldo";
            form.Width = 410;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            Label lblProduto = new Label();
            lblProduto.Text = "Produto";
            lblProduto.Width = 50;
            lblProduto.Height = 30;
            lblProduto.Location = new Point(25, 20);

            TextBox txtProduto = new TextBox();
            txtProduto.Width = 355;
            txtProduto.Height = 30;
            txtProduto.Location = new Point(25, 50);
            txtProduto.Text = Controllers.Produto.show(Controllers.Saldo.show(id).ProdutoId).Nome;

            Label lblAlmoxarifado = new Label();
            lblAlmoxarifado.Text = "Almoxarifado";
            lblAlmoxarifado.Width = 50;
            lblAlmoxarifado.Height = 30;
            lblAlmoxarifado.Location = new Point(25, 80);

            TextBox txtAlmoxarifado = new TextBox();
            txtAlmoxarifado.Width = 355;
            txtAlmoxarifado.Height = 30;
            txtAlmoxarifado.Location = new Point(25, 110);
            txtAlmoxarifado.Text = Controllers.Almoxarifado.show(Controllers.Saldo.show(id).AlmoxarifadoId).Nome;

            Label lblQuantidade = new Label();
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.Width = 50;
            lblQuantidade.Height = 30;
            lblQuantidade.Location = new Point(25, 140);

            TextBox txtQuantidade = new TextBox();
            txtQuantidade.Width = 355;
            txtQuantidade.Height = 30;
            txtQuantidade.Location = new Point(25, 170);
            txtQuantidade.Text = Controllers.Saldo.show(id).Quantidade.ToString();

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Width = 65;
            btnSalvar.Height = 30;
            btnSalvar.Location = new Point(25, 300);
            btnSalvar.Click += (sender, e) => {
                Controllers.Saldo.update(id, new Models.Saldo(
                    Controllers.Produto.show(Controllers.Saldo.show(id).ProdutoId).Id,
                    Controllers.Almoxarifado.show(Controllers.Saldo.show(id).AlmoxarifadoId).Id,
                    Int32.Parse(txtQuantidade.Text)
                ));
                form.Close();
                form.Dispose();
                index();
            };

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Width = 65;
            btnCancelar.Height = 30;
            btnCancelar.Location = new Point(117, 300);
            btnCancelar.Click += (sender, e) => {
                form.Close();
                form.Dispose();
            };

            form.Controls.Add(lblProduto);
            form.Controls.Add(txtProduto);
            form.Controls.Add(lblAlmoxarifado);
            form.Controls.Add(txtAlmoxarifado);
            form.Controls.Add(lblQuantidade);
            form.Controls.Add(txtQuantidade);
            form.Controls.Add(btnSalvar);
            form.Controls.Add(btnCancelar);

            form.ShowDialog();
        }

        public static void delete(int id)
        {
            Form form = new Form();
            form.Text = "Excluir Saldo";
            form.Width = 300;
            form.Height = 300;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            Label lblMensagem = new Label();
            lblMensagem.Text = "Deseja excluir o saldo?";
            lblMensagem.Width = 150;
            lblMensagem.Height = 30;
            lblMensagem.Location = new Point(25, 20);

            Button btnSim = new Button();
            btnSim.Text = "Sim";
            btnSim.Width = 65;
            btnSim.Height = 30;
            btnSim.Location = new Point(25, 50);
            btnSim.Click += (sender, e) => {
                Controllers.Saldo.delete(id);
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
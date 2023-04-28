using Views;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "Menu";
            form.Width = 400;
            form.Height = 350;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            Button btnProduto = new Button();
            btnProduto.Text = "Produtos";
            btnProduto.Width = 200;
            btnProduto.Height = 30;
            btnProduto.Location = new Point(100, 50);
            btnProduto.Click += (sender, e) => {
                Produto.index();
            };

            Button btnAlmoxarifado = new Button();
            btnAlmoxarifado.Text = "Almoxarifado";
            btnAlmoxarifado.Width = 200;
            btnAlmoxarifado.Height = 30;
            btnAlmoxarifado.Location = new Point(100, 100);
            btnAlmoxarifado.Click += (sender, e) => {
                Almoxarifado.index();
            };

            Button btnSaldo = new Button();
            btnSaldo.Text = "Saldo";
            btnSaldo.Width = 200;
            btnSaldo.Height = 30;
            btnSaldo.Location = new Point(100, 150);
            btnSaldo.Click += (sender, e) => {
                Saldo.index();
            };

            Button btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Width = 200;
            btnSair.Height = 30;
            btnSair.Location = new Point(100, 200);
            btnSair.Click += (sender, e) => {
                form.Close();
            };

            form.Controls.Add(btnProduto);
            form.Controls.Add(btnAlmoxarifado);
            form.Controls.Add(btnSaldo);
            form.Controls.Add(btnSair);

            form.ShowDialog();
        }
    }
}
namespace teste;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    /// 
    public Random dado = new Random();
    public int roll;
    public string listaString;
    public List<string> historico = new List<string>();
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    private Button btnDquatro;
    private Button btnDseis;
    private Button btnDoito;
    private Button btnDdez;
    private Button btnDdoze;
    private Button btnDvinte;
    private Button btnDcem;
    private Button btnLimpar;
    private Button btnMinimizar;
    private Button btnFechar;
    private RichTextBox txtHistorico;

    private PictureBox fotoNormal;
    private PictureBox fotoFalha;
    private PictureBox fotoCrit;

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        //this.WindowState = FormWindowState.Maximized;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.ControlBox = false;
        this.ClientSize = new System.Drawing.Size(700, 500);
        Icon meuIcone = new Icon("C:/Users/arthur.filipus/OneDrive - NDD.Tech/Área de Trabalho/teste/Icone/dado-20-lados.ico");
        this.Icon = meuIcone;
        this.Text = "ROLADORdeDADO";

        btnDquatro = new Button();
        btnDquatro.Text = "D4";
        btnDquatro.Location = new Point(10, 10);
        btnDquatro.Size = new Size(80, 50);
        btnDquatro.Click += btnDquatro_Click;

        btnDseis = new Button();
        btnDseis.Text = "D6";
        btnDseis.Location = new Point(110, 10);
        btnDseis.Size = new Size(80, 50);
        btnDseis.Click += btnDseis_Click;

        btnDoito = new Button();
        btnDoito.Text = "D8";
        btnDoito.Location = new Point(210, 10);
        btnDoito.Size = new Size(80, 50);
        btnDoito.Click += btnDoito_Click;

        btnDdez = new Button();
        btnDdez.Text = "D10";
        btnDdez.Location = new Point(310, 10);
        btnDdez.Size = new Size(80, 50);
        btnDdez.Click += btnDdez_Click;

        btnDdoze = new Button();
        btnDdoze.Text = "D12";
        btnDdoze.Location = new Point(410, 10);
        btnDdoze.Size = new Size(80, 50);
        btnDdoze.Click += btnDdoze_Click;

        btnDvinte = new Button();
        btnDvinte.Text = "D20";
        btnDvinte.Location = new Point(510, 10);
        btnDvinte.Size = new Size(80, 50);
        btnDvinte.Click += btnDvinte_Click;

        btnDcem = new Button();
        btnDcem.Text = "D100";
        btnDcem.Location = new Point(610, 10);
        btnDcem.Size = new Size(80, 50);
        btnDcem.Click += btnDcem_Click;

        btnLimpar = new Button();
        btnLimpar.Text = "Limpar";
        btnLimpar.Location = new Point(610, 80);
        btnLimpar.Size = new Size(80, 50);
        btnLimpar.Click += btnLimpar_Click;

        btnMinimizar = new Button();
        btnMinimizar.Text = "Minimizar";
        btnMinimizar.Location = new Point(610, 370);
        btnMinimizar.Size = new Size(80, 50);
        btnMinimizar.Click += btnMinimizar_Click;

        btnFechar = new Button();
        btnFechar.Text = "Fechar";
        btnFechar.Location = new Point(610, 430);
        btnFechar.Size = new Size(80, 50);
        btnFechar.Click += btnFechar_Click;

        txtHistorico = new RichTextBox();
        txtHistorico.Location = new Point(10, 80);
        txtHistorico.Size = new Size(590, 400);
        txtHistorico.Multiline = true;
        txtHistorico.ScrollBars = RichTextBoxScrollBars.Vertical;
        txtHistorico.ReadOnly = true;

        fotoFalha = new PictureBox();
        fotoFalha.Size = new System.Drawing.Size(295, 390);
        fotoFalha.Location = new Point(300, 85);
        fotoFalha.SizeMode = PictureBoxSizeMode.StretchImage;
        fotoFalha.BorderStyle = BorderStyle.FixedSingle;
        fotoFalha.Image = Image.FromFile("C:/Users/arthur.filipus/OneDrive - NDD.Tech/Área de Trabalho/teste/Imagem/rebecca_falha.png");

        fotoCrit = new PictureBox();
        fotoCrit.Size = new System.Drawing.Size(295, 390);
        fotoCrit.Location = new Point(300, 85);
        fotoCrit.SizeMode = PictureBoxSizeMode.StretchImage;
        fotoCrit.BorderStyle = BorderStyle.FixedSingle;
        fotoCrit.Image = Image.FromFile("C:/Users/arthur.filipus/OneDrive - NDD.Tech/Área de Trabalho/teste/Imagem/rebecca_crit.png");

        fotoNormal = new PictureBox();
        fotoNormal.Size = new System.Drawing.Size(295, 390);
        fotoNormal.Location = new Point(300, 85);
        fotoNormal.SizeMode = PictureBoxSizeMode.StretchImage;
        fotoNormal.BorderStyle = BorderStyle.FixedSingle;
        fotoNormal.Image = Image.FromFile("C:/Users/arthur.filipus/OneDrive - NDD.Tech/Área de Trabalho/teste/Imagem/rebecca_normal.png");

        Controls.Add(fotoNormal);
        Controls.Add(fotoCrit);
        Controls.Add(fotoFalha);
        Controls.Add(btnDquatro);
        Controls.Add(btnDseis);
        Controls.Add(btnDoito);
        Controls.Add(btnDdez);
        Controls.Add(btnDdoze);
        Controls.Add(btnDvinte);
        Controls.Add(btnDcem);
        Controls.Add(btnLimpar);
        Controls.Add(btnMinimizar);
        Controls.Add(btnFechar);
        this.Controls.Add(txtHistorico);
    }
    private void btnDquatro_Click(object sender, EventArgs e)
    {
        roll = dado.Next(1, 5);
        
        int startPosition = txtHistorico.TextLength;

        if (roll == 4)
        {
            historico.Add($"D4 = {roll} CRÍTICO\n");
            txtHistorico.AppendText($"D4 = {roll} CRÍTICO\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D4 = {roll} CRÍTICO\n".Length;
            txtHistorico.SelectionColor = Color.Green;
            fotoCrit.BringToFront();
        }
        else if(roll == 1)
        {
            historico.Add($"D4 = {roll} FALHA CRÍTICA\n");
            txtHistorico.AppendText($"D4 = {roll} FALHA CRÍTICA\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D4 = {roll} FALHA CRÍTICA\n".Length;
            txtHistorico.SelectionColor = Color.Red;
            fotoFalha.BringToFront();
            
        }
        else 
        {
            historico.Add($"D4 = {roll}");
            txtHistorico.AppendText($"D4 = {roll}\n");
            fotoNormal.BringToFront();
            
        }
        txtHistorico.SelectionStart = txtHistorico.TextLength;
        txtHistorico.SelectionLength = 0;
        txtHistorico.SelectionColor = txtHistorico.ForeColor;
    }

    private void btnDseis_Click(object sender, EventArgs e)
    {
        roll = dado.Next(1, 7);

        int startPosition = txtHistorico.TextLength;

        if (roll == 6)
        {
            historico.Add($"D6 = {roll} CRÍTICO\n");
            txtHistorico.AppendText($"D6 = {roll} CRÍTICO\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D4 = {roll} CRÍTICO\n".Length;
            txtHistorico.SelectionColor = Color.Green;
            fotoCrit.BringToFront();
        }
        else if(roll == 1)
        {
            historico.Add($"D6 = {roll} FALHA CRÍTICA\n");
            txtHistorico.AppendText($"D6 = {roll} FALHA CRÍTICA\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D6 = {roll} FALHA CRÍTICA\n".Length;
            txtHistorico.SelectionColor = Color.Red;
            fotoFalha.BringToFront();
        }
        else 
        {
            historico.Add($"D6 = {roll}");
            txtHistorico.AppendText($"D6 = {roll}\n");
            fotoNormal.BringToFront();
        }
        txtHistorico.SelectionStart = txtHistorico.TextLength;
        txtHistorico.SelectionLength = 0;
        txtHistorico.SelectionColor = txtHistorico.ForeColor;
    }

    private void btnDoito_Click(object sender, EventArgs e)
    {
        roll = dado.Next(1, 9);

        int startPosition = txtHistorico.TextLength;

        if (roll == 8)
        {
            historico.Add($"D8 = {roll} CRÍTICO\n");
            txtHistorico.AppendText($"D8 = {roll} CRÍTICO\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D8 = {roll} CRÍTICO\n".Length;
            txtHistorico.SelectionColor = Color.Green;
            fotoCrit.BringToFront();
        }
        else if(roll == 1)
        {
            historico.Add($"D8 = {roll} FALHA CRÍTICA\n");
            txtHistorico.AppendText($"D8 = {roll} FALHA CRÍTICA\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D8 = {roll} FALHA CRÍTICA\n".Length;
            txtHistorico.SelectionColor = Color.Red;
            fotoFalha.BringToFront();
        }
        else 
        {
            historico.Add($"D8 = {roll}");
            txtHistorico.AppendText($"D8 = {roll}\n");
            fotoNormal.BringToFront();
        }
        txtHistorico.SelectionStart = txtHistorico.TextLength;
        txtHistorico.SelectionLength = 0;
        txtHistorico.SelectionColor = txtHistorico.ForeColor;
    }

    private void btnDdez_Click(object sender, EventArgs e)
    {
        roll = dado.Next(1, 11);

        
        int startPosition = txtHistorico.TextLength;

        if (roll == 10)
        {
            historico.Add($"D10 = {roll} CRÍTICO\n");
            txtHistorico.AppendText($"D10 = {roll} CRÍTICO\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D10 = {roll} CRÍTICO\n".Length;
            txtHistorico.SelectionColor = Color.Green;
            fotoCrit.BringToFront();
        }
        else if(roll == 1)
        {
            historico.Add($"D10 = {roll} FALHA CRÍTICA\n");
            txtHistorico.AppendText($"D10 = {roll} FALHA CRÍTICA\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D10 = {roll} FALHA CRÍTICA\n".Length;
            txtHistorico.SelectionColor = Color.Red;
            fotoFalha.BringToFront();
        }
        else 
        {
            historico.Add($"D10 = {roll}");
            txtHistorico.AppendText($"D10 = {roll}\n");
            fotoNormal.BringToFront();
        }
        txtHistorico.SelectionStart = txtHistorico.TextLength;
        txtHistorico.SelectionLength = 0;
        txtHistorico.SelectionColor = txtHistorico.ForeColor;
    }

    private void btnDdoze_Click(object sender, EventArgs e)
    {
        roll = dado.Next(1, 13);
        
        int startPosition = txtHistorico.TextLength;

        if (roll == 12)
        {
            historico.Add($"D12 = {roll} CRÍTICO\n");
            txtHistorico.AppendText($"D12 = {roll} CRÍTICO\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D12 = {roll} CRÍTICO\n".Length;
            txtHistorico.SelectionColor = Color.Green;
            fotoCrit.BringToFront();
        }
        else if(roll == 1)
        {
            historico.Add($"D12 = {roll} FALHA CRÍTICA\n");
            txtHistorico.AppendText($"D12 = {roll} FALHA CRÍTICA\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D12 = {roll} FALHA CRÍTICA\n".Length;
            txtHistorico.SelectionColor = Color.Red;
            fotoFalha.BringToFront();
        }
        else 
        {
            historico.Add($"D12 = {roll}");
            txtHistorico.AppendText($"D12 = {roll}\n");
            fotoNormal.BringToFront();
        }
        txtHistorico.SelectionStart = txtHistorico.TextLength;
        txtHistorico.SelectionLength = 0;
        txtHistorico.SelectionColor = txtHistorico.ForeColor;
    }

    private void btnDvinte_Click(object sender, EventArgs e)
    {
        roll = dado.Next(1, 21);
        
        int startPosition = txtHistorico.TextLength;

        if (roll == 20)
        {
            historico.Add($"D20 = {roll} CRÍTICO\n");
            txtHistorico.AppendText($"D20 = {roll} CRÍTICO\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D20 = {roll} CRÍTICO\n".Length;
            txtHistorico.SelectionColor = Color.Green;
            fotoCrit.BringToFront();
        }
        else if(roll == 1)
        {
            historico.Add($"D20 = {roll} FALHA CRÍTICA\n");
            txtHistorico.AppendText($"D20 = {roll} FALHA CRÍTICA\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D20 = {roll} FALHA CRÍTICA\n".Length;
            txtHistorico.SelectionColor = Color.Red;
            fotoFalha.BringToFront();
        }
        else 
        {
            historico.Add($"D20 = {roll}");
            txtHistorico.AppendText($"D20 = {roll}\n");
            fotoNormal.BringToFront();
        }
        txtHistorico.SelectionStart = txtHistorico.TextLength;
        txtHistorico.SelectionLength = 0;
        txtHistorico.SelectionColor = txtHistorico.ForeColor;
    }

    private void btnDcem_Click(object sender, EventArgs e)
    {
        roll = dado.Next(1, 101);
        
        int startPosition = txtHistorico.TextLength;

        if (roll == 100)
        {
            historico.Add($"D100 = {roll} CRÍTICO\n");
            txtHistorico.AppendText($"D100 = {roll} CRÍTICO\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D100 = {roll} CRÍTICO\n".Length;
            txtHistorico.SelectionColor = Color.Green;
            fotoCrit.BringToFront();
        }
        else if(roll == 1)
        {
            historico.Add($"D100 = {roll} FALHA CRÍTICA\n");
            txtHistorico.AppendText($"D100 = {roll} FALHA CRÍTICA\n");
            txtHistorico.SelectionStart = startPosition;
            txtHistorico.SelectionLength = $"D100 = {roll} FALHA CRÍTICA\n".Length;
            txtHistorico.SelectionColor = Color.Red;
            fotoFalha.BringToFront();
        }
        else 
        {
            historico.Add($"D100 = {roll}");
            txtHistorico.AppendText($"D100 = {roll}\n");
            fotoNormal.BringToFront();
        }
        txtHistorico.SelectionStart = txtHistorico.TextLength;
        txtHistorico.SelectionLength = 0;
        txtHistorico.SelectionColor = txtHistorico.ForeColor;
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        historico.Clear();
        listaString = string.Join(Environment.NewLine, historico);
        txtHistorico.Text = listaString;
    }
    private void btnMinimizar_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }
    private void btnFechar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    #endregion
}
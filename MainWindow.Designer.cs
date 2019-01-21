namespace TrabalhoFPI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNovaImagem = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelPronto = new System.Windows.Forms.Label();
            this.RadiusNUD = new System.Windows.Forms.NumericUpDown();
            this.Radius = new System.Windows.Forms.Label();
            this.Intensity = new System.Windows.Forms.Label();
            this.IntensityNUD = new System.Windows.Forms.NumericUpDown();
            this.buttonEffect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovaImagem
            // 
            this.buttonNovaImagem.Location = new System.Drawing.Point(59, 71);
            this.buttonNovaImagem.Name = "buttonNovaImagem";
            this.buttonNovaImagem.Size = new System.Drawing.Size(92, 35);
            this.buttonNovaImagem.TabIndex = 0;
            this.buttonNovaImagem.Text = "Nova Imagem";
            this.buttonNovaImagem.UseVisualStyleBackColor = true;
            this.buttonNovaImagem.Click += new System.EventHandler(this.buttonNovaImagem_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(59, 112);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(92, 35);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar Imagem";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // labelPronto
            // 
            this.labelPronto.AutoSize = true;
            this.labelPronto.ForeColor = System.Drawing.Color.Green;
            this.labelPronto.Location = new System.Drawing.Point(37, 346);
            this.labelPronto.Name = "labelPronto";
            this.labelPronto.Size = new System.Drawing.Size(168, 13);
            this.labelPronto.TabIndex = 9;
            this.labelPronto.Text = "Processo finalizado com Sucesso!";
            this.labelPronto.Visible = false;
            // 
            // RadiusNUD
            // 
            this.RadiusNUD.Location = new System.Drawing.Point(92, 177);
            this.RadiusNUD.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.RadiusNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RadiusNUD.Name = "RadiusNUD";
            this.RadiusNUD.Size = new System.Drawing.Size(59, 20);
            this.RadiusNUD.TabIndex = 18;
            this.RadiusNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(40, 179);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(46, 13);
            this.Radius.TabIndex = 19;
            this.Radius.Text = "Radius: ";
            // 
            // Intensity
            // 
            this.Intensity.AutoSize = true;
            this.Intensity.Location = new System.Drawing.Point(37, 205);
            this.Intensity.Name = "Intensity";
            this.Intensity.Size = new System.Drawing.Size(49, 13);
            this.Intensity.TabIndex = 21;
            this.Intensity.Text = "Intensity:";
            // 
            // IntensityNUD
            // 
            this.IntensityNUD.Location = new System.Drawing.Point(92, 203);
            this.IntensityNUD.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.IntensityNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntensityNUD.Name = "IntensityNUD";
            this.IntensityNUD.Size = new System.Drawing.Size(59, 20);
            this.IntensityNUD.TabIndex = 20;
            this.IntensityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonEffect
            // 
            this.buttonEffect.Location = new System.Drawing.Point(59, 268);
            this.buttonEffect.Name = "buttonEffect";
            this.buttonEffect.Size = new System.Drawing.Size(92, 35);
            this.buttonEffect.TabIndex = 22;
            this.buttonEffect.Text = "OilEffect";
            this.buttonEffect.UseVisualStyleBackColor = true;
            this.buttonEffect.Click += new System.EventHandler(this.buttonEffect_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 438);
            this.Controls.Add(this.buttonEffect);
            this.Controls.Add(this.Intensity);
            this.Controls.Add(this.IntensityNUD);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.RadiusNUD);
            this.Controls.Add(this.labelPronto);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonNovaImagem);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovaImagem;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelPronto;
        private System.Windows.Forms.NumericUpDown RadiusNUD;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label Intensity;
        private System.Windows.Forms.NumericUpDown IntensityNUD;
        private System.Windows.Forms.Button buttonEffect;
    }
}
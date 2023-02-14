namespace Conversos_de_graus
{
    partial class ConversorJanela
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorJanela));
            this.lblConversorGraus = new System.Windows.Forms.Label();
            this.lblDigitarTemperatura = new System.Windows.Forms.Label();
            this.txtTemperaturaOriginal = new System.Windows.Forms.TextBox();
            this.lblOqueSeráConvertido = new System.Windows.Forms.Label();
            this.cboEscolherConversão = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperaturaConvertida = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConversorGraus
            // 
            resources.ApplyResources(this.lblConversorGraus, "lblConversorGraus");
            this.lblConversorGraus.Name = "lblConversorGraus";
            // 
            // lblDigitarTemperatura
            // 
            resources.ApplyResources(this.lblDigitarTemperatura, "lblDigitarTemperatura");
            this.lblDigitarTemperatura.Name = "lblDigitarTemperatura";
            // 
            // txtTemperaturaOriginal
            // 
            resources.ApplyResources(this.txtTemperaturaOriginal, "txtTemperaturaOriginal");
            this.txtTemperaturaOriginal.Name = "txtTemperaturaOriginal";
            // 
            // lblOqueSeráConvertido
            // 
            resources.ApplyResources(this.lblOqueSeráConvertido, "lblOqueSeráConvertido");
            this.lblOqueSeráConvertido.Name = "lblOqueSeráConvertido";
            // 
            // cboEscolherConversão
            // 
            this.cboEscolherConversão.FormattingEnabled = true;
            this.cboEscolherConversão.Items.AddRange(new object[] {
            resources.GetString("cboEscolherConversão.Items"),
            resources.GetString("cboEscolherConversão.Items1")});
            resources.ApplyResources(this.cboEscolherConversão, "cboEscolherConversão");
            this.cboEscolherConversão.Name = "cboEscolherConversão";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtTemperaturaConvertida
            // 
            resources.ApplyResources(this.txtTemperaturaConvertida, "txtTemperaturaConvertida");
            this.txtTemperaturaConvertida.Name = "txtTemperaturaConvertida";
            // 
            // btnConverter
            // 
            resources.ApplyResources(this.btnConverter, "btnConverter");
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ConversorJanela
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtTemperaturaConvertida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEscolherConversão);
            this.Controls.Add(this.lblOqueSeráConvertido);
            this.Controls.Add(this.txtTemperaturaOriginal);
            this.Controls.Add(this.lblDigitarTemperatura);
            this.Controls.Add(this.lblConversorGraus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConversorJanela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblConversorGraus;
        private Label lblDigitarTemperatura;
        private TextBox txtTemperaturaOriginal;
        private Label lblOqueSeráConvertido;
        private ComboBox cboEscolherConversão;
        private Label label1;
        private TextBox txtTemperaturaConvertida;
        private Button btnConverter;
        private Button btnLimpar;
    }
}
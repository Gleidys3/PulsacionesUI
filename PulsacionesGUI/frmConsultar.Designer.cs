namespace PulsacionesGUI
{
    partial class frmConsultar
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
            this.DtgPersona = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CmbGneros = new System.Windows.Forms.ComboBox();
            this.btnConsultarIndividual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgConsultarIndi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarIndi)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPersona
            // 
            this.DtgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPersona.Location = new System.Drawing.Point(58, 26);
            this.DtgPersona.Name = "DtgPersona";
            this.DtgPersona.Size = new System.Drawing.Size(670, 126);
            this.DtgPersona.TabIndex = 0;
            this.DtgPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgConsultar_CellContentClick);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(693, 348);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 34);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CmbGneros
            // 
            this.CmbGneros.FormattingEnabled = true;
            this.CmbGneros.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CmbGneros.Location = new System.Drawing.Point(68, 361);
            this.CmbGneros.Name = "CmbGneros";
            this.CmbGneros.Size = new System.Drawing.Size(100, 21);
            this.CmbGneros.TabIndex = 2;
            // 
            // btnConsultarIndividual
            // 
            this.btnConsultarIndividual.Location = new System.Drawing.Point(228, 359);
            this.btnConsultarIndividual.Name = "btnConsultarIndividual";
            this.btnConsultarIndividual.Size = new System.Drawing.Size(118, 23);
            this.btnConsultarIndividual.TabIndex = 4;
            this.btnConsultarIndividual.Text = "Consulta Indivudual";
            this.btnConsultarIndividual.UseVisualStyleBackColor = true;
            this.btnConsultarIndividual.Click += new System.EventHandler(this.btnConsultarIndividual_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genero";
            // 
            // DtgConsultarIndi
            // 
            this.DtgConsultarIndi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsultarIndi.Location = new System.Drawing.Point(58, 168);
            this.DtgConsultarIndi.Name = "DtgConsultarIndi";
            this.DtgConsultarIndi.Size = new System.Drawing.Size(670, 150);
            this.DtgConsultarIndi.TabIndex = 7;
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgConsultarIndi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarIndividual);
            this.Controls.Add(this.CmbGneros);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DtgPersona);
            this.Name = "frmConsultar";
            this.Text = "fmrConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarIndi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPersona;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CmbGneros;
        private System.Windows.Forms.Button btnConsultarIndividual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DtgConsultarIndi;
    }
}
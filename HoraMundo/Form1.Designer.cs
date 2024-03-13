namespace HoraMundo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbFusosHorarios;
        private System.Windows.Forms.Label lblHoraUTC;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Hora Mundo";

            // ComboBox para os fusos horários
            this.cmbFusosHorarios = new System.Windows.Forms.ComboBox();
            this.cmbFusosHorarios.FormattingEnabled = true;
            this.cmbFusosHorarios.Location = new System.Drawing.Point(199, 123);
            this.cmbFusosHorarios.Name = "cmbFusosHorarios";
            this.cmbFusosHorarios.Size = new System.Drawing.Size(362, 28);
            this.cmbFusosHorarios.TabIndex = 0;
            this.cmbFusosHorarios.SelectedIndexChanged += new System.EventHandler(this.cmbFusosHorarios_SelectedIndexChanged);
            this.Controls.Add(this.cmbFusosHorarios);

            // Label para exibir a hora UTC
            this.lblHoraUTC = new System.Windows.Forms.Label();
            this.lblHoraUTC.AutoSize = true;
            this.lblHoraUTC.Location = new System.Drawing.Point(305, 9);
            this.lblHoraUTC.Name = "lblHoraUTC";
            this.lblHoraUTC.Size = new System.Drawing.Size(68, 20);
            this.lblHoraUTC.TabIndex = 1;
            this.lblHoraUTC.Text = "Hora UTC:";
            this.Controls.Add(this.lblHoraUTC);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

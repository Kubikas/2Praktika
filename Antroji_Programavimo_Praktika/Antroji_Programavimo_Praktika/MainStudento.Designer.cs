
namespace Antroji_Programavimo_Praktika
{
    partial class MainStudento
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
            this.dataGridViewPazimys = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPazimys55 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazimys)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPazimys
            // 
            this.dataGridViewPazimys.AllowUserToOrderColumns = true;
            this.dataGridViewPazimys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPazimys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPazimys.Location = new System.Drawing.Point(106, 122);
            this.dataGridViewPazimys.Name = "dataGridViewPazimys";
            this.dataGridViewPazimys.Size = new System.Drawing.Size(322, 397);
            this.dataGridViewPazimys.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(654, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Studentas";
            // 
            // textBoxPazimys55
            // 
            this.textBoxPazimys55.Location = new System.Drawing.Point(23, 15);
            this.textBoxPazimys55.Name = "textBoxPazimys55";
            this.textBoxPazimys55.ReadOnly = true;
            this.textBoxPazimys55.Size = new System.Drawing.Size(100, 20);
            this.textBoxPazimys55.TabIndex = 12;
            // 
            // MainStudento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 600);
            this.Controls.Add(this.textBoxPazimys55);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPazimys);
            this.Name = "MainStudento";
            this.Text = "MainStudento";
            this.Load += new System.EventHandler(this.MainStudento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazimys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPazimys;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxPazimys55;
    }
}
namespace Sprawdz_status
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCompHistory = new System.Windows.Forms.DataGridView();
            this.tbCompQr = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbOrderNoMes = new System.Windows.Forms.TextBox();
            this.dgvRw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompHistory)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbCompQr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 54);
            this.panel1.TabIndex = 0;
            // 
            // dgvCompHistory
            // 
            this.dgvCompHistory.AllowUserToAddRows = false;
            this.dgvCompHistory.AllowUserToDeleteRows = false;
            this.dgvCompHistory.AllowUserToResizeColumns = false;
            this.dgvCompHistory.AllowUserToResizeRows = false;
            this.dgvCompHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvCompHistory.Name = "dgvCompHistory";
            this.dgvCompHistory.ReadOnly = true;
            this.dgvCompHistory.RowHeadersVisible = false;
            this.dgvCompHistory.RowHeadersWidth = 51;
            this.dgvCompHistory.RowTemplate.Height = 24;
            this.dgvCompHistory.Size = new System.Drawing.Size(1017, 491);
            this.dgvCompHistory.TabIndex = 1;
            // 
            // tbCompQr
            // 
            this.tbCompQr.AcceptsReturn = true;
            this.tbCompQr.AcceptsTab = true;
            this.tbCompQr.Location = new System.Drawing.Point(85, 16);
            this.tbCompQr.Name = "tbCompQr";
            this.tbCompQr.Size = new System.Drawing.Size(288, 26);
            this.tbCompQr.TabIndex = 0;
            this.tbCompQr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 526);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvCompHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Komponent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgvRw);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Co na zleceniu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbOrderNoMes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 54);
            this.panel2.TabIndex = 2;
            // 
            // tbOrderNoMes
            // 
            this.tbOrderNoMes.Location = new System.Drawing.Point(148, 15);
            this.tbOrderNoMes.Name = "tbOrderNoMes";
            this.tbOrderNoMes.Size = new System.Drawing.Size(245, 26);
            this.tbOrderNoMes.TabIndex = 0;
            this.tbOrderNoMes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // dgvRw
            // 
            this.dgvRw.AllowUserToAddRows = false;
            this.dgvRw.AllowUserToDeleteRows = false;
            this.dgvRw.AllowUserToResizeColumns = false;
            this.dgvRw.AllowUserToResizeRows = false;
            this.dgvRw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRw.Location = new System.Drawing.Point(3, 3);
            this.dgvRw.Name = "dgvRw";
            this.dgvRw.ReadOnly = true;
            this.dgvRw.RowHeadersVisible = false;
            this.dgvRw.RowHeadersWidth = 51;
            this.dgvRw.RowTemplate.Height = 24;
            this.dgvRw.Size = new System.Drawing.Size(1017, 491);
            this.dgvRw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr zlecenia MES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kod QR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sprawdź status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompHistory)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCompQr;
        private System.Windows.Forms.DataGridView dgvCompHistory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbOrderNoMes;
        private System.Windows.Forms.DataGridView dgvRw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}



namespace HeChuyenGia
{
    partial class frThongTin
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
            this.siticoneLabel1 = new ns1.SiticoneLabel();
            this.siticoneMaterialTextBox1 = new ns1.SiticoneMaterialTextBox();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(151, 160);
            this.siticoneLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(89, 26);
            this.siticoneLabel1.TabIndex = 0;
            this.siticoneLabel1.Text = "Người làm";
            // 
            // siticoneMaterialTextBox1
            // 
            this.siticoneMaterialTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneMaterialTextBox1.DefaultText = "Sơn pro 123";
            this.siticoneMaterialTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.DisabledState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox1.FocusedState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox1.HoveredState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Location = new System.Drawing.Point(258, 150);
            this.siticoneMaterialTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneMaterialTextBox1.Name = "siticoneMaterialTextBox1";
            this.siticoneMaterialTextBox1.PasswordChar = '\0';
            this.siticoneMaterialTextBox1.PlaceholderForeColor = System.Drawing.Color.Red;
            this.siticoneMaterialTextBox1.PlaceholderText = "";
            this.siticoneMaterialTextBox1.SelectedText = "";
            this.siticoneMaterialTextBox1.ShadowDecoration.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Size = new System.Drawing.Size(200, 36);
            this.siticoneMaterialTextBox1.TabIndex = 1;
            // 
            // frThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.siticoneMaterialTextBox1);
            this.Controls.Add(this.siticoneLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frThongTin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.SiticoneLabel siticoneLabel1;
        private ns1.SiticoneMaterialTextBox siticoneMaterialTextBox1;
    }
}
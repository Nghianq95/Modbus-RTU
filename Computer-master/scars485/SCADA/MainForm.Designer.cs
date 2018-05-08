namespace SCADA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTenNhom = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(532, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(385, 54);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(217, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(576, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "TRUYỀN THÔNG VỚI MODBUS RTU ";
            // 
            // lbTenNhom
            // 
            this.lbTenNhom.AutoSize = true;
            this.lbTenNhom.BackColor = System.Drawing.Color.White;
            this.lbTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhom.ForeColor = System.Drawing.Color.Gold;
            this.lbTenNhom.Location = new System.Drawing.Point(12, 245);
            this.lbTenNhom.Name = "lbTenNhom";
            this.lbTenNhom.Size = new System.Drawing.Size(280, 232);
            this.lbTenNhom.TabIndex = 17;
            this.lbTenNhom.Text = "Môn học: SCADA\r\n\r\nGV: Trần Thái Anh Âu\r\n\r\nSinh Viên:\r\n      Nguyễn Văn Trường\r\n  " +
    "    Nguyễn Minh Hiếu\r\n      Nguyễn Quang Nghĩa";
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRequest.FlatAppearance.BorderSize = 10;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(532, 140);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(385, 54);
            this.btnRequest.TabIndex = 21;
            this.btnRequest.Text = "Đăng nhập";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 533);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lbTenNhom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Hello Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTenNhom;
        private System.Windows.Forms.Button btnRequest;

    }
}


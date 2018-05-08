namespace SCADA
{
    partial class RequestForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nHIETDOLabel;
            System.Windows.Forms.Label cOILabel;
            System.Windows.Forms.Label tHOITIETLabel;
            System.Windows.Forms.Label dENLabel;
            System.Windows.Forms.Label nGAYLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbbPortName = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.ptcWeather = new System.Windows.Forms.PictureBox();
            this.ptcLed = new System.Windows.Forms.PictureBox();
            this.ptcBuzzer = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.database1DataSet1 = new SCADA.Database1DataSet1();
            this.scadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scadaTableAdapter = new SCADA.Database1DataSet1TableAdapters.ScadaTableAdapter();
            this.tableAdapterManager = new SCADA.Database1DataSet1TableAdapters.TableAdapterManager();
            this.nHIETDOTextBox = new System.Windows.Forms.TextBox();
            this.cOITextBox = new System.Windows.Forms.TextBox();
            this.tHOITIETTextBox = new System.Windows.Forms.TextBox();
            this.dENTextBox = new System.Windows.Forms.TextBox();
            this.nGAYTextBox = new System.Windows.Forms.TextBox();
            this.scadaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            nHIETDOLabel = new System.Windows.Forms.Label();
            cOILabel = new System.Windows.Forms.Label();
            tHOITIETLabel = new System.Windows.Forms.Label();
            dENLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBuzzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nHIETDOLabel
            // 
            nHIETDOLabel.AutoSize = true;
            nHIETDOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nHIETDOLabel.Location = new System.Drawing.Point(143, 294);
            nHIETDOLabel.Name = "nHIETDOLabel";
            nHIETDOLabel.Size = new System.Drawing.Size(80, 16);
            nHIETDOLabel.TabIndex = 17;
            nHIETDOLabel.Text = "NHIETDO:";
            // 
            // cOILabel
            // 
            cOILabel.AutoSize = true;
            cOILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            cOILabel.Location = new System.Drawing.Point(143, 323);
            cOILabel.Name = "cOILabel";
            cOILabel.Size = new System.Drawing.Size(37, 16);
            cOILabel.TabIndex = 19;
            cOILabel.Text = "COI:";
            // 
            // tHOITIETLabel
            // 
            tHOITIETLabel.AutoSize = true;
            tHOITIETLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tHOITIETLabel.Location = new System.Drawing.Point(143, 349);
            tHOITIETLabel.Name = "tHOITIETLabel";
            tHOITIETLabel.Size = new System.Drawing.Size(82, 16);
            tHOITIETLabel.TabIndex = 21;
            tHOITIETLabel.Text = "THOITIET:";
            // 
            // dENLabel
            // 
            dENLabel.AutoSize = true;
            dENLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dENLabel.Location = new System.Drawing.Point(143, 375);
            dENLabel.Name = "dENLabel";
            dENLabel.Size = new System.Drawing.Size(44, 16);
            dENLabel.TabIndex = 23;
            dENLabel.Text = "DEN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYLabel.Location = new System.Drawing.Point(143, 401);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(54, 16);
            nGAYLabel.TabIndex = 25;
            nGAYLabel.Text = "NGAY:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbbPortName);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.ForeColor = System.Drawing.Color.Gold;
            this.btnConnect.Location = new System.Drawing.Point(40, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 47);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbbPortName
            // 
            this.cbbPortName.FormattingEnabled = true;
            this.cbbPortName.Location = new System.Drawing.Point(85, 23);
            this.cbbPortName.Name = "cbbPortName";
            this.cbbPortName.Size = new System.Drawing.Size(76, 21);
            this.cbbPortName.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(19, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 13);
            this.label.TabIndex = 0;
            this.label.Text = "PORT";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(102, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.ForeColor = System.Drawing.Color.Gold;
            this.btnStop.Location = new System.Drawing.Point(12, 207);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 45);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ptcWeather
            // 
            this.ptcWeather.Location = new System.Drawing.Point(217, 5);
            this.ptcWeather.Name = "ptcWeather";
            this.ptcWeather.Size = new System.Drawing.Size(206, 150);
            this.ptcWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcWeather.TabIndex = 11;
            this.ptcWeather.TabStop = false;
            // 
            // ptcLed
            // 
            this.ptcLed.Location = new System.Drawing.Point(565, 5);
            this.ptcLed.Name = "ptcLed";
            this.ptcLed.Size = new System.Drawing.Size(199, 150);
            this.ptcLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcLed.TabIndex = 12;
            this.ptcLed.TabStop = false;
            // 
            // ptcBuzzer
            // 
            this.ptcBuzzer.Location = new System.Drawing.Point(429, 5);
            this.ptcBuzzer.Name = "ptcBuzzer";
            this.ptcBuzzer.Size = new System.Drawing.Size(130, 150);
            this.ptcBuzzer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcBuzzer.TabIndex = 15;
            this.ptcBuzzer.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 4000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scadaBindingSource
            // 
            this.scadaBindingSource.DataMember = "Scada";
            this.scadaBindingSource.DataSource = this.database1DataSet1;
            // 
            // scadaTableAdapter
            // 
            this.scadaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScadaTableAdapter = this.scadaTableAdapter;
            this.tableAdapterManager.UpdateOrder = SCADA.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHIETDOTextBox
            // 
            this.nHIETDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scadaBindingSource, "NHIETDO", true));
            this.nHIETDOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nHIETDOTextBox.Location = new System.Drawing.Point(229, 294);
            this.nHIETDOTextBox.Name = "nHIETDOTextBox";
            this.nHIETDOTextBox.Size = new System.Drawing.Size(101, 20);
            this.nHIETDOTextBox.TabIndex = 18;
            // 
            // cOITextBox
            // 
            this.cOITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scadaBindingSource, "COI", true));
            this.cOITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cOITextBox.Location = new System.Drawing.Point(229, 320);
            this.cOITextBox.Name = "cOITextBox";
            this.cOITextBox.Size = new System.Drawing.Size(101, 20);
            this.cOITextBox.TabIndex = 20;
            // 
            // tHOITIETTextBox
            // 
            this.tHOITIETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scadaBindingSource, "THOITIET", true));
            this.tHOITIETTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tHOITIETTextBox.Location = new System.Drawing.Point(229, 346);
            this.tHOITIETTextBox.Name = "tHOITIETTextBox";
            this.tHOITIETTextBox.Size = new System.Drawing.Size(101, 20);
            this.tHOITIETTextBox.TabIndex = 22;
            // 
            // dENTextBox
            // 
            this.dENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scadaBindingSource, "DEN", true));
            this.dENTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dENTextBox.Location = new System.Drawing.Point(229, 372);
            this.dENTextBox.Name = "dENTextBox";
            this.dENTextBox.Size = new System.Drawing.Size(101, 20);
            this.dENTextBox.TabIndex = 24;
            // 
            // nGAYTextBox
            // 
            this.nGAYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scadaBindingSource, "NGAY", true));
            this.nGAYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nGAYTextBox.Location = new System.Drawing.Point(229, 398);
            this.nGAYTextBox.Name = "nGAYTextBox";
            this.nGAYTextBox.Size = new System.Drawing.Size(101, 20);
            this.nGAYTextBox.TabIndex = 26;
            // 
            // scadaDataGridView
            // 
            this.scadaDataGridView.AutoGenerateColumns = false;
            this.scadaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scadaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scadaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.scadaDataGridView.DataSource = this.scadaBindingSource;
            this.scadaDataGridView.Location = new System.Drawing.Point(336, 223);
            this.scadaDataGridView.Name = "scadaDataGridView";
            this.scadaDataGridView.Size = new System.Drawing.Size(595, 250);
            this.scadaDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NHIETDO";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "NHIETDO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COI";
            this.dataGridViewTextBoxColumn2.HeaderText = "COI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "THOITIET";
            this.dataGridViewTextBoxColumn3.HeaderText = "THOITIET";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DEN";
            this.dataGridViewTextBoxColumn4.HeaderText = "DEN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAY";
            this.dataGridViewTextBoxColumn5.HeaderText = "NGAY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(431, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "NGAY";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(506, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(664, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(824, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = " ";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(952, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scadaDataGridView);
            this.Controls.Add(nHIETDOLabel);
            this.Controls.Add(this.nHIETDOTextBox);
            this.Controls.Add(cOILabel);
            this.Controls.Add(this.cOITextBox);
            this.Controls.Add(tHOITIETLabel);
            this.Controls.Add(this.tHOITIETTextBox);
            this.Controls.Add(dENLabel);
            this.Controls.Add(this.dENTextBox);
            this.Controls.Add(nGAYLabel);
            this.Controls.Add(this.nGAYTextBox);
            this.Controls.Add(this.ptcBuzzer);
            this.Controls.Add(this.ptcLed);
            this.Controls.Add(this.ptcWeather);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBuzzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbbPortName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox ptcWeather;
        private System.Windows.Forms.PictureBox ptcLed;
        private System.Windows.Forms.PictureBox ptcBuzzer;
        private System.Windows.Forms.Timer timer2;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource scadaBindingSource;
        private Database1DataSet1TableAdapters.ScadaTableAdapter scadaTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nHIETDOTextBox;
        private System.Windows.Forms.TextBox cOITextBox;
        private System.Windows.Forms.TextBox tHOITIETTextBox;
        private System.Windows.Forms.TextBox dENTextBox;
        private System.Windows.Forms.TextBox nGAYTextBox;
        private System.Windows.Forms.DataGridView scadaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;

    }
}
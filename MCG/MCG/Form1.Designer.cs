namespace VIN2Chassis_Converter
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.carInfo = new System.Windows.Forms.DataGridView();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chassis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // yearBox
            // 
            this.yearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.yearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987"});
            this.yearBox.Location = new System.Drawing.Point(15, 12);
            this.yearBox.MaxDropDownItems = 5;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(140, 21);
            this.yearBox.TabIndex = 0;
            this.yearBox.SelectedIndexChanged += new System.EventHandler(this.yearBox_SelectedIndexChanged);
            this.yearBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yearBox_KeyDown);
            // 
            // modelBox
            // 
            this.modelBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.modelBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(161, 12);
            this.modelBox.MaxDropDownItems = 5;
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(140, 21);
            this.modelBox.TabIndex = 1;
            this.modelBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modelBox_KeyDown);
            // 
            // carInfo
            // 
            this.carInfo.AllowUserToAddRows = false;
            this.carInfo.AllowUserToDeleteRows = false;
            this.carInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Car,
            this.Chassis,
            this.Engine,
            this.Transmission});
            this.carInfo.Location = new System.Drawing.Point(12, 41);
            this.carInfo.Name = "carInfo";
            this.carInfo.ReadOnly = true;
            this.carInfo.Size = new System.Drawing.Size(495, 134);
            this.carInfo.TabIndex = 2;
            this.carInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carInfo_RowHeaderMouseClick);
            // 
            // Car
            // 
            this.Car.HeaderText = "Car";
            this.Car.Name = "Car";
            this.Car.ReadOnly = true;
            this.Car.Width = 150;
            // 
            // Chassis
            // 
            this.Chassis.HeaderText = "Chassis";
            this.Chassis.Name = "Chassis";
            this.Chassis.ReadOnly = true;
            // 
            // Engine
            // 
            this.Engine.HeaderText = "Engine";
            this.Engine.Name = "Engine";
            this.Engine.ReadOnly = true;
            // 
            // Transmission
            // 
            this.Transmission.HeaderText = "Transmission";
            this.Transmission.Name = "Transmission";
            this.Transmission.ReadOnly = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(408, 10);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(95, 23);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(307, 10);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(95, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(373, 178);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(134, 13);
            this.creditLabel.TabIndex = 5;
            this.creditLabel.Text = "Created by: Anthony Cantu";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 178);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 196);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.carInfo);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.yearBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Mercedes-Benz Chassis Grab";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.carInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chassis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Engine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        public System.Windows.Forms.ComboBox yearBox;
        public System.Windows.Forms.ComboBox modelBox;
        public System.Windows.Forms.DataGridView carInfo;
        public System.Windows.Forms.Button submitBtn;
        public System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}


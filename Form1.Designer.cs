namespace EquipmentCalculator
{
    partial class Form1
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
            lblELenght = new Label();
            lblEAmouth = new Label();
            txtELenght = new TextBox();
            nudEAmouth = new NumericUpDown();
            btnSave = new Button();
            dgwEquipments = new DataGridView();
            dgwCalculateResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudEAmouth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwEquipments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwCalculateResults).BeginInit();
            SuspendLayout();
            // 
            // lblELenght
            // 
            lblELenght.AutoSize = true;
            lblELenght.Location = new Point(53, 65);
            lblELenght.Name = "lblELenght";
            lblELenght.Size = new Size(120, 20);
            lblELenght.TabIndex = 0;
            lblELenght.Text = "Donatı Uzunluğu";
            // 
            // lblEAmouth
            // 
            lblEAmouth.AutoSize = true;
            lblEAmouth.Location = new Point(69, 111);
            lblEAmouth.Name = "lblEAmouth";
            lblEAmouth.Size = new Size(104, 20);
            lblEAmouth.TabIndex = 1;
            lblEAmouth.Text = "Donatı Miktarı";
            // 
            // txtELenght
            // 
            txtELenght.Location = new Point(179, 62);
            txtELenght.Name = "txtELenght";
            txtELenght.Size = new Size(125, 27);
            txtELenght.TabIndex = 2;
            // 
            // nudEAmouth
            // 
            nudEAmouth.Location = new Point(211, 109);
            nudEAmouth.Name = "nudEAmouth";
            nudEAmouth.Size = new Size(53, 27);
            nudEAmouth.TabIndex = 5;
            nudEAmouth.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(132, 171);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgwEquipments
            // 
            dgwEquipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEquipments.Location = new Point(431, 42);
            dgwEquipments.Name = "dgwEquipments";
            dgwEquipments.RowHeadersWidth = 51;
            dgwEquipments.Size = new Size(452, 158);
            dgwEquipments.TabIndex = 7;
            dgwEquipments.CellDoubleClick += dgwEquipments_CellDoubleClick;
            // 
            // dgwCalculateResults
            // 
            dgwCalculateResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCalculateResults.Location = new Point(431, 247);
            dgwCalculateResults.Name = "dgwCalculateResults";
            dgwCalculateResults.RowHeadersWidth = 51;
            dgwCalculateResults.Size = new Size(452, 158);
            dgwCalculateResults.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 574);
            Controls.Add(dgwCalculateResults);
            Controls.Add(dgwEquipments);
            Controls.Add(btnSave);
            Controls.Add(nudEAmouth);
            Controls.Add(txtELenght);
            Controls.Add(lblEAmouth);
            Controls.Add(lblELenght);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudEAmouth).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwEquipments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwCalculateResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblELenght;
        private Label lblEAmouth;
        private TextBox txtELenght;
        private NumericUpDown nudEAmouth;
        private Button btnSave;
        private DataGridView dgwEquipments;
        private DataGridView dgwCalculateResults;
    }
}

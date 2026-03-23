namespace Task1
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
            this.lblFloor = new System.Windows.Forms.Label();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.lblElevator = new System.Windows.Forms.Label();
            this.cmbElevator = new System.Windows.Forms.ComboBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.numHourlyRate = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(57, 58);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(84, 13);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "Номер поверху";
            // 
            // numFloor
            // 
            this.numFloor.Location = new System.Drawing.Point(210, 51);
            this.numFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(120, 20);
            this.numFloor.TabIndex = 1;
            this.numFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblElevator
            // 
            this.lblElevator.AutoSize = true;
            this.lblElevator.Location = new System.Drawing.Point(57, 95);
            this.lblElevator.Name = "lblElevator";
            this.lblElevator.Size = new System.Drawing.Size(90, 13);
            this.lblElevator.TabIndex = 2;
            this.lblElevator.Text = "Наявність ліфту ";
            // 
            // cmbElevator
            // 
            this.cmbElevator.FormattingEnabled = true;
            this.cmbElevator.Items.AddRange(new object[] {
            "Відстутній ",
            "Звичайний ",
            "Вантажний"});
            this.cmbElevator.Location = new System.Drawing.Point(209, 92);
            this.cmbElevator.Name = "cmbElevator";
            this.cmbElevator.Size = new System.Drawing.Size(121, 21);
            this.cmbElevator.TabIndex = 3;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(57, 136);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(135, 13);
            this.lblHourlyRate.TabIndex = 4;
            this.lblHourlyRate.Text = "Вартість 1 години роботи";
            // 
            // numHourlyRate
            // 
            this.numHourlyRate.Location = new System.Drawing.Point(210, 129);
            this.numHourlyRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHourlyRate.Name = "numHourlyRate";
            this.numHourlyRate.Size = new System.Drawing.Size(120, 20);
            this.numHourlyRate.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(392, 78);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 47);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Розрахувати вартість";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(57, 197);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Вартість: 0 грн";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.cmbElevator);
            this.Controls.Add(this.lblElevator);
            this.Controls.Add(this.numFloor);
            this.Controls.Add(this.lblFloor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.Label lblElevator;
        private System.Windows.Forms.ComboBox cmbElevator;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.NumericUpDown numHourlyRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}


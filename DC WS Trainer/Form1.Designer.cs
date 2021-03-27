namespace DC_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.godMode_Checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.creator_Label = new System.Windows.Forms.Label();
            this.addCells_Button = new System.Windows.Forms.Button();
            this.activateTrainer_checkbox = new System.Windows.Forms.CheckBox();
            this.addMoney_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.status_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(28, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSize = true;
            this.ProcessID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessID.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProcessID.Location = new System.Drawing.Point(126, 207);
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Size = new System.Drawing.Size(103, 25);
            this.ProcessID.TabIndex = 1;
            this.ProcessID.Text = "Not Found";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // godMode_Checkbox
            // 
            this.godMode_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godMode_Checkbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.godMode_Checkbox.Location = new System.Drawing.Point(33, 297);
            this.godMode_Checkbox.Name = "godMode_Checkbox";
            this.godMode_Checkbox.Size = new System.Drawing.Size(180, 28);
            this.godMode_Checkbox.TabIndex = 2;
            this.godMode_Checkbox.Text = "God Mode (F2)";
            this.godMode_Checkbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(77, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add 10 Cells";
            // 
            // creator_Label
            // 
            this.creator_Label.AutoSize = true;
            this.creator_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creator_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.creator_Label.Location = new System.Drawing.Point(184, 509);
            this.creator_Label.Name = "creator_Label";
            this.creator_Label.Size = new System.Drawing.Size(98, 13);
            this.creator_Label.TabIndex = 14;
            this.creator_Label.Text = "Created by Felix";
            this.creator_Label.Click += new System.EventHandler(this.creator_Label_Click);
            // 
            // addCells_Button
            // 
            this.addCells_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.addCells_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCells_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCells_Button.ForeColor = System.Drawing.Color.White;
            this.addCells_Button.Location = new System.Drawing.Point(28, 340);
            this.addCells_Button.Name = "addCells_Button";
            this.addCells_Button.Size = new System.Drawing.Size(43, 35);
            this.addCells_Button.TabIndex = 15;
            this.addCells_Button.Text = "F3";
            this.addCells_Button.UseVisualStyleBackColor = false;
            // 
            // activateTrainer_checkbox
            // 
            this.activateTrainer_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateTrainer_checkbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.activateTrainer_checkbox.Location = new System.Drawing.Point(33, 263);
            this.activateTrainer_checkbox.Name = "activateTrainer_checkbox";
            this.activateTrainer_checkbox.Size = new System.Drawing.Size(236, 28);
            this.activateTrainer_checkbox.TabIndex = 18;
            this.activateTrainer_checkbox.Text = "Activate Trainer (F1)";
            this.activateTrainer_checkbox.UseVisualStyleBackColor = true;
            this.activateTrainer_checkbox.CheckedChanged += new System.EventHandler(this.activateTrainer_checkbox_CheckedChanged);
            // 
            // addMoney_Button
            // 
            this.addMoney_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.addMoney_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMoney_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoney_Button.ForeColor = System.Drawing.Color.White;
            this.addMoney_Button.Location = new System.Drawing.Point(28, 392);
            this.addMoney_Button.Name = "addMoney_Button";
            this.addMoney_Button.Size = new System.Drawing.Size(43, 35);
            this.addMoney_Button.TabIndex = 20;
            this.addMoney_Button.Text = "F4";
            this.addMoney_Button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(77, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Add 10000 Money";
            // 
            // status_Label
            // 
            this.status_Label.AutoSize = true;
            this.status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.status_Label.Location = new System.Drawing.Point(30, 509);
            this.status_Label.Name = "status_Label";
            this.status_Label.Size = new System.Drawing.Size(111, 13);
            this.status_Label.TabIndex = 21;
            this.status_Label.Text = "Status: Not Active";
            this.status_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(370, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Icon by sirleviatan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Crimson;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(30, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cells and Money won\'t update the UI until their ingame value changes\r\nbut you can" +
    " still use their new added value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::DC_Trainer.Properties.Resources.dead_cells___button_fin_1560125633132;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status_Label);
            this.Controls.Add(this.addMoney_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.activateTrainer_checkbox);
            this.Controls.Add(this.addCells_Button);
            this.Controls.Add(this.creator_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.godMode_Checkbox);
            this.Controls.Add(this.ProcessID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dead Cells Windows Edition Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcessID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox godMode_Checkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label creator_Label;
        private System.Windows.Forms.Button addCells_Button;
        private System.Windows.Forms.CheckBox activateTrainer_checkbox;
        private System.Windows.Forms.Button addMoney_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}


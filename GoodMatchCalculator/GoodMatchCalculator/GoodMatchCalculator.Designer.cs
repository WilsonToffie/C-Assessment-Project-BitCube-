
namespace GoodMatchCalculator
{
    partial class GoodMatchCalculator
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
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnLocateFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.pnlMatch = new System.Windows.Forms.Panel();
            this.lblCalculated = new System.Windows.Forms.Label();
            this.pbxPercentage1 = new System.Windows.Forms.PictureBox();
            this.lbxAllMatches = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPercentage1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Location = new System.Drawing.Point(12, 102);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerTwo.TabIndex = 0;
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(12, 44);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerOne.TabIndex = 1;
            this.txtPlayerOne.TextChanged += new System.EventHandler(this.txtPlayerOne_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter player one\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter player two\'s name";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnLocateFile
            // 
            this.btnLocateFile.Location = new System.Drawing.Point(698, 202);
            this.btnLocateFile.Name = "btnLocateFile";
            this.btnLocateFile.Size = new System.Drawing.Size(90, 23);
            this.btnLocateFile.TabIndex = 5;
            this.btnLocateFile.Text = "Select csv file";
            this.btnLocateFile.UseVisualStyleBackColor = true;
            this.btnLocateFile.Click += new System.EventHandler(this.btnLocateFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(444, 202);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(248, 23);
            this.txtFilePath.TabIndex = 6;
            // 
            // pnlMatch
            // 
            this.pnlMatch.Controls.Add(this.lblCalculated);
            this.pnlMatch.Controls.Add(this.pbxPercentage1);
            this.pnlMatch.Location = new System.Drawing.Point(151, 26);
            this.pnlMatch.Name = "pnlMatch";
            this.pnlMatch.Size = new System.Drawing.Size(287, 199);
            this.pnlMatch.TabIndex = 7;
            // 
            // lblCalculated
            // 
            this.lblCalculated.AutoSize = true;
            this.lblCalculated.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalculated.Location = new System.Drawing.Point(10, 63);
            this.lblCalculated.Name = "lblCalculated";
            this.lblCalculated.Size = new System.Drawing.Size(72, 30);
            this.lblCalculated.TabIndex = 1;
            this.lblCalculated.Text = "label3";
            // 
            // pbxPercentage1
            // 
            this.pbxPercentage1.Image = global::GoodMatchCalculator.Properties.Resources._0;
            this.pbxPercentage1.Location = new System.Drawing.Point(10, 18);
            this.pbxPercentage1.Name = "pbxPercentage1";
            this.pbxPercentage1.Size = new System.Drawing.Size(267, 42);
            this.pbxPercentage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPercentage1.TabIndex = 0;
            this.pbxPercentage1.TabStop = false;
            // 
            // lbxAllMatches
            // 
            this.lbxAllMatches.FormattingEnabled = true;
            this.lbxAllMatches.ItemHeight = 15;
            this.lbxAllMatches.Location = new System.Drawing.Point(444, 26);
            this.lbxAllMatches.Name = "lbxAllMatches";
            this.lbxAllMatches.Size = new System.Drawing.Size(344, 169);
            this.lbxAllMatches.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 8);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(186, 15);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Incorrect input, please try again.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(444, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 10;
            // 
            // GoodMatchCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lbxAllMatches);
            this.Controls.Add(this.pnlMatch);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnLocateFile);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.txtPlayerTwo);
            this.Name = "GoodMatchCalculator";
            this.Text = "GoodMatch";
            this.pnlMatch.ResumeLayout(false);
            this.pnlMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPercentage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnLocateFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Panel pnlMatch;
        private System.Windows.Forms.ListBox lbxAllMatches;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.PictureBox pbxPercentage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCalculated;
    }
}


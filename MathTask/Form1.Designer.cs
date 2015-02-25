namespace MathTask
{
    partial class MATH
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
            this.title = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addRight = new System.Windows.Forms.Label();
            this.addRes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subRes = new System.Windows.Forms.NumericUpDown();
            this.subRight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.subLeft = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mulRes = new System.Windows.Forms.NumericUpDown();
            this.mulRight = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mulLeft = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.divRes = new System.Windows.Forms.NumericUpDown();
            this.divRight = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.divLeft = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addState = new System.Windows.Forms.Label();
            this.subState = new System.Windows.Forms.Label();
            this.mulState = new System.Windows.Forms.Label();
            this.divState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.title.Location = new System.Drawing.Point(329, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 18);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome to the math test!";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(128, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(153, 30);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Counter";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Left:";
            // 
            // addLeft
            // 
            this.addLeft.AutoSize = true;
            this.addLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLeft.Location = new System.Drawing.Point(133, 92);
            this.addLeft.Name = "addLeft";
            this.addLeft.Size = new System.Drawing.Size(18, 21);
            this.addLeft.TabIndex = 3;
            this.addLeft.Text = "?";
            this.addLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(174, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addRight
            // 
            this.addRight.AutoSize = true;
            this.addRight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRight.Location = new System.Drawing.Point(201, 92);
            this.addRight.Name = "addRight";
            this.addRight.Size = new System.Drawing.Size(18, 21);
            this.addRight.TabIndex = 5;
            this.addRight.Text = "?";
            this.addRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRes
            // 
            this.addRes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRes.Location = new System.Drawing.Point(261, 90);
            this.addRes.Name = "addRes";
            this.addRes.Size = new System.Drawing.Size(72, 29);
            this.addRes.TabIndex = 2;
            this.addRes.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(234, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "=";
            // 
            // subRes
            // 
            this.subRes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subRes.Location = new System.Drawing.Point(261, 142);
            this.subRes.Name = "subRes";
            this.subRes.Size = new System.Drawing.Size(72, 29);
            this.subRes.TabIndex = 3;
            this.subRes.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // subRight
            // 
            this.subRight.AutoSize = true;
            this.subRight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subRight.Location = new System.Drawing.Point(201, 142);
            this.subRight.Name = "subRight";
            this.subRight.Size = new System.Drawing.Size(18, 21);
            this.subRight.TabIndex = 10;
            this.subRight.Text = "?";
            this.subRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(174, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subLeft
            // 
            this.subLeft.AutoSize = true;
            this.subLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subLeft.Location = new System.Drawing.Point(133, 142);
            this.subLeft.Name = "subLeft";
            this.subLeft.Size = new System.Drawing.Size(18, 21);
            this.subLeft.TabIndex = 8;
            this.subLeft.Text = "?";
            this.subLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(234, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "=";
            // 
            // mulRes
            // 
            this.mulRes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulRes.Location = new System.Drawing.Point(261, 195);
            this.mulRes.Name = "mulRes";
            this.mulRes.Size = new System.Drawing.Size(72, 29);
            this.mulRes.TabIndex = 4;
            this.mulRes.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // mulRight
            // 
            this.mulRight.AutoSize = true;
            this.mulRight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulRight.Location = new System.Drawing.Point(201, 195);
            this.mulRight.Name = "mulRight";
            this.mulRight.Size = new System.Drawing.Size(18, 21);
            this.mulRight.TabIndex = 15;
            this.mulRight.Text = "?";
            this.mulRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(174, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulLeft
            // 
            this.mulLeft.AutoSize = true;
            this.mulLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulLeft.Location = new System.Drawing.Point(133, 195);
            this.mulLeft.Name = "mulLeft";
            this.mulLeft.Size = new System.Drawing.Size(18, 21);
            this.mulLeft.TabIndex = 13;
            this.mulLeft.Text = "?";
            this.mulLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(234, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 21);
            this.label14.TabIndex = 22;
            this.label14.Text = "=";
            // 
            // divRes
            // 
            this.divRes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divRes.Location = new System.Drawing.Point(261, 251);
            this.divRes.Name = "divRes";
            this.divRes.Size = new System.Drawing.Size(72, 29);
            this.divRes.TabIndex = 5;
            this.divRes.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // divRight
            // 
            this.divRight.AutoSize = true;
            this.divRight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divRight.Location = new System.Drawing.Point(201, 251);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(18, 21);
            this.divRight.TabIndex = 20;
            this.divRight.Text = "?";
            this.divRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(174, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = "/";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeft
            // 
            this.divLeft.AutoSize = true;
            this.divLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divLeft.Location = new System.Drawing.Point(133, 251);
            this.divLeft.Name = "divLeft";
            this.divLeft.Size = new System.Drawing.Size(18, 21);
            this.divLeft.TabIndex = 18;
            this.divLeft.Text = "?";
            this.divLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_button
            // 
            this.start_button.AutoSize = true;
            this.start_button.BackColor = System.Drawing.Color.Sienna;
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.Font = new System.Drawing.Font("Times New Roman", 13.25F, System.Drawing.FontStyle.Bold);
            this.start_button.ForeColor = System.Drawing.Color.Cornsilk;
            this.start_button.Location = new System.Drawing.Point(169, 339);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(138, 67);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start the TEST";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addState
            // 
            this.addState.AutoSize = true;
            this.addState.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addState.Location = new System.Drawing.Point(362, 97);
            this.addState.Name = "addState";
            this.addState.Size = new System.Drawing.Size(34, 17);
            this.addState.TabIndex = 23;
            this.addState.Text = "N/D";
            // 
            // subState
            // 
            this.subState.AutoSize = true;
            this.subState.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subState.Location = new System.Drawing.Point(362, 150);
            this.subState.Name = "subState";
            this.subState.Size = new System.Drawing.Size(34, 17);
            this.subState.TabIndex = 24;
            this.subState.Text = "N/D";
            // 
            // mulState
            // 
            this.mulState.AutoSize = true;
            this.mulState.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulState.Location = new System.Drawing.Point(362, 203);
            this.mulState.Name = "mulState";
            this.mulState.Size = new System.Drawing.Size(34, 17);
            this.mulState.TabIndex = 25;
            this.mulState.Text = "N/D";
            // 
            // divState
            // 
            this.divState.AutoSize = true;
            this.divState.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divState.Location = new System.Drawing.Point(362, 259);
            this.divState.Name = "divState";
            this.divState.Size = new System.Drawing.Size(34, 17);
            this.divState.TabIndex = 26;
            this.divState.Text = "N/D";
            // 
            // MATH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.divState);
            this.Controls.Add(this.mulState);
            this.Controls.Add(this.subState);
            this.Controls.Add(this.addState);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.divRes);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.divLeft);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mulRes);
            this.Controls.Add(this.mulRight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mulLeft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subRes);
            this.Controls.Add(this.subRight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addRes);
            this.Controls.Add(this.addRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MATH";
            this.Text = "MATH TEST";
            ((System.ComponentModel.ISupportInitialize)(this.addRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addRight;
        private System.Windows.Forms.NumericUpDown addRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown subRes;
        private System.Windows.Forms.Label subRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label subLeft;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown mulRes;
        private System.Windows.Forms.Label mulRight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label mulLeft;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown divRes;
        private System.Windows.Forms.Label divRight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label divLeft;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label addState;
        private System.Windows.Forms.Label subState;
        private System.Windows.Forms.Label mulState;
        private System.Windows.Forms.Label divState;
    }
}


namespace FaceRecognition
{
	partial class FormTraining
	{
	
		private System.ComponentModel.IContainer components = null;

		
		protected override void Dispose(bool disposing)
		{
			ReleaseData();
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

	
		private void InitializeComponent()
		{
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnRecMulty = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(885, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(885, 136);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加人脸";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(885, 203);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(133, 27);
            this.btnAddAll.TabIndex = 4;
            this.btnAddAll.Text = "姓名";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(885, 170);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(53, 27);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(965, 170);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 27);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(885, 496);
            this.btnRec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(133, 27);
            this.btnRec.TabIndex = 7;
            this.btnRec.Text = "录制";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnRecMulty
            // 
            this.btnRecMulty.Location = new System.Drawing.Point(885, 530);
            this.btnRecMulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecMulty.Name = "btnRecMulty";
            this.btnRecMulty.Size = new System.Drawing.Size(133, 27);
            this.btnRecMulty.TabIndex = 8;
            this.btnRecMulty.Text = "连续录制";
            this.btnRecMulty.UseVisualStyleBackColor = true;
            this.btnRecMulty.Click += new System.EventHandler(this.btnRecMulty_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(885, 237);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 9;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(885, 339);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(133, 27);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // FormTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 585);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRecMulty);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormTraining";
            this.Text = "人脸识别";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTraining_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnAddAll;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnRec;
		private System.Windows.Forms.Button btnRecMulty;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_Clear;

	}
}
namespace Hanoi_Winform
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
            this.label_time = new System.Windows.Forms.Label();
            this.label_floor = new System.Windows.Forms.Label();
            this.cb_time = new System.Windows.Forms.ComboBox();
            this.cb_floor = new System.Windows.Forms.ComboBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_time.Location = new System.Drawing.Point(12, 24);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(94, 23);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "이동 시간 :";
            this.label_time.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_floor
            // 
            this.label_floor.AutoSize = true;
            this.label_floor.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_floor.Location = new System.Drawing.Point(12, 74);
            this.label_floor.Name = "label_floor";
            this.label_floor.Size = new System.Drawing.Size(60, 23);
            this.label_floor.TabIndex = 2;
            this.label_floor.Text = "층 수 :";
            this.label_floor.Click += new System.EventHandler(this.label_floor_Click);
            // 
            // cb_time
            // 
            this.cb_time.FormattingEnabled = true;
            this.cb_time.Location = new System.Drawing.Point(112, 24);
            this.cb_time.Name = "cb_time";
            this.cb_time.Size = new System.Drawing.Size(84, 28);
            this.cb_time.TabIndex = 3;
            // 
            // cb_floor
            // 
            this.cb_floor.FormattingEnabled = true;
            this.cb_floor.Location = new System.Drawing.Point(78, 72);
            this.cb_floor.Name = "cb_floor";
            this.cb_floor.Size = new System.Drawing.Size(118, 28);
            this.cb_floor.TabIndex = 4;
            // 
            // btn_move
            // 
            this.btn_move.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_move.Location = new System.Drawing.Point(202, 24);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(66, 76);
            this.btn_move.TabIndex = 5;
            this.btn_move.Text = "이동";
            this.btn_move.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(328, 24);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(693, 30);
            this.textBox.TabIndex = 6;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_A.Location = new System.Drawing.Point(328, 77);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(110, 23);
            this.label_A.TabIndex = 7;
            this.label_A.Text = "Front Pole[A]";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_B.Location = new System.Drawing.Point(575, 77);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(109, 23);
            this.label_B.TabIndex = 8;
            this.label_B.Text = "Front Pole[B]";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_C.Location = new System.Drawing.Point(818, 77);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(110, 23);
            this.label_C.TabIndex = 9;
            this.label_C.Text = "Front Pole[C]";
            // 
            // tb_A
            // 
            this.tb_A.Location = new System.Drawing.Point(444, 77);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(87, 27);
            this.tb_A.TabIndex = 10;
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(690, 74);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(87, 27);
            this.tb_B.TabIndex = 11;
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(934, 77);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(87, 27);
            this.tb_C.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 477);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_A);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.cb_floor);
            this.Controls.Add(this.cb_time);
            this.Controls.Add(this.label_floor);
            this.Controls.Add(this.label_time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_time;
        private Label label_floor;
        private ComboBox cb_time;
        private ComboBox cb_floor;
        private Button btn_move;
        private TextBox textBox;
        private Label label_A;
        private Label label_B;
        private Label label_C;
        private TextBox tb_A;
        private TextBox tb_B;
        private TextBox tb_C;
    }
}
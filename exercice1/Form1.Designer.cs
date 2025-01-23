namespace exercice1
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
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            SuspendLayout();
            // 
            // btn_1
            // 
            btn_1.Location = new Point(77, 36);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(171, 126);
            btn_1.TabIndex = 0;
            btn_1.Text = "button1";
            btn_1.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(298, 166);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(171, 126);
            btn_2.TabIndex = 1;
            btn_2.Text = "button2";
            btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(558, 274);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(171, 126);
            btn_3.TabIndex = 2;
            btn_3.Text = "button3";
            btn_3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
    }
}

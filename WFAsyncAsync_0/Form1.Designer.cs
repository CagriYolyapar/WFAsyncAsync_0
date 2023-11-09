namespace WFAsyncAsync_0
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
            btnSim = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnSim
            // 
            btnSim.Location = new Point(167, 119);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(94, 29);
            btnSim.TabIndex = 0;
            btnSim.Text = "Simulation";
            btnSim.UseVisualStyleBackColor = true;
            btnSim.Click += btnSim_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnSim);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSim;
        private TextBox textBox1;
    }
}
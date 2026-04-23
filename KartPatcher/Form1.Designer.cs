namespace KartPatcher
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
            label1 = new Label();
            ipBox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            stepStatus = new Label();
            playerConnectBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            bombServerBox = new TextBox();
            titleIdBox = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Playstation 3 IP Address";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ipBox
            // 
            ipBox.Location = new Point(96, 27);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(142, 23);
            ipBox.TabIndex = 1;
            ipBox.Text = "192.168.0.100";
            // 
            // button1
            // 
            button1.Location = new Point(99, 191);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 2;
            button1.Text = "Patch my ModNation!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(300, 15);
            label2.TabIndex = 3;
            label2.Text = "Made with <3 for the ModNation community by convix";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 235);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(299, 23);
            progressBar1.TabIndex = 4;
            // 
            // stepStatus
            // 
            stepStatus.AutoSize = true;
            stepStatus.Location = new Point(13, 217);
            stepStatus.Name = "stepStatus";
            stepStatus.Size = new Size(139, 15);
            stepStatus.TabIndex = 5;
            stepStatus.Text = "Click patch to continue...";
            // 
            // playerConnectBox
            // 
            playerConnectBox.Location = new Point(96, 71);
            playerConnectBox.Name = "playerConnectBox";
            playerConnectBox.Size = new Size(142, 23);
            playerConnectBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 53);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 7;
            label3.Text = "PlayerConnect server URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 97);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "BombServer URL";
            // 
            // bombServerBox
            // 
            bombServerBox.Location = new Point(96, 115);
            bombServerBox.Name = "bombServerBox";
            bombServerBox.Size = new Size(142, 23);
            bombServerBox.TabIndex = 9;
            // 
            // titleIdBox
            // 
            titleIdBox.Location = new Point(96, 162);
            titleIdBox.Name = "titleIdBox";
            titleIdBox.Size = new Size(142, 23);
            titleIdBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 144);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Title ID";
            // 
            // button2
            // 
            button2.Location = new Point(244, 162);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 12;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 281);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(titleIdBox);
            Controls.Add(bombServerBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(playerConnectBox);
            Controls.Add(stepStatus);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(ipBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "KartPatcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ipBox;
        private Button button1;
        private Label label2;
        private ProgressBar progressBar1;
        private Label stepStatus;
        private TextBox playerConnectBox;
        private Label label3;
        private Label label4;
        private TextBox bombServerBox;
        private TextBox titleIdBox;
        private Label label5;
        private Button button2;
    }
}

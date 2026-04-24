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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // ipBox
            // 
            resources.ApplyResources(ipBox, "ipBox");
            ipBox.Name = "ipBox";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Name = "label2";
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            // 
            // stepStatus
            // 
            resources.ApplyResources(stepStatus, "stepStatus");
            stepStatus.Name = "stepStatus";
            // 
            // playerConnectBox
            // 
            resources.ApplyResources(playerConnectBox, "playerConnectBox");
            playerConnectBox.Name = "playerConnectBox";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // bombServerBox
            // 
            resources.ApplyResources(bombServerBox, "bombServerBox");
            bombServerBox.Name = "bombServerBox";
            // 
            // titleIdBox
            // 
            resources.ApplyResources(titleIdBox, "titleIdBox");
            titleIdBox.Name = "titleIdBox";
            titleIdBox.TextChanged += titleIdBox_TextChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
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
            Load += Form1_Load;
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
        private Label label6;
    }
}

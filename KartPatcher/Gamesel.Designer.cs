namespace KartPatcher
{
    partial class Gamesel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gamesel));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.ModNation_Racers_Logo;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(65, 12);
            button1.Name = "button1";
            button1.Size = new Size(281, 105);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._0f361adbc11cad08a4f36ab42780c0fa;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(65, 123);
            button2.Name = "button2";
            button2.Size = new Size(281, 105);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // Gamesel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 246);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Gamesel";
            Text = "KartPatcher";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
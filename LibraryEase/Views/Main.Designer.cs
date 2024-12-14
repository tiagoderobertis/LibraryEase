namespace LibraryEase.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lbl_title = new Label();
            label1 = new Label();
            lbl_explanation = new Label();
            panel1 = new Panel();
            pnl_Buttons = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            pnl_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_title
            // 
            resources.ApplyResources(lbl_title, "lbl_title");
            lbl_title.Name = "lbl_title";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.White;
            label1.Name = "label1";
            // 
            // lbl_explanation
            // 
            resources.ApplyResources(lbl_explanation, "lbl_explanation");
            lbl_explanation.Name = "lbl_explanation";
            // 
            // panel1
            // 
            panel1.Controls.Add(pnl_Buttons);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_explanation);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pnl_Buttons
            // 
            pnl_Buttons.BackColor = Color.FromArgb(224, 224, 224);
            pnl_Buttons.Controls.Add(button6);
            pnl_Buttons.Controls.Add(button5);
            pnl_Buttons.Controls.Add(button4);
            pnl_Buttons.Controls.Add(button3);
            pnl_Buttons.Controls.Add(button2);
            pnl_Buttons.Controls.Add(button1);
            resources.ApplyResources(pnl_Buttons, "pnl_Buttons");
            pnl_Buttons.Name = "pnl_Buttons";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(lbl_title);
            ForeColor = SystemColors.ControlText;
            Name = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnl_Buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Label lbl_title;
        private Label label1;
        private Label lbl_explanation;
        private Panel panel1;
        private Panel pnl_Buttons;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
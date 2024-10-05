namespace DateGraph
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DateBox = new TextBox();
            MonthBox = new TextBox();
            YearBox = new TextBox();
            GenerateDateBtn = new Button();
            PlusDateBtn = new Button();
            DateLabel = new Label();
            SuspendLayout();
            // 
            // DateBox
            // 
            resources.ApplyResources(DateBox, "DateBox");
            DateBox.Name = "DateBox";
            // 
            // MonthBox
            // 
            resources.ApplyResources(MonthBox, "MonthBox");
            MonthBox.Name = "MonthBox";
            // 
            // YearBox
            // 
            resources.ApplyResources(YearBox, "YearBox");
            YearBox.Name = "YearBox";
            // 
            // GenerateDateBtn
            // 
            resources.ApplyResources(GenerateDateBtn, "GenerateDateBtn");
            GenerateDateBtn.Name = "GenerateDateBtn";
            GenerateDateBtn.UseVisualStyleBackColor = true;
            GenerateDateBtn.Click += GenerateDateBtn_Click;
            // 
            // PlusDateBtn
            // 
            resources.ApplyResources(PlusDateBtn, "PlusDateBtn");
            PlusDateBtn.Name = "PlusDateBtn";
            PlusDateBtn.UseVisualStyleBackColor = true;
            PlusDateBtn.Click += PlusDateBtn_Click;
            // 
            // DateLabel
            // 
            resources.ApplyResources(DateLabel, "DateLabel");
            DateLabel.Name = "DateLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DateLabel);
            Controls.Add(PlusDateBtn);
            Controls.Add(GenerateDateBtn);
            Controls.Add(YearBox);
            Controls.Add(MonthBox);
            Controls.Add(DateBox);
            Name = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DateBox;
        private TextBox MonthBox;
        private TextBox YearBox;
        private Button GenerateDateBtn;
        private Button PlusDateBtn;
        private Label DateLabel;
    }
}

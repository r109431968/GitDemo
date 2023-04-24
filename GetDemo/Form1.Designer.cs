namespace GetDemo
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
            button1=new Button();
            Txt_1=new TextBox();
            Txt_2=new TextBox();
            labAnswer=new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(303, 234);
            button1.Name="button1";
            button1.Size=new Size(115, 38);
            button1.TabIndex=2;
            button1.Text="ADD";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // Txt_1
            // 
            Txt_1.Location=new Point(189, 151);
            Txt_1.Name="Txt_1";
            Txt_1.Size=new Size(150, 23);
            Txt_1.TabIndex=0;
            // 
            // Txt_2
            // 
            Txt_2.Location=new Point(189, 180);
            Txt_2.Name="Txt_2";
            Txt_2.Size=new Size(150, 23);
            Txt_2.TabIndex=1;
            // 
            // labAnswer
            // 
            labAnswer.Location=new Point(355, 166);
            labAnswer.Name="labAnswer";
            labAnswer.Size=new Size(150, 23);
            labAnswer.TabIndex=3;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(labAnswer);
            Controls.Add(Txt_2);
            Controls.Add(Txt_1);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Txt_1;
        private TextBox Txt_2;
        private TextBox labAnswer;
    }
}
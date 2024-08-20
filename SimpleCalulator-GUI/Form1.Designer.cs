namespace SimpleCalulator_GUI
{
    partial class Calc
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
            Input = new TextBox();
            but1 = new Button();
            but4 = new Button();
            but7 = new Button();
            but6 = new Button();
            but5 = new Button();
            but2 = new Button();
            but9 = new Button();
            but3 = new Button();
            butClear = new Button();
            butPlus = new Button();
            butSub = new Button();
            butTim = new Button();
            butDiv = new Button();
            butDP = new Button();
            but8 = new Button();
            but0 = new Button();
            butEq = new Button();
            butLBrac = new Button();
            butRBrac = new Button();
            butBack = new Button();
            SuspendLayout();
            // 
            // Input
            // 
            Input.Location = new Point(21, 22);
            Input.Margin = new Padding(8);
            Input.Name = "Input";
            Input.Size = new Size(403, 44);
            Input.TabIndex = 0;
            Input.TextChanged += Input_TextChanged;
            // 
            // but1
            // 
            but1.Location = new Point(21, 162);
            but1.Margin = new Padding(4, 5, 4, 5);
            but1.Name = "but1";
            but1.Size = new Size(94, 72);
            but1.TabIndex = 2;
            but1.Text = "1";
            but1.UseVisualStyleBackColor = true;
            but1.Click += but1_Click;
            // 
            // but4
            // 
            but4.Location = new Point(21, 243);
            but4.Margin = new Padding(4, 5, 4, 5);
            but4.Name = "but4";
            but4.Size = new Size(94, 72);
            but4.TabIndex = 3;
            but4.Text = "4";
            but4.UseVisualStyleBackColor = true;
            but4.Click += but4_Click;
            // 
            // but7
            // 
            but7.Location = new Point(21, 324);
            but7.Margin = new Padding(4, 5, 4, 5);
            but7.Name = "but7";
            but7.Size = new Size(94, 72);
            but7.TabIndex = 4;
            but7.Text = "7";
            but7.UseVisualStyleBackColor = true;
            but7.Click += but7_Click;
            // 
            // but6
            // 
            but6.Location = new Point(228, 243);
            but6.Margin = new Padding(4, 5, 4, 5);
            but6.Name = "but6";
            but6.Size = new Size(94, 72);
            but6.TabIndex = 5;
            but6.Text = "6";
            but6.UseVisualStyleBackColor = true;
            but6.Click += but6_Click;
            // 
            // but5
            // 
            but5.Location = new Point(125, 243);
            but5.Margin = new Padding(4, 5, 4, 5);
            but5.Name = "but5";
            but5.Size = new Size(94, 72);
            but5.TabIndex = 6;
            but5.Text = "5";
            but5.UseVisualStyleBackColor = true;
            but5.Click += but5_Click;
            // 
            // but2
            // 
            but2.Location = new Point(125, 162);
            but2.Margin = new Padding(4, 5, 4, 5);
            but2.Name = "but2";
            but2.Size = new Size(94, 72);
            but2.TabIndex = 7;
            but2.Text = "2";
            but2.UseVisualStyleBackColor = true;
            but2.Click += but2_Click;
            // 
            // but9
            // 
            but9.Location = new Point(228, 324);
            but9.Margin = new Padding(4, 5, 4, 5);
            but9.Name = "but9";
            but9.Size = new Size(94, 72);
            but9.TabIndex = 9;
            but9.Text = "9";
            but9.UseVisualStyleBackColor = true;
            but9.Click += but9_Click;
            // 
            // but3
            // 
            but3.Location = new Point(228, 162);
            but3.Margin = new Padding(4, 5, 4, 5);
            but3.Name = "but3";
            but3.Size = new Size(94, 72);
            but3.TabIndex = 10;
            but3.Text = "3";
            but3.UseVisualStyleBackColor = true;
            but3.Click += but3_Click;
            // 
            // butClear
            // 
            butClear.Location = new Point(228, 81);
            butClear.Margin = new Padding(4, 5, 4, 5);
            butClear.Name = "butClear";
            butClear.Size = new Size(94, 72);
            butClear.TabIndex = 11;
            butClear.Text = "clear";
            butClear.UseVisualStyleBackColor = true;
            butClear.Click += button11_Click;
            // 
            // butPlus
            // 
            butPlus.Location = new Point(332, 406);
            butPlus.Margin = new Padding(4, 5, 4, 5);
            butPlus.Name = "butPlus";
            butPlus.Size = new Size(94, 71);
            butPlus.TabIndex = 12;
            butPlus.Text = "+";
            butPlus.UseVisualStyleBackColor = true;
            butPlus.Click += butPlus_Click;
            // 
            // butSub
            // 
            butSub.Location = new Point(332, 324);
            butSub.Margin = new Padding(4, 5, 4, 5);
            butSub.Name = "butSub";
            butSub.Size = new Size(94, 72);
            butSub.TabIndex = 13;
            butSub.Text = "-";
            butSub.UseVisualStyleBackColor = true;
            butSub.Click += butSub_Click;
            // 
            // butTim
            // 
            butTim.Location = new Point(332, 243);
            butTim.Margin = new Padding(4, 5, 4, 5);
            butTim.Name = "butTim";
            butTim.Size = new Size(94, 72);
            butTim.TabIndex = 14;
            butTim.Text = "x";
            butTim.UseVisualStyleBackColor = true;
            butTim.Click += butTim_Click;
            // 
            // butDiv
            // 
            butDiv.Location = new Point(330, 161);
            butDiv.Margin = new Padding(4, 5, 4, 5);
            butDiv.Name = "butDiv";
            butDiv.Size = new Size(94, 72);
            butDiv.TabIndex = 15;
            butDiv.Text = "/";
            butDiv.UseVisualStyleBackColor = true;
            butDiv.Click += butDiv_Click;
            // 
            // butDP
            // 
            butDP.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            butDP.Location = new Point(125, 406);
            butDP.Margin = new Padding(4, 5, 4, 5);
            butDP.Name = "butDP";
            butDP.Size = new Size(94, 72);
            butDP.TabIndex = 16;
            butDP.Text = ".";
            butDP.UseVisualStyleBackColor = true;
            butDP.Click += butDP_Click;
            // 
            // but8
            // 
            but8.Location = new Point(125, 324);
            but8.Margin = new Padding(4, 5, 4, 5);
            but8.Name = "but8";
            but8.Size = new Size(94, 72);
            but8.TabIndex = 17;
            but8.Text = "8";
            but8.UseVisualStyleBackColor = true;
            but8.Click += but8_Click;
            // 
            // but0
            // 
            but0.Location = new Point(21, 406);
            but0.Margin = new Padding(4, 5, 4, 5);
            but0.Name = "but0";
            but0.Size = new Size(94, 72);
            but0.TabIndex = 18;
            but0.Text = "0";
            but0.UseVisualStyleBackColor = true;
            but0.Click += but0_Click;
            // 
            // butEq
            // 
            butEq.Location = new Point(228, 406);
            butEq.Margin = new Padding(4, 5, 4, 5);
            butEq.Name = "butEq";
            butEq.Size = new Size(94, 72);
            butEq.TabIndex = 19;
            butEq.Text = "=";
            butEq.UseVisualStyleBackColor = true;
            butEq.Click += butEq_Click;
            // 
            // butLBrac
            // 
            butLBrac.Location = new Point(21, 81);
            butLBrac.Margin = new Padding(4, 5, 4, 5);
            butLBrac.Name = "butLBrac";
            butLBrac.Size = new Size(94, 72);
            butLBrac.TabIndex = 20;
            butLBrac.Text = "(";
            butLBrac.UseVisualStyleBackColor = true;
            butLBrac.Click += butLBrac_Click;
            // 
            // butRBrac
            // 
            butRBrac.Location = new Point(123, 81);
            butRBrac.Margin = new Padding(4, 5, 4, 5);
            butRBrac.Name = "butRBrac";
            butRBrac.Size = new Size(94, 72);
            butRBrac.TabIndex = 21;
            butRBrac.Text = ")";
            butRBrac.UseVisualStyleBackColor = true;
            butRBrac.Click += butRBrac_Click;
            // 
            // butBack
            // 
            butBack.Location = new Point(332, 81);
            butBack.Margin = new Padding(4, 5, 4, 5);
            butBack.Name = "butBack";
            butBack.Size = new Size(94, 72);
            butBack.TabIndex = 22;
            butBack.Text = "<-";
            butBack.UseVisualStyleBackColor = true;
            butBack.Click += butBack_Click;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 494);
            Controls.Add(butBack);
            Controls.Add(butRBrac);
            Controls.Add(butLBrac);
            Controls.Add(butEq);
            Controls.Add(but0);
            Controls.Add(but8);
            Controls.Add(butDP);
            Controls.Add(butDiv);
            Controls.Add(butTim);
            Controls.Add(butSub);
            Controls.Add(butPlus);
            Controls.Add(butClear);
            Controls.Add(but3);
            Controls.Add(but9);
            Controls.Add(but2);
            Controls.Add(but5);
            Controls.Add(but6);
            Controls.Add(but7);
            Controls.Add(but4);
            Controls.Add(but1);
            Controls.Add(Input);
            Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8);
            Name = "Calc";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input;
        private Button but1;
        private Button but4;
        private Button but7;
        private Button but6;
        private Button but5;
        private Button but2;
        private Button but9;
        private Button but3;
        private Button butClear;
        private Button butPlus;
        private Button butSub;
        private Button butTim;
        private Button butDiv;
        private Button butDP;
        private Button but8;
        private Button but0;
        private Button butEq;
        private Button butLBrac;
        private Button butRBrac;
        private Button butBack;
    }
}

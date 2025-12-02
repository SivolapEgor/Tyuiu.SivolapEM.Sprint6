namespace Tyuiu.SivolapEM.Sprint6.Task0.V8
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxValueX;
        private System.Windows.Forms.Label labelValueX;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxGraph;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxValueX = new TextBox();
            labelValueX = new Label();
            buttonCalculate = new Button();
            buttonAbout = new Button();
            textBoxResult = new TextBox();
            labelResult = new Label();
            pictureBoxGraph = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).BeginInit();
            SuspendLayout();
            // 
            // textBoxValueX
            // 
            textBoxValueX.Location = new Point(14, 35);
            textBoxValueX.Margin = new Padding(4, 3, 4, 3);
            textBoxValueX.Name = "textBoxValueX";
            textBoxValueX.Size = new Size(116, 23);
            textBoxValueX.TabIndex = 0;
            textBoxValueX.KeyPress += textBoxValueX_KeyPress;
            // 
            // labelValueX
            // 
            labelValueX.AutoSize = true;
            labelValueX.Location = new Point(14, 17);
            labelValueX.Margin = new Padding(4, 0, 4, 0);
            labelValueX.Name = "labelValueX";
            labelValueX.Size = new Size(62, 15);
            labelValueX.TabIndex = 1;
            labelValueX.Text = "Введите x:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(14, 69);
            buttonCalculate.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(117, 27);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "Вычислить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Location = new Point(13, 102);
            buttonAbout.Margin = new Padding(4, 3, 4, 3);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(148, 28);
            buttonAbout.TabIndex = 3;
            buttonAbout.Text = "О программе";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 156);
            textBoxResult.Margin = new Padding(4, 3, 4, 3);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(116, 23);
            textBoxResult.TabIndex = 4;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(14, 138);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат:";
            // 
            // pictureBoxGraph
            // 
            pictureBoxGraph.Image = (Image)resources.GetObject("pictureBoxGraph.Image");
            pictureBoxGraph.Location = new Point(202, 35);
            pictureBoxGraph.Margin = new Padding(4, 3, 4, 3);
            pictureBoxGraph.Name = "pictureBoxGraph";
            pictureBoxGraph.Size = new Size(335, 124);
            pictureBoxGraph.TabIndex = 6;
            pictureBoxGraph.TabStop = false;
            pictureBoxGraph.Click += pictureBoxGraph_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 258);
            Controls.Add(pictureBoxGraph);
            Controls.Add(labelResult);
            Controls.Add(textBoxResult);
            Controls.Add(buttonAbout);
            Controls.Add(buttonCalculate);
            Controls.Add(labelValueX);
            Controls.Add(textBoxValueX);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Задание 0";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

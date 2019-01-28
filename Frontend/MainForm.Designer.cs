namespace ImageNST
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddContent = new System.Windows.Forms.Button();
            this.AddStyle = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.Button();
            this.SaveOutput = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.GithubBox = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.ContentBox = new System.Windows.Forms.PictureBox();
            this.StyleBox = new System.Windows.Forms.PictureBox();
            this.OutputBox = new System.Windows.Forms.PictureBox();
            this.PythonBackend = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GithubBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddContent
            // 
            this.AddContent.BackColor = System.Drawing.Color.White;
            this.AddContent.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContent.ForeColor = System.Drawing.Color.Gray;
            this.AddContent.Location = new System.Drawing.Point(746, 81);
            this.AddContent.Name = "AddContent";
            this.AddContent.Size = new System.Drawing.Size(196, 72);
            this.AddContent.TabIndex = 2;
            this.AddContent.Text = "Add Content";
            this.AddContent.UseVisualStyleBackColor = false;
            this.AddContent.Click += new System.EventHandler(this.AddContent_Click);
            // 
            // AddStyle
            // 
            this.AddStyle.BackColor = System.Drawing.Color.White;
            this.AddStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStyle.ForeColor = System.Drawing.Color.Gray;
            this.AddStyle.Location = new System.Drawing.Point(746, 198);
            this.AddStyle.Name = "AddStyle";
            this.AddStyle.Size = new System.Drawing.Size(196, 72);
            this.AddStyle.TabIndex = 3;
            this.AddStyle.Text = "Add Style";
            this.AddStyle.UseVisualStyleBackColor = false;
            this.AddStyle.Click += new System.EventHandler(this.AddStyle_Click);
            // 
            // Train
            // 
            this.Train.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Train.BackColor = System.Drawing.Color.White;
            this.Train.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train.ForeColor = System.Drawing.Color.Gray;
            this.Train.Location = new System.Drawing.Point(746, 315);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(196, 72);
            this.Train.TabIndex = 4;
            this.Train.Text = "Train Model";
            this.Train.UseVisualStyleBackColor = false;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // SaveOutput
            // 
            this.SaveOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SaveOutput.BackColor = System.Drawing.Color.White;
            this.SaveOutput.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOutput.ForeColor = System.Drawing.Color.Gray;
            this.SaveOutput.Location = new System.Drawing.Point(746, 432);
            this.SaveOutput.Name = "SaveOutput";
            this.SaveOutput.Size = new System.Drawing.Size(196, 72);
            this.SaveOutput.TabIndex = 5;
            this.SaveOutput.Text = "Save Output";
            this.SaveOutput.UseVisualStyleBackColor = false;
            this.SaveOutput.Click += new System.EventHandler(this.SaveOutput_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label.Location = new System.Drawing.Point(37, 14);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(171, 30);
            this.Label.TabIndex = 12;
            this.Label.Text = "ImageNST RC1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StatusLabel.Location = new System.Drawing.Point(37, 527);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(140, 30);
            this.StatusLabel.TabIndex = 13;
            this.StatusLabel.Text = "MIT License";
            // 
            // GithubBox
            // 
            this.GithubBox.Image = global::ImageNST.Properties.Resources.github;
            this.GithubBox.ImageLocation = "";
            this.GithubBox.Location = new System.Drawing.Point(827, 12);
            this.GithubBox.Name = "GithubBox";
            this.GithubBox.Size = new System.Drawing.Size(32, 32);
            this.GithubBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GithubBox.TabIndex = 14;
            this.GithubBox.TabStop = false;
            this.GithubBox.Click += new System.EventHandler(this.GithubBox_Click);
            // 
            // Close
            // 
            this.Close.Image = global::ImageNST.Properties.Resources.CloseW;
            this.Close.Location = new System.Drawing.Point(918, 6);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(47, 48);
            this.Close.TabIndex = 11;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Image = global::ImageNST.Properties.Resources.MinimizeW;
            this.Minimize.Location = new System.Drawing.Point(865, 6);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(47, 48);
            this.Minimize.TabIndex = 10;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(41, 81);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(200, 200);
            this.ContentBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContentBox.TabIndex = 15;
            this.ContentBox.TabStop = false;
            // 
            // StyleBox
            // 
            this.StyleBox.Location = new System.Drawing.Point(281, 81);
            this.StyleBox.Name = "StyleBox";
            this.StyleBox.Size = new System.Drawing.Size(200, 200);
            this.StyleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StyleBox.TabIndex = 16;
            this.StyleBox.TabStop = false;
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(521, 81);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(200, 200);
            this.OutputBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputBox.TabIndex = 17;
            this.OutputBox.TabStop = false;
            // 
            // PythonBackend
            // 
            this.PythonBackend.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PythonBackend.Location = new System.Drawing.Point(41, 321);
            this.PythonBackend.Multiline = true;
            this.PythonBackend.Name = "PythonBackend";
            this.PythonBackend.ReadOnly = true;
            this.PythonBackend.Size = new System.Drawing.Size(678, 183);
            this.PythonBackend.TabIndex = 18;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContentLabel.Location = new System.Drawing.Point(87, 284);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(101, 30);
            this.ContentLabel.TabIndex = 19;
            this.ContentLabel.Text = "Content";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StyleLabel.Location = new System.Drawing.Point(348, 284);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(63, 30);
            this.StyleLabel.TabIndex = 20;
            this.StyleLabel.Text = "Style";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.OutputLabel.Location = new System.Drawing.Point(581, 284);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(92, 30);
            this.OutputLabel.TabIndex = 21;
            this.OutputLabel.Text = "Output";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(972, 566);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.StyleLabel);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.PythonBackend);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.StyleBox);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.GithubBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.SaveOutput);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.AddStyle);
            this.Controls.Add(this.AddContent);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageNST RC1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.GithubBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddContent;
        private System.Windows.Forms.Button AddStyle;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.Button SaveOutput;
        private System.Windows.Forms.PictureBox Minimize;
        private new System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.PictureBox GithubBox;
        private System.Windows.Forms.PictureBox ContentBox;
        private System.Windows.Forms.PictureBox StyleBox;
        private System.Windows.Forms.PictureBox OutputBox;
        private System.Windows.Forms.TextBox PythonBackend;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label OutputLabel;
    }
}


namespace Simple_Face_Recognition_App
{
    partial class Form1
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCapture = new Guna.UI.WinForms.GunaGradientButton();
            this.btnDetectFaces = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTrain = new Guna.UI.WinForms.GunaGradientButton();
            this.btnAddPerson = new Guna.UI.WinForms.GunaGradientButton();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(13, 60);
            this.picCapture.Margin = new System.Windows.Forms.Padding(4);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(865, 528);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(903, 251);
            this.picDetected.Margin = new System.Windows.Forms.Padding(4);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(228, 126);
            this.picDetected.TabIndex = 7;
            this.picDetected.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(903, 524);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1043, 524);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.AnimationHoverSpeed = 0.07F;
            this.btnCapture.AnimationSpeed = 0.03F;
            this.btnCapture.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnCapture.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnCapture.BorderColor = System.Drawing.Color.Black;
            this.btnCapture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapture.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Image = null;
            this.btnCapture.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapture.Location = new System.Drawing.Point(903, 73);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnCapture.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnCapture.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapture.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapture.OnHoverImage = null;
            this.btnCapture.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapture.Size = new System.Drawing.Size(228, 42);
            this.btnCapture.TabIndex = 11;
            this.btnCapture.Text = "Capture";
            this.btnCapture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.AnimationHoverSpeed = 0.07F;
            this.btnDetectFaces.AnimationSpeed = 0.03F;
            this.btnDetectFaces.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnDetectFaces.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnDetectFaces.BorderColor = System.Drawing.Color.Black;
            this.btnDetectFaces.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetectFaces.FocusedColor = System.Drawing.Color.Empty;
            this.btnDetectFaces.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetectFaces.ForeColor = System.Drawing.Color.White;
            this.btnDetectFaces.Image = null;
            this.btnDetectFaces.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDetectFaces.Location = new System.Drawing.Point(903, 129);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnDetectFaces.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnDetectFaces.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDetectFaces.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDetectFaces.OnHoverImage = null;
            this.btnDetectFaces.OnPressedColor = System.Drawing.Color.Black;
            this.btnDetectFaces.Size = new System.Drawing.Size(228, 42);
            this.btnDetectFaces.TabIndex = 11;
            this.btnDetectFaces.Text = "Detect Faces";
            this.btnDetectFaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.AnimationHoverSpeed = 0.07F;
            this.btnTrain.AnimationSpeed = 0.03F;
            this.btnTrain.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnTrain.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnTrain.BorderColor = System.Drawing.Color.Black;
            this.btnTrain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrain.FocusedColor = System.Drawing.Color.Empty;
            this.btnTrain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = null;
            this.btnTrain.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTrain.Location = new System.Drawing.Point(903, 416);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnTrain.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnTrain.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTrain.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTrain.OnHoverImage = null;
            this.btnTrain.OnPressedColor = System.Drawing.Color.Black;
            this.btnTrain.Size = new System.Drawing.Size(228, 101);
            this.btnTrain.TabIndex = 11;
            this.btnTrain.Text = "Detect Face For Attendence";
            this.btnTrain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.AnimationHoverSpeed = 0.07F;
            this.btnAddPerson.AnimationSpeed = 0.03F;
            this.btnAddPerson.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnAddPerson.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnAddPerson.BorderColor = System.Drawing.Color.Black;
            this.btnAddPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPerson.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Image = null;
            this.btnAddPerson.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddPerson.Location = new System.Drawing.Point(903, 191);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnAddPerson.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.btnAddPerson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddPerson.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddPerson.OnHoverImage = null;
            this.btnAddPerson.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddPerson.Size = new System.Drawing.Size(228, 42);
            this.btnAddPerson.TabIndex = 11;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(903, 387);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(228, 22);
            this.txtPersonName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 14);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(296, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your Attendence Not Yet Marked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1155, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.picCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Simple Face Recognition App";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGradientButton btnCapture;
        private Guna.UI.WinForms.GunaGradientButton btnDetectFaces;
        private Guna.UI.WinForms.GunaGradientButton btnTrain;
        private Guna.UI.WinForms.GunaGradientButton btnAddPerson;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}


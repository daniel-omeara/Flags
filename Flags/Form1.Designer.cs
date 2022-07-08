namespace Flags
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
            this.labelInstruction = new System.Windows.Forms.Label();
            this.pictureBoxFinland = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrance = new System.Windows.Forms.PictureBox();
            this.pictureBoxGermany = new System.Windows.Forms.PictureBox();
            this.labelCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGermany)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(35, 9);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(233, 15);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Click a flag to see the name of the country.";
            // 
            // pictureBoxFinland
            // 
            this.pictureBoxFinland.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFinland.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFinland.Image")));
            this.pictureBoxFinland.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxFinland.Name = "pictureBoxFinland";
            this.pictureBoxFinland.Size = new System.Drawing.Size(90, 60);
            this.pictureBoxFinland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFinland.TabIndex = 1;
            this.pictureBoxFinland.TabStop = false;
            this.pictureBoxFinland.Click += new System.EventHandler(this.pictureBoxFinland_Click);
            // 
            // pictureBoxFrance
            // 
            this.pictureBoxFrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFrance.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFrance.Image")));
            this.pictureBoxFrance.Location = new System.Drawing.Point(108, 27);
            this.pictureBoxFrance.Name = "pictureBoxFrance";
            this.pictureBoxFrance.Size = new System.Drawing.Size(90, 60);
            this.pictureBoxFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrance.TabIndex = 2;
            this.pictureBoxFrance.TabStop = false;
            this.pictureBoxFrance.Click += new System.EventHandler(this.pictureBoxFrance_Click);
            // 
            // pictureBoxGermany
            // 
            this.pictureBoxGermany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGermany.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGermany.Image")));
            this.pictureBoxGermany.Location = new System.Drawing.Point(204, 27);
            this.pictureBoxGermany.Name = "pictureBoxGermany";
            this.pictureBoxGermany.Size = new System.Drawing.Size(90, 60);
            this.pictureBoxGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGermany.TabIndex = 3;
            this.pictureBoxGermany.TabStop = false;
            this.pictureBoxGermany.Click += new System.EventHandler(this.pictureBoxGermany_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.Location = new System.Drawing.Point(12, 90);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(282, 23);
            this.labelCountry.TabIndex = 4;
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 125);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.pictureBoxGermany);
            this.Controls.Add(this.pictureBoxFrance);
            this.Controls.Add(this.pictureBoxFinland);
            this.Controls.Add(this.labelInstruction);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGermany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInstruction;
        private PictureBox pictureBoxFinland;
        private PictureBox pictureBoxFrance;
        private PictureBox pictureBoxGermany;
        private Label labelCountry;
    }
}
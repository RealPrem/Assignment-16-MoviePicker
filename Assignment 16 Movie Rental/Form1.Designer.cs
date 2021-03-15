
namespace Assignment_16_Movie_Rental
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
            this.Text = new System.Windows.Forms.Label();
            this.MoviePicker = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Calibri", 30F);
            this.Text.ForeColor = System.Drawing.Color.Fuchsia;
            this.Text.Location = new System.Drawing.Point(3, 21);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(258, 49);
            this.Text.TabIndex = 0;
            this.Text.Text = "MOVIE SCAMS";
            // 
            // MoviePicker
            // 
            this.MoviePicker.FormattingEnabled = true;
            this.MoviePicker.Location = new System.Drawing.Point(12, 100);
            this.MoviePicker.Name = "MoviePicker";
            this.MoviePicker.Size = new System.Drawing.Size(219, 21);
            this.MoviePicker.TabIndex = 1;
            this.MoviePicker.SelectedIndexChanged += new System.EventHandler(this.MoviePicker_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MovieNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LengthLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AvailableLabel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(261, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 234);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOVIENAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LENGTH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AVAILABLE";
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(158, 0);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(69, 13);
            this.MovieNameLabel.TabIndex = 3;
            this.MovieNameLabel.Text = "Select Movie";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(158, 79);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(72, 13);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Select Movie";
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Location = new System.Drawing.Point(158, 158);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(69, 13);
            this.AvailableLabel.TabIndex = 5;
            this.AvailableLabel.Text = "Select Movie";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorrowButton.Location = new System.Drawing.Point(261, 276);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(155, 68);
            this.BorrowButton.TabIndex = 3;
            this.BorrowButton.Text = "BORROW";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.ReturnButton.ForeColor = System.Drawing.Color.Maroon;
            this.ReturnButton.Location = new System.Drawing.Point(422, 276);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(146, 68);
            this.ReturnButton.TabIndex = 4;
            this.ReturnButton.Text = "RETURN";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MoviePicker);
            this.Controls.Add(this.Text);
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.ComboBox MoviePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}


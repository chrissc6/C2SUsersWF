namespace C2SUsersWF
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1WF1INSERT = new System.Windows.Forms.Button();
            this.button1WF1UPDATE = new System.Windows.Forms.Button();
            this.button1WF1DELETE = new System.Windows.Forms.Button();
            this.button1WF1QUERY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "User DB Connection";
            // 
            // button1WF1INSERT
            // 
            this.button1WF1INSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1WF1INSERT.Location = new System.Drawing.Point(12, 116);
            this.button1WF1INSERT.Name = "button1WF1INSERT";
            this.button1WF1INSERT.Size = new System.Drawing.Size(147, 60);
            this.button1WF1INSERT.TabIndex = 1;
            this.button1WF1INSERT.Text = "INSERT";
            this.button1WF1INSERT.UseVisualStyleBackColor = true;
            this.button1WF1INSERT.Click += new System.EventHandler(this.button1WF1INSERT_Click);
            // 
            // button1WF1UPDATE
            // 
            this.button1WF1UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1WF1UPDATE.Location = new System.Drawing.Point(12, 203);
            this.button1WF1UPDATE.Name = "button1WF1UPDATE";
            this.button1WF1UPDATE.Size = new System.Drawing.Size(147, 60);
            this.button1WF1UPDATE.TabIndex = 2;
            this.button1WF1UPDATE.Text = "UPDATE";
            this.button1WF1UPDATE.UseVisualStyleBackColor = true;
            this.button1WF1UPDATE.Click += new System.EventHandler(this.button1WF1UPDATE_Click);
            // 
            // button1WF1DELETE
            // 
            this.button1WF1DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1WF1DELETE.Location = new System.Drawing.Point(12, 290);
            this.button1WF1DELETE.Name = "button1WF1DELETE";
            this.button1WF1DELETE.Size = new System.Drawing.Size(147, 60);
            this.button1WF1DELETE.TabIndex = 3;
            this.button1WF1DELETE.Text = "DELETE";
            this.button1WF1DELETE.UseVisualStyleBackColor = true;
            this.button1WF1DELETE.Click += new System.EventHandler(this.button1WF1DELETE_Click);
            // 
            // button1WF1QUERY
            // 
            this.button1WF1QUERY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1WF1QUERY.Location = new System.Drawing.Point(12, 377);
            this.button1WF1QUERY.Name = "button1WF1QUERY";
            this.button1WF1QUERY.Size = new System.Drawing.Size(147, 60);
            this.button1WF1QUERY.TabIndex = 4;
            this.button1WF1QUERY.Text = "QUERY";
            this.button1WF1QUERY.UseVisualStyleBackColor = true;
            this.button1WF1QUERY.Click += new System.EventHandler(this.button1WF1QUERY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert a new user into the database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Query the database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Update a current user in the database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Delete a user from the database";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1WF1QUERY);
            this.Controls.Add(this.button1WF1DELETE);
            this.Controls.Add(this.button1WF1UPDATE);
            this.Controls.Add(this.button1WF1INSERT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User DB Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1WF1INSERT;
        private System.Windows.Forms.Button button1WF1UPDATE;
        private System.Windows.Forms.Button button1WF1DELETE;
        private System.Windows.Forms.Button button1WF1QUERY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}


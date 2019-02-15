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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
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
            this.button1WF1UPDATE.Location = new System.Drawing.Point(12, 202);
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
            this.button1WF1DELETE.Location = new System.Drawing.Point(12, 287);
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
            this.button1WF1QUERY.Location = new System.Drawing.Point(12, 378);
            this.button1WF1QUERY.Name = "button1WF1QUERY";
            this.button1WF1QUERY.Size = new System.Drawing.Size(147, 60);
            this.button1WF1QUERY.TabIndex = 4;
            this.button1WF1QUERY.Text = "QUERY";
            this.button1WF1QUERY.UseVisualStyleBackColor = true;
            this.button1WF1QUERY.Click += new System.EventHandler(this.button1WF1QUERY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1WF1QUERY);
            this.Controls.Add(this.button1WF1DELETE);
            this.Controls.Add(this.button1WF1UPDATE);
            this.Controls.Add(this.button1WF1INSERT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}


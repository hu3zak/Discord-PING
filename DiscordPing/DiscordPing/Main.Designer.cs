namespace DiscordPing
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sendButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.delayLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.textWebHook = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Animated = true;
            this.sendButton.AutoRoundedCorners = true;
            this.sendButton.BackColor = System.Drawing.Color.Transparent;
            this.sendButton.BorderColor = System.Drawing.Color.Transparent;
            this.sendButton.BorderRadius = 9;
            this.sendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(149, 480);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(149, 21);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            this.sendButton.Paint += new System.Windows.Forms.PaintEventHandler(this.sendButton_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(454, 36);
            this.guna2Panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Discord Ping";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(364, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 36);
            this.guna2ControlBox2.TabIndex = 1;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(408, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 36);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(115, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 72;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(105, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 71;
            this.label2.Text = "1.";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(142, 115);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(103, 23);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Delay Mínimo";
            // 
            // delayLabel
            // 
            this.delayLabel.BackColor = System.Drawing.Color.Transparent;
            this.delayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.delayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.delayLabel.Location = new System.Drawing.Point(282, 48);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(61, 23);
            this.delayLabel.TabIndex = 10;
            this.delayLabel.Text = "1500 ms";
            // 
            // textMessage
            // 
            this.textMessage.Animated = true;
            this.textMessage.BackColor = System.Drawing.Color.Transparent;
            this.textMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textMessage.BorderRadius = 5;
            this.textMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMessage.DefaultText = "";
            this.textMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.Location = new System.Drawing.Point(17, 270);
            this.textMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textMessage.Name = "textMessage";
            this.textMessage.PasswordChar = '\0';
            this.textMessage.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.textMessage.PlaceholderText = "Message";
            this.textMessage.SelectedText = "";
            this.textMessage.Size = new System.Drawing.Size(200, 29);
            this.textMessage.TabIndex = 70;
            this.textMessage.TextChanged += new System.EventHandler(this.textMessage_TextChanged);
            this.textMessage.MouseEnter += new System.EventHandler(this.textMessage_TextChanged);
            this.textMessage.MouseLeave += new System.EventHandler(this.textMessage_TextChanged);
            // 
            // textWebHook
            // 
            this.textWebHook.Animated = true;
            this.textWebHook.BackColor = System.Drawing.Color.Transparent;
            this.textWebHook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textWebHook.BorderRadius = 5;
            this.textWebHook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textWebHook.DefaultText = "";
            this.textWebHook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textWebHook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textWebHook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textWebHook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(196)))));
            this.textWebHook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textWebHook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textWebHook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.Location = new System.Drawing.Point(241, 270);
            this.textWebHook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textWebHook.Name = "textWebHook";
            this.textWebHook.PasswordChar = '\0';
            this.textWebHook.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(146)))), ((int)(((byte)(165)))));
            this.textWebHook.PlaceholderText = "WebHook";
            this.textWebHook.SelectedText = "";
            this.textWebHook.Size = new System.Drawing.Size(200, 29);
            this.textWebHook.TabIndex = 72;
            this.textWebHook.TextChanged += new System.EventHandler(this.textWebHook_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::DiscordPing.Properties.Resources.heart_love;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(93, 68);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(262, 196);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(454, 530);
            this.Controls.Add(this.textWebHook);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.sendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Webhook Messager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button sendButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel delayLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textMessage;
        private Guna.UI2.WinForms.Guna2TextBox textWebHook;
    }
}


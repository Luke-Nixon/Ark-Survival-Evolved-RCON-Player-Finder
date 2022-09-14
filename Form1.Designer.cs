namespace Ark_Survival_Evolved_RCON_Player_Finder
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
            this.tab_page_config = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox_set_name = new System.Windows.Forms.TextBox();
            this.label_set_name = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_page_config.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_page_config
            // 
            this.tab_page_config.Controls.Add(this.richTextBox1);
            this.tab_page_config.Controls.Add(this.textBox_set_name);
            this.tab_page_config.Controls.Add(this.label_set_name);
            this.tab_page_config.Controls.Add(this.button_connect);
            this.tab_page_config.Location = new System.Drawing.Point(4, 29);
            this.tab_page_config.Name = "tab_page_config";
            this.tab_page_config.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page_config.Size = new System.Drawing.Size(1532, 851);
            this.tab_page_config.TabIndex = 0;
            this.tab_page_config.Text = "Config";
            this.tab_page_config.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(291, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1235, 842);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // textBox_set_name
            // 
            this.textBox_set_name.Location = new System.Drawing.Point(142, 49);
            this.textBox_set_name.Name = "textBox_set_name";
            this.textBox_set_name.Size = new System.Drawing.Size(125, 27);
            this.textBox_set_name.TabIndex = 4;
            // 
            // label_set_name
            // 
            this.label_set_name.AutoSize = true;
            this.label_set_name.Location = new System.Drawing.Point(10, 52);
            this.label_set_name.Name = "label_set_name";
            this.label_set_name.Size = new System.Drawing.Size(126, 20);
            this.label_set_name.TabIndex = 5;
            this.label_set_name.Text = "Your Player Name";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(142, 94);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(94, 29);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_page_config);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1540, 884);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 908);
            this.Controls.Add(this.tabControl1);
            this.Name = "Ark Player Finder";
            this.Text = "Ark Player Finder";
            this.tab_page_config.ResumeLayout(false);
            this.tab_page_config.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private TabPage tab_page_config;
        private TextBox textBox_set_name;
        private Label label_set_name;
        private Button button_connect;
        private TabControl tabControl1;
        private RichTextBox richTextBox1;
    }
}
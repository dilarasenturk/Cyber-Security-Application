namespace Görsel_Programlama_2_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialListBox2 = new MaterialSkin.Controls.MaterialListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.ımageList1;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(111, 35);
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1095, 562);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialTextBox2);
            this.tabPage1.Controls.Add(this.materialTextBox1);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.ImageKey = "pngwing.com.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1087, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Password Creator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel9.Location = new System.Drawing.Point(705, 361);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(59, 19);
            this.materialLabel9.TabIndex = 5;
            this.materialLabel9.Text = "material";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel2.Location = new System.Drawing.Point(221, 361);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(122, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Password Check:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.Location = new System.Drawing.Point(221, 130);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(151, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Generated Password:";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(414, 346);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(239, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(414, 116);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(239, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(453, 235);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Create Password";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.materialTextBox6);
            this.tabPage2.Controls.Add(this.materialButton8);
            this.tabPage2.Controls.Add(this.materialButton9);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialButton2);
            this.tabPage2.Controls.Add(this.materialTextBox4);
            this.tabPage2.Controls.Add(this.materialTextBox3);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.materialComboBox1);
            this.tabPage2.Controls.Add(this.materialProgressBar1);
            this.tabPage2.ImageKey = "encryption.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1087, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encryption Tool";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel11.Location = new System.Drawing.Point(590, 234);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(75, 19);
            this.materialLabel11.TabIndex = 12;
            this.materialLabel11.Text = "Password:";
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.AnimateReadOnly = false;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox6.LeadingIcon = null;
            this.materialTextBox6.Location = new System.Drawing.Point(723, 219);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(231, 50);
            this.materialTextBox6.TabIndex = 11;
            this.materialTextBox6.Text = "";
            this.materialTextBox6.TrailingIcon = null;
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton8.Depth = 0;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = null;
            this.materialButton8.Location = new System.Drawing.Point(788, 314);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton8.Size = new System.Drawing.Size(119, 36);
            this.materialButton8.TabIndex = 10;
            this.materialButton8.Text = "Encrypt File";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(788, 132);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(106, 36);
            this.materialButton9.TabIndex = 9;
            this.materialButton9.Text = "Select File";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel6.Location = new System.Drawing.Point(22, 234);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(55, 19);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Decrypt";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel5.Location = new System.Drawing.Point(23, 132);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(54, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Encrypt";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(764, 158);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(1, 0);
            this.materialLabel4.TabIndex = 6;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(126, 314);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(160, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Start Encryption";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(135, 219);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(141, 50);
            this.materialTextBox4.TabIndex = 4;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(135, 121);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(141, 50);
            this.materialTextBox3.TabIndex = 3;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(587, 27);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(1, 0);
            this.materialLabel3.TabIndex = 2;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(341, 122);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(137, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(59, 440);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(267, 5);
            this.materialProgressBar1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.materialLabel8);
            this.tabPage5.Controls.Add(this.materialLabel7);
            this.tabPage5.Controls.Add(this.materialButton6);
            this.tabPage5.Controls.Add(this.materialButton5);
            this.tabPage5.Controls.Add(this.materialButton4);
            this.tabPage5.Controls.Add(this.materialListBox2);
            this.tabPage5.Controls.Add(this.progressBar1);
            this.tabPage5.ImageKey = "pngwing.com (1).png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1087, 519);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Malware Detection";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel8.Location = new System.Drawing.Point(627, 208);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(66, 19);
            this.materialLabel8.TabIndex = 20;
            this.materialLabel8.Text = "Delected:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel7.Location = new System.Drawing.Point(627, 110);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(113, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Selected Folder:";
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(340, 387);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(80, 36);
            this.materialButton6.TabIndex = 18;
            this.materialButton6.Text = "Remove";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(219, 387);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(64, 36);
            this.materialButton5.TabIndex = 17;
            this.materialButton5.Text = "Scan";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(53, 387);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(117, 36);
            this.materialButton4.TabIndex = 16;
            this.materialButton4.Text = "Scan Folder";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialListBox2
            // 
            this.materialListBox2.BackColor = System.Drawing.Color.White;
            this.materialListBox2.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox2.Depth = 0;
            this.materialListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox2.Location = new System.Drawing.Point(30, 110);
            this.materialListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox2.Name = "materialListBox2";
            this.materialListBox2.SelectedIndex = -1;
            this.materialListBox2.SelectedItem = null;
            this.materialListBox2.Size = new System.Drawing.Size(557, 254);
            this.materialListBox2.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(555, 25);
            this.progressBar1.TabIndex = 8;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "firewall.png");
            this.ımageList1.Images.SetKeyName(1, "pngwing.com (1).png");
            this.ımageList1.Images.SetKeyName(2, "privacy-policy.png");
            this.ımageList1.Images.SetKeyName(3, "wireless-network-icon.png");
            this.ımageList1.Images.SetKeyName(4, "encryption.png");
            this.ımageList1.Images.SetKeyName(5, "pngwing.com.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1101, 629);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "MULTY SEC";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialListBox materialListBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}


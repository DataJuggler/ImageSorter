

#region using statements


#endregion

namespace ImageSorter
{

    #region class MainForm
    /// <summary>
    /// This is the designer for this form.
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputControl;
        private DataJuggler.Win.Controls.Button StartButton;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Label StatusLabel;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.OutputControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.StartButton = new DataJuggler.Win.Controls.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FastFactorControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.FastFactorInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceControl
            // 
            this.SourceControl.BackColor = System.Drawing.Color.Transparent;
            this.SourceControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.SourceControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.SourceControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SourceControl.ButtonImage")));
            this.SourceControl.ButtonWidth = 48;
            this.SourceControl.DarkMode = false;
            this.SourceControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SourceControl.Editable = true;
            this.SourceControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SourceControl.Filter = null;
            this.SourceControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.HideBrowseButton = false;
            this.SourceControl.LabelBottomMargin = 0;
            this.SourceControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SourceControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.LabelText = "Source Folder:";
            this.SourceControl.LabelTopMargin = 0;
            this.SourceControl.LabelWidth = 140;
            this.SourceControl.Location = new System.Drawing.Point(47, 28);
            this.SourceControl.Name = "SourceControl";
            this.SourceControl.OnTextChangedListener = null;
            this.SourceControl.OpenCallback = null;
            this.SourceControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceControl.SelectedPath = null;
            this.SourceControl.Size = new System.Drawing.Size(700, 32);
            this.SourceControl.StartPath = null;
            this.SourceControl.TabIndex = 0;
            this.SourceControl.TextBoxBottomMargin = 0;
            this.SourceControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SourceControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SourceControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.TextBoxTopMargin = 0;
            this.SourceControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // OutputControl
            // 
            this.OutputControl.BackColor = System.Drawing.Color.Transparent;
            this.OutputControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.OutputControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.OutputControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("OutputControl.ButtonImage")));
            this.OutputControl.ButtonWidth = 48;
            this.OutputControl.DarkMode = false;
            this.OutputControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.OutputControl.Editable = true;
            this.OutputControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.OutputControl.Filter = null;
            this.OutputControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputControl.HideBrowseButton = false;
            this.OutputControl.LabelBottomMargin = 0;
            this.OutputControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.OutputControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputControl.LabelText = "Output Folder:";
            this.OutputControl.LabelTopMargin = 0;
            this.OutputControl.LabelWidth = 140;
            this.OutputControl.Location = new System.Drawing.Point(47, 88);
            this.OutputControl.Name = "OutputControl";
            this.OutputControl.OnTextChangedListener = null;
            this.OutputControl.OpenCallback = null;
            this.OutputControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputControl.SelectedPath = null;
            this.OutputControl.Size = new System.Drawing.Size(700, 32);
            this.OutputControl.StartPath = null;
            this.OutputControl.TabIndex = 1;
            this.OutputControl.TextBoxBottomMargin = 0;
            this.OutputControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.OutputControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.OutputControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputControl.TextBoxTopMargin = 0;
            this.OutputControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.ButtonText = "Start";
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StartButton.Location = new System.Drawing.Point(627, 368);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 48);
            this.StartButton.TabIndex = 2;
            this.StartButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.StartButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(47, 324);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(700, 23);
            this.Graph.TabIndex = 3;
            this.Graph.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(47, 295);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(700, 23);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FastFactorControl
            // 
            this.FastFactorControl.BackColor = System.Drawing.Color.Transparent;
            this.FastFactorControl.BottomMargin = 0;
            this.FastFactorControl.Editable = true;
            this.FastFactorControl.Encrypted = false;
            this.FastFactorControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FastFactorControl.Inititialized = true;
            this.FastFactorControl.LabelBottomMargin = 0;
            this.FastFactorControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FastFactorControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FastFactorControl.LabelText = "* Fast Factor:";
            this.FastFactorControl.LabelTopMargin = 0;
            this.FastFactorControl.LabelWidth = 140;
            this.FastFactorControl.Location = new System.Drawing.Point(47, 148);
            this.FastFactorControl.MultiLine = false;
            this.FastFactorControl.Name = "FastFactorControl";
            this.FastFactorControl.OnTextChangedListener = null;
            this.FastFactorControl.PasswordMode = false;
            this.FastFactorControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FastFactorControl.Size = new System.Drawing.Size(200, 32);
            this.FastFactorControl.TabIndex = 5;
            this.FastFactorControl.TextBoxBottomMargin = 0;
            this.FastFactorControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.FastFactorControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.FastFactorControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FastFactorControl.TextBoxTopMargin = 0;
            this.FastFactorControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // FastFactorInfo
            // 
            this.FastFactorInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FastFactorInfo.ForeColor = System.Drawing.Color.LemonChiffon;
            this.FastFactorInfo.Location = new System.Drawing.Point(47, 193);
            this.FastFactorInfo.Name = "FastFactorInfo";
            this.FastFactorInfo.Size = new System.Drawing.Size(700, 47);
            this.FastFactorInfo.TabIndex = 6;
            this.FastFactorInfo.Text = "* Optional - enter a number such as 4, and every 4th pixel is inspected.\r\nThis is" +
    " much faster, although not as accurate.\r\n";
            this.FastFactorInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ImageSorter.Properties.Resources.BlackImage;
            this.ClientSize = new System.Drawing.Size(785, 441);
            this.Controls.Add(this.FastFactorInfo);
            this.Controls.Add(this.FastFactorControl);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutputControl);
            this.Controls.Add(this.SourceControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Sorter 1.1.1";
            this.ResumeLayout(false);

            }
        #endregion

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl FastFactorControl;
        private System.Windows.Forms.Label FastFactorInfo;
    }
    #endregion

}

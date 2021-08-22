
namespace ImageSorter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.OutputControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.StartButton = new DataJuggler.Win.Controls.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceControl
            // 
            this.SourceControl.BackColor = System.Drawing.Color.Transparent;
            this.SourceControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
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
            this.SourceControl.Location = new System.Drawing.Point(47, 47);
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
            this.OutputControl.Location = new System.Drawing.Point(47, 132);
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
            this.StartButton.Location = new System.Drawing.Point(627, 293);
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
            this.Graph.Location = new System.Drawing.Point(47, 236);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(700, 23);
            this.Graph.TabIndex = 3;
            this.Graph.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(47, 195);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(700, 23);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ImageSorter.Properties.Resources.BlackImage;
            this.ClientSize = new System.Drawing.Size(785, 367);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutputControl);
            this.Controls.Add(this.SourceControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Directory Sorter";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputControl;
        private DataJuggler.Win.Controls.Button StartButton;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Label StatusLabel;
    }
}


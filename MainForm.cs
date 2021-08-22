

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Win.Controls;
using DataJuggler.PixelDatabase;
using DataJuggler.UltimateHelper;

#endregion

namespace ImageSorter
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this app
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region StartButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'StartButton' is clicked.
            /// </summary>
            private void StartButton_Click(object sender, EventArgs e)
            {
                // get the values selected
                string outputFolder = OutputControl.Text;
                string sourceFolder = SourceControl.Text;
                int fastFactor = 0;

                // If the strings outputFolder and sourceFolder both exist
                if (TextHelper.Exists(outputFolder, sourceFolder))
                {
                    // if a value is entered in FastFactorControl
                    if (FastFactorControl.HasText)
                    {
                        // Get the int value
                        fastFactor = FastFactorControl.IntValue;
                    }

                    // Set the Text
                    StatusLabel.Text = "Analyzing images, please be patient. This may take several minutes or longer.";

                    // Refresh before starting
                    this.Refresh();
                    Application.DoEvents();

                    // Now perform the sort
                    ImageClassifier.Sort(sourceFolder, outputFolder, UpdateStatus, fastFactor);

                    // Refresh Again
                    this.Refresh();
                    Application.DoEvents();
                }

                // Set the Text
                StatusLabel.Text = "Done";
                Graph.Visible = false;
            }
        #endregion

        #endregion

        #region Methods
            
            #region UpdateStatus(string message, int pixelsUpdated)
            /// <summary>
            /// This method Update Status
            /// </summary>
            public void UpdateStatus(string message, int pixelsUpdated)
            {
                // If the message string exists
                if (TextHelper.Exists(message))
                {
                    // Show the graph
                    Graph.Visible = true;

                    // if this is a Total or SetGraphMax
                    if ((message.Contains("Total")) || (message.Contains("SetGraphMax")))
                    {
                        // Set the Max
                        this.Graph.Maximum = pixelsUpdated;
                        StatusLabel.Text = "Analyzing images, this may take a while...";
                    }
                    else
                    {
                        // Setup the Graph
                        this.Graph.Value = pixelsUpdated;

                        // Set our message
                        StatusLabel.Text = message;
                    }

                    // Refresh everything
                    this.Refresh();
                    Application.DoEvents();
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}

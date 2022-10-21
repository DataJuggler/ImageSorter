# ImageSorter
Image Sorter makes it easy to sort an entire directory of images by color.

Update 10.21.2022: This project has been udpated to .NET7. To run this version, you will need Visual Studio 2022 Preview, which is available here:
https://visualstudio.microsoft.com/vs/preview/

Here is a video I made a couple of days ago which includes Image sorter and Sub Image Creator:
https://youtu.be/XUAOjQIoHhQ

Here is another short video:
https://youtu.be/YsL96hmkAqw

This project uses the following DataJuggler Nuget packages:
DataJuggler.Win.Controls
DataJuggler.PixelDatabase
DataJuggler.UltimateHelper

using DataJuggler.PixelDatabase;
using DataJuggler.UltimateHelper;
using DataJuggler.Win.Controls;

    // get the values selected
    string outputFolder = OutputControl.Text;
    string sourceFolder = SourceControl.Text;

    // If the strings outputFolder and sourceFolder both exist
    if (TextHelper.Exists(outputFolder, sourceFolder))
    {
        // Now perform the sort
        ImageClassifier.Sort(sourceFolder, outputFolder, UpdateStatus);
    }
    
UpdateStatus is a method for a delegate to callback from long operations:

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
            }
            else
            {
                // Set the Graph value
                this.Graph.Value = pixelsUpdated;

                // Set our message
                StatusLabel.Text = message;
            }
        }
    }
    
The UI is a very simple form with two LabelTextBoxBrowserControls, which make it simple to create a file or folder dialog.

ImageClassifier is part of DataJuggler.PixelDatabase, and the way it works is it finds the average red, average green and average blue values.
Next the Primary Color (red, green or blue) is determined, and also the Secondary and Minority colors are set.

Finally a new filename is created for each ImageClassification, and the new name will be in the format of [PrimaryColor][SecondaryColor][MinorityColor]
followed by the Red Green and Blue values, converted to text, plus a partial Guid to ensure uniqueness in a folder.

A few output file names:
bluegreenredbagaaaaaa.e5086356-0d4.png
redgreenbluebedbdgahj.25986e80-0ba.png
greenredbluebgbbcabaa.e7633860-ad9.png

The 9 digits between the minority color and partial guid, contains the Average RGB values for an image.
In this example:
greenredbluebgbbcabaa.e7633860-ad9.png
bgbbcabaa - translates to:

Green - bgb
Red - bca
Blue - baa

Using the values here, you can decipher this if desired
https://github.com/DataJuggler/PixelDatabase/blob/master/ImageClassifier.cs

Which translates to:
Green - 161
Red - 120
Blue - 100

The Fast Factor value speeds up the sorting, however you do lose a little accuracy possibly depending on your images.





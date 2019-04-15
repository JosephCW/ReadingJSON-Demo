using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingJSON
{
    public partial class Form1 : Form
    {
        JObject parsedJson;

        public Form1()
        {
            InitializeComponent();
            // Read in the json via file or w/e means necessary
            string demoFileLocation = @"c:\wcj\demoJSON.json";
            string demoFileContents = File.ReadAllText(demoFileLocation);

            // Parse it using the Newtonsoft.Json library
            parsedJson = JObject.Parse(demoFileContents);
        }

        private void loadButtonPressed(object sender, EventArgs e)
        {
            // Different ways to get specific values
            // Chaining dictionary calls
            Debug.WriteLine(parsedJson["widget"]["text"]["data"]);

            JToken imageToken = parsedJson["widget"]["image"];
            Debug.WriteLine(imageToken);

            Debug.WriteLine(imageToken["alignment"]);
        }
    }
}

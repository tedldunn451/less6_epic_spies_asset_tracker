using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace less6_epic_spies_asset_tracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Create new empty arrays and add them to ViewState to maintain "state" after each button click
                int[] rigged = new int[0];
                ViewState.Add("rigged", rigged);

                double[] acts = new double[0];
                ViewState.Add("acts", acts);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            // Put values stored in ViewState into arrays
            int[] rigged = (int[])ViewState["rigged"];
            double[] acts = (double[])ViewState["acts"];

            // Increase the size of each array by 1
            Array.Resize(ref rigged, rigged.Length + 1);
            Array.Resize(ref acts, acts.Length + 1);

            // Store the values entered by the user in the text boxes into their appropriate array
            rigged[rigged.Length - 1] = int.Parse(riggedTextBox.Text);
            acts[acts.Length - 1] = double.Parse(actsTextBox.Text);

            // Store updated arrays back into ViewState to update "state" of page
            ViewState["rigged"] = rigged;
            ViewState["acts"] = acts;

            // Display results into labels on screen
            riggedLabel.Text = "Total Elections Rigged: " + rigged.Sum().ToString();
            averageActsLabel.Text = "Average Acts of Subterfuge per Asset: " + acts.Average().ToString("N2");
            assetNameLabel.Text = "(Last Asset you Added: " + nameTextBox.Text + ")";

            // Clear out text from the text boxes
            nameTextBox.Text = "";
            riggedTextBox.Text = "";
            actsTextBox.Text = "";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] acts = (int[])ViewState["Acts"];

            // resize, use assets for all 3 (not the best method)
            int newLength = assets.Length + 1;
            Array.Resize(ref assets, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref acts, newLength);

            int newIndex = assets.GetUpperBound(0);

            assets[newIndex] = assetsTextBox.Text;
            elections[newIndex] = int.Parse(electionsTextBox.Text);
            acts[newIndex] = int.Parse(actsTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            // print result label
            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you added: {2})",
                elections.Sum(), acts.Average(), assets[newIndex]);

            // clear out text boxes
            assetsTextBox.Text = "";
            electionsTextBox.Text = "";
            actsTextBox.Text = "";
        }
    }
}
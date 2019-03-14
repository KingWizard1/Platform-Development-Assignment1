using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace PDA1.UI
{
    /// <summary>UI panel for game login.</summary>
    public class UILoginPanel : UIPanel
    {

        public InputField usernameField;
        public InputField passwordField;

        // ----------------------------------------------------- //

        public void DoLogin()
        {

            var user = usernameField.text;
            var pass = passwordField.text;

            Debug.Log("Do Login!");

        }

        // ----------------------------------------------------- //


        // ----------------------------------------------------- //


    }

}
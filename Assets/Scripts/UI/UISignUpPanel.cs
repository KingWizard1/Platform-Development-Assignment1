using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PDA1.UI
{
    /// <summary>UI panel for registering an account.</summary>
    public class UISignUpPanel : UIPanel
    {

        public InputField emailField;
        public InputField usernameField;
        public InputField passwordField;
        public InputField verifyPasswordField;


        // ----------------------------------------------------- //

        public void DoSignUp()
        {

            Debug.Log("Doing sign up...");


        }

        // ----------------------------------------------------- //

    }

}
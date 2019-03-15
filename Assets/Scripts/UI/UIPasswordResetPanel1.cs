using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PDA1.UI
{
    /// <summary>UI panel for resetting the password on a user account (Part 1)</summary>
    public class UIPasswordResetPanel1 : UIPanel
    {

        public InputField emailField;

        public Text errorText;

        // ------------------------------------------------- //

        private void Start()
        {
            errorText.text = string.Empty;
        }

        private void OnEnable()
        {
            errorText.text = string.Empty;
        }

        // ------------------------------------------------- //

        public void SendResetCode()
        {
            // Validate inputs
            if (string.IsNullOrEmpty(emailField.text.Trim())) {
                errorText.text = "Please enter your e-mail address.";
                return;
            }

            // PHP GetUsernameFromEmail
            var response = DBContext.GetUsernameFromEmail(emailField.text);

            // Show error if no user found
            if (response == "No user found") {
                errorText.text = "Account does not exist.";
                return;
            }


            // Now we have username
            var username = response;

            Debug.Log("Sending reset code...");




        }

        // ------------------------------------------------- //

    }

}
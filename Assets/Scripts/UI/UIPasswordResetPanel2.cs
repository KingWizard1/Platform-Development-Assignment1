using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PDA1.UI
{
    /// <summary>UI panel for resetting the password on a user account (Part 2)</summary>
    public class UIPasswordResetPanel2 : UIPanel
    {

        public InputField codeField;
        public InputField newPasswordField;
        public InputField verifyPasswordField;


        // ----------------------------------------------------- //

        public void DoPasswordReset()
        {

            Debug.Log("Resetting account...");



        }

        // ----------------------------------------------------- //

    }

}
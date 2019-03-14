using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PDA1.UI
{
    /// <summary>Provides top-level functionality for handling and switching panels.</summary>
    public class UIController : MonoBehaviour
    {

        public UILoginPanel _LoginPanel;

        public UISignUpPanel _SignUpPanel;

        public UIPasswordResetPanel1 _PasswordResetPanel1;

        public UIPasswordResetPanel2 _PasswordResetPanel2;


        // ----------------------------------------------------- //


        // ----------------------------------------------------- //

        // Ideally, I'd use a single method that accepts an enum parameter
        // to determine which panel to show, but the Button component on
        // 

        public void SwitchToSignUpPanel()
        {
            HideAllPanels();
            _SignUpPanel.Show();
        }

        public void SwitchToResetPanel1()
        {
            HideAllPanels();
            _PasswordResetPanel1.Show();
        }

        public void SwitchToResetPanel2()
        {
            HideAllPanels();
            _PasswordResetPanel2.Show();
        }

        public void SwitchToLoginPanel()
        {
            HideAllPanels();
            _LoginPanel.Show();
        }

        // ----------------------------------------------------- //

        public void HideAllPanels()
        {

            _LoginPanel.Hide();
            _SignUpPanel.Hide();
            _PasswordResetPanel1.Hide();
            _PasswordResetPanel2.Hide();

        }

        // ----------------------------------------------------- //

    }

}
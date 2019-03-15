using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace PDA1
{

    public static class DBContext
    {
        private const string baseURL = "http://localhost/SQueaLsystem/";

        // ------------------------------------------------- //

        public static string CreateUser(string username, string password, string email)
        {
            // Link to PHP
            string url = baseURL + "addUser.php";

            //Info to send to the POST variables in PHP
            WWWForm insetUserForm = new WWWForm();
            insetUserForm.AddField("usernamePost", username);
            insetUserForm.AddField("passwordPost", password);
            insetUserForm.AddField("emailPost", email);

            // Send info to PHP
            WWW www = new WWW(url, insetUserForm);

            while (!www.isDone)
                Thread.Sleep(1);

            if (www.error != null)
                Debug.Log("PHP Error: \"" + www.error + "\"");


            Debug.Log("PHP Response: \"" + www.text + "\"");
            return www.text;


        }

        // ------------------------------------------------- //

        public static string Login(string username, string password)
        {
            // Link to PHP
            string url = baseURL + "login.php";

            //Info to send to the POST variables in PHP
            WWWForm loginForm = new WWWForm();
            loginForm.AddField("usernamePost", username);
            loginForm.AddField("passwordPost", password);

            // Send info to PHP
            WWW www = new WWW(url, loginForm);

            while (!www.isDone)
                Thread.Sleep(1);

            if (www.error != null)
                Debug.Log("PHP Error: \"" + www.error + "\"");


            Debug.Log("PHP Response: \"" + www.text + "\"");

            return www.text;


        }

        // ------------------------------------------------- //

        public static string GetUsernameFromEmail(string email)
        {
            // Link to PHP
            string url = baseURL + "getUsernameFromEmail.php";

            //Info to send to the POST variables in PHP
            WWWForm loginForm = new WWWForm();
            loginForm.AddField("emailPost", email);

            // Send info to PHP
            WWW www = new WWW(url, loginForm);

            while (!www.isDone)
                Thread.Sleep(1);

            if (www.error != null)
                Debug.Log("PHP Error: \"" + www.error + "\"");

            Debug.Log("PHP Response: \"" + www.text.Trim() + "\"");

            // Should be the username associated with the given email address.
            return www.text.Trim();


        }


    }

}
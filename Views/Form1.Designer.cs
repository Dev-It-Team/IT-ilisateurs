using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace IT_ilisateurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "It-itlisateur";
            this.StartPosition = FormStartPosition.CenterScreen;

            //Initialize first entry for user: login
            Label UserLabel = new Label();
            UserLabel.Text = "Identifiant";
            this.Controls.Add(UserLabel);
            UserLabel.Location = new Point(350, 100);
            TextBox UserTextBox = new TextBox();
            this.Controls.Add(UserTextBox);
            UserTextBox.Location = new Point(350,125);

            

            //Initialize second entry for user: password
            Label PasswordLabel = new Label();
            PasswordLabel.Text = "Mot de Passe";
            this.Controls.Add(PasswordLabel);
            PasswordLabel.Location = new Point(350, 175);
            TextBox PasswordTextBox = new TextBox();
            this.Controls.Add(PasswordTextBox);
            PasswordTextBox.Location = new Point(350,200);
            
            //Initialize connexion button
            Button ConnexionButton = new Button();
            this.Controls.Add(ConnexionButton);
            ConnexionButton.Text = "Se connecter";
            ConnexionButton.AutoSize = true;
            ConnexionButton.Location = new Point(350,300);
            ConnexionButton.MouseClick += ConnexionButton_Click;

            void ConnexionButton_Click(object sender, EventArgs e)
            {
                InitiateConnexion(UserTextBox.Text, PasswordTextBox.Text);
            }

            
        }

    }
}


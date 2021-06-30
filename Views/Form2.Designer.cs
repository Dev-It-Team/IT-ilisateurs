using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace IT_ilisateurs
{
    partial class Form2
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
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "It-itlisateur";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //Initialize action button
            Button CreateUserButton = new Button();
            this.Controls.Add(CreateUserButton);
            CreateUserButton.Text = "Créer un utilisateur";
            CreateUserButton.AutoSize = true;
            CreateUserButton.Location = new Point(200,50);

            //Initialize action button
            Button ModifyUserButton = new Button();
            this.Controls.Add(ModifyUserButton);
            ModifyUserButton.Text = "Modifier un utilisateur";
            ModifyUserButton.AutoSize = true;
            ModifyUserButton.Location = new Point(400,50);

            //Initialize action button
            Button DeleteUserButton = new Button();
            this.Controls.Add(DeleteUserButton);
            DeleteUserButton.Text = "Supprimer un utilisateur";
            DeleteUserButton.AutoSize = true;
            DeleteUserButton.Location = new Point(600,50);
            // DeleteUserButton.MouseClick += SetDeleteInterfaceVisible;

            //Initialize second entry for user: password
            Label UserToDeleteLabel = new Label();
            UserToDeleteLabel.Text = "Utilisateur à supprimer";
            UserToDeleteLabel.AutoSize = true;
            this.Controls.Add(UserToDeleteLabel);
            UserToDeleteLabel.Location = new Point(375, 200);
            UserToDeleteLabel.Visible = false;
            
            TextBox UserToDeleteTextBox = new TextBox();
            this.Controls.Add(UserToDeleteTextBox);
            UserToDeleteTextBox.Location = new Point(375,225);
            UserToDeleteTextBox.Visible = false;

            //Initialize action button
            Button ActionDeleteUserButton = new Button();
            this.Controls.Add(ActionDeleteUserButton);
            ActionDeleteUserButton.Text = "Supprimer l'utilisateur";
            ActionDeleteUserButton.AutoSize = true;
            ActionDeleteUserButton.Location = new Point(375,250);
            ActionDeleteUserButton.MouseClick += ActionDeleteUserButton_Click;
            ActionDeleteUserButton.Visible = false;

            void ActionDeleteUserButton_Click(object sender, EventArgs e)
            {
                DeleteUser(UserToDeleteTextBox.Text);
            }
            // void SetDeleteInterfaceVisible(object sender, EventArgs e)
            // {
            //     ActivateDeleteInterface();
            // }
            // void ActivateDeleteInterface()
            // {
            //     UserToDeleteLabel.Visible = true;
            //     UserToDeleteTextBox.Visible = true;
            //     ActionDeleteUserButton.Visible = true;
            //     Application.DoEvents();
            // }
            
        }

    }
}
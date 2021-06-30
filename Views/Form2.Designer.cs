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
            CreateUserButton.MouseClick += OpenCreateForm;

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
            DeleteUserButton.MouseClick += OpenDeleteForm;            
            
        }

    }
}
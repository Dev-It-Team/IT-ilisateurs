using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace IT_ilisateurs
{
    partial class FormModify
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
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Text = "It-itlisateur";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            Label NameLabel = new Label();
            NameLabel.Text = "Nom:";
            this.Controls.Add(NameLabel);
            NameLabel.Location = new Point(375,50);
            TextBox NameTextBox = new TextBox();
            this.Controls.Add(NameTextBox);
            NameTextBox.Location = new Point(375,75);

            Label FirstNameLabel = new Label();
            FirstNameLabel.Text = "Prénom:";
            this.Controls.Add(FirstNameLabel);
            TextBox FirstNameTextBox = new TextBox();
            FirstNameLabel.Location = new Point(375,125);
            this.Controls.Add(FirstNameTextBox);
            FirstNameTextBox.Location = new Point(375,150);

            Label EmailLabel = new Label();
            EmailLabel.Text = "Email:";
            this.Controls.Add(EmailLabel);
            TextBox EmailTextBox = new TextBox();
            EmailLabel.Location = new Point(375,200);
            this.Controls.Add(EmailTextBox);
            EmailTextBox.Location = new Point(375,225);

            Label PasswordLabel = new Label();
            PasswordLabel.Text = "Mot de passe:";
            this.Controls.Add(PasswordLabel);
            TextBox PasswordTextBox = new TextBox();
            PasswordLabel.Location = new Point(375,275);
            this.Controls.Add(PasswordTextBox);
            PasswordTextBox.Location = new Point(375,300);

            Label BirthdateLabel = new Label();
            BirthdateLabel.Text = "Date de naissance (YYYY-MM-DD):";
            this.Controls.Add(BirthdateLabel);
            BirthdateLabel.AutoSize = true;
            TextBox BirthdateTextBox = new TextBox();
            BirthdateLabel.Location = new Point(375,350);
            this.Controls.Add(BirthdateTextBox);
            BirthdateTextBox.Location = new Point(375,375);

            Label AdresseLabel = new Label();
            AdresseLabel.Text = "Adresse:";
            this.Controls.Add(AdresseLabel);
            TextBox AddressTextBox = new TextBox();
            AdresseLabel.Location = new Point(375,425);
            this.Controls.Add(AddressTextBox);
            AddressTextBox.Location = new Point(375,450);

            Label UserFlag = new Label();
            this.Controls.Add(UserFlag);
            UserFlag.Text = "Choisir un type d'utilisateur:";
            UserFlag.Location = new Point(375,500);
            UserFlag.AutoSize = true;
            ComboBox UserFlagComboBox = new ComboBox();
            UserFlagComboBox.Items.AddRange(new object[] {"User","Restaurant","DeliveryDriver","Tech","Comm"});
            this.Controls.Add(UserFlagComboBox);
            UserFlagComboBox.Location = new Point(375,525);

            //Initialize action button
            Button ActionModifyUserButton = new Button();
            this.Controls.Add(ActionModifyUserButton);
            ActionModifyUserButton.Text = "Modifier l'utilisateur";
            ActionModifyUserButton.AutoSize = true;
            ActionModifyUserButton.Location = new Point(375,600);
            ActionModifyUserButton.MouseClick += ActionModifyUserButton_Click;

            void ActionModifyUserButton_Click(object sender, EventArgs e)
            {
                ModifyUser(NameTextBox.Text, FirstNameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text, BirthdateTextBox.Text, AddressTextBox.Text, UserFlagComboBox.Text);
            }
        }

    }
}
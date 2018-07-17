using System;
using System.Windows.Forms;
using System.IO;

namespace RandomStoryGenerator
{
    public partial class Form1 : Form
    {
        //All possible text that can be generated.
        string[] whenText = { "Once upon a time, ", "Many moons ago, ", "Somewhere in the not too distant future, ", "Yesterday... ", "In the year 20XX, ", "Some amount of time in the past, " };
        string[] whereText = { "In a galaxy far, far away... ", "In an enchanted forest... ", "In your home town... ", "In some nondescript location... ", "Within a peaceful village ", "Inside your mind... " };
        string[] whoText = { "The apples and the oranges ", "The forces of good and evil ", "You and your mother-in-law ", "A man named Phil and a woman named Jane ", "Donald Trump and Barack Obama ", "Dogs and cats " };
        string[] whatText = { "Fought an epic battle over the entire land ", "Had a very petty dispute ", "Partook in a tea party ", "Went off to college together ", "Played a game of chess ", "Discovered a way to travel through time " };
        string[] whyText = { "To prove that one side was superior. ", "Because they got their wittle feelings hurt. ", "In order to feel like pretty princesses! ", "So they could earn the education they so strongly desired. ", "To see who was the smartest one of them all. ", "In order to change something about the past that they regretted. " };
        string[] endingText = { "In the end, both sides were superior becuase they were really really strong.", "But then they got over it.", "In doing so, both parties felt incredibly accomplished.", "Everyone involved became a smarter person in the end.", "But both sides had equal intellect, so it ended in a truce.", "But then everybody died, so it was all for nothing."};


        public Form1()
        {
            InitializeComponent();
        }

        //When the user presses the "When?" button...
        private void WhenButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(0, whenText.Length); // only pick between zero and the length of the text array.
            whenBox.Text = whenText[rnd]; // add the randomly chosen text to the "When?" text box.
        }

        //When the user presses the "Where?" button...
        private void WhereButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(0, whereText.Length); // only pick between zero and the length of the text array.
            whereBox.Text = whereText[rnd]; // add the randomly chosen text to the "Where?" text box.
        }

        //When the user presses the "Who?" button...
        private void WhoButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(0, whoText.Length); // only pick between zero and the length of the text array.
            whoBox.Text = whoText[rnd]; // add the randomly chosen text to the "Who?" text box.
        }

        //When the user presses the "What?" button...
        private void WhatButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(0, whatText.Length); // only pick between zero and the length of the text array.
            whatBox.Text = whatText[rnd]; // add the randomly chosen text to the "What?" text box.
        }

        //When the user presses the "Why?" button...
        private void WhyButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(0, whyText.Length); // only pick between zero and the length of the text array.
            whyBox.Text = whyText[rnd]; // add the randomly chosen text to the "Why?" text box.
        }

        //When the user presses the "Ending" button...
        private void EndingButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(0, endingText.Length); // only pick between zero and the length of the text array.
            endingBox.Text = endingText[rnd]; // add the randomly chosen text to the "Ending" text box.
        }

        //When the user presses the "Export Your Masterpiece!" button...
        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Environment.UserName; // get the name of the user as seen in Windows.

                if (!File.Exists("C:\\Users\\" + username + "\\Desktop\\NewStory.doc")) // if no NewStory.doc file is present at Desktop.
                {
                    //Create a .doc file on the user's desktop, including all the text present in the various boxes. Give due credits at the end.
                    File.WriteAllText("C:\\Users\\" + username + "\\Desktop\\NewStory.doc", whenBox.Text + "\n \n" + whereBox.Text + "\n \n" + whoBox.Text
                        + "\n \n" + whatBox.Text + "\n \n" + whyBox.Text + "\n \n" + endingBox.Text + "\n \n \n \n \nA story created by " +
                        username + " with some help from Lance Talbert's Story Generator.");

                    //Display a dialogue box saying the story was created and where they can find it.
                    MessageBox.Show("Your story has been successfully created! Story can be found on your Desktop.", "Yahoo!");
                }
                else //if NewStory.doc is present at Desktop.
                {
                    //Display a dialogue box saying a file with the exact name is already present at location
                    var userInput = MessageBox.Show("Story already created at location. Overwrite?", "Alert!", MessageBoxButtons.YesNo);
                    
                    if (userInput == DialogResult.Yes) // user chooses to overwrite NewStory.doc
                    {
                        //Overwrite the original NewStory.doc file.
                        File.WriteAllText("C:\\Users\\" + username + "\\Desktop\\NewStory.doc", whenBox.Text + "\n \n" + whereBox.Text + "\n \n" +
                            whoBox.Text + "\n \n" + whatBox.Text + "\n \n" + whyBox.Text + "\n \n" + endingBox.Text + "\n \n \n \n \nA story created by " +
                            username + " with some help from Lance Talbert's Story Generator.");

                        //Display a dialogue box saying the old story was overwritten, the new story has been created, and where they can find it.
                        MessageBox.Show("Old story overwritten. Your new story has been successfully created! Story can be found on your Desktop.", "Yahoo!");
                    }
                    else // user wishes to not overwrite NewStory.doc
                    {
                        //Display a dialogue box saying the story has not been overwritten.
                        MessageBox.Show("Story not overwritten.", "No changes made.");
                    }

                }
            }
            catch(Exception ex) //if for some reason something goes wrong...
            {
                //Display a dialogue box showing the exception message and stating that the new story could not be created.
                MessageBox.Show(ex.Message + " \n \n Your story could not be created. So sorry. :(", "An unexpected thing happened.");
            }
        }
    }
}

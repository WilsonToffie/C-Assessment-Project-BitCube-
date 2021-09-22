using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMatchCalculator
{
    public partial class GoodMatchCalculator : Form
    {
        string player1, player2, path;
        int matchPerc;
        List<string> female = new List<string>();
        List<string> male = new List<string>();
        List<string> matches = new List<string>();
        static List<Image> imgList = new List<Image>();

        public GoodMatchCalculator()
        {
            InitializeComponent();
  
            lblError.Visible = false;
            txtFilePath.ReadOnly = true;
            lblCalculated.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            player1 = txtPlayerOne.Text.ToLower();
            player2 = txtPlayerTwo.Text.ToLower();

            //Checks if the input is only alphanumeric characters
            if (!Regex.IsMatch(player1, @"^[a-zA-Z]+$"))
            {
                txtPlayerOne.Text = "";
                txtPlayerTwo.Text = "";
                lblError.Visible = true;
                Log(player1);
            }
            else if (!Regex.IsMatch(player2, @"^[a-zA-Z]+$"))
            {
                txtPlayerOne.Text = "";
                txtPlayerTwo.Text = "";
                lblError.Visible = true;
                Log(player2);
            }
            else
            {
                int percentage = int.Parse(CalculateMatch(player1, player2));// returns a match percentage

                AddImages();
                //Ads images to a list and then those images correspond to the images according to the match percentage
                if (percentage <= 10)
                    pbxPercentage1.Image = imgList[0];
                else if (percentage <= 20)
                    pbxPercentage1.Image = imgList[1];
                else if (percentage <= 30)
                    pbxPercentage1.Image = imgList[2];
                else if (percentage <= 40)
                    pbxPercentage1.Image = imgList[3];
                else if (percentage <= 50)
                    pbxPercentage1.Image = imgList[4];
                else if (percentage <= 60)
                    pbxPercentage1.Image = imgList[5];
                else if (percentage <= 70)
                    pbxPercentage1.Image = imgList[6];
                else if (percentage < 80)
                    pbxPercentage1.Image = imgList[7];
                //Displays a green label if its a good match
                if (percentage >= 80)
                {
                    pbxPercentage1.Image = imgList[12];
                    lblCalculated.Text = percentage + "% good match!";
                    lblCalculated.ForeColor = Color.Green;
                    lblCalculated.Visible = true;
                }
                else//Displays a normal black lable for matches below 80% 
                {
                    lblCalculated.Text = percentage + "% match";
                    lblCalculated.ForeColor = Color.Black;
                    lblCalculated.Visible = true;
                }

            }

        }

        private void txtPlayerOne_TextChanged(object sender, EventArgs e)
        {//After user has read that incorrect input was given and goes to start typing again, the error message dissapears.
            lblError.Visible = false;
        }

        private void btnLocateFile_Click(object sender, EventArgs e)
        {//Clears all the lists soon to be populated
            matches.Clear();
            male.Clear();
            female.Clear();

            lbxAllMatches.Items.Clear();
            lbxAllMatches.Items.Add("Player 1 \t \tPlayer 2 \tPercentage");
            lbxAllMatches.Items.Add("------------------------------------------------------");

            OpenFileDialog ofd = new OpenFileDialog();
            //Only displays files in the correct csv format to avoid errors
            ofd.Filter = "CSV Files (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
                path = ofd.FileName;

            txtFilePath.Text = path;

            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {//Takes each line and assigns each name to a list according to gender using a split to identify 'm' and 'f' for male and female
                var line = reader.ReadLine();
                var values = line.Split(';');

                if (values[1] == "m")
                {
                    if (!male.Contains(values[0]))
                        male.Add(values[0]);
                }
                else
                {
                    if (!female.Contains(values[0]))
                        female.Add(values[0]);
                }
            }
            //Takes and mathes each males with every female and adds it to a list with the match percentage
            for (int i = 0; i < male.Count(); i++)
            {
                for (int j = 0; j < female.Count(); j++)
                {
                    matchPerc = int.Parse(CalculateMatch(male[i], female[j]));
                    if (matchPerc >= 80)
                        matches.Add(male[i] + " \tmatches \t" + female[j] + " \t" + matchPerc + " %, good match.");
                    else
                        matches.Add(male[i] + " \tmatches \t" + female[j] + " \t" + matchPerc + " %");
                }
            }
            
            matches = Sort(matches);
            SaveToFile(matches);

            foreach (string match in matches)
            {//Populates listbox with all the different possible matches
                lbxAllMatches.Items.Add(match);
            }
        }
        //Calculates match percentage
        static string CalculateMatch(string player1, string player2)
        {
            string s = player1 + "matches" + player2,
                    occurences = "";
            int count = 0;
            int length = s.Length;

            char first;
            //Takes each character and checks the count of each in the sentence then removes all the corresponding characters from the sentence using substring() untill there are none left
            for (int i = 0; i < length; i++)
            {
                if (s.Length != 0)
                    first = s[0];
                else
                    break;

                foreach (char letter in s)
                {
                    if (letter == first)
                    {
                        s = s.Remove(s.IndexOf(letter), 1);
                        count++;
                    }
                }
                occurences += count;
                count = 0;
            }


            int head;
            int tail;
            string temp = occurences;
            string final = "";
            //Simplifies the character occurrences until only 2 digits are left.
            while (temp.Length != 0)
            {
                if (temp.Length % 2 != 0)
                {
                    if (temp.Length == 1)
                    {
                        final += temp;

                        if (final.Length == 2)
                            break;

                        temp = final;
                        final = "";
                    }
                    else
                    {
                        head = 0;
                        tail = temp.Length - 1;
                        final += int.Parse(temp[head].ToString()) + int.Parse(temp[tail].ToString());
                        temp = temp.Substring(head + 1, tail - 1);
                    }
                }
                else
                {
                    head = 0;
                    tail = temp.Length - 1;
                    final += int.Parse(temp[head].ToString()) + int.Parse(temp[tail].ToString());
                    temp = temp.Substring(head + 1, tail - 1);

                    if (final.Length == 2 && temp == "")
                        break;

                    if (temp.Length == 0)
                    {
                        temp = final;
                        final = "";
                    }
                }
            }

            return final;
        }

        public static List<string> Sort(List<string> input)
        {//using split, this method sorts the percentages in descending fashion then by the first names alphabetically and then by the second names
            var ordered = input.Select(s => new { Str = s, Split = s.Split(' ') })
                        .OrderByDescending(x => int.Parse(x.Split[3]))
                        .ThenBy(x => x.Split[0])
                        .ThenBy(x => x.Split[2])
                        .Select(x => x.Str)
                        .ToList();

            return ordered;
        }

        public static void SaveToFile(List<string> input)
        {//Saves the csv loaded input onto a textfile
            StreamWriter str = new StreamWriter("output.txt");

            foreach (String s in input)
                str.WriteLine(s);

            str.Close();
        }

        public static void Log(string input)
        {//Stores and keeps track of all incorrect inputs and what the actuall input is that was given
            using (StreamWriter str = File.AppendText("log.txt"))
            {
                str.WriteLine($"{DateTime.Now} : Incorrect format entered :: {input}");
                str.Close();
            }
        }

        public static void AddImages()
        {
            imgList.Add(Properties.Resources._0);
            imgList.Add(Properties.Resources._1);
            imgList.Add(Properties.Resources._2);
            imgList.Add(Properties.Resources._3);
            imgList.Add(Properties.Resources._4);
            imgList.Add(Properties.Resources._5);
            imgList.Add(Properties.Resources._6);
            imgList.Add(Properties.Resources._7);
            imgList.Add(Properties.Resources._8);
            imgList.Add(Properties.Resources._9);
            imgList.Add(Properties.Resources._10);
            imgList.Add(Properties.Resources._11);
            imgList.Add(Properties.Resources._12);
            imgList.Add(Properties.Resources._13);
        }
    }
}

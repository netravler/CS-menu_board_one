using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace menu_board_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // read run-time configuration elements

            const string f = "c:\\revocup_menu_board\\app.config.txt";

            // Declare new List.
            List<string> RT_config = new List<string>();

            // Use using StreamReader for disposing.
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    RT_config.Add(line);
                }
            }

            // set form1 size and color

            this.Width = Convert.ToInt16(RT_config[0].ToString()); // form1 width
            this.Height = Convert.ToInt16(RT_config[1].ToString()); // form1 height

            try
            {
                this.BackColor = Color.FromArgb(Convert.ToInt16(RT_config[2].ToString()), Convert.ToInt16(RT_config[3].ToString()), Convert.ToInt16(RT_config[4].ToString())); // form1 color
                this.rtb_espresso.BackColor = Color.FromArgb(Convert.ToInt16(RT_config[5].ToString()), Convert.ToInt16(RT_config[6].ToString()), Convert.ToInt16(RT_config[6].ToString())); // form1 color
                this.richTextBox1.BackColor = Color.FromArgb(Convert.ToInt16(RT_config[8].ToString()), Convert.ToInt16(RT_config[9].ToString()), Convert.ToInt16(RT_config[10].ToString())); // form1 color
                this.richTextBox2.BackColor = Color.FromArgb(Convert.ToInt16(RT_config[11].ToString()), Convert.ToInt16(RT_config[12].ToString()), Convert.ToInt16(RT_config[13].ToString())); // form1 color
                this.odds_and_ends.BackColor = Color.FromArgb(Convert.ToInt16(RT_config[14].ToString()), Convert.ToInt16(RT_config[15].ToString()), Convert.ToInt16(RT_config[16].ToString())); // form1 color
                this.pictureBox1.BackColor = Color.FromArgb(Convert.ToInt16(RT_config[17].ToString()), Convert.ToInt16(RT_config[18].ToString()), Convert.ToInt16(RT_config[19].ToString())); // form1 color
            }
            finally
            {
            }

            this.label1.Text = RT_config[RT_config.Count - 1];

            // end run-time configuration elements
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            odds_and_ends.LoadFile("c:\\revocup_menu_board\\odds_and_ends.rtf");

            rtb_espresso.LoadFile("c:\\revocup_menu_board\\espresso.rtf");

            richTextBox1.LoadFile("c:\\revocup_menu_board\\richTextBox1.rtf");

            richTextBox2.LoadFile("c:\\revocup_menu_board\\richTextBox2.rtf"); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rtb_espresso_TextChanged(object sender, EventArgs e)
        {

        }

        private void odds_and_ends_TextChanged(object sender, EventArgs e)
        {

        }

        private void odds_and_ends_DoubleClick(object sender, EventArgs e)
        {
            /* Show the dialog.
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                this.odds_and_ends.Font = font;
            } */

            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                odds_and_ends.BackColor = colorDialog1.Color;
            }
         }

        private void rtb_espresso_DoubleClick(object sender, EventArgs e)
        {

        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void richTextBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
                pictureBox1.BackColor = colorDialog1.Color;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.button1.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.button8.Visible = false;
            this.button9.Visible = false;
            this.button10.Visible = false;
            this.button11.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.button1.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.button8.Visible = true;
            this.button9.Visible = true;
            this.button10.Visible = true;
            this.button11.Visible = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Hide";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Text = "Show";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Text = "Espresso";
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Text = "Ice";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.Text = "Sand";
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.Text = "Odds";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                this.rtb_espresso.Font = font;
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
           DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                this.richTextBox1.Font = font;
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                this.richTextBox2.Font = font;
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                this.odds_and_ends.Font = font;
            } 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.rtb_espresso.BackColor = colorDialog1.Color;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.richTextBox2.BackColor = colorDialog1.Color;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.odds_and_ends.BackColor = colorDialog1.Color;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //save all the rtf's
            // You should replace the bold file name in the 
            // sample below with a file name of your own choosing.
            // Note the escape character used (@) when specifying the path.
            odds_and_ends.SaveFile("c:\\revocup_menu_board\\odds_and_ends.rtf",
                RichTextBoxStreamType.RichNoOleObjs);

            odds_and_ends.LoadFile("c:\\revocup_menu_board\\odds_and_ends.rtf");

            // You should replace the bold file name in the 
            // sample below with a file name of your own choosing.
            // Note the escape character used (@) when specifying the path.
            rtb_espresso.SaveFile("c:\\revocup_menu_board\\espresso.rtf",
                RichTextBoxStreamType.RichNoOleObjs);

            rtb_espresso.LoadFile("c:\\revocup_menu_board\\espresso.rtf");

            // You should replace the bold file name in the 
            // sample below with a file name of your own choosing.
            // Note the escape character used (@) when specifying the path.
            richTextBox1.SaveFile("c:\\revocup_menu_board\\richTextBox1.rtf",
                RichTextBoxStreamType.RichNoOleObjs);

            richTextBox1.LoadFile("c:\\revocup_menu_board\\richTextBox1.rtf");

            // You should replace the bold file name in the 
            // sample below with a file name of your own choosing.
            // Note the escape character used (@) when specifying the path.
            richTextBox2.SaveFile("c:\\revocup_menu_board\\richTextBox2.rtf",
                RichTextBoxStreamType.RichNoOleObjs);

            richTextBox2.LoadFile("c:\\revocup_menu_board\\richTextBox2.rtf"); 

            // Save Colors we save them all back to a text file...
            // read in for prep to re-write...

            const string f = "c:\\revocup_menu_board\\app.config.txt";

            // Declare new List.
            List<string> RT_config = new List<string>();

            // Use using StreamReader for disposing.
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    RT_config.Add(line);
                }
            }

            // 
            Color color = this.BackColor;
            RT_config[2] = color.R.ToString();
            RT_config[3] = color.G.ToString();
            RT_config[4] = color.B.ToString();
            // 
            color = this.rtb_espresso.BackColor;
            RT_config[5] = color.R.ToString();
            RT_config[6] = color.G.ToString();
            RT_config[7] = color.B.ToString();
            // 
            color = this.richTextBox1.BackColor;
            RT_config[8] = color.R.ToString();
            RT_config[9] = color.G.ToString();
            RT_config[10] = color.B.ToString();
            // 
            color = this.richTextBox2.BackColor;
            RT_config[11] = color.R.ToString();
            RT_config[12] = color.G.ToString();
            RT_config[13] = color.B.ToString();
            // 
            color = this.odds_and_ends.BackColor;
            RT_config[14] = color.R.ToString();
            RT_config[15] = color.G.ToString();
            RT_config[16] = color.B.ToString();
            // 
            color = this.pictureBox1.BackColor;
            RT_config[17] = color.R.ToString();
            RT_config[18] = color.G.ToString();
            RT_config[19] = color.B.ToString();

            // write it out to app.config.txt
            File.WriteAllLines("c:\\revocup_menu_board\\app.config.txt", RT_config);
        }
      }
}

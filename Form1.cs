using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Collections.Generic;

namespace KAR_RTATool
{
    public partial class Form1 : Form
    {
        CheckBox checkBox;
        ToolStripMenuItem toolStripMenuItem;
        int checkBoxNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.checkBoxes1 = new System.Windows.Forms.CheckBox[120];
            this.checkBoxes2 = new System.Windows.Forms.CheckBox[120];
            this.checkBoxes3 = new System.Windows.Forms.CheckBox[120];
            this.SuspendLayout();

            for (int i = 0; i < 120; i += 1)
            {
                this.checkBoxes1[i] = new System.Windows.Forms.CheckBox();
                this.checkBoxes1[i].AutoSize = true;
                this.checkBoxes1[i].Name = "checkBox" + (i + 1).ToString();
                this.checkBoxes1[i].Location = new System.Drawing.Point(7 + 21 * (i % 20), 7 + 20 * (i / 20));
                this.checkBoxes1[i].TabIndex = i + 1;
                this.checkBoxes1[i].UseVisualStyleBackColor = true;
                this.checkBoxes1[i].Enter += new System.EventHandler(this.CheckBoxSelect);
                this.checkBoxes1[i].MouseEnter += new System.EventHandler(this.CheckBoxSelect);
                this.checkBoxes1[i].CheckedChanged += new System.EventHandler(this.CheckedCheckBox);
            }
            this.checkBoxes1[119].AutoCheck = false;
            this.tabPage1.Controls.AddRange(this.checkBoxes1);
            this.ResumeLayout(false);

            for (int i = 0; i < 120; i += 1)
            {
                this.checkBoxes2[i] = new System.Windows.Forms.CheckBox();
                this.checkBoxes2[i].AutoSize = true;
                this.checkBoxes2[i].Name = "checkBox" + (i + 121).ToString();
                this.checkBoxes2[i].Location = new System.Drawing.Point(7 + 21 * (i % 20), 7 + 20 * (i / 20));
                this.checkBoxes2[i].TabIndex = i + 121;
                this.checkBoxes2[i].UseVisualStyleBackColor = true;
                this.checkBoxes2[i].Enter += new System.EventHandler(this.CheckBoxSelect);
                this.checkBoxes2[i].MouseEnter += new System.EventHandler(this.CheckBoxSelect);
                this.checkBoxes2[i].CheckedChanged += new System.EventHandler(this.CheckedCheckBox);
            }
            this.checkBoxes2[119].AutoCheck = false;
            this.tabPage2.Controls.AddRange(this.checkBoxes2);
            this.ResumeLayout(false);

            for (int i = 0; i < 120; i += 1)
            {
                this.checkBoxes3[i] = new System.Windows.Forms.CheckBox();
                this.checkBoxes3[i].AutoSize = true;
                this.checkBoxes3[i].Name = "checkBox" + (i + 241).ToString();
                this.checkBoxes3[i].Location = new System.Drawing.Point(7 + 21 * (i % 20), 7 + 20 * (i / 20));
                this.checkBoxes3[i].TabIndex = i + 241;
                this.checkBoxes3[i].UseVisualStyleBackColor = true;
                this.checkBoxes3[i].Enter += new System.EventHandler(this.CheckBoxSelect);
                this.checkBoxes3[i].MouseEnter += new System.EventHandler(this.CheckBoxSelect);
                this.checkBoxes3[i].CheckedChanged += new System.EventHandler(this.CheckedCheckBox);
            }
            this.checkBoxes3[119].AutoCheck = false;
            this.tabPage3.Controls.AddRange(this.checkBoxes3);
            this.ResumeLayout(false);
            return;
        }

        private void Reset(object sender, EventArgs e)
        {
            for (int i = 0; i < 120; i += 1)
            {
                this.checkBoxes1[i].Checked = false;
                this.checkBoxes2[i].Checked = false;
                this.checkBoxes3[i].Checked = false;
            }
            this.checkBoxAr21.Checked = false;
            this.checkBoxAr22.Checked = false;
            this.checkBoxAr33.Checked = false;
            this.checkBoxAr34.Checked = false;
            this.checkBoxAr35.Checked = false;
            this.checkBoxAr55.Checked = false;
            this.checkBoxAr57.Checked = false;
            this.checkBoxAr78.Checked = false;
            this.checkBoxAr79.Checked = false;
            this.checkBoxAr92.Checked = false;
            this.checkBoxAr93.Checked = false;
            this.checkBoxAr94.Checked = false;
            this.checkBoxAr95.Checked = false;
            this.checkBoxAr96.Checked = false;
            this.checkBoxAr98.Checked = false;
            this.checkBoxAr99.Checked = false;
            this.checkBoxAr100.Checked = false;
            this.checkBoxAr101.Checked = false;
            this.checkBoxAr102.Checked = false;
            this.checkBoxTr11.Checked = false;
            this.checkBoxTr12.Checked = false;
            this.checkBoxTr27.Checked = false;
            this.checkBoxTr63.Checked = false;
            this.checkBoxTr77.Checked = false;
            this.checkBoxTr78.Checked = false;
            this.checkBoxTr96.Checked = false;
            this.checkBoxTr100.Checked = false;
            this.checkBoxTr106.Checked = false;
            this.checkBoxTr109.Checked = false;
            this.checkBoxTr110.Checked = false;
            this.checkBoxTr111.Checked = false;
            this.checkBoxTr112.Checked = false;
            this.checkBoxTr113.Checked = false;
            this.checkBoxTr114.Checked = false;
            this.checkBoxTr115.Checked = false;
            this.checkBoxTr116.Checked = false;
            this.checkBoxTr118.Checked = false;
            this.checkBoxCt1.Checked = false;
            this.checkBoxCt2.Checked = false;
            this.checkBoxCt3.Checked = false;
            this.checkBoxCt5.Checked = false;
            this.checkBoxCt6.Checked = false;
            this.checkBoxCt7.Checked = false;
            this.checkBoxCt8.Checked = false;
            this.checkBoxCt9.Checked = false;
            this.checkBoxCt10.Checked = false;
            this.checkBoxCt11.Checked = false;
            this.checkBoxCt12.Checked = false;
            this.checkBoxCt13.Checked = false;
            this.checkBoxCt14.Checked = false;
            this.checkBoxCt15.Checked = false;
            this.checkBoxCt16.Checked = false;
            this.checkBoxCt17.Checked = false;
            this.checkBoxCt18.Checked = false;
            this.checkBoxCt19.Checked = false;
            this.checkBoxCt20.Checked = false;
            this.checkBoxCt21.Checked = false;
            this.checkBoxCt22.Checked = false;
            this.checkBoxCt23.Checked = false;
            this.checkBoxCt24.Checked = false;
            this.checkBoxCt25.Checked = false;
            this.checkBoxCt26.Checked = false;
            this.checkBoxCt27.Checked = false;
            this.checkBoxCt28.Checked = false;
            this.checkBoxCt29.Checked = false;
            this.checkBoxCt30.Checked = false;
            this.checkBoxCt31.Checked = false;
            this.checkBoxCt32.Checked = false;
            this.checkBoxCt33.Checked = false;
            this.checkBoxCt34.Checked = false;
            this.checkBoxCt35.Checked = false;
            this.checkBoxCt36.Checked = false;
            this.checkBoxCt37.Checked = false;
            this.checkBoxCt38.Checked = false;
            this.checkBoxCt39.Checked = false;
            this.checkBoxCt40.Checked = false;
            this.checkBoxCt41.Checked = false;
            this.checkBoxCt42.Checked = false;
            this.checkBoxCt43.Checked = false;
            this.checkBoxCt44.Checked = false;
            this.checkBoxCt45.Checked = false;
            this.checkBoxCt46.Checked = false;
            this.checkBoxCt47.Checked = false;
            this.checkBoxCt65.Checked = false;
            this.checkBoxCt68.Checked = false;
            this.checkBoxCt80.Checked = false;
            this.checkBoxCt81.Checked = false;
            this.checkBoxCt83.Checked = false;
            this.checkBoxCt84.Checked = false;
            this.checkBoxCt86.Checked = false;
            this.checkBoxCt94.Checked = false;
            this.checkBoxCt95.Checked = false;
            this.checkBoxCt96.Checked = false;
            this.checkBoxCt97.Checked = false;
            this.checkBoxCt98.Checked = false;
            this.checkBoxCt99.Checked = false;
            this.checkBoxCt100.Checked = false;
            this.checkBoxCt103.Checked = false;
            this.checkBoxCt104.Checked = false;
            this.checkBoxCt105.Checked = false;
            this.checkBoxCt106.Checked = false;
            this.checkBoxCt108.Checked = false;
            this.checkBoxCt109.Checked = false;
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
            this.checkBox10.Checked = false;
            this.checkBox11.Checked = false;
            this.checkBox12.Checked = false;
            this.checkBox13.Checked = false;
            this.checkBox14.Checked = false;
            this.checkBox15.Checked = false;
            this.textBox1.Text = "";
            return;
        }

        private void Check(object sender, EventArgs e)
        {
            Run();
            ListChecked();
            return;
        }

        private void KarChecklistChecker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Insert)
            {
                Run();
                ListChecked();
            }
            /*
            if (e.Control && e.KeyCode == Keys.C)
            {
                StadiumPrediction();
            }
            */
            return;
        }

        private void Run()
        {
            int checkBoxNumber;
            string[] temps = null;
            if (this.toolStripMenuItem2.Checked == true)
            {
                if (this.toolStripMenuItem8.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\ja\ar", "*.png");
                else if (this.toolStripMenuItem9.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\ja\tr", "*.png");
                else if (this.toolStripMenuItem10.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\ja\ct", "*.png");
                else if (this.toolStripMenuItem11.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\ja", "*.png", System.IO.SearchOption.AllDirectories);
            }
            else if (this.toolStripMenuItem3.Checked == true)
            {
                if (this.toolStripMenuItem8.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\en\ar", "*.png");
                else if (this.toolStripMenuItem9.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\en\tr", "*.png");
                else if (this.toolStripMenuItem10.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\en\ct", "*.png");
                else if (this.toolStripMenuItem11.Checked == true) temps = System.IO.Directory.GetFiles(@".\temp\checkboxes\en", "*.png", System.IO.SearchOption.AllDirectories);
            }
            
            string[] files = System.IO.Directory.GetFiles(@".\pic", "*.png");
            for (int i = 0; i < files.Length; i += 1)
            {
                Mat mat = new Mat();
                Mat matOrig = new Mat(files[i]);
                mat = matOrig.Clone(new Rect(182, 358, 422, 58));
                for (int j = 0; j < temps.Length; j += 1)
                {
                    Mat temp = new Mat(temps[j]);
                    Mat result = new Mat();

                    //テンプレートマッチ
                    Cv2.MatchTemplate(mat, temp, result, TemplateMatchModes.CCoeffNormed);
                    OpenCvSharp.Point minloc, maxloc;
                    double minval, maxval;
                    Cv2.MinMaxLoc(result, out minval, out maxval, out minloc, out maxloc);

                    double threshold = 0.93;
                    if (maxval >= threshold)
                    {
                        checkBoxNumber = Int32.Parse(System.IO.Path.GetFileName(temps[j]).Replace(".png", ""));
                        if (ValidateNumber(matOrig, checkBoxNumber) <= 0.93) continue;
                        
                        if (checkBoxNumber < 121)
                        {
                            checkBoxes1[checkBoxNumber - 1].Checked = true;
                        }
                        else if (checkBoxNumber < 241)
                        {
                            checkBoxes2[checkBoxNumber - 121].Checked = true;
                        }
                        else if (checkBoxNumber < 361)
                        {
                            checkBoxes3[checkBoxNumber - 241].Checked = true;
                        }
                        break;
                    }
                    temp.Dispose();
                    result.Dispose();
                }
                mat.Dispose();
                matOrig.Dispose();
            }
            foreach (string pathFrom in System.IO.Directory.EnumerateFiles(@".\pic", "*.png"))
            {
                string pathTo = pathFrom.Replace(@".\pic", @".\pic\rm");
                System.IO.File.Move(pathFrom, pathTo, true);
            }
            return;
        }

        //似ている課題がある場合、2回目のマッチングを行う
        private double ValidateNumber(Mat mat, int checkBoxNumber)
        {
            Mat mat2 = new Mat();
            String path = null;
            if (this.toolStripMenuItem2.Checked == true) path = @".\temp\details\ja\" + checkBoxNumber.ToString() + ".png";
            else if (this.toolStripMenuItem3.Checked == true) path = @".\temp\details\en\" + checkBoxNumber.ToString() + ".png";
            Mat result2 = new Mat();
            OpenCvSharp.Point minloc, maxloc;
            double minval; double maxval = 1.0;

            if (this.toolStripMenuItem2.Checked == true)
            {
                if (checkBoxNumber == 1 || checkBoxNumber == 2)
                {
                    mat2 = mat.Clone(new Rect(288, 383, 49, 32));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 3 || checkBoxNumber == 26 || checkBoxNumber == 38 || checkBoxNumber == 48 || checkBoxNumber == 60)
                {
                    mat2 = mat.Clone(new Rect(286, 359, 126, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 15 || checkBoxNumber == 16)
                {
                    mat2 = mat.Clone(new Rect(601, 319, 75, 71));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 36 || checkBoxNumber == 46)
                {
                    mat2 = mat.Clone(new Rect(286, 359, 119, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 37 || checkBoxNumber == 58 || checkBoxNumber == 59)
                {
                    mat2 = mat.Clone(new Rect(286, 359, 53, 55));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 43 || checkBoxNumber == 65)
                {
                    mat2 = mat.Clone(new Rect(319, 360, 125, 29));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 49 || checkBoxNumber == 50)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 52 || checkBoxNumber == 53)
                {
                    mat2 = mat.Clone(new Rect(221, 384, 42, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 69 || checkBoxNumber == 70)
                {
                    mat2 = mat.Clone(new Rect(268, 385, 70, 29));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 80 || checkBoxNumber == 81)
                {
                    mat2 = mat.Clone(new Rect(601, 319, 75, 71));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 83 || checkBoxNumber == 84)
                {
                    mat2 = mat.Clone(new Rect(232, 385, 28, 29));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 86 || checkBoxNumber == 87)
                {
                    mat2 = mat.Clone(new Rect(221, 384, 50, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    //this.label5.Text += "\n" + checkBoxNumber.ToString() + " " + maxval.ToString("F3") + " ";
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 288 || checkBoxNumber == 289 || checkBoxNumber == 292 || checkBoxNumber == 293 || checkBoxNumber == 296 || checkBoxNumber == 297 || checkBoxNumber == 300)
                {
                    mat2 = mat.Clone(new Rect(502, 359, 31, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    if (maxval >= 0.93) maxval = ValidateNumber2(mat, checkBoxNumber);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 290 || checkBoxNumber == 294)
                {
                    mat2 = mat.Clone(new Rect(502, 359, 31, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 304 || checkBoxNumber == 307 || checkBoxNumber == 309 || checkBoxNumber == 310 || checkBoxNumber == 312)
                {
                    mat2 = mat.Clone(new Rect(441, 359, 31, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 305 || checkBoxNumber == 308 || checkBoxNumber == 311 || checkBoxNumber == 313)
                {
                    mat2 = mat.Clone(new Rect(441, 359, 31, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 319 || checkBoxNumber == 320)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 325 || checkBoxNumber == 327)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 326 || checkBoxNumber == 328)
                {
                    mat2 = mat.Clone(new Rect(601, 319, 75, 71));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
            }
            else if (this.toolStripMenuItem3.Checked == true)
            {
                if (checkBoxNumber == 1 || checkBoxNumber == 2)
                {
                    mat2 = mat.Clone(new Rect(507, 384, 48, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 15 || checkBoxNumber == 16)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 49 || checkBoxNumber == 50)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 52 || checkBoxNumber == 53)
                {
                    mat2 = mat.Clone(new Rect(509, 383, 43, 32));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 58 || checkBoxNumber == 59)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 69 || checkBoxNumber == 70)
                {
                    mat2 = mat.Clone(new Rect(489, 383, 66, 32));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 80 || checkBoxNumber == 81)
                {
                    mat2 = mat.Clone(new Rect(601, 319, 75, 71));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 83 || checkBoxNumber == 84)
                {
                    mat2 = mat.Clone(new Rect(448, 384, 30, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 86 || checkBoxNumber == 87)
                {
                    mat2 = mat.Clone(new Rect(503, 384, 50, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 121 || checkBoxNumber == 136 || checkBoxNumber == 149 || checkBoxNumber == 161 || checkBoxNumber == 173 || checkBoxNumber == 200)
                {
                    mat2 = mat.Clone(new Rect(321, 358, 107, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 122 || checkBoxNumber == 137 || checkBoxNumber == 150 || checkBoxNumber == 162 || checkBoxNumber == 174 || checkBoxNumber == 201)
                {
                    mat2 = mat.Clone(new Rect(321, 358, 107, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 123 || checkBoxNumber == 138 || checkBoxNumber == 151 || checkBoxNumber == 163 || checkBoxNumber == 175 || checkBoxNumber == 202)
                {
                    mat2 = mat.Clone(new Rect(321, 358, 107, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 125 || checkBoxNumber == 140 || checkBoxNumber == 153 || checkBoxNumber == 165 || checkBoxNumber == 177 || checkBoxNumber == 204)
                {
                    mat2 = mat.Clone(new Rect(321, 358, 107, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 126 || checkBoxNumber == 127)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 130 || checkBoxNumber == 196)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 141 || checkBoxNumber == 142)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 143 || checkBoxNumber == 144 || checkBoxNumber == 157 || checkBoxNumber == 168 || checkBoxNumber == 169 || checkBoxNumber == 180 || checkBoxNumber == 181 || checkBoxNumber == 208)
                {
                    mat2 = mat.Clone(new Rect(321, 358, 101, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    if (maxval >= 0.93) maxval = ValidateNumber2(mat, checkBoxNumber);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 145 || checkBoxNumber == 182)
                {
                    mat2 = mat.Clone(new Rect(285, 359, 73, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 154 || checkBoxNumber == 155)
                {
                    mat2 = mat.Clone(new Rect(448, 384, 29, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 158 || checkBoxNumber == 170)
                {
                    mat2 = mat.Clone(new Rect(292, 358, 56, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 164 || checkBoxNumber == 176)
                {
                    mat2 = mat.Clone(new Rect(321, 359, 90, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 166 || checkBoxNumber == 167 || checkBoxNumber == 178 || checkBoxNumber == 179)
                {
                    mat2 = mat.Clone(new Rect(469, 384, 28, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 194 || checkBoxNumber == 195)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 205 || checkBoxNumber == 206)
                {
                    mat2 = mat.Clone(new Rect(469, 384, 28, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 233 || checkBoxNumber == 234 || checkBoxNumber == 235 || checkBoxNumber == 236 || checkBoxNumber == 238 || checkBoxNumber == 239)
                {
                    mat2 = mat.Clone(new Rect(321, 358, 107, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 288 || checkBoxNumber == 289 || checkBoxNumber == 292 || checkBoxNumber == 293 || checkBoxNumber == 296 || checkBoxNumber == 297 || checkBoxNumber == 300)
                {
                    mat2 = mat.Clone(new Rect(488, 359, 35, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    if (maxval >= 0.85) maxval = ValidateNumber2(mat, checkBoxNumber);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 307 || checkBoxNumber == 309 || checkBoxNumber == 310 || checkBoxNumber == 312)
                {
                    mat2 = mat.Clone(new Rect(576, 359, 27, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 308 || checkBoxNumber == 311 || checkBoxNumber == 313)
                {
                    mat2 = mat.Clone(new Rect(576, 359, 27, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 318 || checkBoxNumber == 319)
                {
                    mat2 = mat.Clone(new Rect(384, 384, 51, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 325 || checkBoxNumber == 327)
                {
                    mat2 = mat.Clone(new Rect(595, 326, 72, 70));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 326 || checkBoxNumber == 328)
                {
                    mat2 = mat.Clone(new Rect(601, 319, 75, 71));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat2, temp2, result2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result2, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                    //this.textBox1.Text += checkBoxNumber.ToString() + " " + maxval.ToString("F3") + " ";
                }
            }
            mat2.Dispose();
            result2.Dispose();
            return maxval;
        }

        //2回目のマッチングでも絞れない場合、3回目のマッチングを行う
        private double ValidateNumber2(Mat mat, int checkBoxNumber)
        {
            Mat mat3 = new Mat();
            String path = null;
            if (this.toolStripMenuItem2.Checked == true) path = @".\temp\details\ja\" + checkBoxNumber.ToString() + "_2.png";
            else if (this.toolStripMenuItem3.Checked == true) path = @".\temp\details\en\" + checkBoxNumber.ToString() + "_2.png";
            Mat result3 = new Mat();
            OpenCvSharp.Point minloc, maxloc;
            double minval; double maxval = 1.0;

            if (this.toolStripMenuItem2.Checked == true)
            {
                if (checkBoxNumber == 288 || checkBoxNumber == 289 || checkBoxNumber == 292 || checkBoxNumber == 293 || checkBoxNumber == 296 || checkBoxNumber == 297 || checkBoxNumber == 300)
                {
                    mat3 = mat.Clone(new Rect(248, 384, 31, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat3, temp2, result3, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result3, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
            }
            else if (this.toolStripMenuItem3.Checked == true)
            {
                if (checkBoxNumber == 143 || checkBoxNumber == 144 || checkBoxNumber == 157 || checkBoxNumber == 168 || checkBoxNumber == 169 || checkBoxNumber == 180 || checkBoxNumber == 181 || checkBoxNumber == 208)
                {
                    mat3 = mat.Clone(new Rect(522, 384, 56, 31));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat3, temp2, result3, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result3, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
                else if (checkBoxNumber == 288 || checkBoxNumber == 289 || checkBoxNumber == 292 || checkBoxNumber == 293 || checkBoxNumber == 296 || checkBoxNumber == 297 || checkBoxNumber == 300)
                {
                    mat3 = mat.Clone(new Rect(515, 384, 30, 30));
                    Mat temp2 = new Mat(path);
                    Cv2.MatchTemplate(mat3, temp2, result3, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result3, out minval, out maxval, out minloc, out maxloc);
                    temp2.Dispose();
                }
            }

            mat3.Dispose();
            result3.Dispose();
            return maxval;
        }

        private void CheckedCheckBox(object sender, EventArgs e)
        {
            checkBox = (CheckBox)sender;
            if (checkBox.TabIndex < 121)
            {
                int num = Int32.Parse(this.label1.Text);
                if (checkBox.Checked == true) num += 1;
                else num -= 1;
                this.label1.Text = num.ToString();
                if (num == 100) this.checkBoxes1[119].Checked = !(this.checkBoxes1[119].Checked);
            }
            else if (checkBox.TabIndex < 241)
            {
                int num = Int32.Parse(this.label2.Text);
                if (checkBox.Checked == true) num += 1;
                else num -= 1;
                this.label2.Text = num.ToString();
                if (num == 100) this.checkBoxes2[119].Checked = !(this.checkBoxes2[119].Checked);
            }
            else
            {
                int num = Int32.Parse(this.label3.Text);
                if (checkBox.Checked == true) num += 1;
                else num -= 1;
                this.label3.Text = num.ToString();
                if (num == 100) this.checkBoxes3[119].Checked = !(this.checkBoxes3[119].Checked);
            }
            return;
        }

        private void ListChecked()
        {
            if (this.checkBoxes1[20].Checked == true) this.checkBoxAr21.Checked = true;
            if (this.checkBoxes1[21].Checked == true) this.checkBoxAr22.Checked = true;
            if (this.checkBoxes1[32].Checked == true) this.checkBoxAr33.Checked = true;
            if (this.checkBoxes1[33].Checked == true) this.checkBoxAr34.Checked = true;
            if (this.checkBoxes1[34].Checked == true) this.checkBoxAr35.Checked = true;
            if (this.checkBoxes1[54].Checked == true) this.checkBoxAr55.Checked = true;
            if (this.checkBoxes1[56].Checked == true) this.checkBoxAr57.Checked = true;
            if (this.checkBoxes1[77].Checked == true) this.checkBoxAr78.Checked = true;
            if (this.checkBoxes1[78].Checked == true) this.checkBoxAr79.Checked = true;
            if (this.checkBoxes1[91].Checked == true) this.checkBoxAr92.Checked = true;
            if (this.checkBoxes1[92].Checked == true) this.checkBoxAr93.Checked = true;
            if (this.checkBoxes1[93].Checked == true) this.checkBoxAr94.Checked = true;
            if (this.checkBoxes1[94].Checked == true) this.checkBoxAr95.Checked = true;
            if (this.checkBoxes1[95].Checked == true) this.checkBoxAr96.Checked = true;
            if (this.checkBoxes1[97].Checked == true) this.checkBoxAr98.Checked = true;
            if (this.checkBoxes1[98].Checked == true) this.checkBoxAr99.Checked = true;
            if (this.checkBoxes1[99].Checked == true) this.checkBoxAr100.Checked = true;
            if (this.checkBoxes1[100].Checked == true) this.checkBoxAr101.Checked = true;
            if (this.checkBoxes1[101].Checked == true) this.checkBoxAr102.Checked = true;
            if (this.checkBoxes2[10].Checked == true) this.checkBoxTr11.Checked = true;
            if (this.checkBoxes2[11].Checked == true) this.checkBoxTr12.Checked = true;
            if (this.checkBoxes2[26].Checked == true) this.checkBoxTr27.Checked = true;
            if (this.checkBoxes2[62].Checked == true) this.checkBoxTr63.Checked = true;
            if (this.checkBoxes2[76].Checked == true) this.checkBoxTr77.Checked = true;
            if (this.checkBoxes2[77].Checked == true) this.checkBoxTr78.Checked = true;
            if (this.checkBoxes2[95].Checked == true) this.checkBoxTr96.Checked = true;
            if (this.checkBoxes2[99].Checked == true) this.checkBoxTr100.Checked = true;
            if (this.checkBoxes2[105].Checked == true) this.checkBoxTr106.Checked = true;
            if (this.checkBoxes2[108].Checked == true) this.checkBoxTr109.Checked = true;
            if (this.checkBoxes2[109].Checked == true) this.checkBoxTr110.Checked = true;
            if (this.checkBoxes2[110].Checked == true) this.checkBoxTr111.Checked = true;
            if (this.checkBoxes2[111].Checked == true) this.checkBoxTr112.Checked = true;
            if (this.checkBoxes2[112].Checked == true) this.checkBoxTr113.Checked = true;
            if (this.checkBoxes2[113].Checked == true) this.checkBoxTr114.Checked = true;
            if (this.checkBoxes2[114].Checked == true) this.checkBoxTr115.Checked = true;
            if (this.checkBoxes2[115].Checked == true) this.checkBoxTr116.Checked = true;
            if (this.checkBoxes2[117].Checked == true) this.checkBoxTr118.Checked = true;
            if (this.checkBoxes3[0].Checked == true) this.checkBoxCt1.Checked = true;
            if (this.checkBoxes3[1].Checked == true) this.checkBoxCt2.Checked = true;
            if (this.checkBoxes3[2].Checked == true) this.checkBoxCt3.Checked = true;
            if (this.checkBoxes3[4].Checked == true) this.checkBoxCt5.Checked = true;
            if (this.checkBoxes3[5].Checked == true) this.checkBoxCt6.Checked = true;
            if (this.checkBoxes3[6].Checked == true) this.checkBoxCt7.Checked = true;
            if (this.checkBoxes3[7].Checked == true) this.checkBoxCt8.Checked = true;
            if (this.checkBoxes3[8].Checked == true) this.checkBoxCt9.Checked = true;
            if (this.checkBoxes3[9].Checked == true) this.checkBoxCt10.Checked = true;
            if (this.checkBoxes3[10].Checked == true) this.checkBoxCt11.Checked = true;
            if (this.checkBoxes3[11].Checked == true) this.checkBoxCt12.Checked = true;
            if (this.checkBoxes3[12].Checked == true) this.checkBoxCt13.Checked = true;
            if (this.checkBoxes3[13].Checked == true) this.checkBoxCt14.Checked = true;
            if (this.checkBoxes3[14].Checked == true) this.checkBoxCt15.Checked = true;
            if (this.checkBoxes3[15].Checked == true) this.checkBoxCt16.Checked = true;
            if (this.checkBoxes3[16].Checked == true) this.checkBoxCt17.Checked = true;
            if (this.checkBoxes3[17].Checked == true) this.checkBoxCt18.Checked = true;
            if (this.checkBoxes3[18].Checked == true) this.checkBoxCt19.Checked = true;
            if (this.checkBoxes3[19].Checked == true) this.checkBoxCt20.Checked = true;
            if (this.checkBoxes3[20].Checked == true) this.checkBoxCt21.Checked = true;
            if (this.checkBoxes3[21].Checked == true) this.checkBoxCt22.Checked = true;
            if (this.checkBoxes3[22].Checked == true) this.checkBoxCt23.Checked = true;
            if (this.checkBoxes3[23].Checked == true) this.checkBoxCt24.Checked = true;
            if (this.checkBoxes3[24].Checked == true) this.checkBoxCt25.Checked = true;
            if (this.checkBoxes3[25].Checked == true) this.checkBoxCt26.Checked = true;
            if (this.checkBoxes3[26].Checked == true) this.checkBoxCt27.Checked = true;
            if (this.checkBoxes3[27].Checked == true) this.checkBoxCt28.Checked = true;
            if (this.checkBoxes3[28].Checked == true) this.checkBoxCt29.Checked = true;
            if (this.checkBoxes3[29].Checked == true) this.checkBoxCt30.Checked = true;
            if (this.checkBoxes3[30].Checked == true) this.checkBoxCt31.Checked = true;
            if (this.checkBoxes3[31].Checked == true) this.checkBoxCt32.Checked = true;
            if (this.checkBoxes3[32].Checked == true) this.checkBoxCt33.Checked = true;
            if (this.checkBoxes3[33].Checked == true) this.checkBoxCt34.Checked = true;
            if (this.checkBoxes3[34].Checked == true) this.checkBoxCt35.Checked = true;
            if (this.checkBoxes3[35].Checked == true) this.checkBoxCt36.Checked = true;
            if (this.checkBoxes3[36].Checked == true) this.checkBoxCt37.Checked = true;
            if (this.checkBoxes3[37].Checked == true) this.checkBoxCt38.Checked = true;
            if (this.checkBoxes3[38].Checked == true) this.checkBoxCt39.Checked = true;
            if (this.checkBoxes3[39].Checked == true) this.checkBoxCt40.Checked = true;
            if (this.checkBoxes3[40].Checked == true) this.checkBoxCt41.Checked = true;
            if (this.checkBoxes3[41].Checked == true) this.checkBoxCt42.Checked = true;
            if (this.checkBoxes3[42].Checked == true) this.checkBoxCt43.Checked = true;
            if (this.checkBoxes3[43].Checked == true) this.checkBoxCt44.Checked = true;
            if (this.checkBoxes3[44].Checked == true) this.checkBoxCt45.Checked = true;
            if (this.checkBoxes3[45].Checked == true) this.checkBoxCt46.Checked = true;
            if (this.checkBoxes3[46].Checked == true) this.checkBoxCt47.Checked = true;
            if (this.checkBoxes3[64].Checked == true) this.checkBoxCt65.Checked = true;
            if (this.checkBoxes3[67].Checked == true) this.checkBoxCt68.Checked = true;
            if (this.checkBoxes3[79].Checked == true) this.checkBoxCt80.Checked = true;
            if (this.checkBoxes3[80].Checked == true) this.checkBoxCt81.Checked = true;
            if (this.checkBoxes3[82].Checked == true) this.checkBoxCt83.Checked = true;
            if (this.checkBoxes3[83].Checked == true) this.checkBoxCt84.Checked = true;
            if (this.checkBoxes3[85].Checked == true) this.checkBoxCt86.Checked = true;
            if (this.checkBoxes3[93].Checked == true) this.checkBoxCt94.Checked = true;
            if (this.checkBoxes3[94].Checked == true) this.checkBoxCt95.Checked = true;
            if (this.checkBoxes3[95].Checked == true) this.checkBoxCt96.Checked = true;
            if (this.checkBoxes3[96].Checked == true) this.checkBoxCt97.Checked = true;
            if (this.checkBoxes3[97].Checked == true) this.checkBoxCt98.Checked = true;
            if (this.checkBoxes3[98].Checked == true) this.checkBoxCt99.Checked = true;
            if (this.checkBoxes3[99].Checked == true) this.checkBoxCt100.Checked = true;
            if (this.checkBoxes3[102].Checked == true) this.checkBoxCt103.Checked = true;
            if (this.checkBoxes3[103].Checked == true) this.checkBoxCt104.Checked = true;
            if (this.checkBoxes3[104].Checked == true) this.checkBoxCt105.Checked = true;
            if (this.checkBoxes3[105].Checked == true) this.checkBoxCt106.Checked = true;
            if (this.checkBoxes3[107].Checked == true) this.checkBoxCt108.Checked = true;
            if (this.checkBoxes3[108].Checked == true) this.checkBoxCt109.Checked = true;
            return;
        }

        private void ListedCheckBoxCount(object sender, EventArgs e)
        {
            int num = Int32.Parse(this.label4.Text);
            checkBox = (CheckBox)sender;
            if (checkBox.Checked == true) num += 1;
            else num -= 1;
            this.label4.Text = num.ToString();
        }

        private void CheckBoxSelect(object sender, EventArgs e)
        {
            //if (!(sender is CheckBox)) return;
            checkBox = (CheckBox)sender;
            checkBoxNumber = checkBox.TabIndex;
            if (this.toolStripMenuItem5.Checked == true)
            {
                switch (checkBoxNumber)
                {
                    case 1:
                        this.textBox1.Text = "周回制：プランテス　3周を01'20\"00以内でゴールする";
                        break;
                    case 2:
                        this.textBox1.Text = "周回制：プランテス　3周を01'03\"00以内でゴールする";
                        break;
                    case 3:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：プランテス　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：プランテス　2分で4500フィート以上走る";
                        break;
                    case 4:
                        this.textBox1.Text = "タイムアタック：プランテス　01'12\"00以内でゴールする";
                        break;
                    case 5:
                        this.textBox1.Text = "タイムアタック：プランテス　01'00\"00以内でゴールする";
                        break;
                    case 6:
                        this.textBox1.Text = "タイムアタック：プランテス　スリックスター、01'05\"00以内でゴールする";
                        break;
                    case 7:
                        this.textBox1.Text = "フリーラン：プランテス　00'24\"00以内で1周する";
                        break;
                    case 8:
                        this.textBox1.Text = "フリーラン：プランテス　00'21\"00以内で1周する";
                        break;
                    case 9:
                        this.textBox1.Text = "フリーラン：プランテス　ワゴンスター、00'23\"00以内で1周する";
                        break;
                    case 10:
                        this.textBox1.Text = "プランテス　敵を20体以上すいこみ1位をとる";
                        break;
                    case 11:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "プランテス　1周する間30km/hを切らずに走る";
                        else this.textBox1.Text = "プランテス　1周する間20マイル毎時を切らずに走る";
                        break;
                    case 12:
                        this.textBox1.Text = "周回制：ヴァレリオン　2周を02'20\"00以内でゴールする";
                        break;
                    case 13:
                        this.textBox1.Text = "周回制：ヴァレリオン　2周を01'56\"00以内でゴールする";
                        break;
                    case 14:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：ヴァレリオン　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：ヴァレリオン　2分で6000フィート以上走る";
                        break;
                    case 15:
                        this.textBox1.Text = "タイムアタック：ヴァレリオン　03'20\"00以内でゴールする";
                        break;
                    case 16:
                        this.textBox1.Text = "タイムアタック：ヴァレリオン　02'56\"00以内でゴールする";
                        break;
                    case 17:
                        this.textBox1.Text = "タイムアタック：ヴァレリオン　ジェットスター、02'58\"00以内でゴールする";
                        break;
                    case 18:
                        this.textBox1.Text = "フリーラン：ヴァレリオン　01'10\"00以内で1周する";
                        break;
                    case 19:
                        this.textBox1.Text = "フリーラン：ヴァレリオン　00'57\"00以内で1周する";
                        break;
                    case 20:
                        this.textBox1.Text = "フリーラン：ヴァレリオン　スリックスター、01'02\"00以内で1周する";
                        break;
                    case 21:
                        this.textBox1.Text = "ヴァレリオン　1レース中、つり橋の手すりを左右ともに乗る";
                        break;
                    case 22:
                        this.textBox1.Text = "ヴァレリオン　樹の上のコピールーレットを使う";
                        break;
                    case 23:
                        this.textBox1.Text = "1ゲーム中、3回以上ガケから落ちる";
                        break;
                    case 24:
                        this.textBox1.Text = "周回制：サンドーラ　2周を02'05\"00以内でゴールする";
                        break;
                    case 25:
                        this.textBox1.Text = "周回制：サンドーラ　2周を01'45\"00以内でゴールする";
                        break;
                    case 26:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：サンドーラ　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：サンドーラ　2分で4000フィート以上走る";
                        break;
                    case 27:
                        this.textBox1.Text = "タイムアタック：サンドーラ　03'10\"00以内でゴールする";
                        break;
                    case 28:
                        this.textBox1.Text = "タイムアタック：サンドーラ　02'40\"00以内でゴールする";
                        break;
                    case 29:
                        this.textBox1.Text = "タイムアタック：サンドーラ　ワゴンスター、02'40\"00以内でゴールする";
                        break;
                    case 30:
                        this.textBox1.Text = "フリーラン：サンドーラ　01'05\"00以内で1周する";
                        break;
                    case 31:
                        this.textBox1.Text = "フリーラン：サンドーラ　00'53\"00以内で1周する";
                        break;
                    case 32:
                        this.textBox1.Text = "フリーラン：サンドーラ　ヘビースター、01'05\"00以内で1周する";
                        break;
                    case 33:
                        this.textBox1.Text = "サンドーラ　流砂に3回だけつっこんで1位をとる";
                        break;
                    case 34:
                        this.textBox1.Text = "サンドーラ　地下への入り口を3回だけあけて1位をとる";
                        break;
                    case 35:
                        this.textBox1.Text = "サンドーラ　すべてのサンゴをこわして1位をとる";
                        break;
                    case 36:
                        this.textBox1.Text = "周回制：コルダ　2周を02'20\"00以内でゴールする";
                        break;
                    case 37:
                        this.textBox1.Text = "周回制：コルダ　2周を01'56\"00以内でゴールする";
                        break;
                    case 38:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：コルダ　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：コルダ　2分で5300フィート以上走る";
                        break;
                    case 39:
                        this.textBox1.Text = "タイムアタック：コルダ　03'14\"00以内でゴールする";
                        break;
                    case 40:
                        this.textBox1.Text = "タイムアタック：コルダ　02'50\"00以内でゴールする";
                        break;
                    case 41:
                        this.textBox1.Text = "タイムアタック：コルダ　ターボスター、03'10\"00以内でゴールする";
                        break;
                    case 42:
                        this.textBox1.Text = "フリーラン：コルダ　01'10\"00以内で1周する";
                        break;
                    case 43:
                        this.textBox1.Text = "フリーラン：コルダ　00'58\"00以内で1周する";
                        break;
                    case 44:
                        this.textBox1.Text = "フリーラン：コルダ　フォーミュラスター、01'10\"00以内に1周する";
                        break;
                    case 45:
                        this.textBox1.Text = "コルダ　氷の床を20枚以上割り1位をとる";
                        break;
                    case 46:
                        this.textBox1.Text = "周回制：マグヒート　2周を02'20\"00以内でゴールする";
                        break;
                    case 47:
                        this.textBox1.Text = "周回制：マグヒート　2周を02'01\"00以内でゴールする";
                        break;
                    case 48:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：マグヒート　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：マグヒート　2分で4800フィート以上走る";
                        break;
                    case 49:
                        this.textBox1.Text = "タイムアタック：マグヒート　03'20\"00以内でゴールする";
                        break;
                    case 50:
                        this.textBox1.Text = "タイムアタック：マグヒート　03'04\"00以内でゴールする";
                        break;
                    case 51:
                        this.textBox1.Text = "タイムアタック：マグヒート　デビルスター、03'15\"00以内でゴールする";
                        break;
                    case 52:
                        this.textBox1.Text = "フリーラン：マグヒート　01'10\"00以内で1周する";
                        break;
                    case 53:
                        this.textBox1.Text = "フリーラン：マグヒート　01'01\"00以内で1周する";
                        break;
                    case 54:
                        this.textBox1.Text = "フリーラン：マグヒート　ターボスター、01'02\"00以内に1周する";
                        break;
                    case 55:
                        this.textBox1.Text = "マグヒート　すべてのダッシュパネルを使い、1位をとる";
                        break;
                    case 56:
                        this.textBox1.Text = "マグヒート　火山のすべてのレールを使い、1位をとる";
                        break;
                    case 57:
                        this.textBox1.Text = "マグヒート　火炎龍にぶつかる";
                        break;
                    case 58:
                        this.textBox1.Text = "周回制：アイルーン　2周を02'18\"00以内でゴールする";
                        break;
                    case 59:
                        this.textBox1.Text = "周回制：アイルーン　2周を01'56\"00以内でゴールする";
                        break;
                    case 60:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：アイルーン　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：アイルーン　2分で5500フィート以上走る";
                        break;
                    case 61:
                        this.textBox1.Text = "タイムアタック：アイルーン　03'10\"00以内でゴールする";
                        break;
                    case 62:
                        this.textBox1.Text = "タイムアタック：アイルーン　02'55\"00以内でゴールする";
                        break;
                    case 63:
                        this.textBox1.Text = "タイムアタック：アイルーン　ロケットスター、03'00\"00以内でゴールする";
                        break;
                    case 64:
                        this.textBox1.Text = "フリーラン：アイルーン　01'07\"00以内で1周する";
                        break;
                    case 65:
                        this.textBox1.Text = "フリーラン：アイルーン　00'58\"00以内で1周する";
                        break;
                    case 66:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "フリーラン：アイルーン　ウィングスター、01'00\"00以内に1周する";
                        else this.textBox1.Text = "フリーラン：アイルーン　ウィングスター、00'58\"00以内に1周する";
                        break;
                    case 67:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "アイルーン　観覧車に乗らずに連続5周以上走る";
                        else this.textBox1.Text = "アイルーン　観覧車に乗らずに連続3周以上走る";
                        break;
                    case 68:
                        this.textBox1.Text = "アイルーン　敵を20体以上すいこみ1位をとる";
                        break;
                    case 69:
                        this.textBox1.Text = "周回制：スチールオーガン　2周を02'10\"00以内でゴールする";
                        break;
                    case 70:
                        this.textBox1.Text = "周回制：スチールオーガン　2周を01'48\"00以内でゴールする";
                        break;
                    case 71:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：スチールオーガン　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：スチールオーガン　3分で4500フィート以上走る";
                        break;
                    case 72:
                        this.textBox1.Text = "タイムアタック：スチールオーガン　03'10\"00以内でゴールする";
                        break;
                    case 73:
                        this.textBox1.Text = "タイムアタック：スチールオーガン　02'48\"00以内でゴールする";
                        break;
                    case 74:
                        this.textBox1.Text = "タイムアタック：スチールオーガン　レックスウィリー、02'50\"00以内でゴールする";
                        break;
                    case 75:
                        this.textBox1.Text = "フリーラン：スチールオーガン　01'05\"00以内で1周する";
                        break;
                    case 76:
                        this.textBox1.Text = "フリーラン：スチールオーガン　00'56\"00以内で1周する";
                        break;
                    case 77:
                        this.textBox1.Text = "フリーラン：スチールオーガン　ルインズスター、00'57\"00以内に1周する";
                        break;
                    case 78:
                        this.textBox1.Text = "スチールオーガン　大砲から同時に3人以上飛び出す";
                        break;
                    case 79:
                        this.textBox1.Text = "スチールオーガン　1度もカベにさわらずに1位をとる";
                        break;
                    case 80:
                        this.textBox1.Text = "周回制：チェックナイト　2周を03'05\"00以内でゴールする";
                        break;
                    case 81:
                        this.textBox1.Text = "周回制：チェックナイト　2周を02'40\"00以内でゴールする";
                        break;
                    case 82:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "時間制：チェックナイト　3分で2000m以上走る";
                        else this.textBox1.Text = "時間制：チェックナイト　2分で5500フィート以上走る";
                        break;
                    case 83:
                        this.textBox1.Text = "タイムアタック：チェックナイト　04'30\"00以内でゴールする";
                        break;
                    case 84:
                        this.textBox1.Text = "タイムアタック：チェックナイト　04'00\"00以内でゴールする";
                        break;
                    case 85:
                        this.textBox1.Text = "タイムアタック：チェックナイト　ワープスター、03'55\"00以内でゴールする";
                        break;
                    case 86:
                        this.textBox1.Text = "フリーラン：チェックナイト　01'35\"00以内で1周する";
                        break;
                    case 87:
                        this.textBox1.Text = "フリーラン：チェックナイト　01'20\"00以内で1周する";
                        break;
                    case 88:
                        this.textBox1.Text = "フリーラン：チェックナイト　ロケットスター、01'25\"00以内に1周する";
                        break;
                    case 89:
                        this.textBox1.Text = "チェックナイト　カベを2回以上こわして1位をとる";
                        break;
                    case 90:
                        this.textBox1.Text = "チェックナイト　スピンパネルを7回以上ふんで1位をとる";
                        break;
                    case 91:
                        this.textBox1.Text = "チェックナイト　敵を20体以上すいこみ1位をとる";
                        break;
                    case 92:
                        this.textBox1.Text = "周回制：スリープ能力を持って1位でゴールする";
                        break;
                    case 93:
                        this.textBox1.Text = "周回制：ファイア能力を持って1位でゴールする";
                        break;
                    case 94:
                        this.textBox1.Text = "周回制：ニードル能力を持って1位でゴールする";
                        break;
                    case 95:
                        this.textBox1.Text = "周回制：ウィング能力を持って1位でゴールする";
                        break;
                    case 96:
                        this.textBox1.Text = "ソード能力　レース中、10回だけ剣を振り1位をとる";
                        break;
                    case 97:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "トルネイド能力　敵を20体以上やっつけ、1位をとる";
                        else this.textBox1.Text = "トルネイド能力　敵を15体以上やっつけ、1位をとる";
                        break;
                    case 98:
                        this.textBox1.Text = "\"チリー\"(雪だるまの敵)を3体以上すいこみ、1位をとる";
                        break;
                    case 99:
                        this.textBox1.Text = "\"プラズマウィスプ\"(電気の敵)を3体以上すいこみ、1位をとる";
                        break;
                    case 100:
                        this.textBox1.Text = "\"ソードナイト\"(剣を持った敵)を3体以上すいこみ、1位をとる";
                        break;
                    case 101:
                        this.textBox1.Text = "\"ウィリー\"(バイクの敵)を3体以上すいこみ、1位をとる";
                        break;
                    case 102:
                        this.textBox1.Text = "周回制：スカ(コピー能力がない敵)を5回連続すいこみ、1位をとる";
                        break;
                    case 103:
                        this.textBox1.Text = "周回制：最後の1周を4位で通過し、逆転1位でゴールする";
                        break;
                    case 104:
                        this.textBox1.Text = "周回制：空を飛びながら1位でゴールする";
                        break;
                    case 105:
                        this.textBox1.Text = "周回制：ダメージを受けながら1位でゴールする";
                        break;
                    case 106:
                        this.textBox1.Text = "周回制：スピンしながら1位でゴールする";
                        break;
                    case 107:
                        this.textBox1.Text = "クイックスピンで、敵キャラを総計10体以上やっつける";
                        break;
                    case 108:
                        this.textBox1.Text = "クイックスピンを、総計20回以上ライバルにヒットさせる";
                        break;
                    case 109:
                        this.textBox1.Text = "ラップタイムの下2ケタがゾロ目になる";
                        break;
                    case 110:
                        this.textBox1.Text = "エアライドの基本コースを全て遊ぶ";
                        break;
                    case 111:
                        this.textBox1.Text = "周回制orタイムアタック：総計3回ゴールする";
                        break;
                    case 112:
                        this.textBox1.Text = "敵キャラを、総計300体以上やっつける";
                        break;
                    case 113:
                        this.textBox1.Text = "敵キャラを、総計1000体以上やっつける";
                        break;
                    case 114:
                        this.textBox1.Text = "すいこんだ敵の数が総計200体以上になる";
                        break;
                    case 115:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "星型弾でやっつけた敵の数が総計200体以上になる";
                        else this.textBox1.Text = "星型弾でやっつけた敵の数が総計100体以上になる";
                        break;
                    case 116:
                        this.textBox1.Text = "コースを総計100周以上走る";
                        break;
                    case 117:
                        this.textBox1.Text = "コースを総計300周以上走る";
                        break;
                    case 118:
                        this.textBox1.Text = "コースを総計30分以上滑空する";
                        break;
                    case 119:
                        this.textBox1.Text = "コースを総計1時間以上滑空する";
                        break;
                    case 120:
                        this.textBox1.Text = "クリアチェッカーのマスを100コ以上うめる";
                        break;
                    case 121:
                        this.textBox1.Text = "ウエライド：草　プッシュを使わず1位をとる";
                        break;
                    case 122:
                        this.textBox1.Text = "ウエライド：草　CPレベルを5にして1位をとる";
                        break;
                    case 123:
                        this.textBox1.Text = "ウエライド：草　1位を総計10回以上とる";
                        break;
                    case 124:
                        this.textBox1.Text = "ウエライド：草　7周を00'43\"00以内にゴールする";
                        break;
                    case 125:
                        this.textBox1.Text = "ウエライド：草　2位に5秒以上差をつけて1位をとる";
                        break;
                    case 126:
                        this.textBox1.Text = "タイムアタック：草　00'33\"00以内でゴールする";
                        break;
                    case 127:
                        this.textBox1.Text = "タイムアタック：草　00'28\"00以内でゴールする";
                        break;
                    case 128:
                        this.textBox1.Text = "フリーラン：草　00'06\"00以内で1周する";
                        break;
                    case 129:
                        this.textBox1.Text = "フリーラン：草　00'04\"50以内で1周する";
                        break;
                    case 130:
                        this.textBox1.Text = "ウエライド：草　(アイテムなし 禁止)アイテムを1コもとらないで1位をとる";
                        break;
                    case 131:
                        this.textBox1.Text = "ウエライド：アイテム\"ハンマー\"を持ったまま1位をとる";
                        break;
                    case 132:
                        this.textBox1.Text = "\"ボム\"(爆弾アイテム)を1試合中ライバルに3回以上ぶつける";
                        break;
                    case 133:
                        this.textBox1.Text = "ウエライド：草　1試合中、木から爆弾を30コ以上落とす";
                        break;
                    case 134:
                        this.textBox1.Text = "ウエライド：草　ダッシュパネルを5回以上ふんで1位をとる";
                        break;
                    case 135:
                        this.textBox1.Text = "ウエライド：クイックスピンをしながら1位をとる";
                        break;
                    case 136:
                        this.textBox1.Text = "ウエライド：砂　プッシュを使わず1位をとる";
                        break;
                    case 137:
                        this.textBox1.Text = "ウエライド：砂　CPレベルを5にして1位をとる";
                        break;
                    case 138:
                        this.textBox1.Text = "ウエライド：砂　1位を総計10回以上とる";
                        break;
                    case 139:
                        this.textBox1.Text = "ウエライド：砂　7周を00'52\"00以内にゴールする";
                        break;
                    case 140:
                        this.textBox1.Text = "ウエライド：砂　2位に5秒以上差をつけて1位をとる";
                        break;
                    case 141:
                        this.textBox1.Text = "タイムアタック：砂　00'35\"00以内でゴールする";
                        break;
                    case 142:
                        this.textBox1.Text = "タイムアタック：砂　00'29\"00以内でゴールする";
                        break;
                    case 143:
                        this.textBox1.Text = "フリーラン：砂　00'06\"50以内で1周する";
                        break;
                    case 144:
                        this.textBox1.Text = "フリーラン：砂　00'05\"00以内で1周する";
                        break;
                    case 145:
                        this.textBox1.Text = "ウエライド：砂　(アイテムなし 禁止)アイテムを1コもとらないで1位をとる";
                        break;
                    case 146:
                        this.textBox1.Text = "ウエライド：砂　サンドワームに3回以上つかまり1位をとる";
                        break;
                    case 147:
                        this.textBox1.Text = "ウエライド：砂　総計50回以上ありじごくにおちる";
                        break;
                    case 148:
                        this.textBox1.Text = "ウエライド：砂　1試合中、20回以上ありじごくにおちる";
                        break;
                    case 149:
                        this.textBox1.Text = "ウエライド：空　プッシュを使わず1位をとる";
                        break;
                    case 150:
                        this.textBox1.Text = "ウエライド：空　CPレベルを5にして1位をとる";
                        break;
                    case 151:
                        this.textBox1.Text = "ウエライド：空　1位を総計10回以上とる";
                        break;
                    case 152:
                        this.textBox1.Text = "ウエライド：空　6周を01'02\"00以内にゴールする";
                        break;
                    case 153:
                        this.textBox1.Text = "ウエライド：空　2位に5秒以上差をつけて1位をとる";
                        break;
                    case 154:
                        this.textBox1.Text = "タイムアタック：空　00'57\"00以内でゴールする";
                        break;
                    case 155:
                        this.textBox1.Text = "タイムアタック：空　00'47\"00以内でゴールする";
                        break;
                    case 156:
                        this.textBox1.Text = "フリーラン：空　00'11\"00以内で1周する";
                        break;
                    case 157:
                        this.textBox1.Text = "フリーラン：空　00'09\"00以内で1周する";
                        break;
                    case 158:
                        this.textBox1.Text = "ウエライド：空　(アイテムなし 禁止)アイテムを1コもとらないで1位をとる";
                        break;
                    case 159:
                        this.textBox1.Text = "ウエライド：空　島のスイッチを5回以上おして1位をとる";
                        break;
                    case 160:
                        this.textBox1.Text = "ウエライド：空　ジャンププレートを使わないで1位をとる";
                        break;
                    case 161:
                        this.textBox1.Text = "ウエライド：炎　プッシュを使わず1位をとる";
                        break;
                    case 162:
                        this.textBox1.Text = "ウエライド：炎　CPレベルを5にして1位をとる";
                        break;
                    case 163:
                        this.textBox1.Text = "ウエライド：炎　1位を総計10回以上とる";
                        break;
                    case 164:
                        this.textBox1.Text = "ウエライド：炎　6周を00'53\"00以内にゴールする";
                        break;
                    case 165:
                        this.textBox1.Text = "ウエライド：炎　2位に5秒以上差をつけて1位をとる";
                        break;
                    case 166:
                        this.textBox1.Text = "タイムアタック：炎　00'46\"00以内でゴールする";
                        break;
                    case 167:
                        this.textBox1.Text = "タイムアタック：炎　00'39\"00以内でゴールする";
                        break;
                    case 168:
                        this.textBox1.Text = "フリーラン：炎　00'08\"00以内で1周する";
                        break;
                    case 169:
                        this.textBox1.Text = "フリーラン：炎　00'06\"50以内で1周する";
                        break;
                    case 170:
                        this.textBox1.Text = "ウエライド：炎　(アイテムなし 禁止)アイテムを1コもとらないで1位をとる";
                        break;
                    case 171:
                        this.textBox1.Text = "ウエライド：炎　アイテム\"ファイア\"を持ったまま1位をとる";
                        break;
                    case 172:
                        this.textBox1.Text = "ウエライド：炎　1試合中、大噴火を3回以上起こす";
                        break;
                    case 173:
                        this.textBox1.Text = "ウエライド：光　プッシュを使わず1位をとる";
                        break;
                    case 174:
                        this.textBox1.Text = "ウエライド：光　CPレベルを5にして1位をとる";
                        break;
                    case 175:
                        this.textBox1.Text = "ウエライド：光　1位を総計10回以上とる";
                        break;
                    case 176:
                        this.textBox1.Text = "ウエライド：光　6周を00'43\"00以内にゴールする";
                        break;
                    case 177:
                        this.textBox1.Text = "ウエライド：光　2位に5秒以上差をつけて1位をとる";
                        break;
                    case 178:
                        this.textBox1.Text = "タイムアタック：光　00'38\"00以内でゴールする";
                        break;
                    case 179:
                        this.textBox1.Text = "タイムアタック：光　00'33\"00以内でゴールする";
                        break;
                    case 180:
                        this.textBox1.Text = "フリーラン：光　00'07\"50以内で1周する";
                        break;
                    case 181:
                        this.textBox1.Text = "フリーラン：光　00'06\"00以内で1周する";
                        break;
                    case 182:
                        this.textBox1.Text = "ウエライド：光　(アイテムなし 禁止)アイテムを1コもとらないで1位をとる";
                        break;
                    case 183:
                        this.textBox1.Text = "ウエライド：光　グラインドレールに総計50回以上乗る";
                        break;
                    case 184:
                        this.textBox1.Text = "ウエライド：光　グラインドレールに5回以上乗り1位をとる";
                        break;
                    case 185:
                        this.textBox1.Text = "ウエライド：光　6本以上の柱をこわして1位をとる";
                        break;
                    case 186:
                        this.textBox1.Text = "ウエライド：カベに1度もぶつからないで1位をとる";
                        break;
                    case 187:
                        this.textBox1.Text = "ウエライド：水　プッシュを使わず1位をとる";
                        break;
                    case 188:
                        this.textBox1.Text = "ウエライド：水　CPレベルを5にして1位をとる";
                        break;
                    case 189:
                        this.textBox1.Text = "ウエライド：水　1位を総計10回以上とる";
                        break;
                    case 190:
                        this.textBox1.Text = "ウエライド：水　5周を01'02\"00以内にゴールする";
                        break;
                    case 191:
                        this.textBox1.Text = "ウエライド：水　2位に5秒以上差をつけて1位をとる";
                        break;
                    case 192:
                        this.textBox1.Text = "タイムアタック：水　01'06\"00以内でゴールする";
                        break;
                    case 193:
                        this.textBox1.Text = "タイムアタック：水　00'56\"00以内でゴールする";
                        break;
                    case 194:
                        this.textBox1.Text = "フリーラン：水　00'12\"00以内で1周する";
                        break;
                    case 195:
                        this.textBox1.Text = "フリーラン：水　00'10\"50以内で1周する";
                        break;
                    case 196:
                        this.textBox1.Text = "ウエライド：水　(アイテムなし 禁止)アイテムを1コもとらないで1位をとる";
                        break;
                    case 197:
                        this.textBox1.Text = "1回の\"ファイア\"(火炎放射アイテム)発射で、ライバル3台以上を燃やす";
                        break;
                    case 198:
                        this.textBox1.Text = "1回の\"ギコノコ\"(丸ノコアイテム)でライバル3台以上をはねとばす";
                        break;
                    case 199:
                        this.textBox1.Text = "ウエライド：水　5回以上滝に入って1位をとる";
                        break;
                    case 200:
                        this.textBox1.Text = "ウエライド：鉄　プッシュを使わず1位をとる";
                        break;
                    case 201:
                        this.textBox1.Text = "ウエライド：鉄　CPレベルを5にして1位をとる";
                        break;
                    case 202:
                        this.textBox1.Text = "ウエライド：鉄　1位を総計10回以上とる";
                        break;
                    case 203:
                        this.textBox1.Text = "ウエライド：鉄　5周を00'58\"00以内にゴールする";
                        break;
                    case 204:
                        this.textBox1.Text = "ウエライド：鉄　2位に5秒以上差をつけて1位をとる";
                        break;
                    case 205:
                        this.textBox1.Text = "タイムアタック：鉄　00'57\"00以内でゴールする";
                        break;
                    case 206:
                        this.textBox1.Text = "タイムアタック：鉄　00'51\"00以内でゴールする";
                        break;
                    case 207:
                        this.textBox1.Text = "フリーラン：鉄　00'11\"50以内で1周する";
                        break;
                    case 208:
                        this.textBox1.Text = "フリーラン：鉄　00'09\"50以内で1周する";
                        break;
                    case 209:
                        this.textBox1.Text = "ウエライド：鉄　(アイテムなし 禁止)アイテムを1コもとらないで1位をとる";
                        break;
                    case 210:
                        this.textBox1.Text = "ウエライド：鉄　1度も歯車のカベをこわさないで1位をとる";
                        break;
                    case 211:
                        this.textBox1.Text = "ウエライド：鉄　スイッチを10回以上おして1位をとる";
                        break;
                    case 212:
                        this.textBox1.Text = "ウエライド：鉄　歯車のカベを5回以上こわして1位をとる";
                        break;
                    case 213:
                        this.textBox1.Text = "ウエライド：クイックスピンを20回以上して1位をとる";
                        break;
                    case 214:
                        this.textBox1.Text = "ウエライド：2位に1周以上の差をつけて1位をとる";
                        break;
                    case 215:
                        this.textBox1.Text = "ウエライド：2位に2周以上の差をつけて1位をとる";
                        break;
                    case 216:
                        this.textBox1.Text = "ウエライド：1試合中同じアイテムを3回以上とる";
                        break;
                    case 217:
                        this.textBox1.Text = "ウエライド：総計50回以上対戦する";
                        break;
                    case 218:
                        this.textBox1.Text = "ウエライド：総計10回以上対戦する";
                        break;
                    case 219:
                        this.textBox1.Text = "総計20回以上ゴールする";
                        break;
                    case 220:
                        this.textBox1.Text = "ウエライド：総計300周以上走る";
                        break;
                    case 221:
                        this.textBox1.Text = "フリーラン：総計100周以上走る";
                        break;
                    case 222:
                        this.textBox1.Text = "タイムアタック：総計30回以上ゴールする";
                        break;
                    case 223:
                        this.textBox1.Text = "ウエライド：全コース1位をとる";
                        break;
                    case 224:
                        this.textBox1.Text = "ウエライド：(アイテムなし 禁止)全コースで1コもアイテムをとらないで完走する";
                        break;
                    case 225:
                        this.textBox1.Text = "ウエライド：(アイテムなし 禁止)全コースで1コもアイテムをとらないで1位をとる";
                        break;
                    case 226:
                        this.textBox1.Text = "アイテムを総計500コ以上とる";
                        break;
                    case 227:
                        this.textBox1.Text = "ウエライド：全コースで、プッシュを使わず完走する";
                        break;
                    case 228:
                        this.textBox1.Text = "ウエライド：全コースで、プッシュを使わず1位をとる";
                        break;
                    case 229:
                        this.textBox1.Text = "\"フットバス\"(スピンするアイテム)を総計20コ以上とる";
                        break;
                    case 230:
                        this.textBox1.Text = "\"キャンディ\"(無敵になるアイテム)を総計20コ以上とる";
                        break;
                    case 231:
                        this.textBox1.Text = "\"マイク\"(大声を出すアイテム)を総計20コ以上とる";
                        break;
                    case 232:
                        this.textBox1.Text = "アイテムを総計18種類以上とる";
                        break;
                    case 233:
                        this.textBox1.Text = "ウエライド：草　総計100周以上走る";
                        break;
                    case 234:
                        this.textBox1.Text = "ウエライド：砂　総計100周以上走る";
                        break;
                    case 235:
                        this.textBox1.Text = "ウエライド：空　総計100周以上走る";
                        break;
                    case 236:
                        this.textBox1.Text = "ウエライド：炎　総計100周以上走る";
                        break;
                    case 237:
                        this.textBox1.Text = "ウエライド：水　総計100周以上走る";
                        break;
                    case 238:
                        this.textBox1.Text = "ウエライド：光　総計100周以上走る";
                        break;
                    case 239:
                        this.textBox1.Text = "ウエライド：鉄　総計100周以上走る";
                        break;
                    case 240:
                        this.textBox1.Text = "クリアチェッカーのマスを100コ以上うめる";
                        break;
                    case 241:
                        this.textBox1.Text = "シティトライアル：スタートから10秒以内にライバルにダメージを与える";
                        break;
                    case 242:
                        this.textBox1.Text = "シティトライアル：スタートから20秒以内にアイテムを10コとる";
                        break;
                    case 243:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "シティトライアル：スーパージャンプ台で総計5回以上ビルの屋上に登る";
                        else this.textBox1.Text = "シティトライアル：スーパージャンプ台で総計10回以上ビルの屋上に登る";
                        break;
                    case 244:
                        this.textBox1.Text = "シティトライアル：スターポールの星をこわす";
                        break;
                    case 245:
                        this.textBox1.Text = "シティトライアル：スターポールの星を総計10回以上こわす";
                        break;
                    case 246:
                        this.textBox1.Text = "シティトライアル：1試合中、空中のリングを5回以上通過する";
                        break;
                    case 247:
                        this.textBox1.Text = "シティトライアル：コピールーレットでボム能力をとる";
                        break;
                    case 248:
                        this.textBox1.Text = "シティトライアル：コピールーレットでスリープ能力をとる";
                        break;
                    case 249:
                        this.textBox1.Text = "シティトライアル：1試合中、カソクパネルを10コ以上とる";
                        break;
                    case 250:
                        this.textBox1.Text = "シティトライアル：1試合中、サイコウソクパネルを10コ以上とる";
                        break;
                    case 251:
                        this.textBox1.Text = "シティトライアル：1試合中、センカイパネルを10コ以上とる";
                        break;
                    case 252:
                        this.textBox1.Text = "シティトライアル：1試合中、チャージパネルを10コ以上とる";
                        break;
                    case 253:
                        this.textBox1.Text = "シティトライアル：1試合中、オモサパネルを10コ以上とる";
                        break;
                    case 254:
                        this.textBox1.Text = "シティトライアル：1試合中、ボウギョパネルを10コ以上とる";
                        break;
                    case 255:
                        this.textBox1.Text = "シティトライアル：1試合中、ヒコウパネルを10コ以上とる";
                        break;
                    case 256:
                        this.textBox1.Text = "シティトライアル：1試合中、マキシムトマトを2コ以上食べる";
                        break;
                    case 257:
                        this.textBox1.Text = "シティトライアル：1試合中、元気ドリンクを3本以上飲む";
                        break;
                    case 258:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "シティトライアル：1試合中、天ぷらそばを3杯以上食べる";
                        else this.textBox1.Text = "シティトライアル：1試合中、ホットドッグを3個以上食べる";
                        break;
                    case 259:
                        this.textBox1.Text = "シティトライアル：1試合中、すしを3皿以上食べる";
                        break;
                    case 260:
                        this.textBox1.Text = "シティトライアル：1試合中、平原地区のホールに3回以上カップインする";
                        break;
                    case 261:
                        this.textBox1.Text = "シティトライアル：グラインドレールで火口へ突入する";
                        break;
                    case 262:
                        this.textBox1.Text = "シティトライアル：空中庭園にたどりつく";
                        break;
                    case 263:
                        this.textBox1.Text = "シティトライアル：森の木をすべて倒す";
                        break;
                    case 264:
                        this.textBox1.Text = "シティトライアル：1試合中、火山、平原の岩をすべてこわす";
                        break;
                    case 265:
                        this.textBox1.Text = "シティトライアル：廃屋をすべてこわす";
                        break;
                    case 266:
                        this.textBox1.Text = "シティトライアル：ライバルを総計3回以上、センサーボムを使って倒す";
                        break;
                    case 267:
                        this.textBox1.Text = "シティトライアル：ライバルを総計3回以上、ゴルボールを使って倒す";
                        break;
                    case 268:
                        this.textBox1.Text = "シティトライアル：ライバルを総計10回以上、クラッカーを使って倒す";
                        break;
                    case 269:
                        this.textBox1.Text = "シティトライアル：街で総計5回以上、CPのマシンをこわす";
                        break;
                    case 270:
                        this.textBox1.Text = "シティトライアル：3人CPを入れ、街で全CPマシンに対してダメージを与える";
                        break;
                    case 271:
                        this.textBox1.Text = "シティトライアル：街でライトスターに乗ってウィリースクーターをこわす";
                        break;
                    case 272:
                        this.textBox1.Text = "シティトライアル：街でワープスターに乗ってウィリーバイクをこわす";
                        break;
                    case 273:
                        this.textBox1.Text = "シティトライアル：街でウィリーバイクに乗ってルインズスターをこわす";
                        break;
                    case 274:
                        this.textBox1.Text = "シティトライアル：街でルインズスターに乗ってワープスターをこわす";
                        break;
                    case 275:
                        this.textBox1.Text = "シティトライアル：街でターボスターに乗ってフォーミュラスターをこわす";
                        break;
                    case 276:
                        this.textBox1.Text = "シティトライアル：街でフォーミュラスターに乗ってスリックスターをこわす";
                        break;
                    case 277:
                        this.textBox1.Text = "シティトライアル：街でスリックスターに乗ってロケットスターをこわす";
                        break;
                    case 278:
                        this.textBox1.Text = "シティトライアル：街でロケットスターに乗ってターボスターをこわす";
                        break;
                    case 279:
                        this.textBox1.Text = "シティトライアル：全員マシンに乗っていない時にタイムアップする";
                        break;
                    case 280:
                        this.textBox1.Text = "シティトライアル：参加者全員同時にエアライドマシンから降りる";
                        break;
                    case 281:
                        this.textBox1.Text = "シティトライアル：全員レールの上でタイムアップする";
                        break;
                    case 282:
                        this.textBox1.Text = "1試合でドラグーンとハイドラが完成する";
                        break;
                    case 283:
                        this.textBox1.Text = "シティトライアル：出現した回復エリアを1つ以上使い切る";
                        break;
                    case 284:
                        this.textBox1.Text = "シティトライアル：タックからアイテムをひとりで8コ以上うばう";
                        break;
                    case 285:
                        this.textBox1.Text = "シティトライアル：巨岩が出現してから40秒以内にこわす";
                        break;
                    case 286:
                        this.textBox1.Text = "シティトライアル：ダイナブレイドにダメージを与える";
                        break;
                    case 287:
                        this.textBox1.Text = "シティトライアル：ダイナブレイドにふみつけられる";
                        break;
                    case 288:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック1　00'24\"00以内でゴールする";
                        break;
                    case 289:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック1　00'20\"00以内でゴールする";
                        break;
                    case 290:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック1　ワープスター、00'26\"00以内でゴールする";
                        break;
                    case 291:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック1　フォーミュラスター、00'17\"00以内でゴールする";
                        break;
                    case 292:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック2　00'24\"00以内でゴールする";
                        break;
                    case 293:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック2　00'20\"00以内でゴールする";
                        break;
                    case 294:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック2　ワゴンスター、00'27\"00以内でゴールする";
                        break;
                    case 295:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック2　ウィングスター、00'29\"00以内でゴールする";
                        break;
                    case 296:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック3　00'35\"00以内でゴールする";
                        break;
                    case 297:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック3　00'27\"00以内でゴールする";
                        break;
                    case 298:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック3　ルインズスター、00'28\"00以内でゴールする";
                        break;
                    case 299:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック3　ウィリーバイク、00'31\"00以内でゴールする";
                        break;
                    case 300:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック4　00'24\"00以内でゴールする";
                        break;
                    case 301:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック4　00'19\"00以内でゴールする";
                        break;
                    case 302:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック4　ターボスター、00'33\"00以内でゴールする";
                        break;
                    case 303:
                        this.textBox1.Text = "スタジアム：ゼロヨンアタック4　レックスウィリー、00'24\"00以内でゴールする";
                        break;
                    case 304:
                        this.textBox1.Text = "スタジアム：デスマッチ1　1試合中、ライバルを5回以上倒す";
                        break;
                    case 305:
                        this.textBox1.Text = "スタジアム：デスマッチ1　1試合中、ライバルを10回以上倒す";
                        break;
                    case 306:
                        this.textBox1.Text = "スタジアム：デスマッチ1　フィールド上の岩をすべてこわす";
                        break;
                    case 307:
                        this.textBox1.Text = "スタジアム：デスマッチ2　1試合中、ライバルを5回以上倒す";
                        break;
                    case 308:
                        this.textBox1.Text = "スタジアム：デスマッチ2　1試合中、ライバルを10回以上倒す";
                        break;
                    case 309:
                        this.textBox1.Text = "スタジアム：デスマッチ3　1試合中、ライバルを5回以上倒す";
                        break;
                    case 310:
                        this.textBox1.Text = "スタジアム：デスマッチ4　1試合中、ライバルを5回以上倒す";
                        break;
                    case 311:
                        this.textBox1.Text = "スタジアム：デスマッチ4　1試合中、ライバルを10回以上倒す";
                        break;
                    case 312:
                        this.textBox1.Text = "スタジアム：デスマッチ5　1試合中、ライバルを5回以上倒す";
                        break;
                    case 313:
                        this.textBox1.Text = "スタジアム：デスマッチ5　1試合中、ライバルを10回以上倒す";
                        break;
                    case 314:
                        this.textBox1.Text = "スタジアム：ポイントストライク　1試合中、150点以上とる";
                        break;
                    case 315:
                        this.textBox1.Text = "スタジアム：ポイントストライク　1試合中、ぴったり90点とる";
                        break;
                    case 316:
                        this.textBox1.Text = "スタジアム：ポイントストライク　1試合中、200点(パーフェクト)をとる";
                        break;
                    case 317:
                        this.textBox1.Text = "スタジアム：ポイントストライク　15秒以上飛び続ける";
                        break;
                    case 318:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "スタジアム：エアグライダー　飛距離100m以上を出す";
                        else this.textBox1.Text = "スタジアム：エアグライダー　飛距離330フィート以上を出す";
                        break;
                    case 319:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "スタジアム：エアグライダー　飛距離200m以上を出す";
                        else this.textBox1.Text = "スタジアム：エアグライダー　飛距離660フィート以上を出す";
                        break;
                    case 320:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "スタジアム：エアグライダー　飛距離400m以上を出す";
                        else this.textBox1.Text = "スタジアム：エアグライダー　飛距離1300フィート以上を出す";
                        break;
                    case 321:
                        this.textBox1.Text = "スタジアム：エアグライダー　30秒以上飛び続ける";
                        break;
                    case 322:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "スタジアム：ハイジャンプ　高さ150m以上跳ぶ";
                        else this.textBox1.Text = "スタジアム：ハイジャンプ　高さ500フィート以上跳ぶ";
                        break;
                    case 323:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "スタジアム：ハイジャンプ　高さ300m以上跳ぶ";
                        else this.textBox1.Text = "スタジアム：ハイジャンプ　高さ1000フィート以上跳ぶ";
                        break;
                    case 324:
                        this.textBox1.Text = "スタジアム：ハイジャンプ　10秒以上飛び続ける";
                        break;
                    case 325:
                        this.textBox1.Text = "スタジアム：バトルロイヤル1　1試合中、敵を50体以上やっつける";
                        break;
                    case 326:
                        this.textBox1.Text = "スタジアム：バトルロイヤル1　1試合中、ひとりで敵を75体以上倒す";
                        break;
                    case 327:
                        this.textBox1.Text = "スタジアム：バトルロイヤル2　1試合中、敵を30体以上やっつける";
                        break;
                    case 328:
                        this.textBox1.Text = "スタジアム：バトルロイヤル2　1試合中、ひとりで敵を40体以上倒す";
                        break;
                    case 329:
                        this.textBox1.Text = "スタジアム：VSデデデ　デデデ大王を1分以内に倒す";
                        break;
                    case 330:
                        this.textBox1.Text = "ドライブ：エアライドマシンを10回以上乗りかえる";
                        break;
                    case 331:
                        this.textBox1.Text = "ドライブ：総計10分以上走る";
                        break;
                    case 332:
                        this.textBox1.Text = "ドライブ：総計30分以上走る";
                        break;
                    case 333:
                        this.textBox1.Text = "ドライブ：総計2時間以上走る";
                        break;
                    case 334:
                        this.textBox1.Text = "シティトライアル：森の落とし穴をあける";
                        break;
                    case 335:
                        this.textBox1.Text = "シティトライアル：火山のふもとの穴をすべてあける";
                        break;
                    case 336:
                        this.textBox1.Text = "シティトライアル：水車に総計10回以上運ばれる";
                        break;
                    case 337:
                        this.textBox1.Text = "シティトライアル：出現した巨岩を総計5回以上こわす";
                        break;
                    case 338:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "シティトライアル：街がメテオに総計5回以上襲われる";
                        else this.textBox1.Text = "シティトライアル：街がメテオに総計3回以上襲われる";
                        break;
                    case 339:
                        this.textBox1.Text = "シティトライアル：城のシャッターが開いた時、中に入る";
                        break;
                    case 340:
                        this.textBox1.Text = "シティトライアル：ヒコウパネルを総計30コ以上とる";
                        break;
                    case 341:
                        this.textBox1.Text = "シティトライアル：1試合中、アイテムを50コ以上とる";
                        break;
                    case 342:
                        this.textBox1.Text = "シティトライアル：アイテムを総計100コ以上とる";
                        break;
                    case 343:
                        this.textBox1.Text = "シティトライアル：アイテムを総計500コ以上とる";
                        break;
                    case 344:
                        this.textBox1.Text = "シティトライアル：アイテムを総計1000コ以上とる";
                        break;
                    case 345:
                        this.textBox1.Text = "シティトライアル：アイテムを総計3000コ以上とる";
                        break;
                    case 346:
                        this.textBox1.Text = "シティトライアル：コンテナを総計500コ以上こわす";
                        break;
                    case 347:
                        this.textBox1.Text = "シティトライアル：コンテナを総計1000コ以上こわす";
                        break;
                    case 348:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "シティトライアル：街を走った距離が、総計100km以上になる";
                        else this.textBox1.Text = "シティトライアル：街を走った距離が、総計60マイル以上になる";
                        break;
                    case 349:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "シティトライアル：街を走った距離が、総計300km以上になる";
                        else this.textBox1.Text = "シティトライアル：街を走った距離が、総計200マイル以上になる";
                        break;
                    case 350:
                        this.textBox1.Text = "スタジアム：デスマッチ(すべて)　ライバルを総計50回以上倒す";
                        break;
                    case 351:
                        this.textBox1.Text = "スタジアム：デスマッチ(すべて)　ライバルを総計150回以上倒す";
                        break;
                    case 352:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "スタジアム：ポイントストライク30回以上遊ぶ";
                        else this.textBox1.Text = "スタジアム：ポイントストライク15回以上遊ぶ";
                        break;
                    case 353:
                        this.textBox1.Text = "スタジアム：ポイントストライク総計1500点以上とる";
                        break;
                    case 354:
                        this.textBox1.Text = "スタジアム：バトルロイヤル(すべて)　総計500体以上の敵をやっつける";
                        break;
                    case 355:
                        this.textBox1.Text = "スタジアム：バトルロイヤル(すべて)　総計1500体以上の敵をやっつける";
                        break;
                    case 356:
                        this.textBox1.Text = "スタジアム：遊べるスタジアムが10種類以上になる";
                        break;
                    case 357:
                        this.textBox1.Text = "スタジアム：遊べるスタジアムが20種類以上になる";
                        break;
                    case 358:
                        this.textBox1.Text = "クリアチェッカー上で、ドラグーンパーツA,B,Cをそろえる";
                        break;
                    case 359:
                        this.textBox1.Text = "クリアチェッカー上で、ハイドラパーツA,B,Cをそろえる";
                        break;
                    case 360:
                        this.textBox1.Text = "クリアチェッカーのマスを100コ以上うめる";
                        break;
                    default:
                        break;
                }
            }
            else if (this.toolStripMenuItem6.Checked == true)
            {
                switch (checkBoxNumber)
                {
                    case 1:
                        this.textBox1.Text = "Air Ride: FANTASY MEADOWS　Finish 3 laps in under 01:20:00!";
                        break;
                    case 2:
                        this.textBox1.Text = "Air Ride: FANTASY MEADOWS　Finish 3 laps in under 01:03:00!";
                        break;
                    case 3:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: FANTASY MEADOWS　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: FANTASY MEADOWS　Race over 4,500 feet in 2 minutes!";
                        break;
                    case 4:
                        this.textBox1.Text = "Time Attack: FANTASY MEADOWS　Finish in under 01:12:00!";
                        break;
                    case 5:
                        this.textBox1.Text = "Time Attack: FANTASY MEADOWS　Finish in under 01:00:00!";
                        break;
                    case 6:
                        this.textBox1.Text = "Time Attack: FANTASY MEADOWS　Finish in under 01:05:00 on Slick Star!";
                        break;
                    case 7:
                        this.textBox1.Text = "Free Run: FANTASY MEADOWS　Finish 1 lap in under 00:24:00!";
                        break;
                    case 8:
                        this.textBox1.Text = "Free Run: FANTASY MEADOWS　Finish 1 lap in under 00:21:00!";
                        break;
                    case 9:
                        this.textBox1.Text = "Free Run: FANTASY MEADOWS　Do 1 lap under 00:23:00 on Wagon Star!";
                        break;
                    case 10:
                        this.textBox1.Text = "FANTASY MEADOWS: Swallow over 20 enemies and take 1st place!";
                        break;
                    case 11:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "FANTASY MEADOWS: Race 1 lap without dropping below 30 km/h!";
                        else this.textBox1.Text = "FANTASY MEADOWS: Race 1 lap without dropping below 20 mph!";
                        break;
                    case 12:
                        this.textBox1.Text = "Air Ride: CELESTIAL VALLEY　Finish 2 laps in under 02:20:00!";
                        break;
                    case 13:
                        this.textBox1.Text = "Air Ride: CELESTIAL VALLEY　Finish 2 laps in under 01:56:00!";
                        break;
                    case 14:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: CELESTIAL VALLEY　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: CELESTIAL VALLEY　Race over 6,000 feet in 2 minutes!";
                        break;
                    case 15:
                        this.textBox1.Text = "Time Attack: CELESTIAL VALLEY　Finish in under 03:20:00!";
                        break;
                    case 16:
                        this.textBox1.Text = "Time Attack: CELESTIAL VALLEY　Finish in under 02:56:00!";
                        break;
                    case 17:
                        this.textBox1.Text = "Time Attack: CELESTIAL VALLEY　Finish in under 02:58:00 on Jet Star!";
                        break;
                    case 18:
                        this.textBox1.Text = "Free Run: CELESTIAL VALLEY　Finish 1 lap in under 01:10:00!";
                        break;
                    case 19:
                        this.textBox1.Text = "Free Run: CELESTIAL VALLEY　Finish 1 lap in under 00:57:00!";
                        break;
                    case 20:
                        this.textBox1.Text = "Free Run: CELESTIAL VALLEY　Do 1 lap under 01:02:00 on Slick Star!";
                        break;
                    case 21:
                        this.textBox1.Text = "CELESTIAL VALLEY: Over one race, ride on both the left and right bridge railings!";
                        break;
                    case 22:
                        this.textBox1.Text = "CELESTIAL VALLEY: Use the Copy Chance Wheel on top of the tree!";
                        break;
                    case 23:
                        this.textBox1.Text = "In one game, drop from the cliffs 3 times!";
                        break;
                    case 24:
                        this.textBox1.Text = "Air Ride: SKY SANDS　Finish 2 laps in under 02:05:00!";
                        break;
                    case 25:
                        this.textBox1.Text = "Air Ride: SKY SANDS　Finish 2 laps in under 01:45:00!";
                        break;
                    case 26:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: SKY SANDS　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: SKY SANDS　Race over 4,000 feet in 2 minutes!";
                        break;
                    case 27:
                        this.textBox1.Text = "Time Attack: SKY SANDS　Finish in under 03:10:00!";
                        break;
                    case 28:
                        this.textBox1.Text = "Time Attack: SKY SANDS　Finish in under 02:40:00!";
                        break;
                    case 29:
                        this.textBox1.Text = "Time Attack: SKY SANDS　Finish in under 02:40:00 on Wagon Star!";
                        break;
                    case 30:
                        this.textBox1.Text = "Free Run: SKY SANDS　Finish 1 lap in under 01:05:00!";
                        break;
                    case 31:
                        this.textBox1.Text = "Free Run: SKY SANDS　Finish 1 lap in under 00:53:00!";
                        break;
                    case 32:
                        this.textBox1.Text = "Free Run: SKY SANDS　Do 1 lap under 01:05:00 on Bulk Star!";
                        break;
                    case 33:
                        this.textBox1.Text = "SKY SANDS: Enter the quicksand 3 times and finish in 1st place!";
                        break;
                    case 34:
                        this.textBox1.Text = "SKY SANDS: Open the trapdoor exactly 3 times and finish in 1st place!";
                        break;
                    case 35:
                        this.textBox1.Text = "SKY SANDS: Break all of the coral and finish in 1st place!";
                        break;
                    case 36:
                        this.textBox1.Text = "Air Ride: FROZEN HILLSIDE　Race 2 laps in under 02:20:00!";
                        break;
                    case 37:
                        this.textBox1.Text = "Air Ride: FROZEN HILLSIDE　Race 2 laps in under 01:56:00!";
                        break;
                    case 38:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: FROZEN HILLSIDE　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: FROZEN HILLSIDE　Race over 5,300 feet in 2 minutes!";
                        break;
                    case 39:
                        this.textBox1.Text = "Time Attack: FROZEN HILLSIDE　Finish in under 03:14:00!";
                        break;
                    case 40:
                        this.textBox1.Text = "Time Attack: FROZEN HILLSIDE　Finish in under 02:50:00!";
                        break;
                    case 41:
                        this.textBox1.Text = "Time Attack: FROZEN HILLSIDE　Finish in under 03:10:00 on Turbo Star!";
                        break;
                    case 42:
                        this.textBox1.Text = "Free Run: FROZEN HILLSIDE　Finish 1 lap in under 01:10:00!";
                        break;
                    case 43:
                        this.textBox1.Text = "Free Run: FROZEN HILLSIDE　Finish 1 lap in under 00:58:00!";
                        break;
                    case 44:
                        this.textBox1.Text = "Free Run: FROZEN HILLSIDE　Do 1 lap under 01:10:00 on Formula Star!";
                        break;
                    case 45:
                        this.textBox1.Text = "FROZEN HILLSIDE: Split at least 20 ice platforms and finish in 1st place!";
                        break;
                    case 46:
                        this.textBox1.Text = "Air Ride: MAGMA FLOWS　Finish 2 laps in under 02:20:00!";
                        break;
                    case 47:
                        this.textBox1.Text = "Air Ride: MAGMA FLOWS　Finish 2 laps in under 02:01:00!";
                        break;
                    case 48:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: MAGMA FLOWS　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: MAGMA FLOWS　Race over 4,800 feet in 2 minutes!";
                        break;
                    case 49:
                        this.textBox1.Text = "Time Attack: MAGMA FLOWS　Finish in under 03:20:00!";
                        break;
                    case 50:
                        this.textBox1.Text = "Time Attack: MAGMA FLOWS　Finish in under 03:04:00!";
                        break;
                    case 51:
                        this.textBox1.Text = "Time Attack: MAGMA FLOWS　Finish in under 03:15:00 on Shadow Star!";
                        break;
                    case 52:
                        this.textBox1.Text = "Free Run: MAGMA FLOWS　Finish 1 lap in under 01:10:00!";
                        break;
                    case 53:
                        this.textBox1.Text = "Free Run: MAGMA FLOWS　Finish 1 lap in under 01:01:00!";
                        break;
                    case 54:
                        this.textBox1.Text = "Free Run: MAGMA FLOWS　Do 1 lap under 01:02:00 on Turbo Star!";
                        break;
                    case 55:
                        this.textBox1.Text = "MAGMA FLOWS: Use all of the Boost Panels and finish in 1st place!";
                        break;
                    case 56:
                        this.textBox1.Text = "MAGMA FLOWS: Use all the volcano rails and finish in 1st place!";
                        break;
                    case 57:
                        this.textBox1.Text = "MAGMA FLOWS: Bump into a flaming dragon!";
                        break;
                    case 58:
                        this.textBox1.Text = "Air Ride: BEANSTALK PARK　Finish 2 laps in under 02:18:00!";
                        break;
                    case 59:
                        this.textBox1.Text = "Air Ride: BEANSTALK PARK　Finish 2 laps in under 01:56:00!";
                        break;
                    case 60:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: BEANSTALK PARK　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: BEANSTALK PARK　Race over 5,500 feet in 2 minutes!";
                        break;
                    case 61:
                        this.textBox1.Text = "Time Attack: BEANSTALK PARK　Finish in under 03:10:00!";
                        break;
                    case 62:
                        this.textBox1.Text = "Time Attack: BEANSTALK PARK　Finish in under 02:55:00!";
                        break;
                    case 63:
                        this.textBox1.Text = "Time Attack: BEANSTALK PARK　Finish in under 03:00:00 on Rocket Star!";
                        break;
                    case 64:
                        this.textBox1.Text = "Free Run: BEANSTALK PARK　Finish 1 lap in under 01:07:00!";
                        break;
                    case 65:
                        this.textBox1.Text = "Free Run: BEANSTALK PARK　Finish 1 lap in under 00:58:00!";
                        break;
                    case 66:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Free Run: BEANSTALK PARK　Do 1 lap under 01:00:00 on Winged Star!";
                        else this.textBox1.Text = "Free Run: BEANSTALK PARK　Do 1 lap under 00:58:00 on Winged Star!";
                        break;
                    case 67:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "BEANSTALK PARK: Race over 5 laps without riding the Ferris wheel!";
                        else this.textBox1.Text = "BEANSTALK PARK: Race over 3 laps without riding the Ferris wheel!";
                        break;
                    case 68:
                        this.textBox1.Text = "BEANSTALK PARK: Swallow over 20 enemies and take 1st place!";
                        break;
                    case 69:
                        this.textBox1.Text = "Air Ride: MACHINE PASSAGE　Finish 2 laps in under 02:10:00!";
                        break;
                    case 70:
                        this.textBox1.Text = "Air Ride: MACHINE PASSAGE　Finish 2 laps in under 01:48:00!";
                        break;
                    case 71:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: MACHINE PASSAGE　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: MACHINE PASSAGE　Race over 4,500 feet in 2 minutes!";
                        break;
                    case 72:
                        this.textBox1.Text = "Time Attack: MACHINE PASSAGE　Finish in under 03:10:00!";
                        break;
                    case 73:
                        this.textBox1.Text = "Time Attack: MACHINE PASSAGE　Finish in under 02:48:00!";
                        break;
                    case 74:
                        this.textBox1.Text = "Time Attack: MACHINE PASSAGE　Finish in under 02:50:00 on Rex Wheelie!";
                        break;
                    case 75:
                        this.textBox1.Text = "Free Run: MACHINE PASSAGE　Finish 1 lap in under 01:05:00!";
                        break;
                    case 76:
                        this.textBox1.Text = "Free Run: MACHINE PASSAGE　Finish 1 lap in under 00:56:00!";
                        break;
                    case 77:
                        this.textBox1.Text = "Free Run: MACHINE PASSAGE　Finish 1 lap in under 00:57:00 on Swerve Star!";
                        break;
                    case 78:
                        this.textBox1.Text = "MACHINE PASSAGE: Shoot 3 characters out of the cannon at one time!";
                        break;
                    case 79:
                        this.textBox1.Text = "MACHINE PASSAGE: Finish in 1st place without touching the walls even once!";
                        break;
                    case 80:
                        this.textBox1.Text = "Air Ride: CHECKER KNIGHTS　Finish 2 laps in under 03:05:00!";
                        break;
                    case 81:
                        this.textBox1.Text = "Air Ride: CHECKER KNIGHTS　Finish 2 laps in under 02:40:00!";
                        break;
                    case 82:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Air Ride: CHECKER KNIGHTS　Race over 2,000 meter in 3 minutes!";
                        else this.textBox1.Text = "Air Ride: CHECKER KNIGHTS　Race over 5,500 feet in 2 minutes!";
                        break;
                    case 83:
                        this.textBox1.Text = "Time Attack: CHECKER KNIGHTS　Finish in under 04:30:00!";
                        break;
                    case 84:
                        this.textBox1.Text = "Time Attack: CHECKER KNIGHTS　Finish in under 04:00:00!";
                        break;
                    case 85:
                        this.textBox1.Text = "Time Attack: CHECKER KNIGHTS　Finish in under 03:55:00 on Warpstar!";
                        break;
                    case 86:
                        this.textBox1.Text = "Free Run: CHECKER KNIGHTS　Finish 1 lap in under 01:35:00!";
                        break;
                    case 87:
                        this.textBox1.Text = "Free Run: CHECKER KNIGHTS　Finish 1 lap in under 01:20:00!";
                        break;
                    case 88:
                        this.textBox1.Text = "Free Run: CHECKER KNIGHTS　Do 1 lap under 01:25:00 on Rocket Star!";
                        break;
                    case 89:
                        this.textBox1.Text = "CHECKER KNIGHTS: Break at least 2 walls and finish in 1st place!";
                        break;
                    case 90:
                        this.textBox1.Text = "CHECKER KNIGHTS: Use spin panels 7 times or more and take 1st place!";
                        break;
                    case 91:
                        this.textBox1.Text = "CHECKER KNIGHTS: Swallow over 20 enemies and finish in 1st place!";
                        break;
                    case 92:
                        this.textBox1.Text = "Air Ride: Finish in 1st place with Sleep ability!";
                        break;
                    case 93:
                        this.textBox1.Text = "Air Ride: Finish in 1st place with Fire ability!";
                        break;
                    case 94:
                        this.textBox1.Text = "Air Ride: Finish in 1st place with Needle ability!";
                        break;
                    case 95:
                        this.textBox1.Text = "Air Ride: Finish in 1st place with Wing ability!";
                        break;
                    case 96:
                        this.textBox1.Text = "Sword Challenge: During a race, swing your sword exactly 10 times and take 1st!";
                        break;
                    case 97:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Tornade Challenge: Defeat over 20 enemies as Tornado Kirby and finish in 1st place!";
                        else this.textBox1.Text = "Tornade Challenge: Defeat over 15 enemies as Tornado Kirby and finish in 1st place!";
                        break;
                    case 98:
                        this.textBox1.Text = "Swallow Chilly (snowman enemy) 3 or more times and take 1st place!";
                        break;
                    case 99:
                        this.textBox1.Text = "Swallow Plasma Wisp (electrical enemy) 3 or more times and take 1st place!";
                        break;
                    case 100:
                        this.textBox1.Text = "Swallow Sword Knight (sword-wielding enemy) 3 or more times and take 1st place!";
                        break;
                    case 101:
                        this.textBox1.Text = "Swallow Wheelie (motorcycle enemy) 3 or more times and take 1st place!";
                        break;
                    case 102:
                        this.textBox1.Text = "Air Ride: Swallow 5 consecutive garbage enemies (with no copy abilities) and take 1st!";
                        break;
                    case 103:
                        this.textBox1.Text = "Air Ride: Start the final lap in 4th place and move to 1st to win.";
                        break;
                    case 104:
                        this.textBox1.Text = "Air Ride: Finish in 1st place while flying through the air!";
                        break;
                    case 105:
                        this.textBox1.Text = "Air Ride: Finish in 1st place while taking damage!";
                        break;
                    case 106:
                        this.textBox1.Text = "Air Ride: Cross the finish line while spinning and take 1st place!";
                        break;
                    case 107:
                        this.textBox1.Text = "Defeat 10 or more enemies using the Quick Spin!";
                        break;
                    case 108:
                        this.textBox1.Text = "Hit 20 or more rivals with your Quick Spin!";
                        break;
                    case 109:
                        this.textBox1.Text = "Make your lap time's last two digits the same!";
                        break;
                    case 110:
                        this.textBox1.Text = "Race all of the standard Aur Rude courses!";
                        break;
                    case 111:
                        this.textBox1.Text = "In any mode other than Free Run, reach the goal a total of 3 times!";
                        break;
                    case 112:
                        this.textBox1.Text = "Defeat over 300 of your enemies!";
                        break;
                    case 113:
                        this.textBox1.Text = "Defeat over 1,000 of your enemies!";
                        break;
                    case 114:
                        this.textBox1.Text = "Swallow 200 or more enemies!";
                        break;
                    case 115:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Defeat 200 or more enemies with exhaled stars!";
                        else this.textBox1.Text = "Defeat 100 or more enemies with exhaled stars!";
                        break;
                    case 116:
                        this.textBox1.Text = "Race over 100 laps!";
                        break;
                    case 117:
                        this.textBox1.Text = "Race over 300 laps!";
                        break;
                    case 118:
                        this.textBox1.Text = "Glide for more than 30 minutes!";
                        break;
                    case 119:
                        this.textBox1.Text = "Glide for more than 1 hour!";
                        break;
                    case 120:
                        this.textBox1.Text = "Fill in over 100 Checklist blocks!";
                        break;
                    case 121:
                        this.textBox1.Text = "Top Ride: GRASS　Take 1st place without using Boost!";
                        break;
                    case 122:
                        this.textBox1.Text = "Top Ride: GRASS　Finish 1st with CPUs set to level 5!";
                        break;
                    case 123:
                        this.textBox1.Text = "Top Ride: GRASS　Take 1st place 10 times or more!";
                        break;
                    case 124:
                        this.textBox1.Text = "Top Ride: GRASS　Finish 7 laps in under 00:43:00!";
                        break;
                    case 125:
                        this.textBox1.Text = "Top Ride: GRASS　Finish 1st 5 seconds faster than #2!";
                        break;
                    case 126:
                        this.textBox1.Text = "Time Attack: GRASS　Finish in under 00:33:00!";
                        break;
                    case 127:
                        this.textBox1.Text = "Time Attack: GRASS　Finish in under 00:28:00!";
                        break;
                    case 128:
                        this.textBox1.Text = "Free Run: GRASS　Do one lap in under 00:06:00!";
                        break;
                    case 129:
                        this.textBox1.Text = "Free Run: GRASS　Do one lap in under 00:04:50!";
                        break;
                    case 130:
                        this.textBox1.Text = "Top Ride: GRASS　(No \"Zero Items\" rule) Take 1st place without using items!";
                        break;
                    case 131:
                        this.textBox1.Text = "Top Ride: Take 1st place while holding the Hammer!";
                        break;
                    case 132:
                        this.textBox1.Text = "In one game, hit enemies 3 times or more with Bomb items!";
                        break;
                    case 133:
                        this.textBox1.Text = "Top Ride: GRASS　in one race, drop 30 or more tree bombs!";
                        break;
                    case 134:
                        this.textBox1.Text = "Top Ride: GRASS　Finish 1st and hit 5 or more Dash Panels!";
                        break;
                    case 135:
                        this.textBox1.Text = "Top Ride: Take 1st place while doing a Quick Spin!";
                        break;
                    case 136:
                        this.textBox1.Text = "Top Ride: SAND　Take 1st place without using Boost!";
                        break;
                    case 137:
                        this.textBox1.Text = "Top Ride: SAND　Finish 1st with CPUs set to level 5!";
                        break;
                    case 138:
                        this.textBox1.Text = "Top Ride: SAND　Take 1st place 10 times or more!";
                        break;
                    case 139:
                        this.textBox1.Text = "Top Ride: SAND　Finish 7 laps in under 00:52:00!";
                        break;
                    case 140:
                        this.textBox1.Text = "Top Ride: SAND　Finish 1st 5 seconds faster than #2!";
                        break;
                    case 141:
                        this.textBox1.Text = "Time Attack: SAND　Finish in under 00:35:00!";
                        break;
                    case 142:
                        this.textBox1.Text = "Time Attack: SAND　Finish in under 00:29:00!";
                        break;
                    case 143:
                        this.textBox1.Text = "Free Run: SAND　Do one lap in under 00:06:50!";
                        break;
                    case 144:
                        this.textBox1.Text = "Free Run: SAND　Do one lap in under 00:05:00!";
                        break;
                    case 145:
                        this.textBox1.Text = "Top Ride: SAND　(No \"Zero Items\" rule) Take 1st place without using items!";
                        break;
                    case 146:
                        this.textBox1.Text = "Top Ride: SAND　Take 1st and catch the worm 3 or more times!";
                        break;
                    case 147:
                        this.textBox1.Text = "Top Ride: SAND　Drop into Ant Doom 50 times or more!";
                        break;
                    case 148:
                        this.textBox1.Text = "Top Ride: SAND　Drop into Ant Doom 20 times in one game!";
                        break;
                    case 149:
                        this.textBox1.Text = "Top Ride: SKY　Take 1st place without using Boost!";
                        break;
                    case 150:
                        this.textBox1.Text = "Top Ride: SKY　Finish 1st with CPUs set to level 5!";
                        break;
                    case 151:
                        this.textBox1.Text = "Top Ride: SKY　Take 1st place 10 times or more!";
                        break;
                    case 152:
                        this.textBox1.Text = "Top Ride: SKY　Finish 6 laps in under 01:02:00!";
                        break;
                    case 153:
                        this.textBox1.Text = "Top Ride: SKY　Finish 1st 5 seconds faster than #2!";
                        break;
                    case 154:
                        this.textBox1.Text = "Time Attack: SKY　Finish in under 00:57:00!";
                        break;
                    case 155:
                        this.textBox1.Text = "Time Attack: SKY　Finish in under 00:47:00!";
                        break;
                    case 156:
                        this.textBox1.Text = "Free Run: SKY　Do one lap in under 00:11:00!";
                        break;
                    case 157:
                        this.textBox1.Text = "Free Run: SKY　Do one lap in under 00:09:00!";
                        break;
                    case 158:
                        this.textBox1.Text = "Top Ride: SKY　(No \"Zero Items\" rule) Take 1st place without using items!";
                        break;
                    case 159:
                        this.textBox1.Text = "Top Ride: SKY　Take 1st and hit the Isle Knob 5 or more times!";
                        break;
                    case 160:
                        this.textBox1.Text = "Top Ride: SKY　Finish 1st without using the Jump Plate!";
                        break;
                    case 161:
                        this.textBox1.Text = "Top Ride: FIRE　Take 1st place without using Boost!";
                        break;
                    case 162:
                        this.textBox1.Text = "Top Ride: FIRE　Finish 1st with CPUs set to level 5!";
                        break;
                    case 163:
                        this.textBox1.Text = "Top Ride: FIRE　Take 1st place 10 times or more!";
                        break;
                    case 164:
                        this.textBox1.Text = "Top Ride: FIRE　Finish 6 laps in under 00:53:00!";
                        break;
                    case 165:
                        this.textBox1.Text = "Top Ride: FIRE　Finish 1st 5 seconds faster than #2!";
                        break;
                    case 166:
                        this.textBox1.Text = "Time Attack: FIRE　Finish in under 00:46:00!";
                        break;
                    case 167:
                        this.textBox1.Text = "Time Attack: FIRE　Finish in under 00:39:00!";
                        break;
                    case 168:
                        this.textBox1.Text = "Free Run: FIRE　Do one lap in under 00:08:00!";
                        break;
                    case 169:
                        this.textBox1.Text = "Free Run: FIRE　Do one lap in under 00:06:50!";
                        break;
                    case 170:
                        this.textBox1.Text = "Top Ride: FIRE　(No \"Zero Items\" rule) Take 1st place without using items!";
                        break;
                    case 171:
                        this.textBox1.Text = "Top Ride: FIRE　Finish 1st while holding the Fire item.";
                        break;
                    case 172:
                        this.textBox1.Text = "Top Ride: FIRE　Cause a huge eruption 3 times or more!";
                        break;
                    case 173:
                        this.textBox1.Text = "Top Ride: LIGHT　Take 1st place without using Boost!";
                        break;
                    case 174:
                        this.textBox1.Text = "Top Ride: LIGHT　Finish 1st with CPUs set to level 5!";
                        break;
                    case 175:
                        this.textBox1.Text = "Top Ride: LIGHT　Take 1st place 10 times or more!";
                        break;
                    case 176:
                        this.textBox1.Text = "Top Ride: LIGHT　Finish 6 laps in under 00:43:00!";
                        break;
                    case 177:
                        this.textBox1.Text = "Top Ride: LIGHT　Finish 1st 5 seconds faster than #2!";
                        break;
                    case 178:
                        this.textBox1.Text = "Time Attack: LIGHT　Finish in under 00:38:00!";
                        break;
                    case 179:
                        this.textBox1.Text = "Time Attack: LIGHT　Finish in under 00:33:00!";
                        break;
                    case 180:
                        this.textBox1.Text = "Free Run: LIGHT　Do one lap in under 00:07:50!";
                        break;
                    case 181:
                        this.textBox1.Text = "Free Run: LIGHT　Do one lap in under 00:06:00!";
                        break;
                    case 182:
                        this.textBox1.Text = "Top Ride: LIGHT　(No \"Zero Items\" rule) Take 1st place without using items!";
                        break;
                    case 183:
                        this.textBox1.Text = "Top Ride: LIGHT　Ride the grind rail 50 times or more!";
                        break;
                    case 184:
                        this.textBox1.Text = "Top Ride: LIGHT　Take 1st and grind the rail 5 times or more!";
                        break;
                    case 185:
                        this.textBox1.Text = "Top Ride: LIGHT　Finish 1st and bust 6 or more columns!";
                        break;
                    case 186:
                        this.textBox1.Text = "Top Ride: Race one lap without hitting a wall and finish 1st!";
                        break;
                    case 187:
                        this.textBox1.Text = "Top Ride: WATER　Take 1st place without using Boost!";
                        break;
                    case 188:
                        this.textBox1.Text = "Top Ride: WATER　Finish 1st with CPUs set to level 5!";
                        break;
                    case 189:
                        this.textBox1.Text = "Top Ride: WATER　Take 1st place 10 times or more!";
                        break;
                    case 190:
                        this.textBox1.Text = "Top Ride: WATER　Finish 5 laps in under 01:02:00!";
                        break;
                    case 191:
                        this.textBox1.Text = "Top Ride: WATER　Finish 1st 5 seconds faster than #2!";
                        break;
                    case 192:
                        this.textBox1.Text = "Time Attack: WATER　Finish in under 01:06:00!";
                        break;
                    case 193:
                        this.textBox1.Text = "Time Attack: WATER　Finish in under 00:56:00!";
                        break;
                    case 194:
                        this.textBox1.Text = "Free Run: WATER　Do one lap in under 00:12:00!";
                        break;
                    case 195:
                        this.textBox1.Text = "Free Run: WATER　Do one lap in under 00:10:50!";
                        break;
                    case 196:
                        this.textBox1.Text = "Top Ride: WATER　(No \"Zero Items\" rule) Take 1st place without using items!";
                        break;
                    case 197:
                        this.textBox1.Text = "Torch 3 or more rivals using one Fire item!";
                        break;
                    case 198:
                        this.textBox1.Text = "Send 3 or more rivals sailing using one Buzz Saw item!";
                        break;
                    case 199:
                        this.textBox1.Text = "Top Ride: WATER　Take 1st and enter the falls 5 times or more!";
                        break;
                    case 200:
                        this.textBox1.Text = "Top Ride: METAL　Take 1st place without using Boost!";
                        break;
                    case 201:
                        this.textBox1.Text = "Top Ride: METAL　Finish 1st with CPUs set to level 5!";
                        break;
                    case 202:
                        this.textBox1.Text = "Top Ride: METAL　Take 1st place 10 times or more!";
                        break;
                    case 203:
                        this.textBox1.Text = "Top Ride: METAL　Finish 5 laps in under 00:58:00!";
                        break;
                    case 204:
                        this.textBox1.Text = "Top Ride: METAL　Finish 1st 5 seconds faster than #2!";
                        break;
                    case 205:
                        this.textBox1.Text = "Time Attack: METAL　Finish in under 00:57:00!";
                        break;
                    case 206:
                        this.textBox1.Text = "Time Attack: METAL　Finish in under 00:51:00!";
                        break;
                    case 207:
                        this.textBox1.Text = "Free Run: METAL　Do one lap in under 00:11:50!";
                        break;
                    case 208:
                        this.textBox1.Text = "Free Run: METAL　Do one lap in under 00:09:50!";
                        break;
                    case 209:
                        this.textBox1.Text = "Top Ride: METAL　(No \"Zero Items\" rule) Take 1st place without using items!";
                        break;
                    case 210:
                        this.textBox1.Text = "Top Ride: METAL　Take 1st without breaking any gear walls!";
                        break;
                    case 211:
                        this.textBox1.Text = "Top Ride: METAL　Take 1st and hit the switch 10 times or more!";
                        break;
                    case 212:
                        this.textBox1.Text = "Top Ride: METAL　Take 1st and break 5 or more gear walls!";
                        break;
                    case 213:
                        this.textBox1.Text = "Top Ride: Do 20 or more Quick Spins in one lap and finish 1st!";
                        break;
                    case 214:
                        this.textBox1.Text = "Top Ride: Finish 1st with 1 lap between you and #2!";
                        break;
                    case 215:
                        this.textBox1.Text = "Top Ride: Finish 1st with 2 laps between you and #2!";
                        break;
                    case 216:
                        this.textBox1.Text = "Top Ride: Get the same item 3 times in one race!";
                        break;
                    case 217:
                        this.textBox1.Text = "Top Ride: Compete in more than 50 multiplayer races!";
                        break;
                    case 218:
                        this.textBox1.Text = "Top Ride: Compete in more than 10 multiplayer races!";
                        break;
                    case 219:
                        this.textBox1.Text = "Cross the goal 20 or more times!";
                        break;
                    case 220:
                        this.textBox1.Text = "Top Ride: Race over 300 laps!";
                        break;
                    case 221:
                        this.textBox1.Text = "Free Run: Race more than 100 laps!";
                        break;
                    case 222:
                        this.textBox1.Text = "Time Attack: Cross the goal 30 or more times!";
                        break;
                    case 223:
                        this.textBox1.Text = "Top Ride: Take 1st place on all courses!";
                        break;
                    case 224:
                        this.textBox1.Text = "Top Ride: (No \"Zero Items\" rule) Complete all courses without using items!";
                        break;
                    case 225:
                        this.textBox1.Text = "Top Ride: (No \"Zero Items\" rule) Finish 1st on all courses using no items!";
                        break;
                    case 226:
                        this.textBox1.Text = "Collect 500 items or more!";
                        break;
                    case 227:
                        this.textBox1.Text = "Top Ride: Finish all courses without using Boost!";
                        break;
                    case 228:
                        this.textBox1.Text = "Top Ride: Finish 1st on all courses without Boost!";
                        break;
                    case 229:
                        this.textBox1.Text = "Get more than 20 Spinner items!";
                        break;
                    case 230:
                        this.textBox1.Text = "Get more than 20 Invincible Candy items!";
                        break;
                    case 231:
                        this.textBox1.Text = "Get more than 20 Walky items!";
                        break;
                    case 232:
                        this.textBox1.Text = "Get over 18 different types of items!";
                        break;
                    case 233:
                        this.textBox1.Text = "Top Ride: GRASS　Race more than 100 laps!";
                        break;
                    case 234:
                        this.textBox1.Text = "Top Ride: SAND　Race more than 100 laps!";
                        break;
                    case 235:
                        this.textBox1.Text = "Top Ride: SKY　Race more than 100 laps!";
                        break;
                    case 236:
                        this.textBox1.Text = "Top Ride: FIRE　Race more than 100 laps!";
                        break;
                    case 237:
                        this.textBox1.Text = "Top Ride: WATER　Race more than 100 laps!";
                        break;
                    case 238:
                        this.textBox1.Text = "Top Ride: LIGHT　Race more than 100 laps!";
                        break;
                    case 239:
                        this.textBox1.Text = "Top Ride: METAL　Race more than 100 laps!";
                        break;
                    case 240:
                        this.textBox1.Text = "Fill in over 100 Checklist blocks!";
                        break;
                    case 241:
                        this.textBox1.Text = "City Trial: Do damage to a rival within the first 10 seconds of the match!";
                        break;
                    case 242:
                        this.textBox1.Text = "City Trial: Get 10 items within the first 20 seconds of the match!";
                        break;
                    case 243:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "City Trial: Jump on top of the building 5 times or more using super jump ramp!";
                        else this.textBox1.Text = "City Trial: Jump on top of the building 10 times or more using super jump ramp!";
                        break;
                    case 244:
                        this.textBox1.Text = "City Trial: Bust the Star Pole!";
                        break;
                    case 245:
                        this.textBox1.Text = "City Trial: Bust the Star Pole 10 times or more!";
                        break;
                    case 246:
                        this.textBox1.Text = "City Trial: During one game, fly through the rings in the sky 5 times or more!";
                        break;
                    case 247:
                        this.textBox1.Text = "City Trial: Get the Bomb ability from the Copy Chance Wheel!";
                        break;
                    case 248:
                        this.textBox1.Text = "City Trial: Get the Sleep ability from the Copy Chance Wheel!";
                        break;
                    case 249:
                        this.textBox1.Text = "City Trial: In one game, get over 10 Boost Patches!";
                        break;
                    case 250:
                        this.textBox1.Text = "City Trial: In one game, get 10 or more Top Speed Patches!";
                        break;
                    case 251:
                        this.textBox1.Text = "City Trial: In one game, get 10 or more Turn Patches!";
                        break;
                    case 252:
                        this.textBox1.Text = "City Trial: In one game, get 10 or more Charge Patches!";
                        break;
                    case 253:
                        this.textBox1.Text = "City Trial: In one game, get 10 or more Weight Patches!";
                        break;
                    case 254:
                        this.textBox1.Text = "City Trial: In one game, get 10 or more Defense Patches!";
                        break;
                    case 255:
                        this.textBox1.Text = "City Trial: In one game, get 10 or more Glide Patches!";
                        break;
                    case 256:
                        this.textBox1.Text = "City Trial: In one game, eat 2 or more Maxim Tomatoes!";
                        break;
                    case 257:
                        this.textBox1.Text = "City Trial: In one game, drink 3 or more Energy Drinks!";
                        break;
                    case 258:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "City Trial: In one game, eat 3 or more Tempura Soba!";
                        else this.textBox1.Text = "City Trial: In one game, eat 3 or more Hot Dogs!";
                        break;
                    case 259:
                        this.textBox1.Text = "City Trial: In one game, eat 3 or more plates of Sushi!";
                        break;
                    case 260:
                        this.textBox1.Text = "City Trial: During one game, go into the hole in the high plains 3 time or more!";
                        break;
                    case 261:
                        this.textBox1.Text = "City Trial: Use the grind rail to break into the crater!";
                        break;
                    case 262:
                        this.textBox1.Text = "City Trial: Make your way to the garden in the sky!";
                        break;
                    case 263:
                        this.textBox1.Text = "City Trial: Knock down all of the trees in the forest!";
                        break;
                    case 264:
                        this.textBox1.Text = "City Trial: During one game, break all of the volcano rocks and high plains rocks!";
                        break;
                    case 265:
                        this.textBox1.Text = "City Trial: Destroy all of the dilapidated houses!";
                        break;
                    case 266:
                        this.textBox1.Text = "City Trial: Use Sensor Bombs to KO rivals 3 times or more!";
                        break;
                    case 267:
                        this.textBox1.Text = "City Trial: Use Gold Spikes to KO rivals 3 times or more!";
                        break;
                    case 268:
                        this.textBox1.Text = "City Trial: Use Fireworks to KO rivals 10 times or more!";
                        break;
                    case 269:
                        this.textBox1.Text = "City Trial: Break a CPU's machine 5 times or more in the city!";
                        break;
                    case 270:
                        this.textBox1.Text = "City Trial: Enter a race with 3 CPU players and do damage to all of them in the city!";
                        break;
                    case 271:
                        this.textBox1.Text = "City Trial: In the city, bust Wheelie Scooter while riding Compact Star!";
                        break;
                    case 272:
                        this.textBox1.Text = "City Trial: In the city, bust Wheelie Bike while riding on Warpstar!";
                        break;
                    case 273:
                        this.textBox1.Text = "City Trial: In the city, bust Swerve Star while riding on Wheelie Bike!";
                        break;
                    case 274:
                        this.textBox1.Text = "City Trial: In the city, bust Warpstar while riding on Swerve Star!";
                        break;
                    case 275:
                        this.textBox1.Text = "City Trial: In the city, bust Formula Star while riding on Turbo Star!";
                        break;
                    case 276:
                        this.textBox1.Text = "City Trial: In the city, bust Slick Star while riding on Formula Star!";
                        break;
                    case 277:
                        this.textBox1.Text = "City Trial: In the city, bust Rocket Star while riding on Slick Star!";
                        break;
                    case 278:
                        this.textBox1.Text = "City Trial: In the city, bust Turbo Star while riding on Rocket Star!";
                        break;
                    case 279:
                        this.textBox1.Text = "City Trial: Let time run out while all players are off of their machines!";
                        break;
                    case 280:
                        this.textBox1.Text = "City Trial: Have all players simultaneously get off their machines!";
                        break;
                    case 281:
                        this.textBox1.Text = "City Trial: Let time run out while all players are on the rails!";
                        break;
                    case 282:
                        this.textBox1.Text = "In one match, complete both Dragoon and Hydra!";
                        break;
                    case 283:
                        this.textBox1.Text = "City Trial: Use up one of the restoration areas!";
                        break;
                    case 284:
                        this.textBox1.Text = "City Trial: Steal over 8 items from Tac by yourself!";
                        break;
                    case 285:
                        this.textBox1.Text = "City Trial: Break a huge pillar within 40 seconds of the time it appears!";
                        break;
                    case 286:
                        this.textBox1.Text = "City Trial: Do some damage to Dyna Blade!";
                        break;
                    case 287:
                        this.textBox1.Text = "City Trial: Get trampled on by Dyna Blade!";
                        break;
                    case 288:
                        this.textBox1.Text = "Stadium: DRAG RACE 1　Finish in less than 00:24:00!";
                        break;
                    case 289:
                        this.textBox1.Text = "Stadium: DRAG RACE 1　Finish in less than 00:20:00!";
                        break;
                    case 290:
                        this.textBox1.Text = "Stadium: DRAG RACE 1　Finish under 00:26:00 on Warpstar!";
                        break;
                    case 291:
                        this.textBox1.Text = "Stadium: DRAG RACE 1　Finish under 00:17:00 on Formula Star!";
                        break;
                    case 292:
                        this.textBox1.Text = "Stadium: DRAG RACE 2　Finish in less than 00:24:00!";
                        break;
                    case 293:
                        this.textBox1.Text = "Stadium: DRAG RACE 2　Finish in less than 00:20:00!";
                        break;
                    case 294:
                        this.textBox1.Text = "Stadium: DRAG RACE 2　Finish under 00:27:00 on Wagon Star!";
                        break;
                    case 295:
                        this.textBox1.Text = "Stadium: DRAG RACE 2　Finish under 00:29:00 on Winged Star!";
                        break;
                    case 296:
                        this.textBox1.Text = "Stadium: DRAG RACE 3　Finish in less than 00:35:00!";
                        break;
                    case 297:
                        this.textBox1.Text = "Stadium: DRAG RACE 3　Finish in less than 00:27:00!";
                        break;
                    case 298:
                        this.textBox1.Text = "Stadium: DRAG RACE 3　Finish under 00:28:00 on Swerve Star!";
                        break;
                    case 299:
                        this.textBox1.Text = "Stadium: DRAG RACE 3　Finish under 00:31:00 on Wheelie Bike!";
                        break;
                    case 300:
                        this.textBox1.Text = "Stadium: DRAG RACE 4　Finish in less than 00:24:00!";
                        break;
                    case 301:
                        this.textBox1.Text = "Stadium: DRAG RACE 4　Finish in less than 00:19:00!";
                        break;
                    case 302:
                        this.textBox1.Text = "Stadium: DRAG RACE 4　Finish under 00:33:00 on Turbo Star!";
                        break;
                    case 303:
                        this.textBox1.Text = "Stadium: DRAG RACE 4　Finish under 00:24:00 on Rex Wheelie!";
                        break;
                    case 304:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 1　In one game, KO your rivals 5 or more times!";
                        break;
                    case 305:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 1　In one game, KO a rival 10 times or more!";
                        break;
                    case 306:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 1　Bust all the rocks on the field!";
                        break;
                    case 307:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 2　In one game, KO your rivals 5 or more times!";
                        break;
                    case 308:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 2　In one game, KO a rival 10 times or more!";
                        break;
                    case 309:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 3　In one game, KO your rivals 5 or more times!";
                        break;
                    case 310:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 4　In one game, KO your rivals 5 or more times!";
                        break;
                    case 311:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 4　In one game, KO a rival 10 times or more!";
                        break;
                    case 312:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 5　In one game, KO your rivals 5 or more times!";
                        break;
                    case 313:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY 5　In one game, KO a rival 10 times or more!";
                        break;
                    case 314:
                        this.textBox1.Text = "Stadium: TARGET FLIGHT　In one game, get over 150 points!";
                        break;
                    case 315:
                        this.textBox1.Text = "Stadium: TARGET FLIGHT　In one game, get exactly 90 points!";
                        break;
                    case 316:
                        this.textBox1.Text = "Stadium: TARGET FLIGHT　In one game, get a perfect score: 200 points!";
                        break;
                    case 317:
                        this.textBox1.Text = "Stadium: TARGET FLIGHT　Stay airborne longer than 15 seconds!";
                        break;
                    case 318:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Stadium: AIR GLIDER　Fly more than 100 meter!";
                        else this.textBox1.Text = "Stadium: AIR GLIDER　Fly more than 330 feet!";
                        break;
                    case 319:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Stadium: AIR GLIDER　Fly more than 200 meter!";
                        else this.textBox1.Text = "Stadium: AIR GLIDER　Fly more than 660 feet!";
                        break;
                    case 320:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Stadium: AIR GLIDER　Fly more than 400 meter!";
                        else this.textBox1.Text = "Stadium: AIR GLIDER　Fly more than 1,300 feet!";
                        break;
                    case 321:
                        this.textBox1.Text = "Stadium: AIR GLIDER　Stay airborne longer than 30 seconds!";
                        break;
                    case 322:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Stadium: HIGH JUMP　Jump higher than 150 meter!";
                        else this.textBox1.Text = "Stadium: HIGH JUMP　Jump higher than 500 feet!";
                        break;
                    case 323:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Stadium: HIGH JUMP　Jump higher than 300 meter!";
                        else this.textBox1.Text = "Stadium: HIGH JUMP　Jump higher than 1,000 feet!";
                        break;
                    case 324:
                        this.textBox1.Text = "Stadium: HIGH JUMP　Stay airborne longer than 10 seconds!";
                        break;
                    case 325:
                        this.textBox1.Text = "Stadium: KIRBY MELEE 1　In one game, KO enemies over 50 times!";
                        break;
                    case 326:
                        this.textBox1.Text = "Stadium: KIRBY MELEE 1　In one game, KO over 75 enemies by yourself!";
                        break;
                    case 327:
                        this.textBox1.Text = "Stadium: KIRBY MELEE 2　In one game, KO enemies over 30 times!";
                        break;
                    case 328:
                        this.textBox1.Text = "Stadium: KIRBY MELEE 1　In one game, KO over 40 enemies by yourself!";
                        break;
                    case 329:
                        this.textBox1.Text = "Stadium: VS. KING DEDEDE　KO King Dedede in less than a minute!";
                        break;
                    case 330:
                        this.textBox1.Text = "Free Run: Change Air Ride machines 10 times or more!";
                        break;
                    case 331:
                        this.textBox1.Text = "Free Run: Drive for a total of 10 minutes or more!";
                        break;
                    case 332:
                        this.textBox1.Text = "Free Run: Drive for a total of 30 minutes or more!";
                        break;
                    case 333:
                        this.textBox1.Text = "Free Run: Drive for a total of 2 hours or more!";
                        break;
                    case 334:
                        this.textBox1.Text = "City Trial: Open up the pitfall in the forest!";
                        break;
                    case 335:
                        this.textBox1.Text = "City Trial: Open up all of the holes around the base of the volcano!";
                        break;
                    case 336:
                        this.textBox1.Text = "City Trial: Let the waterwheel carry you 10 times or more!";
                        break;
                    case 337:
                        this.textBox1.Text = "City Trial: Break 5 or more of the huge pillars that appear!";
                        break;
                    case 338:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "City Trial: The meteor attacks the city 5 or more times!";
                        else this.textBox1.Text = "City Trial: The meteor attacks the city 3 or more times!";
                        break;
                    case 339:
                        this.textBox1.Text = "City Trial: Go into the castle chamber when it opens!";
                        break;
                    case 340:
                        this.textBox1.Text = "City Trial: Get 30 or more Glide Patches!";
                        break;
                    case 341:
                        this.textBox1.Text = "City Trial: In one game, get 50 or more items!";
                        break;
                    case 342:
                        this.textBox1.Text = "City Trial: Pick up a total of over 100 items!";
                        break;
                    case 343:
                        this.textBox1.Text = "City Trial: Pick up a total of over 500 items!";
                        break;
                    case 344:
                        this.textBox1.Text = "City Trial: Pick up a total of over 1,000 items!";
                        break;
                    case 345:
                        this.textBox1.Text = "City Trial: Pick up a total of over 3,000 items!";
                        break;
                    case 346:
                        this.textBox1.Text = "City Trial: Break more than 500 boxes!";
                        break;
                    case 347:
                        this.textBox1.Text = "City Trial: Break more than 1,000 boxes!";
                        break;
                    case 348:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "City Trial: Race over 100 km!";
                        else this.textBox1.Text = "City Trial: Race over 60 miles!";
                        break;
                    case 349:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "City Trial: Race over 300 km!";
                        else this.textBox1.Text = "City Trial: Race over 200 miles!";
                        break;
                    case 350:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY (All)　KO enemies over 50 times!";
                        break;
                    case 351:
                        this.textBox1.Text = "Stadium: DESTRUCTION DERBY (All)　KO enemies over 150 times!";
                        break;
                    case 352:
                        if (this.toolStripMenuItem2.Checked == true) this.textBox1.Text = "Stadium: TARGET FLIGHT　Play 30 times or more!";
                        else this.textBox1.Text = "Stadium: TARGET FLIGHT　Play 15 times or more!";
                        break;
                    case 353:
                        this.textBox1.Text = "Stadium: TARGET FLIGHT　Get more than 1,500 points!";
                        break;
                    case 354:
                        this.textBox1.Text = "Stadium: KIRBY MELEE (All)　KO over 500 enemies!";
                        break;
                    case 355:
                        this.textBox1.Text = "Stadium: KIRBY MELEE (All)　KO over 1,500 enemies!";
                        break;
                    case 356:
                        this.textBox1.Text = "Stadium: Play in over 10 Stadium modes!";
                        break;
                    case 357:
                        this.textBox1.Text = "Stadium: Play in over 20 Stadium modes!";
                        break;
                    case 358:
                        this.textBox1.Text = "Unlock Dragoon Parts A, B, and C on the Checklist!";
                        break;
                    case 359:
                        this.textBox1.Text = "Unlock Dragoon Parts X, Y, and Z on the Checklist!";
                        break;
                    case 360:
                        this.textBox1.Text = "Fill in over 100 Checklist blocks!";
                        break;
                    default:
                        break;
                }
            }

            return;
        }

        private void FormOut(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            return;
        }

        private void VersionSelect(object sender, EventArgs e)
        {
            toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.Text == "Japanese")
            {
                this.toolStripMenuItem2.Checked = true;
                this.toolStripMenuItem3.Checked = false;
                this.checkBoxCt80.Text = "エアグライダー400メートル";
                this.checkBoxCt83.Text = "ハイジャンプ300メートル";
                this.checkBoxCt108.Text = "100km走る";
                this.checkBoxCt109.Text = "300km走る";
                this.label5.Text = "ひたすらまっすぐ -> ゼロヨン1\n直線コース->ゼロヨン2\nひたすら速い->ゼロヨン3\n遠くに、遠くに->エアグライダー\n高く飛べるほど->ハイジャンプ\nとてもたくさんの敵->バトロイ1\nがんじょうで->デスマッチ1\n速さよりも->デスマッチ2\nさわやかな草原->プランテス\n激流のある渓谷->ヴァレリオン\n砂をまき上げて->サンドーラ\n寒さと氷->コルダ\n火口->マグヒート\n大観覧車->アイルーン\n鋼鉄->スチールオーガン\nチェック模様->チェックナイト\nデデデ大王->VSデデデ";
            }
            else if (toolStripMenuItem.Text == "English")
            {
                this.toolStripMenuItem2.Checked = false;
                this.toolStripMenuItem3.Checked = true;
                this.checkBoxCt80.Text = "エアグライダー1300フィート";
                this.checkBoxCt83.Text = "ハイジャンプ1000フィート";
                this.checkBoxCt108.Text = "60マイル走る";
                this.checkBoxCt109.Text = "200マイル走る";
                this.label5.Text = "A faster -> ゼロヨン3\nA machine -> デスマッチ1\nI feel->バトロイ1\nI see a course -> アイルーン\nI see a dark->ヴァレリオン\nI see a long -> チェックナイト\nI see a machine->サンドーラ\nI see a simple -> ゼロヨン1\nI see a steel->スチールオーガン\nI see a test -> ゼロヨン2\nI see you flying -> マグヒート\nI see you meeting->VSデデデ\nI sense you'll -> エアグライダー\nIt will -> プランテス\nIt's time -> デスマッチ2\nThe farther -> ハイジャンプ\nYou're headed -> コルダ";
            }
            return;
        }

        private void LanguageSelect(object sender, EventArgs e)
        {
            toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.Text == "Japanese")
            {
                this.toolStripMenuItem5.Checked = true;
                this.toolStripMenuItem6.Checked = false;
                this.checkBoxStadium1.Text = "ゼロヨンアタック1";
                this.checkBoxStadium2.Text = "ゼロヨンアタック2";
                this.checkBoxStadium3.Text = "ゼロヨンアタック3";
                this.checkBoxStadium4.Text = "ゼロヨンアタック4";
                this.checkBoxStadium5.Text = "エアグライダー";
                this.checkBoxStadium6.Text = "ポイントストライク";
                this.checkBoxStadium7.Text = "ハイジャンプ";
                this.checkBoxStadium8.Text = "バトルロイヤル1";
                this.checkBoxStadium9.Text = "バトルロイヤル2";
                this.checkBoxStadium10.Text = "デスマッチ1";
                this.checkBoxStadium11.Text = "デスマッチ2";
                this.checkBoxStadium12.Text = "デスマッチ3";
                this.checkBoxStadium13.Text = "デスマッチ4";
                this.checkBoxStadium14.Text = "デスマッチ5";
                this.checkBoxStadium15.Text = "プランテス";
                this.checkBoxStadium16.Text = "マグヒート";
                this.checkBoxStadium17.Text = "サンドーラ";
                this.checkBoxStadium18.Text = "コルダ";
                this.checkBoxStadium19.Text = "アイルーン";
                this.checkBoxStadium20.Text = "ヴァレリオン";
                this.checkBoxStadium21.Text = "スチールオーガン";
                this.checkBoxStadium22.Text = "チェックナイト";
                this.checkBoxStadium23.Text = "ギャラックス";
                this.checkBoxStadium24.Text = "VSデデデ";
                this.buttonStadiumDr.Text = "ゼロヨン";
                this.buttonStadiumDd.Text = "デスマッチ";
                this.buttonStadiumKm.Text = "バトロイ";
                this.button6.Text = "初期Seed計算";
                this.button3.Text = "Seed計算";
                this.button4.Text = "スタジアム変更して表示";
            }
            else if (toolStripMenuItem.Text == "English")
            {
                this.toolStripMenuItem5.Checked = false;
                this.toolStripMenuItem6.Checked = true;
                this.checkBoxStadium1.Text = "Drag Race 1";
                this.checkBoxStadium2.Text = "Drag Race 2";
                this.checkBoxStadium3.Text = "Drag Race 3";
                this.checkBoxStadium4.Text = "Drag Race 4";
                this.checkBoxStadium5.Text = "Air Glider";
                this.checkBoxStadium6.Text = "Target Flight";
                this.checkBoxStadium7.Text = "High Jump";
                this.checkBoxStadium8.Text = "Kirby Melee 1";
                this.checkBoxStadium9.Text = "Kirby Melee 2";
                this.checkBoxStadium10.Text = "Destruction Derby 1";
                this.checkBoxStadium11.Text = "Destruction Derby 2";
                this.checkBoxStadium12.Text = "Destruction Derby 3";
                this.checkBoxStadium13.Text = "Destruction Derby 4";
                this.checkBoxStadium14.Text = "Destruction Derby 5";
                this.checkBoxStadium15.Text = "Fantasy Meadows";
                this.checkBoxStadium16.Text = "Magma Flows";
                this.checkBoxStadium17.Text = "Sky Sands";
                this.checkBoxStadium18.Text = "Frozen Hillside";
                this.checkBoxStadium19.Text = "Beanstalk Park";
                this.checkBoxStadium20.Text = "Celestial Valley";
                this.checkBoxStadium21.Text = "Machine Passage";
                this.checkBoxStadium22.Text = "Checker Knights";
                this.checkBoxStadium23.Text = "Nebula Belt";
                this.checkBoxStadium24.Text = "VS. King Dedede";
                this.buttonStadiumDr.Text = "DR";
                this.buttonStadiumDd.Text = "DD";
                this.buttonStadiumKm.Text = "KM";
                this.button6.Text = "Setup Seed";
                this.button3.Text = "Seed Detect";
                this.button4.Text = "Chenged Stadium and Show";
            }
            return;
        }

        private void RunModeSelect(object sender, EventArgs e)
        {
            toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.Text == "Air Ride")
            {
                this.toolStripMenuItem8.Checked = true;
                this.toolStripMenuItem9.Checked = false;
                this.toolStripMenuItem10.Checked = false;
                this.toolStripMenuItem11.Checked = false;
            }
            else if (toolStripMenuItem.Text == "Top Ride")
            {
                this.toolStripMenuItem9.Checked = true;
                this.toolStripMenuItem8.Checked = false;
                this.toolStripMenuItem10.Checked = false;
                this.toolStripMenuItem11.Checked = false;
            }
            else if (toolStripMenuItem.Text == "City Trial")
            {
                this.toolStripMenuItem10.Checked = true;
                this.toolStripMenuItem8.Checked = false;
                this.toolStripMenuItem9.Checked = false;
                this.toolStripMenuItem11.Checked = false;
            }
            else if (toolStripMenuItem.Text == "100%")
            {
                this.toolStripMenuItem11.Checked = true;
                this.toolStripMenuItem8.Checked = false;
                this.toolStripMenuItem9.Checked = false;
                this.toolStripMenuItem10.Checked = false;
            }
            return;
        }

        private void StadiumReset(object sender, EventArgs e)
        {
            this.checkBoxStadium1.Checked = true;
            this.checkBoxStadium2.Checked = true;
            this.checkBoxStadium3.Checked = true;
            this.checkBoxStadium4.Checked = false;
            this.checkBoxStadium5.Checked = true;
            this.checkBoxStadium6.Checked = true;
            this.checkBoxStadium7.Checked = true;
            this.checkBoxStadium8.Checked = true;
            this.checkBoxStadium9.Checked = false;
            this.checkBoxStadium10.Checked = true;
            this.checkBoxStadium11.Checked = true;
            this.checkBoxStadium12.Checked = false;
            this.checkBoxStadium13.Checked = false;
            this.checkBoxStadium14.Checked = false;
            this.checkBoxStadium15.Checked = true;
            this.checkBoxStadium16.Checked = true;
            this.checkBoxStadium17.Checked = true;
            this.checkBoxStadium18.Checked = true;
            this.checkBoxStadium19.Checked = true;
            this.checkBoxStadium20.Checked = true;
            this.checkBoxStadium21.Checked = true;
            this.checkBoxStadium22.Checked = true;
            this.checkBoxStadium23.Checked = false;
            this.checkBoxStadium24.Checked = true;
            return;
        }

        private void StadiumDr(object sender, EventArgs e)
        {
            this.checkBoxStadium1.Checked = true;
            this.checkBoxStadium2.Checked = true;
            this.checkBoxStadium3.Checked = true;
            this.checkBoxStadium4.Checked = false;
            this.checkBoxStadium5.Checked = false;
            this.checkBoxStadium6.Checked = false;
            this.checkBoxStadium7.Checked = false;
            this.checkBoxStadium8.Checked = false;
            this.checkBoxStadium9.Checked = false;
            this.checkBoxStadium10.Checked = false;
            this.checkBoxStadium11.Checked = false;
            this.checkBoxStadium12.Checked = false;
            this.checkBoxStadium13.Checked = false;
            this.checkBoxStadium14.Checked = false;
            this.checkBoxStadium15.Checked = false;
            this.checkBoxStadium16.Checked = false;
            this.checkBoxStadium17.Checked = false;
            this.checkBoxStadium18.Checked = false;
            this.checkBoxStadium19.Checked = false;
            this.checkBoxStadium20.Checked = false;
            this.checkBoxStadium21.Checked = false;
            this.checkBoxStadium22.Checked = false;
            this.checkBoxStadium23.Checked = false;
            this.checkBoxStadium24.Checked = false;
            return;
        }

        private void StadiumDd(object sender, EventArgs e)
        {
            this.checkBoxStadium1.Checked = false;
            this.checkBoxStadium2.Checked = false;
            this.checkBoxStadium3.Checked = false;
            this.checkBoxStadium4.Checked = false;
            this.checkBoxStadium5.Checked = false;
            this.checkBoxStadium6.Checked = false;
            this.checkBoxStadium7.Checked = false;
            this.checkBoxStadium8.Checked = false;
            this.checkBoxStadium9.Checked = false;
            this.checkBoxStadium10.Checked = true;
            this.checkBoxStadium11.Checked = true;
            this.checkBoxStadium12.Checked = false;
            this.checkBoxStadium13.Checked = false;
            this.checkBoxStadium14.Checked = false;
            this.checkBoxStadium15.Checked = false;
            this.checkBoxStadium16.Checked = false;
            this.checkBoxStadium17.Checked = false;
            this.checkBoxStadium18.Checked = false;
            this.checkBoxStadium19.Checked = false;
            this.checkBoxStadium20.Checked = false;
            this.checkBoxStadium21.Checked = false;
            this.checkBoxStadium22.Checked = false;
            this.checkBoxStadium23.Checked = false;
            this.checkBoxStadium24.Checked = false;
            return;
        }

        private void StadiumKm(object sender, EventArgs e)
        {
            this.checkBoxStadium1.Checked = false;
            this.checkBoxStadium2.Checked = false;
            this.checkBoxStadium3.Checked = false;
            this.checkBoxStadium4.Checked = false;
            this.checkBoxStadium5.Checked = false;
            this.checkBoxStadium6.Checked = false;
            this.checkBoxStadium7.Checked = false;
            this.checkBoxStadium8.Checked = true;
            this.checkBoxStadium9.Checked = true;
            this.checkBoxStadium10.Checked = false;
            this.checkBoxStadium11.Checked = false;
            this.checkBoxStadium12.Checked = false;
            this.checkBoxStadium13.Checked = false;
            this.checkBoxStadium14.Checked = false;
            this.checkBoxStadium15.Checked = false;
            this.checkBoxStadium16.Checked = false;
            this.checkBoxStadium17.Checked = false;
            this.checkBoxStadium18.Checked = false;
            this.checkBoxStadium19.Checked = false;
            this.checkBoxStadium20.Checked = false;
            this.checkBoxStadium21.Checked = false;
            this.checkBoxStadium22.Checked = false;
            this.checkBoxStadium23.Checked = false;
            this.checkBoxStadium24.Checked = false;
            return;
        }

        private void StadiumSr(object sender, EventArgs e)
        {
            this.checkBoxStadium1.Checked = false;
            this.checkBoxStadium2.Checked = false;
            this.checkBoxStadium3.Checked = false;
            this.checkBoxStadium4.Checked = false;
            this.checkBoxStadium5.Checked = false;
            this.checkBoxStadium6.Checked = false;
            this.checkBoxStadium7.Checked = false;
            this.checkBoxStadium8.Checked = false;
            this.checkBoxStadium9.Checked = false;
            this.checkBoxStadium10.Checked = false;
            this.checkBoxStadium11.Checked = false;
            this.checkBoxStadium12.Checked = false;
            this.checkBoxStadium13.Checked = false;
            this.checkBoxStadium14.Checked = false;
            this.checkBoxStadium15.Checked = true;
            this.checkBoxStadium16.Checked = true;
            this.checkBoxStadium17.Checked = true;
            this.checkBoxStadium18.Checked = true;
            this.checkBoxStadium19.Checked = true;
            this.checkBoxStadium20.Checked = true;
            this.checkBoxStadium21.Checked = true;
            this.checkBoxStadium22.Checked = true;
            this.checkBoxStadium23.Checked = true;
            this.checkBoxStadium24.Checked = false;
            return;
        }

        /*
        private void InitialDetectSeed(object sender, EventArgs e)
        {
            DetectMachineId();
            if (this.textBox2.Text.Length == 12)
            {
                char[] machine_id = this.textBox2.Text.ToCharArray();
                long seed = DetectSeed(machine_id, 4294967308, 12);
                this.textBox3.Text = seed.ToString("X");
                this.label8.Text = seed.ToString("X");
                PrintStadium(seed);
            }
            return;
        }
        */

        /*
        private void KarStadiumPrediction(object sender, EventArgs e)
        {
            StadiumPrediction();
            return;
        }
        */

        /*
        private void StadiumPrediction()
        {
            DetectMachineId();
            if (this.textBox2.Text.Length == 12)
            {
                char[] machine_id = this.textBox2.Text.ToCharArray();
                long seed = DetectSeed(machine_id, 42949672, 12);
                this.textBox3.Text = seed.ToString("X");
                if (seed >= 0) this.label8.Text = seed.ToString("X");
                PrintStadium(seed);
            }
            return;
        }
        */

        private void DetectMachineId()
        {
            double threshold = 0.93;
            string machines_id = null;
            string[] temps = Directory.GetFiles(@".\temp\2p", "*.png");
            string[] temps2 = Directory.GetFiles(@".\temp\3p", "*.png");
            string[] temps3 = Directory.GetFiles(@".\temp\4p", "*.png");
            var files = Directory.GetFiles(@".\pic", "*.png").OrderBy(filePath => File.GetLastWriteTime(filePath).Date).ThenBy(filePath => File.GetLastWriteTime(filePath).TimeOfDay).ToList();
            for (int i = 0; i < files.Count; i += 1)
            {
                Mat mat = new Mat();
                Mat mat2 = new Mat();
                Mat mat3 = new Mat();
                Mat matOrig = new Mat(files[i]);
                mat = matOrig.Clone(new Rect(54, 307, 116, 85));
                mat2 = matOrig.Clone(new Rect(538, 67, 116, 85));
                mat3 = matOrig.Clone(new Rect(538, 311, 116, 85));
                //Cv2.ImWrite(@".\temp\2p\" + (i+1).ToString() + ".png", mat);
                for (int j = 0; j < temps.Length; j += 1)
                {
                    Mat temp = new Mat(temps[j]);
                    Mat result = new Mat();

                    Cv2.MatchTemplate(mat, temp, result, TemplateMatchModes.CCoeffNormed);
                    OpenCvSharp.Point minloc, maxloc;
                    double minval, maxval;
                    Cv2.MinMaxLoc(result, out minval, out maxval, out minloc, out maxloc);

                    if (maxval >= threshold)
                    {
                        machines_id += System.IO.Path.GetFileName(temps[j]).Replace(".png", "");
                        // this.listBox1.Items.Add(maxval);
                        break;
                    }
                    temp.Dispose();
                    result.Dispose();
                }
                for (int j = 0; j < temps2.Length; j += 1)
                {
                    Mat temp = new Mat(temps2[j]);
                    Mat result = new Mat();

                    Cv2.MatchTemplate(mat2, temp, result, TemplateMatchModes.CCoeffNormed);
                    OpenCvSharp.Point minloc, maxloc;
                    double minval, maxval;
                    Cv2.MinMaxLoc(result, out minval, out maxval, out minloc, out maxloc);

                    if (maxval >= threshold)
                    {
                        machines_id += System.IO.Path.GetFileName(temps2[j]).Replace(".png", "");
                        break;
                    }
                    temp.Dispose();
                    result.Dispose();
                }
                for (int j = 0; j < temps3.Length; j += 1)
                {
                    Mat temp = new Mat(temps3[j]);
                    Mat result = new Mat();

                    Cv2.MatchTemplate(mat3, temp, result, TemplateMatchModes.CCoeffNormed);
                    OpenCvSharp.Point minloc, maxloc;
                    double minval, maxval;
                    Cv2.MinMaxLoc(result, out minval, out maxval, out minloc, out maxloc);

                    if (maxval >= threshold)
                    {
                        machines_id += System.IO.Path.GetFileName(temps3[j]).Replace(".png", "");
                        break;
                    }
                    temp.Dispose();
                    result.Dispose();
                }
                mat.Dispose();
                mat2.Dispose();
                mat3.Dispose();
                matOrig.Dispose();
            }
            this.Machine_id.Text = machines_id;

            foreach (string pathFrom in System.IO.Directory.EnumerateFiles(@".\pic", "*.png"))
            {
                string pathTo = pathFrom.Replace(@".\pic", @".\pic\rm");
                System.IO.File.Move(pathFrom, pathTo, true);
            }
            return;
        }

        private uint[] StadiumRate()
        {
            uint[] stadium = { 5, 5, 5, 5, 10, 20, 10, 10, 10, 4, 4, 4, 4, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5 };
            if (this.checkBoxStadium1.Checked == false) stadium[0] = 0;
            if (this.checkBoxStadium2.Checked == false) stadium[1] = 0;
            if (this.checkBoxStadium3.Checked == false) stadium[2] = 0;
            if (this.checkBoxStadium4.Checked == false) stadium[3] = 0;
            if (this.checkBoxStadium5.Checked == false) stadium[4] = 0;
            if (this.checkBoxStadium6.Checked == false) stadium[5] = 0;
            if (this.checkBoxStadium7.Checked == false) stadium[6] = 0;
            if (this.checkBoxStadium8.Checked == false) stadium[7] = 0;
            if (this.checkBoxStadium9.Checked == false) stadium[8] = 0;
            if (this.checkBoxStadium10.Checked == false) stadium[9] = 0;
            if (this.checkBoxStadium11.Checked == false) stadium[10] = 0;
            if (this.checkBoxStadium12.Checked == false) stadium[11] = 0;
            if (this.checkBoxStadium13.Checked == false) stadium[12] = 0;
            if (this.checkBoxStadium14.Checked == false) stadium[13] = 0;
            if (this.checkBoxStadium15.Checked == false) stadium[14] = 0;
            if (this.checkBoxStadium16.Checked == false) stadium[15] = 0;
            if (this.checkBoxStadium17.Checked == false) stadium[16] = 0;
            if (this.checkBoxStadium18.Checked == false) stadium[17] = 0;
            if (this.checkBoxStadium19.Checked == false) stadium[18] = 0;
            if (this.checkBoxStadium20.Checked == false) stadium[19] = 0;
            if (this.checkBoxStadium21.Checked == false) stadium[20] = 0;
            if (this.checkBoxStadium22.Checked == false) stadium[21] = 0;
            if (this.checkBoxStadium23.Checked == false) stadium[22] = 0;
            if (this.checkBoxStadium24.Checked == false) stadium[23] = 0;
            return stadium;
        }

        private long DetectSeed(char[] machine_id, long calculate, int id_number)
        {
            long r0 = Convert.ToInt64(this.label8.Text, 16);
            long r1 = 0;
            long rr0 = r0;
            long rr1 = 0;
            int machine_number = 0;
            for (long i = 0; i < calculate; i++)
            {
                r1 = (r0 * 214013 + 2531011) % 4294967296;
                rr0 = r0;
                for (int j = 0; j < id_number; j++)
                {
                    rr1 = (rr0 * 214013 + 2531011) % 4294967296;
                    switch ((rr1 / 65536 - 1) / 4369)
                    {
                        /*
                        Seedが0x1111FFFF → ジェット
                              0x11120000 → フォーミュラ

                        0x2222FFFF → フォーミュラ
                        0x22230000 → ウィング

                        0x3333FFFF → ウィング
                        0x33340000 → ワープ

                        0x4444FFFF → ワープ
                        0x44450000 → ライト

                        0x5555FFFF → ライト
                        0x55560000 → デビル
                        */
                        case 0:
                            if (machine_id[machine_number] == '1') machine_number++;
                            else machine_number = 0;
                            break;
                        case 1:
                            if (machine_id[machine_number] == '2') machine_number++;
                            else machine_number = 0;
                            break;
                        case 2:
                            if (machine_id[machine_number] == '3') machine_number++;
                            else machine_number = 0;
                            break;
                        case 3:
                            if (machine_id[machine_number] == '4') machine_number++;
                            else machine_number = 0;
                            break;
                        case 4:
                            if (machine_id[machine_number] == '5') machine_number++;
                            else machine_number = 0;
                            break;
                        case 5:
                            if (machine_id[machine_number] == '6') machine_number++;
                            else machine_number = 0;
                            break;
                        case 6:
                            if (machine_id[machine_number] == '7') machine_number++;
                            else machine_number = 0;
                            break;
                        case 7:
                            if (machine_id[machine_number] == '8') machine_number++;
                            else machine_number = 0;
                            break;
                        case 8:
                            if (machine_id[machine_number] == 'A') machine_number++;
                            else machine_number = 0;
                            break;
                        case 9:
                            if (machine_id[machine_number] == 'B') machine_number++;
                            else machine_number = 0;
                            break;
                        case 10:
                            if (machine_id[machine_number] == 'C') machine_number++;
                            else machine_number = 0;
                            break;
                        case 11:
                            if (machine_id[machine_number] == 'D') machine_number++;
                            else machine_number = 0;
                            break;
                        case 12:
                            if (machine_id[machine_number] == 'E') machine_number++;
                            else machine_number = 0;
                            break;
                        case 13:
                            if (machine_id[machine_number] == 'F') machine_number++;
                            else machine_number = 0;
                            break;
                        default:
                            if (machine_id[machine_number] == 'G') machine_number++;
                            else machine_number = 0;
                            break;
                    }
                    rr0 = rr1;
                    if (machine_number == 0) break;
                    if (machine_number == id_number) return rr1;
                }
                r0 = r1;
            }
            return -1;
        }

        private void PrintStadium(long r0)
        {
            uint[] stadium = StadiumRate();
            long r1;
            uint rate = 0;
            for (int i = 0; i < 24; i++) rate += stadium[i]; //スタジアムの出現比率の合計
            uint threshold = 4294967295 / rate;
            uint true_threshold; //上位4桁（真の境界）を格納
            uint stadium_number = 0; //出現するスタジアムのIDを格納する変数
            this.listBox1.Items.Clear();

            for (int i = 0; i < 100; i++)
            {
                uint stadium_threshold = 0;
                r1 = (r0 * 214013 + 2531011) % 4294967296;
                
                for (int j = 0; j < 24; j++)
                {
                    stadium_threshold += stadium[j];
                    if (stadium_threshold == 0) continue;
                    true_threshold = threshold * stadium_threshold / 65536;
                    if (r1 / 65536 <= true_threshold)
                    {
                        stadium_number = (uint)j;
                        break;
                    }
                }
                if (this.toolStripMenuItem5.Checked == true)
                {
                    switch (stadium_number)
                    {
                        case 0:
                            this.listBox1.Items.Add(i + "\tゼロヨンアタック1");
                            break;
                        case 1:
                            this.listBox1.Items.Add(i + "\tゼロヨンアタック2");
                            break;
                        case 2:
                            this.listBox1.Items.Add(i + "\tゼロヨンアタック3");
                            break;
                        case 3:
                            this.listBox1.Items.Add(i + "\tゼロヨンアタック4");
                            break;
                        case 4:
                            this.listBox1.Items.Add(i + "\tエアグライダー");
                            break;
                        case 5:
                            this.listBox1.Items.Add(i + "\tポイントストライク");
                            break;
                        case 6:
                            this.listBox1.Items.Add(i + "\tハイジャンプ");
                            break;
                        case 7:
                            this.listBox1.Items.Add(i + "\tバトルロイヤル1");
                            break;
                        case 8:
                            this.listBox1.Items.Add(i + "\tバトルロイヤル2");
                            break;
                        case 9:
                            this.listBox1.Items.Add(i + "\tデスマッチ1");
                            break;
                        case 10:
                            this.listBox1.Items.Add(i + "\tデスマッチ2");
                            break;
                        case 11:
                            this.listBox1.Items.Add(i + "\tデスマッチ3");
                            break;
                        case 12:
                            this.listBox1.Items.Add(i + "\tデスマッチ4");
                            break;
                        case 13:
                            this.listBox1.Items.Add(i + "\tデスマッチ5");
                            break;
                        case 14:
                            this.listBox1.Items.Add(i + "\tプランテス");
                            break;
                        case 15:
                            this.listBox1.Items.Add(i + "\tマグヒート");
                            break;
                        case 16:
                            this.listBox1.Items.Add(i + "\tサンドーラ");
                            break;
                        case 17:
                            this.listBox1.Items.Add(i + "\tコルダ");
                            break;
                        case 18:
                            this.listBox1.Items.Add(i + "\tアイルーン");
                            break;
                        case 19:
                            this.listBox1.Items.Add(i + "\tヴァレリオン");
                            break;
                        case 20:
                            this.listBox1.Items.Add(i + "\tスチールオーガン");
                            break;
                        case 21:
                            this.listBox1.Items.Add(i + "\tチェックナイト");
                            break;
                        case 22:
                            this.listBox1.Items.Add(i + "\tギャラックス");
                            break;
                        default:
                            this.listBox1.Items.Add(i + "\tVSデデデ");
                            break;
                    }
                }
                else if (this.toolStripMenuItem6.Checked == true)
                {
                    switch (stadium_number)
                    {
                        case 0:
                            this.listBox1.Items.Add(i + "\tDrag Race 1");
                            break;
                        case 1:
                            this.listBox1.Items.Add(i + "\tDrag Race 2");
                            break;
                        case 2:
                            this.listBox1.Items.Add(i + "\tDrag Race 3");
                            break;
                        case 3:
                            this.listBox1.Items.Add(i + "\tDrag Race 4");
                            break;
                        case 4:
                            this.listBox1.Items.Add(i + "\tAir Glider");
                            break;
                        case 5:
                            this.listBox1.Items.Add(i + "\tTarget Flight");
                            break;
                        case 6:
                            this.listBox1.Items.Add(i + "\tHigh Jump");
                            break;
                        case 7:
                            this.listBox1.Items.Add(i + "\tKirby Malee 1");
                            break;
                        case 8:
                            this.listBox1.Items.Add(i + "\tKirby Melee 2");
                            break;
                        case 9:
                            this.listBox1.Items.Add(i + "\tDestruction Derby 1");
                            break;
                        case 10:
                            this.listBox1.Items.Add(i + "\tDestruction Derby 2");
                            break;
                        case 11:
                            this.listBox1.Items.Add(i + "\tDestruction Derby 3");
                            break;
                        case 12:
                            this.listBox1.Items.Add(i + "\tDestruction Derby 4");
                            break;
                        case 13:
                            this.listBox1.Items.Add(i + "\tDestruction Derby 5");
                            break;
                        case 14:
                            this.listBox1.Items.Add(i + "\tFantasy Meadows");
                            break;
                        case 15:
                            this.listBox1.Items.Add(i + "\tMagma Flows");
                            break;
                        case 16:
                            this.listBox1.Items.Add(i + "\tSky Sands");
                            break;
                        case 17:
                            this.listBox1.Items.Add(i + "\tFrozen Hillside");
                            break;
                        case 18:
                            this.listBox1.Items.Add(i + "\tBeanstalk Park");
                            break;
                        case 19:
                            this.listBox1.Items.Add(i + "\tCelestial Valley");
                            break;
                        case 20:
                            this.listBox1.Items.Add(i + "\tMachine Passage");
                            break;
                        case 21:
                            this.listBox1.Items.Add(i + "\tChecker Knights");
                            break;
                        case 22:
                            this.listBox1.Items.Add(i + "\tNebula Belt");
                            break;
                        default:
                            this.listBox1.Items.Add(i + "\tVS. King Dedede");
                            break;
                    }
                }
                r0 = r1;
            }
            return;
        }

        private void MachineIdToPrediction(object sender, EventArgs e)
        {
            if (this.Machine_id.Text.Length >= 9)
            {
                char[] machine_id = this.Machine_id.Text.ToCharArray();
                long seed = DetectSeed(machine_id, 42949672, this.Machine_id.Text.Length);
                this.Seed.Text = seed.ToString("X");
                if (seed >= 0) this.label8.Text = seed.ToString("X");
                PrintStadium(seed);
            }
            return;
        }

        private void InitialMachineIdToPrediction(object sender, EventArgs e)
        {
            if (this.Machine_id.Text.Length >= 10)
            {
                char[] machine_id = this.Machine_id.Text.ToCharArray();
                long seed = DetectSeed(machine_id, 4294967308, this.Machine_id.Text.Length);
                this.Seed.Text = seed.ToString("X");
                if (seed >= 0) this.label8.Text = seed.ToString("X");
                PrintStadium(seed);
            }
            return;
        }

        private void SeedToPrediction(object sender, EventArgs e)
        {
            PrintStadium(Convert.ToInt64(this.label8.Text, 16));
            return;
        }

        private void Jet_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '1';
            return;
        }

        private void Formula_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '2';
            return;
        }

        private void Winged_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '3';
            return;
        }

        private void Warp_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '4';
            return;
        }

        private void Compact_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '5';
            return;
        }

        private void Shadow_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '6';
            return;
        }

        private void Wagon_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '7';
            return;
        }

        private void Swerve_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += '8';
            return;
        }

        private void Rocket_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += 'A';
            return;
        }

        private void Turbo_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += 'B';
            return;
        }

        private void Bulk_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += 'C';
            return;
        }

        private void Slick_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += 'D';
            return;
        }

        private void Bike_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += 'E';
            return;
        }

        private void Scooter_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += 'F';
            return;
        }

        private void Rex_MouseDown(object sender, MouseEventArgs e)
        {
            this.Machine_id.Text += 'G';
            return;
        }

        private void ClearMachine_id_Click(object sender, EventArgs e)
        {
            this.Machine_id.Text = "";
            return;
        }
    }
}
